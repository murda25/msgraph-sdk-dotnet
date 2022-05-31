# Microsoft Graph .NET SDK v5 changelog and upgrade guide

The purpose of this document is to outline any breaking change and migration work SDK users might run into while upgrading to the v5 of the SDK.

## Overview
V5 of the Microsoft Graph .NET SDK moves to the new code generator [Kiota](https://github.com/microsoft/kiota) to provide a better user experience for the SDK users as well as a number of new features made possible by these changes.

## Breaking changes

The following section lists out the breaking changes requiring code changes from SDK users.

### Use of `RequestInformation` from Kiota in place of `IBaseRequest`
The `RequestInformation` class is now used to represent requests in the SDK and the `IBaseRequest` is dropped. Using the fluent API, you can always get an instance of the `RequestInformation` as follows.

```cs
// Get the requestInfomation to make a GET request
var requestInformation = graphServiceClient
                         .DirectoryObjects
                         .CreateGetRequestInformation();

// Get the requestInfomation to make a POST request
var requestInformation = graphServiceClient
                         .DirectoryObjects
                         .CreatePostRequestInformation();
```

### Removal of `Request()` from the fluent API

In previous versions, of the SDK, calls involved the calling of `Request()` in the request API as follows

```cs
var user = await graphServiceClient
    .Me
    .Request()  // this is removed
    .GetAsync();
```

A similar call in the V5 will have the `Request()` section removed to be called as below.

```cs
var user = await graphServiceClient
    .Me
    .GetAsync();
```

#### Request executor methods

V5 of the SDK simplifies the request methods to simply reflect the HTTP methods being used. This therefore means that 
- `UpdateAsync()` methods are now `PatchAsync()`
- `AddAsync()` methods are now `PostAsync()`

### Headers
To pass headers, the `HeaderOption` class is no longer used. Headers are added using the `requestConfiguration` modifier as follows

```cs
var user = await graphServiceClient
    .Users["{user-id}"]
    .GetAsync(requestConfiguration => requestConfiguration.Headers.Add("ConsistencyLevel","eventual"));
```

### Query Options
To pass query Options, the `QueryOption` class is no longer used. Query options are set using the `requestConfiguration` modifier as follows

```cs
var user = await graphServiceClient
    .Users["{user-id}"]
    .GetAsync(requestConfiguration => requestConfiguration.QueryParameters.Select = new string[] { "id", "createdDateTime"});
```

### Collections

Querying for collections are done as follows and resembles the response from API.

```cs
var usersResponse = await graphServiceClient
    .Users
    .GetAsync(requestConfiguration => requestConfiguration.QueryParameters.Select = new string[] { "id", "createdDateTime"});

List<User> userList = usersResponse.Value;
```

### PageIterator
To iterate through page collections, use the pageIterator as follows

```cs
var usersResponse = await graphServiceClient
    .Users
    .GetAsync(requestConfiguration => { requestConfiguration.QueryParameters.Select = new string[] { "id", "createdDateTime" }; requestConfiguration.QueryParameters.Top = 1; });

var userList = new List<User>();
var pageIterator = PageIterator<User,UserCollectionResponse>.CreatePageIterator(graphServiceClient,usersResponse, (user) => { userList.Add(user); return true; });

await pageIterator.IterateAsync();

```

### Error handling
Errors and exceptions from the new generated version will be exception classed derived from the [ApiException](https://github.com/microsoft/kiota-abstractions-dotnet/blob/8a136e509c7a71ef889643f047938bdbc3c752be/src/ApiException.cs#L11) class from the Kiota abstrations library. 
Typically, this will be an instance of [OdataError](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/6d1a78fe1ca7d883667b5f231395651e24581653/src/Microsoft.Graph/Generated/Models/ODataErrors/ODataError.cs#L9) and can be handled as below.

```cs
try
{
    await graphServiceClient.Me.PatchAsync(user);
}
catch (ODataError odataError)
{
    Console.WriteLine(odataError.Error.Code);
    Console.WriteLine(odataError.Error.Message);
    throw;
}
```

## New Features

### Backing Store
The backing store allows multiple things like dirty tracking of changes, making it possible to get an object from the API, update a property, send that object back with only the changed property and not the full objects.

This has the added advantage in that SDK user can simply get an object from the API and set a property to null and send back the object without having to use known workarounds where setting properties to null would require to be placed in the additionalData bag.

```cs
// get the object
var @event = await graphServiceClient
    .Me.Events["event-id"]
    .GetAsync();

// the backing store will keep track that the property change and send the updated value.
@event.Recurrence = null;// set to null 

// update the object
await graphServiceClient.Me.Events["event-id"]
    .PatchAsync(@event);
```

### Use of Parameter objects calling Odata functions/actions
To add parameters to an odata action, the SDK uses parameter objects rather than using function overloads to reduce likelihood of the SDK shpping breaking changes.
In the v4 SDK, calling a function/action would look like this.

```cs
//var message = ....
//var saveToSentItems = ...

await graphClient.Me
	.SendMail(message,saveToSentItems)
	.Request()
	.PostAsync();
```

This changes to 

```cs
//var message = ....
//var saveToSentItems = ...

var body = new SendMailPostRequestBody
{
    Message = message,
    SaveToSentItems = saveToSentItems
};

await graphServiceClient.Me
    .SendMail
    .PostAsync(body);
```

### Batch Requests
Apart from passing instances of `HttpRequestMessage`, batch requests support the passing of `RequestInformation` instances as follows.

```cs
var requestInformation = graphServiceClient
                         .Users
                         .CreateGetRequestInformation();

// create the content
var batchRequestContent = new BatchRequestContent(graphServiceClient);
// add steps
var requestStepId = batchRequestContent.AddBatchRequestStep(requestInformation);

// send and get back response
var batchResponseContent = await graphServiceClient.Batch.PostAsync(batchRequestContent);

var usersResponse = await batchResponseContent.GetResponseByIdAsync<UserCollectionResponse>(requestStepId);
List<User> userList = usersResponse.Value;

```

### Support for $count in request builders

The request builders are now enriched with `Count` sections where applicable to enable the use of the $count segment

```cs
var count = await graphServiceClient.Users.Count.GetAsync(requestConfiguration => requestConfiguration.Headers.Add("ConsistencyLevel","eventual"));
```

This addresses the workarounds that SDK users had to make in order to call $count which looked as follows in previous SDK versions(ref [here](https://github.com/microsoftgraph/msgraph-sdk-dotnet/issues/875))

```cs
string requestUrl = graphClient.Users.AppendSegmentToRequestUrl("$count");
Option [] options = new Option[] { new HeaderOption("ConsistencyLevel", "eventual") };
HttpResponseMessage responseMessage = await new UserRequest(requestUrl, graphClient, options)
                                        .SendRequestAsync(null,CancellationToken.None);
string userCount = await responseMessage.Content.ReadAsStringAsync();
```

### Support for OData Casts in request builders

The request builders are now enriched with segments to enable requesting a specific type in the event an API endpoint supports the odata cast functionality.

An example is fetching the members of a group who are of the type `User` which would be done as below.

```cs
var usersInGroup = await graphServiceClient.Groups["group-id"].Members.User.GetAsync();
```

Similarly, members of the group of type `Application` would be done as below.

```cs
var applicationsInGroup = await graphServiceClient.Groups["group-id"].Members.Application.GetAsync();
```

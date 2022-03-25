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
To pass headers, the  `HeaderOption` class is no longer used. Headers are added as follows

```cs
var user = await graphServiceClient
                    .Users["{user-id}"]
                    .GetAsync(h: headers => headers.Add("ConsistencyLevel","eventual"));
```

### Query Options
To pass query Options, the `QueryOption` class is no longer used. Query options are added as follows

```cs
var user = await graphServiceClient
                    .Users["{user-id}"]
                    .GetAsync(q: queryOptions => queryOptions.Select = new string[] { "id", "createdDateTime"});
```

### Collections

Querying for collections are done as follows and resembles the response from API.

```cs
var usersResponse = await graphServiceClient
                        .Users
                        .GetAsync(q: queryOptions => queryOptions.Select = new string[] { "id", "createdDateTime"});
List<User> userList = usersResponse.Value;
```

### PageIterator
To iterate through page collections, use the pageIterator as follows

```cs
var usersResponse = await graphServiceClient
                .Users
                .GetAsync(q: queryOptions => { queryOptions.Select = new string[] { "id", "createdDateTime" }; queryOptions.Top = 1; });

var userList = new List<User>();
var pageIterator = PageIterator<User,UserCollectionResponse>.CreatePageIterator(graphServiceClient,usersResponse, (user) => { userList.Add(user); return true; });

await pageIterator.IterateAsync();

```

## New Features

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

var body = new SendMailRequestBody
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
var count = await graphServiceClient.Users.Count.GetAsync();
```



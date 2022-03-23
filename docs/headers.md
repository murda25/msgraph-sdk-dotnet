# Headers in the Microsoft Graph .NET Client Library

The .NET Client Library allows you to add your own custom request headers and inspect the response headers that come back from the Graph service.

## Adding request headers

Custom headers can be added by creating a new option collection and adding it to the request object:

```csharp

var newObject = graphServiceClient
	.Object
	.Request(options)
	.PatchAsync(h: h => { h.Add("Etag", "etag"); h.Add("If-Match", "ifmatch"); );
```


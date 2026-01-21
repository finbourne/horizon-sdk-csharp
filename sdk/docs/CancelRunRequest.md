# Finbourne.Horizon.Sdk.Model.CancelRunRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunIds** | **List&lt;string&gt;** |  | 
**Message** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<string> runIds = new List<string>();
string message = "example message";

CancelRunRequest cancelRunRequestInstance = new CancelRunRequest(
    runIds: runIds,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

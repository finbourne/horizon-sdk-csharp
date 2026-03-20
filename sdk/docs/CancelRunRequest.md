# Finbourne.Horizon.Sdk.Model.CancelRunRequest
A request to cancel the specified instance execution.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunIds** | **List&lt;string&gt;** | The instance run ids to be cancelled. | 
**Message** | **string** | The user provided message as to why the instance executions were cancelled. | [optional] 

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

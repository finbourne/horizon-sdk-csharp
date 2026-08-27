# Finbourne.Horizon.Sdk.Model.RunStatusCount
record containing the count of runs for a given status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** |  | 
**Count** | **int** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string status = "status";

RunStatusCount runStatusCountInstance = new RunStatusCount(
    status: status,
    count: count);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

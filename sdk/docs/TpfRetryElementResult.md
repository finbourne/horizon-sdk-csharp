# Finbourne.Horizon.Sdk.Model.TpfRetryElementResult
Result for a single batch element retry attempt

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchElementReferenceId** | **string** | Batch element reference identifier | 
**Status** | **string** | Status of the retry attempt (e.g., \&quot;Retrying\&quot;, \&quot;NotFound\&quot;) | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string batchElementReferenceId = "batchElementReferenceId";
string status = "status";

TpfRetryElementResult tpfRetryElementResultInstance = new TpfRetryElementResult(
    batchElementReferenceId: batchElementReferenceId,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

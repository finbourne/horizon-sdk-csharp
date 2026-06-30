# Finbourne.Horizon.Sdk.Model.TpfFailedDeliveryResponse
Response for bulk retry operation of failed deliveries

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Submitted** | **int** | Number of batch elements submitted for retry | 
**Results** | [**List&lt;TpfRetryElementResult&gt;**](TpfRetryElementResult.md) | Per-element retry results | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<TpfRetryElementResult> results = new List<TpfRetryElementResult>();

TpfFailedDeliveryResponse tpfFailedDeliveryResponseInstance = new TpfFailedDeliveryResponse(
    submitted: submitted,
    results: results);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

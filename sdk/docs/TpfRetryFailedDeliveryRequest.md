# Finbourne.Horizon.Sdk.Model.TpfRetryFailedDeliveryRequest
Request to retry failed deliveries for multiple batch elements. The integration instance identifier is supplied via the route, not the body.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchElementReferenceIds** | **List&lt;string&gt;** | Batch element reference identifiers to retry. No regex pattern is required as batch element IDs are vendor-defined strings with varying formats. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<string> batchElementReferenceIds = new List<string>();

TpfRetryFailedDeliveryRequest tpfRetryFailedDeliveryRequestInstance = new TpfRetryFailedDeliveryRequest(
    batchElementReferenceIds: batchElementReferenceIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

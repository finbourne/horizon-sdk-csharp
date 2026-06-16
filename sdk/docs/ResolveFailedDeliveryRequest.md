# Finbourne.Horizon.Sdk.Model.ResolveFailedDeliveryRequest
Request to resolve a failed delivery without retry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | The reason for resolving the failed delivery without retrying. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string reason = "reason";

ResolveFailedDeliveryRequest resolveFailedDeliveryRequestInstance = new ResolveFailedDeliveryRequest(
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

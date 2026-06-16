# Finbourne.Horizon.Sdk.Model.ResolveFailedDeliveryResponse
Response from resolving the failed deliveries for a batch without retry. Resolution is batch-level, so Finbourne.Horizon.Integrations.Web.Dto.Integrations.TradePublicationFramework.Response.ResolveFailedDeliveryResponse.ResolvedCount is the number of failed deliveries marked resolved.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchReferenceId** | **string** |  | 
**ResolvedCount** | **int** |  | 
**Resolved** | **bool** |  | 
**ResolvedAt** | **DateTimeOffset** |  | 
**ResolutionReason** | **string** |  | 
**Message** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string batchReferenceId = "batchReferenceId";
bool resolved = //"True";
string resolutionReason = "resolutionReason";
string message = "message";

ResolveFailedDeliveryResponse resolveFailedDeliveryResponseInstance = new ResolveFailedDeliveryResponse(
    batchReferenceId: batchReferenceId,
    resolvedCount: resolvedCount,
    resolved: resolved,
    resolvedAt: resolvedAt,
    resolutionReason: resolutionReason,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

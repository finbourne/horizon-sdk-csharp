# Finbourne.Horizon.Sdk.Model.FailedDeliveryResponse
A batch's failed deliveries returned by the list endpoint, aggregated to one row per batch. Finbourne.Horizon.Integrations.Web.Dto.Integrations.TradePublicationFramework.Response.FailedDeliveryResponse.FailedCount is the number of failed deliveries in the batch and Finbourne.Horizon.Integrations.Web.Dto.Integrations.TradePublicationFramework.Response.FailedDeliveryResponse.FailureReason is the comma-separated set of their failure reasons.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchReferenceId** | **string** |  | 
**RunId** | **Guid** |  | 
**RunStartTime** | **DateTimeOffset** |  | 
**FailedCount** | **int** |  | 
**FailureReason** | **string** |  | 
**LastAttemptAt** | **DateTimeOffset** |  | 
**AttemptCount** | **int** |  | 
**Resolved** | **bool** |  | 
**ResolvedAt** | **DateTimeOffset?** |  | [optional] 
**ResolutionReason** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string batchReferenceId = "batchReferenceId";
Guid runId = "runId";
string failureReason = "failureReason";
bool resolved = //"True";
string resolutionReason = "example resolutionReason";

FailedDeliveryResponse failedDeliveryResponseInstance = new FailedDeliveryResponse(
    batchReferenceId: batchReferenceId,
    runId: runId,
    runStartTime: runStartTime,
    failedCount: failedCount,
    failureReason: failureReason,
    lastAttemptAt: lastAttemptAt,
    attemptCount: attemptCount,
    resolved: resolved,
    resolvedAt: resolvedAt,
    resolutionReason: resolutionReason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

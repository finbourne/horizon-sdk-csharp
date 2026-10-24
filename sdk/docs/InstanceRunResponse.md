# Finbourne.Horizon.Sdk.Model.InstanceRunResponse
Response containing details of a single run for an instance. The transaction and file figures describe the batch as it stands now, so they are reported on the latest attempt only and are null on earlier attempts of a retried run. Message explains a failed attempt and what will happen or must be done next; it is null for completed, running and queued attempts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **Guid** |  | 
**ReferenceId** | **Guid** |  | 
**Attempt** | **int?** |  | [optional] 
**StartTime** | **DateTimeOffset** |  | 
**EndTime** | **DateTimeOffset?** |  | [optional] 
**Duration** | **string** |  | [optional] 
**Status** | **string** |  | 
**TriggeredBy** | **string** |  | [optional] 
**Total** | **int?** |  | [optional] 
**SentCount** | **long?** |  | [optional] 
**SkippedCount** | **long?** |  | [optional] 
**FailedCount** | **long?** |  | [optional] 
**FailedFiles** | **int?** |  | [optional] 
**Message** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

Guid runId = "runId";
Guid referenceId = "referenceId";
string duration = "example duration";
string status = "status";
string triggeredBy = "example triggeredBy";
string message = "example message";

InstanceRunResponse instanceRunResponseInstance = new InstanceRunResponse(
    runId: runId,
    referenceId: referenceId,
    attempt: attempt,
    startTime: startTime,
    endTime: endTime,
    duration: duration,
    status: status,
    triggeredBy: triggeredBy,
    total: total,
    sentCount: sentCount,
    skippedCount: skippedCount,
    failedCount: failedCount,
    failedFiles: failedFiles,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

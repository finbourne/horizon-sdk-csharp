# Finbourne.Horizon.Sdk.Model.InstanceRunResponse
Response containing details of a single run for an instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **Guid** |  | 
**BatchReferenceId** | **string** |  | [optional] 
**Attempt** | **int?** |  | [optional] 
**StartTime** | **DateTimeOffset** |  | 
**EndTime** | **DateTimeOffset?** |  | [optional] 
**Duration** | **string** |  | [optional] 
**Status** | **string** |  | 
**TriggeredBy** | **string** |  | [optional] 
**Total** | **int** |  | 
**SentCount** | **long** |  | 
**SkippedCount** | **long** |  | 
**FailedCount** | **long** |  | 
**FailedFiles** | **int** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

Guid runId = "runId";
string batchReferenceId = "example batchReferenceId";
string duration = "example duration";
string status = "status";
string triggeredBy = "example triggeredBy";

InstanceRunResponse instanceRunResponseInstance = new InstanceRunResponse(
    runId: runId,
    batchReferenceId: batchReferenceId,
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
    failedFiles: failedFiles);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

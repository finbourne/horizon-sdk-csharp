# Finbourne.Horizon.Sdk.Model.AuditCompleteRequest
An incoming request for a Horizon Complete Event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique ID identifiying the source of the event | 
**UserId** | **string** | A unique ID identifiying who owns the schedule | 
**SchedulerRunId** | **string** | The GUID of the schedule run | 
**StartTime** | **DateTimeOffset** | When the run was started in UTC | 
**EndTime** | **DateTimeOffset** | When the run finished in UTC | 
**Message** | **string** | A descriptive message to accompany the status | 
**Status** | **string** | The final status of the run | 
**RowsTotal** | **int** | The number of data rows operated on | 
**RowsSucceeded** | **int** | The number of data rows successfully operated on | 
**RowsFailed** | **int** | The number of data rows that failed to be operated on | 
**RowsIgnored** | **int** | The number of data rows that had no actions taken | 
**AuditFiles** | [**List&lt;AuditFileDetails&gt;**](AuditFileDetails.md) | A list of file details for attaching to the event | 
**ProcessNameOverride** | **string** | Optional Name for how the process appears in Data Feed Monitoring | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string id = "id";
string userId = "userId";
string schedulerRunId = "schedulerRunId";
string message = "message";
string status = "status";
List<AuditFileDetails> auditFiles = new List<AuditFileDetails>();
string processNameOverride = "example processNameOverride";

AuditCompleteRequest auditCompleteRequestInstance = new AuditCompleteRequest(
    id: id,
    userId: userId,
    schedulerRunId: schedulerRunId,
    startTime: startTime,
    endTime: endTime,
    message: message,
    status: status,
    rowsTotal: rowsTotal,
    rowsSucceeded: rowsSucceeded,
    rowsFailed: rowsFailed,
    rowsIgnored: rowsIgnored,
    auditFiles: auditFiles,
    processNameOverride: processNameOverride);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

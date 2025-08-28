# Finbourne.Horizon.Sdk.Model.AuditUpdateRequest
An incoming request for a Horizon Update Event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique ID identifiying the source of the event | 
**UserId** | **string** | A unique ID identifiying who owns the schedule | 
**SchedulerRunId** | **string** | The GUID of the schedule run | 
**StartTime** | **DateTimeOffset** | When the run was started in UTC | 
**Message** | **string** | A descriptive message to accompany the status | 
**ProcessNameOverride** | **string** | Optional Name for how the process appears in Data Feed Monitoring | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string id = "id";
string userId = "userId";
string schedulerRunId = "schedulerRunId";
string message = "message";
string processNameOverride = "example processNameOverride";

AuditUpdateRequest auditUpdateRequestInstance = new AuditUpdateRequest(
    id: id,
    userId: userId,
    schedulerRunId: schedulerRunId,
    startTime: startTime,
    message: message,
    processNameOverride: processNameOverride);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

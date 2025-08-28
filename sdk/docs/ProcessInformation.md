# Finbourne.Horizon.Sdk.Model.ProcessInformation
Required information for each process

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** |  | 
**ProcessName** | **string** |  | 
**RunId** | **string** |  | 
**StartTime** | **DateTimeOffset** |  | 
**DataAction** | **string** |  | 
**SchemaVersion** | **string** |  | [optional] 
**UserId** | **string** |  | 
**ProcessSummary** | [**ProcessSummary**](ProcessSummary.md) |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string domain = "domain";
string processName = "processName";
string runId = "runId";
string dataAction = "dataAction";
string schemaVersion = "example schemaVersion";
string userId = "userId";
ProcessSummary? processSummary = new ProcessSummary();


ProcessInformation processInformationInstance = new ProcessInformation(
    domain: domain,
    processName: processName,
    runId: runId,
    startTime: startTime,
    dataAction: dataAction,
    schemaVersion: schemaVersion,
    userId: userId,
    processSummary: processSummary);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

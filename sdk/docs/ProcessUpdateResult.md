# Finbourne.Horizon.Sdk.Model.ProcessUpdateResult
Shows details relevant to update events for a query

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** |  | 
**EntryId** | **string** |  | 
**ProcessName** | **string** |  | 
**RunId** | **string** |  | 
**EntryDate** | **DateTimeOffset** |  | 
**Status** | **string** |  | 
**Message** | **string** |  | 
**SchemaVersion** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string domain = "domain";
string entryId = "entryId";
string processName = "processName";
string runId = "runId";
string status = "status";
string message = "message";
string schemaVersion = "example schemaVersion";

ProcessUpdateResult processUpdateResultInstance = new ProcessUpdateResult(
    domain: domain,
    entryId: entryId,
    processName: processName,
    runId: runId,
    entryDate: entryDate,
    status: status,
    message: message,
    schemaVersion: schemaVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

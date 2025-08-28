# Finbourne.Horizon.Sdk.Model.AuditCompleteResponse
Response type for Horizon Audit Event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessName** | **string** | The name of the Process the events will be visible under | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string processName = "processName";

AuditCompleteResponse auditCompleteResponseInstance = new AuditCompleteResponse(
    processName: processName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.ExternalLogInsertionRequest
A request to insert external log records.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Logs** | [**List&lt;ExternalLogRecord&gt;**](ExternalLogRecord.md) | The collection of external log records to insert. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<ExternalLogRecord> logs = new List<ExternalLogRecord>();

ExternalLogInsertionRequest externalLogInsertionRequestInstance = new ExternalLogInsertionRequest(
    logs: logs);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

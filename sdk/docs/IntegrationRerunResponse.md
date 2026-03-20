# Finbourne.Horizon.Sdk.Model.IntegrationRerunResponse
No content is returned when an instance is rerun.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | [**InstanceExecutionReferenceId**](InstanceExecutionReferenceId.md) |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

InstanceExecutionReferenceId runId = new InstanceExecutionReferenceId();

IntegrationRerunResponse integrationRerunResponseInstance = new IntegrationRerunResponse(
    runId: runId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.IntegrationRunResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **Guid** |  | 
**RefRunId** | **Guid?** |  | [optional] 
**Attempt** | **int** |  | 
**InstanceId** | **Guid?** |  | [optional] 
**InstanceName** | **string** |  | [optional] 
**Status** | **string** |  | [optional] 
**Message** | **string** |  | [optional] 
**Integration** | [**IntegrationRunIntegration**](IntegrationRunIntegration.md) |  | 
**VarVersion** | [**IntegrationRunVersion**](IntegrationRunVersion.md) |  | 
**IntegrationLogs** | **Dictionary&lt;string, Dictionary&lt;string, IntegrationRunLog&gt;&gt;** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

Guid runId = "runId";
Guid? refRunId = "example refRunId";
Guid? instanceId = "example instanceId";
string instanceName = "example instanceName";
string status = "example status";
string message = "example message";
IntegrationRunIntegration integration = new IntegrationRunIntegration();
IntegrationRunVersion varVersion = new IntegrationRunVersion();
Dictionary<string, Dictionary<string, IntegrationRunLog>> integrationLogs = new Dictionary<string, Dictionary<string, IntegrationRunLog>>();

IntegrationRunResponse integrationRunResponseInstance = new IntegrationRunResponse(
    runId: runId,
    refRunId: refRunId,
    attempt: attempt,
    instanceId: instanceId,
    instanceName: instanceName,
    status: status,
    message: message,
    integration: integration,
    varVersion: varVersion,
    integrationLogs: integrationLogs);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.WorkflowExecuteParametersResponse
The execute parameters a Workflow-driven integration instance accepts on executewithparams.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceId** | **string** | The instance these parameters belong to. | 
**IntegrationType** | **string** | The integration type of the instance, e.g. ta-tax-processes. | 
**Parameters** | [**List&lt;WorkflowExecuteParameterResponse&gt;**](WorkflowExecuteParameterResponse.md) | Every parameter the integration accepts, each listed once. | 
**Stages** | [**List&lt;WorkflowExecuteStageResponse&gt;**](WorkflowExecuteStageResponse.md) | Per-stage breakdown of the steps that run and the parameters accepted. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string instanceId = "instanceId";
string integrationType = "integrationType";
List<WorkflowExecuteParameterResponse> parameters = new List<WorkflowExecuteParameterResponse>();
List<WorkflowExecuteStageResponse> stages = new List<WorkflowExecuteStageResponse>();

WorkflowExecuteParametersResponse workflowExecuteParametersResponseInstance = new WorkflowExecuteParametersResponse(
    instanceId: instanceId,
    integrationType: integrationType,
    parameters: parameters,
    stages: stages);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

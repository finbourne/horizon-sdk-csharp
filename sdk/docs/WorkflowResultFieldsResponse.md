# Finbourne.Horizon.Sdk.Model.WorkflowResultFieldsResponse
The result fields an instance returns to the Workflow task that started its run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceId** | **string** | The instance these fields belong to. | 
**ReportsToWorkflow** | **bool** | Whether this instance has an enabled RunWorkflow post-process task at all. | 
**ResultFields** | [**List&lt;WorkflowResultFieldResponse&gt;**](WorkflowResultFieldResponse.md) | Every distinct field declared across this instance&#39;s RunWorkflow tasks. | 
**Tasks** | [**List&lt;WorkflowResultFieldsTaskResponse&gt;**](WorkflowResultFieldsTaskResponse.md) | Per-task breakdown: an instance may declare different fields on success and on failure. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string instanceId = "instanceId";
bool reportsToWorkflow = //"True";
List<WorkflowResultFieldResponse> resultFields = new List<WorkflowResultFieldResponse>();
List<WorkflowResultFieldsTaskResponse> tasks = new List<WorkflowResultFieldsTaskResponse>();

WorkflowResultFieldsResponse workflowResultFieldsResponseInstance = new WorkflowResultFieldsResponse(
    instanceId: instanceId,
    reportsToWorkflow: reportsToWorkflow,
    resultFields: resultFields,
    tasks: tasks);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

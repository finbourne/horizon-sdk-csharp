# Finbourne.Horizon.Sdk.Model.WorkflowRunResultsResponse
A run's status and the result values it published, which is what the Workflow AQS polls while it waits for an integration it started to finish.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** | The run these results belong to, as returned by the execute endpoint. | 
**InstanceId** | **string** | The instance that ran. | 
**Status** | **string** | The run&#39;s status, reported exactly as the runs endpoint reports it: Queued, Started, Completed, Errored or Interrupted. A caller waiting for the run to finish is waiting for one of the last three. | 
**QueuedAt** | **DateTimeOffset?** |  | [optional] 
**StartedAt** | **DateTimeOffset?** |  | [optional] 
**CompletedAt** | **DateTimeOffset?** | Null until the run reaches a terminal status. | [optional] 
**Attempt** | **int** | Which attempt this run is, counting reruns of the same work. | 
**ReportsToWorkflow** | **bool** | Whether this run was started by a Workflow task. False for a scheduled or file-triggered run, which publishes no results because nothing is waiting on them. | 
**Results** | [**List&lt;WorkflowRunResultResponse&gt;**](WorkflowRunResultResponse.md) | One entry per field the instance declares, so the shape matches what the discovery endpoint promised when the worker was created. A declared field the run never published carries a null value. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string runId = "runId";
string instanceId = "instanceId";
string status = "status";
bool reportsToWorkflow = //"True";
List<WorkflowRunResultResponse> results = new List<WorkflowRunResultResponse>();

WorkflowRunResultsResponse workflowRunResultsResponseInstance = new WorkflowRunResultsResponse(
    runId: runId,
    instanceId: instanceId,
    status: status,
    queuedAt: queuedAt,
    startedAt: startedAt,
    completedAt: completedAt,
    attempt: attempt,
    reportsToWorkflow: reportsToWorkflow,
    results: results);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.WorkflowResultFieldsTaskResponse
One of the instance's enabled RunWorkflow post-process tasks.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**TriggerOn** | **string** | When this task fires: OnSuccess, OnFailure or Always. | 
**ResultFields** | **List&lt;string&gt;** | Names of the fields this particular task declares. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string name = "name";
string triggerOn = "triggerOn";
List<string> resultFields = new List<string>();

WorkflowResultFieldsTaskResponse workflowResultFieldsTaskResponseInstance = new WorkflowResultFieldsTaskResponse(
    name: name,
    triggerOn: triggerOn,
    resultFields: resultFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

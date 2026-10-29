# Finbourne.Horizon.Sdk.Model.WorkflowExecuteStageResponse
One stage of a staged integration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Steps** | **List&lt;string&gt;** | The steps that run for this stage. | 
**Parameters** | **List&lt;string&gt;** | Names of every parameter this stage accepts. | 
**Rules** | **List&lt;string&gt;** | Cross-field rules the stage enforces, in plain text. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string name = "name";
List<string> steps = new List<string>();
List<string> parameters = new List<string>();
List<string> rules = new List<string>();

WorkflowExecuteStageResponse workflowExecuteStageResponseInstance = new WorkflowExecuteStageResponse(
    name: name,
    steps: steps,
    parameters: parameters,
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

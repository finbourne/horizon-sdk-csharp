# Finbourne.Horizon.Sdk.Model.PostProcessTask
Request defining a post-processing task for an instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The type of action to perform (Allowed: RunIntegration, RunWorkflow, TriggerEmail) | 
**TargetInstance** | **string** | The instance identifier to trigger (for TriggerIntegration action). | [optional] 
**TriggerOn** | **string** | When the task should be triggered (Allowed: OnSuccess, OnFailure, Always) | 
**Parameters** | **Object** | JSON parameters specific to the action type. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string action = "action";
string targetInstance = "example targetInstance";
string triggerOn = "triggerOn";

PostProcessTask postProcessTaskInstance = new PostProcessTask(
    action: action,
    targetInstance: targetInstance,
    triggerOn: triggerOn,
    parameters: parameters);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

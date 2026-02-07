# Finbourne.Horizon.Sdk.Model.PostProcessTask

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** |  | 
**TargetInstance** | **string** |  | [optional] 
**TriggerOn** | **string** |  | 
**Parameters** | **Object** |  | [optional] 

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

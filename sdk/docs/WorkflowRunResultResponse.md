# Finbourne.Horizon.Sdk.Model.WorkflowRunResultResponse
A single declared field and the value this run published for it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Type** | **string** | One of the Workflow field types: String, Decimal, DateTime, Boolean, LusidUserId. | 
**Value** | **string** | The published value, or null when the run published nothing for this field. | [optional] 
**DisplayName** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string name = "name";
string type = "type";
string value = "example value";
string displayName = "example displayName";

WorkflowRunResultResponse workflowRunResultResponseInstance = new WorkflowRunResultResponse(
    name: name,
    type: type,
    value: value,
    displayName: displayName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.WorkflowResultFieldResponse
A single declared field.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Type** | **string** | One of the Workflow field types: String, Decimal, DateTime, Boolean, LusidUserId. | 
**DisplayName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string name = "name";
string type = "type";
string displayName = "example displayName";
string description = "example description";

WorkflowResultFieldResponse workflowResultFieldResponseInstance = new WorkflowResultFieldResponse(
    name: name,
    type: type,
    displayName: displayName,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

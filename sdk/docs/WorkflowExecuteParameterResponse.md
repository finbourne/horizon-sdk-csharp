# Finbourne.Horizon.Sdk.Model.WorkflowExecuteParameterResponse
A single execute parameter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Type** | **string** | One of the Workflow field types: String, Decimal, DateTime, Boolean. | 
**Required** | **bool** | Whether every run must supply the parameter, whatever its stage. | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**Format** | **string** | The shape a String value must take, e.g. YYYY-MM, when it has one. | [optional] 
**AllowedValues** | **List&lt;string&gt;** | The closed set of accepted values, when there is one. | [optional] 
**RequiredForStages** | **List&lt;string&gt;** | The stages for which the parameter is mandatory. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string name = "name";
string type = "type";
bool required = //"True";
string displayName = "displayName";
string description = "description";
string format = "example format";
List<string> allowedValues = new List<string>();
List<string> requiredForStages = new List<string>();

WorkflowExecuteParameterResponse workflowExecuteParameterResponseInstance = new WorkflowExecuteParameterResponse(
    name: name,
    type: type,
    required: required,
    displayName: displayName,
    description: description,
    format: format,
    allowedValues: allowedValues,
    requiredForStages: requiredForStages);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.CreateInstanceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceOptionalProps** | [**Dictionary&lt;string, LusidPropertyDefinitionOverridesByType&gt;**](LusidPropertyDefinitionOverridesByType.md) |  | [optional] 
**IntegrationType** | **string** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**Enabled** | **bool** |  | 
**Triggers** | [**List&lt;Trigger&gt;**](Trigger.md) |  | 
**Details** | **Object** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

Dictionary<string, LusidPropertyDefinitionOverridesByType> instanceOptionalProps = new Dictionary<string, LusidPropertyDefinitionOverridesByType>();
string integrationType = "integrationType";
string name = "name";
string description = "description";
bool enabled = //"True";
List<Trigger> triggers = new List<Trigger>();

CreateInstanceRequest createInstanceRequestInstance = new CreateInstanceRequest(
    instanceOptionalProps: instanceOptionalProps,
    integrationType: integrationType,
    name: name,
    description: description,
    enabled: enabled,
    triggers: triggers,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.IntegrationInstanceResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**IntegrationType** | **string** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**Enabled** | **bool** |  | 
**Triggers** | [**List&lt;Trigger&gt;**](Trigger.md) |  | 
**Details** | **Object** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string id = "id";
string integrationType = "integrationType";
string name = "name";
string description = "description";
bool enabled = //"True";
List<Trigger> triggers = new List<Trigger>();

IntegrationInstanceResponse integrationInstanceResponseInstance = new IntegrationInstanceResponse(
    id: id,
    integrationType: integrationType,
    name: name,
    description: description,
    enabled: enabled,
    triggers: triggers,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

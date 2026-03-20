# Finbourne.Horizon.Sdk.Model.IntegrationInstance
Response containing an integration instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifies the instance within the integration. | 
**IntegrationType** | **string** | The integration type. | 
**Name** | **string** | Name of the instance. | 
**Description** | **string** | Description of the instance. | 
**Enabled** | **bool** | If true the instance will be executed if its trigger is satisfied. | 
**Triggers** | [**List&lt;Trigger&gt;**](Trigger.md) | Defines what triggers execution of the instance. | 
**Details** | **Object** | Base DTO type of an integration configuration specific to the integration type.              N.B. ASP.NET Core model validation is normally applied automatically when [ApiController] is added to a controller, however it doesn&#39;t work here with the polymorphic integration subtypes of this class (see https://github.com/dotnet/aspnetcore/issues/27882). The workaround here is to implement the IValidatableObject interface and each subtype must call Validate() or ValidateContents() on its properties (the validation is not recursive).  Located in Horizon.Integrations.Web so both specific integration projects and Horizon.WebApi can reference it. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string id = "id";
string integrationType = "integrationType";
string name = "name";
string description = "description";
bool enabled = //"True";
List<Trigger> triggers = new List<Trigger>();

IntegrationInstance integrationInstanceInstance = new IntegrationInstance(
    id: id,
    integrationType: integrationType,
    name: name,
    description: description,
    enabled: enabled,
    triggers: triggers,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

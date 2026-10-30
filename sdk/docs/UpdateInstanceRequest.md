# Finbourne.Horizon.Sdk.Model.UpdateInstanceRequest
A request to update an existing integration instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Instance identifier | 
**IntegrationType** | **string** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**Enabled** | **bool** |  | 
**Triggers** | [**List&lt;Trigger&gt;**](Trigger.md) |  | 
**Details** | **Object** | Base DTO type of an integration configuration specific to the integration type.              N.B. ASP.NET Core model validation is normally applied automatically when [ApiController] is added to a controller, however it doesn&#39;t work here with the polymorphic integration subtypes of this class (see https://github.com/dotnet/aspnetcore/issues/27882). The workaround here is to implement the IValidatableObject interface and each subtype must call Validate() or ValidateContents() on its properties (the validation is not recursive).  Located in Horizon.Integrations.Web so both specific integration projects and Horizon.WebApi can reference it. | 
**PostProcessTasks** | [**List&lt;PostProcessTask&gt;**](PostProcessTask.md) | Post-process tasks for the instance. On update the stored tasks are replaced by this set when it is present, an empty set clears them, and omitting the field leaves them unchanged. | [optional] 
**AlertRules** | [**List&lt;AlertRule&gt;**](AlertRule.md) | Alert rules for the instance. On update the stored rules are replaced by this set when it is present, an empty set clears them, and omitting the field leaves them unchanged. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string id = "id";
string integrationType = "integrationType";
string name = "name";
string description = "description";
bool enabled = //"True";
List<Trigger> triggers = new List<Trigger>();
List<PostProcessTask> postProcessTasks = new List<PostProcessTask>();
List<AlertRule> alertRules = new List<AlertRule>();

UpdateInstanceRequest updateInstanceRequestInstance = new UpdateInstanceRequest(
    id: id,
    integrationType: integrationType,
    name: name,
    description: description,
    enabled: enabled,
    triggers: triggers,
    details: details,
    postProcessTasks: postProcessTasks,
    alertRules: alertRules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.IntegrationDescription
Response containing the description of an integration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Unique identifier of the integration e.g. \&quot;copp-clark\&quot;. | 
**Name** | **string** | Readable name of the integration e.g. \&quot;Copp Clark\&quot;. | 
**Description** | **string** | Describes the purpose of the integration. | 
**SupportedTriggerTypes** | **List&lt;string&gt;** | Trigger types (Time, File) the integration supports. | 
**Licensed** | **bool** | True if your domain is licensed to use this integration, otherwise false. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string type = "type";
string name = "name";
string description = "description";
List<string> supportedTriggerTypes = new List<string>();
bool licensed = //"True";

IntegrationDescription integrationDescriptionInstance = new IntegrationDescription(
    type: type,
    name: name,
    description: description,
    supportedTriggerTypes: supportedTriggerTypes,
    licensed: licensed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

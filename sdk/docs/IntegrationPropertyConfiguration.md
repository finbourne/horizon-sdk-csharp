# Finbourne.Horizon.Sdk.Model.IntegrationPropertyConfiguration
Response containing the description of an integration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The Integration this property configuration applies to | 
**Properties** | [**List&lt;PropertyMapping&gt;**](PropertyMapping.md) | The mandatory and optional properties available in this integration | 
**Fields** | [**List&lt;FieldMapping&gt;**](FieldMapping.md) | The fields available in this integration | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string type = "type";
List<PropertyMapping> properties = new List<PropertyMapping>();
List<FieldMapping> fields = new List<FieldMapping>();

IntegrationPropertyConfiguration integrationPropertyConfigurationInstance = new IntegrationPropertyConfiguration(
    type: type,
    properties: properties,
    fields: fields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.PropertyMapping
Mapping from a set of VendorFields to a LUSID Property

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Property** | [**LusidPropertyDefinition**](LusidPropertyDefinition.md) |  | 
**VendorFields** | [**List&lt;VendorField&gt;**](VendorField.md) | Fields that will be used to map to this Property Definition | 
**Optionality** | **string** | Whether the Property is Mandatory, Suggested or Optional | 
**EntityType** | **string** | The LUSID Entity this is valid for | 
**EntitySubType** | **string** | The LUSID Entity sub type this is valid for | [optional] 
**TransformationDescription** | **string** | The transformation, if required, to map from VendorFields to the LUSID Property | [optional] 
**Versions** | **List&lt;string&gt;** | The versions of the Vendor integration this mapping is valid for | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

LusidPropertyDefinition property = new LusidPropertyDefinition();
List<VendorField> vendorFields = new List<VendorField>();
string optionality = "optionality";
string entityType = "entityType";
string entitySubType = "example entitySubType";
string transformationDescription = "example transformationDescription";
List<string> versions = new List<string>();

PropertyMapping propertyMappingInstance = new PropertyMapping(
    property: property,
    vendorFields: vendorFields,
    optionality: optionality,
    entityType: entityType,
    entitySubType: entitySubType,
    transformationDescription: transformationDescription,
    versions: versions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

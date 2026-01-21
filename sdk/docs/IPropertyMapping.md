# Finbourne.Horizon.Sdk.Model.IPropertyMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntitySubType** | **string** |  | [optional] 
**EntityType** | **string** |  | 
**Optionality** | **string** |  | 
**Property** | [**LusidPropertyDefinition**](LusidPropertyDefinition.md) |  | 
**TransformationDescription** | **string** |  | [optional] 
**VendorFields** | [**List&lt;VendorField&gt;**](VendorField.md) |  | 
**Versions** | **List&lt;string&gt;** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string entitySubType = "example entitySubType";
string entityType = "entityType";
string optionality = "optionality";
LusidPropertyDefinition property = new LusidPropertyDefinition();
string transformationDescription = "example transformationDescription";
List<VendorField> vendorFields = new List<VendorField>();
List<string> versions = new List<string>();

IPropertyMapping iPropertyMappingInstance = new IPropertyMapping(
    entitySubType: entitySubType,
    entityType: entityType,
    optionality: optionality,
    property: property,
    transformationDescription: transformationDescription,
    vendorFields: vendorFields,
    versions: versions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

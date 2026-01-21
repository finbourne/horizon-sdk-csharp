# Finbourne.Horizon.Sdk.Model.IFieldMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultValue** | **string** |  | [optional] 
**EntitySubType** | **string** |  | [optional] 
**EntityType** | **string** |  | 
**FieldName** | **string** |  | 
**TransformationDescription** | **string** |  | [optional] 
**VendorFields** | [**List&lt;VendorField&gt;**](VendorField.md) |  | 
**Versions** | **List&lt;string&gt;** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string defaultValue = "example defaultValue";
string entitySubType = "example entitySubType";
string entityType = "entityType";
string fieldName = "fieldName";
string transformationDescription = "example transformationDescription";
List<VendorField> vendorFields = new List<VendorField>();
List<string> versions = new List<string>();

IFieldMapping iFieldMappingInstance = new IFieldMapping(
    defaultValue: defaultValue,
    entitySubType: entitySubType,
    entityType: entityType,
    fieldName: fieldName,
    transformationDescription: transformationDescription,
    vendorFields: vendorFields,
    versions: versions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

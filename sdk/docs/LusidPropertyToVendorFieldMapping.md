# Finbourne.Horizon.Sdk.Model.LusidPropertyToVendorFieldMapping
The mapping of a LUSID Property from the Vendor Field that would populate it

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Property** | [**LusidPropertyDefinition**](LusidPropertyDefinition.md) |  | 
**VendorField** | **string** |  | 
**VendorPackage** | **string** |  | 
**VendorNamespace** | **string** |  | 
**Optionality** | **Optionality** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

LusidPropertyDefinition property = new LusidPropertyDefinition();
string vendorField = "vendorField";
string vendorPackage = "vendorPackage";
string vendorNamespace = "vendorNamespace";

LusidPropertyToVendorFieldMapping lusidPropertyToVendorFieldMappingInstance = new LusidPropertyToVendorFieldMapping(
    property: property,
    vendorField: vendorField,
    vendorPackage: vendorPackage,
    vendorNamespace: vendorNamespace,
    optionality: optionality);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

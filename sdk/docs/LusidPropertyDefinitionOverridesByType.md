# Finbourne.Horizon.Sdk.Model.LusidPropertyDefinitionOverridesByType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayNameOverride** | **string** |  | [optional] 
**DescriptionOverride** | **string** |  | [optional] 
**EntityType** | **string** |  | [optional] 
**EntitySubType** | **List&lt;string&gt;** |  | [optional] 
**VendorPackage** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string displayNameOverride = "example displayNameOverride";
string descriptionOverride = "example descriptionOverride";
string entityType = "example entityType";
List<string> entitySubType = new List<string>();
List<string> vendorPackage = new List<string>();

LusidPropertyDefinitionOverridesByType lusidPropertyDefinitionOverridesByTypeInstance = new LusidPropertyDefinitionOverridesByType(
    displayNameOverride: displayNameOverride,
    descriptionOverride: descriptionOverride,
    entityType: entityType,
    entitySubType: entitySubType,
    vendorPackage: vendorPackage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.LusidPropertyDefinitionOverridesByType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayNameOverride** | **string** |  | [optional] 
**DescriptionOverride** | **string** |  | [optional] 
**EntityType** | **string** |  | [optional] 
**EntitySubType** | **List&lt;string&gt;** |  | [optional] 
**VendorPackage** | **List&lt;string&gt;** |  | [optional] 
**EffectiveFromOverride** | **string** | ISO-8601 instant to use as the property value&#39;s effectiveFrom instead of the date the integration derives, e.g. \&quot;0001-01-01T00:00:00Z\&quot;. Only accepted for integrations reporting supportsEffectiveFromOverride, and only for TimeVariant property definitions. Omit to leave any stored value untouched; send an empty string to clear it. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string displayNameOverride = "example displayNameOverride";
string descriptionOverride = "example descriptionOverride";
string entityType = "example entityType";
List<string> entitySubType = new List<string>();
List<string> vendorPackage = new List<string>();
string effectiveFromOverride = "example effectiveFromOverride";

LusidPropertyDefinitionOverridesByType lusidPropertyDefinitionOverridesByTypeInstance = new LusidPropertyDefinitionOverridesByType(
    displayNameOverride: displayNameOverride,
    descriptionOverride: descriptionOverride,
    entityType: entityType,
    entitySubType: entitySubType,
    vendorPackage: vendorPackage,
    effectiveFromOverride: effectiveFromOverride);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

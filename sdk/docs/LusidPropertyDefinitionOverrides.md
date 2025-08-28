# Finbourne.Horizon.Sdk.Model.LusidPropertyDefinitionOverrides
Override values for property Display Name and Description

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayNameOverride** | **string** |  | [optional] 
**DescriptionOverride** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string displayNameOverride = "example displayNameOverride";
string descriptionOverride = "example descriptionOverride";

LusidPropertyDefinitionOverrides lusidPropertyDefinitionOverridesInstance = new LusidPropertyDefinitionOverrides(
    displayNameOverride: displayNameOverride,
    descriptionOverride: descriptionOverride);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

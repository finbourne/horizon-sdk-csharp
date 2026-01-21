# Finbourne.Horizon.Sdk.Model.LusidPropertyDefinitionOverridesResponse
An item that has been updated as a result of setting LusidPropertyDefinitionOverrides.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The action performed on this property. \&quot;upsert\&quot; for setting values for new and existing             properties. \&quot;delete\&quot; for existing properties that were removed | 
**WriteError** | **string** |  | [optional] 
**WriteErrorDetail** | **string** |  | [optional] 
**DisplayNameOverride** | **string** |  | [optional] 
**DescriptionOverride** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string action = "action";
string writeError = "example writeError";
string writeErrorDetail = "example writeErrorDetail";
string displayNameOverride = "example displayNameOverride";
string descriptionOverride = "example descriptionOverride";

LusidPropertyDefinitionOverridesResponse lusidPropertyDefinitionOverridesResponseInstance = new LusidPropertyDefinitionOverridesResponse(
    action: action,
    writeError: writeError,
    writeErrorDetail: writeErrorDetail,
    displayNameOverride: displayNameOverride,
    descriptionOverride: descriptionOverride);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

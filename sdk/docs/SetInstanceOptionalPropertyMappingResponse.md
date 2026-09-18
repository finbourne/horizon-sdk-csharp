# Finbourne.Horizon.Sdk.Model.SetInstanceOptionalPropertyMappingResponse
Response for SetInstanceOptionalPropertyMapping.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyOverrides** | [**Dictionary&lt;string, LusidPropertyDefinitionOverridesByType&gt;**](LusidPropertyDefinitionOverridesByType.md) | The full, current optional property mapping for the instance, after the write. | 
**Warnings** | **List&lt;string&gt;** | Advisory warnings about a write that succeeded regardless, e.g. a future-dated effectiveFromOverride, or another enabled instance of the same integration holding a different effectiveFromOverride for the same property. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

Dictionary<string, LusidPropertyDefinitionOverridesByType> propertyOverrides = new Dictionary<string, LusidPropertyDefinitionOverridesByType>();
List<string> warnings = new List<string>();

SetInstanceOptionalPropertyMappingResponse setInstanceOptionalPropertyMappingResponseInstance = new SetInstanceOptionalPropertyMappingResponse(
    propertyOverrides: propertyOverrides,
    warnings: warnings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

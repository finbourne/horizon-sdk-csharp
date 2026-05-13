# Finbourne.Horizon.Sdk.Model.VersionedConfigurationTypeResponse
Represents a registered versioned configuration type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigType** | **string** |  | 
**DisplayName** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string configType = "configType";
string displayName = "displayName";

VersionedConfigurationTypeResponse versionedConfigurationTypeResponseInstance = new VersionedConfigurationTypeResponse(
    configType: configType,
    displayName: displayName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

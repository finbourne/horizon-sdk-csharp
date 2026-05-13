# Finbourne.Horizon.Sdk.Model.CreateVersionedConfigurationDraftRequest
Request to create a new draft versioned configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MajorVersion** | **int?** | The major version for the new draft. Must be supplied together with minorVersion, or both omitted to auto-assign the next version. | [optional] 
**MinorVersion** | **int?** | The minor version for the new draft. Must be supplied together with MajorVersion, or both omitted to auto-assign the next version. | [optional] 
**SourceMajorVersion** | **int?** | The major version of an existing record to copy the value from. Must be supplied together with SourceMinorVersion. If omitted, the new draft is initialised with an empty JSON object. | [optional] 
**SourceMinorVersion** | **int?** | The minor version of an existing record to copy the value from. Must be supplied together with SourceMajorVersion. If omitted, the new draft is initialised with an empty JSON object. | [optional] 
**Value** | **string** | The initial JSON value for the new draft. If omitted, the draft is initialised with an empty JSON object. Cannot be supplied together with SourceMajorVersion/SourceMinorVersion. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string value = "example value";

CreateVersionedConfigurationDraftRequest createVersionedConfigurationDraftRequestInstance = new CreateVersionedConfigurationDraftRequest(
    majorVersion: majorVersion,
    minorVersion: minorVersion,
    sourceMajorVersion: sourceMajorVersion,
    sourceMinorVersion: sourceMinorVersion,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.UpdateVersionedConfigurationDraftRequest
Request to update the value of an existing draft versioned configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The new JSON value to store. Must be valid JSON. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string value = "value";

UpdateVersionedConfigurationDraftRequest updateVersionedConfigurationDraftRequestInstance = new UpdateVersionedConfigurationDraftRequest(
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

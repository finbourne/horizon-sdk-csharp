# Finbourne.Horizon.Sdk.Model.UpdateClientConfigurationDraftRequest
Request to update the value of an existing draft client configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The new JSON value to store. Must be valid JSON. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string value = "value";

UpdateClientConfigurationDraftRequest updateClientConfigurationDraftRequestInstance = new UpdateClientConfigurationDraftRequest(
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.UpdateInstanceResponse
The outcome of updating an instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Warnings** | [**List&lt;ValidationNoticeResponse&gt;**](ValidationNoticeResponse.md) | Non-blocking findings about the saved configuration. Empty when there are none. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<ValidationNoticeResponse> warnings = new List<ValidationNoticeResponse>();

UpdateInstanceResponse updateInstanceResponseInstance = new UpdateInstanceResponse(
    warnings: warnings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.ReplayOptions
Optional parameters for replay operations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverridePublicationStatus** | **string** | Override publication status for all transactions (e.g., force as \&quot;New\&quot;). | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string overridePublicationStatus = "example overridePublicationStatus";

ReplayOptions replayOptionsInstance = new ReplayOptions(
    overridePublicationStatus: overridePublicationStatus);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

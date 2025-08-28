# Finbourne.Horizon.Sdk.Model.OnboardInstrumentRequest
The full structure of a instrument creation / onboarding request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataResults** | [**List&lt;OpenFigiPermIdResult&gt;**](OpenFigiPermIdResult.md) | Enumerable packed OpenFigi/PermId information used to create instruments | 
**PrimaryVendorKey** | **string** | Primary vendor used to master instrument from Unknown to an asset type | [optional] 
**SecondaryVendorKeys** | **List&lt;string&gt;** | Secondary vendors used to decorate additional properties | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<OpenFigiPermIdResult> dataResults = new List<OpenFigiPermIdResult>();
string primaryVendorKey = "example primaryVendorKey";
List<string> secondaryVendorKeys = new List<string>();

OnboardInstrumentRequest onboardInstrumentRequestInstance = new OnboardInstrumentRequest(
    dataResults: dataResults,
    primaryVendorKey: primaryVendorKey,
    secondaryVendorKeys: secondaryVendorKeys);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

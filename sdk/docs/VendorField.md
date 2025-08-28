# Finbourne.Horizon.Sdk.Model.VendorField
Reference to a specific vendor field

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Package** | **string** | The vendor package it is included in | 
**Field** | **string** | The name of the field | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string package = "package";
string field = "field";

VendorField vendorFieldInstance = new VendorField(
    package: package,
    field: field);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

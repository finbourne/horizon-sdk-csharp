# Finbourne.Horizon.Sdk.Model.VendorProduct
Denormalised information about vendors, the products they provide and the LUSID entity types they can be used to populate.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorName** | **string** |  | 
**ProductName** | **string** |  | 
**VendorProductKey** | **string** |  | 
**LusidEntity** | [**LusidEntity**](LusidEntity.md) |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string vendorName = "vendorName";
string productName = "productName";
string vendorProductKey = "vendorProductKey";
LusidEntity lusidEntity = new LusidEntity();

VendorProduct vendorProductInstance = new VendorProduct(
    vendorName: vendorName,
    productName: productName,
    vendorProductKey: vendorProductKey,
    lusidEntity: lusidEntity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

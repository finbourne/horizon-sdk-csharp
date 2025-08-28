# Finbourne.Horizon.Sdk.Model.OpenFigiPermIdResult
A packed WebAPI OpenFigi DTO and PermId DTO

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OpenFigiResult** | [**OpenFigiData**](OpenFigiData.md) |  | 
**PermIdResult** | [**PermIdData**](PermIdData.md) |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

OpenFigiData openFigiResult = new OpenFigiData();
PermIdData? permIdResult = new PermIdData();


OpenFigiPermIdResult openFigiPermIdResultInstance = new OpenFigiPermIdResult(
    openFigiResult: openFigiResult,
    permIdResult: permIdResult);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

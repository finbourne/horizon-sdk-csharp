# Finbourne.Horizon.Sdk.Model.QueryRequest
Used to control queries, including getting \"pages\" of data

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Specification** | [**QuerySpecification**](QuerySpecification.md) |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

QuerySpecification? specification = new QuerySpecification();


QueryRequest queryRequestInstance = new QueryRequest(
    specification: specification);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

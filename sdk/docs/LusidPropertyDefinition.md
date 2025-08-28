# Finbourne.Horizon.Sdk.Model.LusidPropertyDefinition
Defines the information in a LUSID Property Definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** |  | [readonly] 
**ProductEntityItemKey** | **string** | Property key associated with the mapping | 
**Domain** | **string** | The domain of this definition. | 
**Scope** | **string** | The scope of this definition. | 
**Code** | **string** | The code of this definition. | 
**DisplayName** | **string** | The name used when this definition is displayed. | 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | 
**Description** | **string** |  | 
**Lifetime** | **string** |  | 
**ConstraintStyle** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string key = "key";
string productEntityItemKey = "productEntityItemKey";
string domain = "domain";
string scope = "scope";
string code = "code";
string displayName = "displayName";
ResourceId dataTypeId = new ResourceId();
string description = "description";
string lifetime = "lifetime";
string constraintStyle = "constraintStyle";

LusidPropertyDefinition lusidPropertyDefinitionInstance = new LusidPropertyDefinition(
    key: key,
    productEntityItemKey: productEntityItemKey,
    domain: domain,
    scope: scope,
    code: code,
    displayName: displayName,
    dataTypeId: dataTypeId,
    description: description,
    lifetime: lifetime,
    constraintStyle: constraintStyle);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

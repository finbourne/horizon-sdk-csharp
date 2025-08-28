# Finbourne.Horizon.Sdk.Model.LusidEntity
Information about the LUSID entity this data can be used with

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The entity type | 
**EntityTypeDisplayName** | **string** | The display name for the entity type. | 
**EntitySubType** | **string** | The entity sub-type | [optional] 
**EntitySubTypeDisplayName** | **string** | Display name for the entity sub-type | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string entityType = "entityType";
string entityTypeDisplayName = "entityTypeDisplayName";
string entitySubType = "example entitySubType";
string entitySubTypeDisplayName = "example entitySubTypeDisplayName";

LusidEntity lusidEntityInstance = new LusidEntity(
    entityType: entityType,
    entityTypeDisplayName: entityTypeDisplayName,
    entitySubType: entitySubType,
    entitySubTypeDisplayName: entitySubTypeDisplayName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

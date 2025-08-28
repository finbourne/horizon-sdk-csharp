# Finbourne.Horizon.Sdk.Model.IntegrationLogTargetRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecordAction** | **string** |  | [optional] 
**RecordType** | **string** |  | [optional] 
**IdType** | **string** |  | [optional] 
**IdValue** | **string** |  | [optional] 
**AttributeName** | **string** |  | [optional] 
**AttributeValue** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string recordAction = "example recordAction";
string recordType = "example recordType";
string idType = "example idType";
string idValue = "example idValue";
string attributeName = "example attributeName";
string attributeValue = "example attributeValue";

IntegrationLogTargetRecord integrationLogTargetRecordInstance = new IntegrationLogTargetRecord(
    recordAction: recordAction,
    recordType: recordType,
    idType: idType,
    idValue: idValue,
    attributeName: attributeName,
    attributeValue: attributeValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

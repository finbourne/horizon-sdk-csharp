# Finbourne.Horizon.Sdk.Model.IntegrationLogRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecordType** | **string** |  | [optional] 
**IdType** | **string** |  | [optional] 
**IdValue** | **string** |  | [optional] 
**AttributeName** | **string** |  | [optional] 
**AttributeValue** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string recordType = "example recordType";
string idType = "example idType";
string idValue = "example idValue";
string attributeName = "example attributeName";
string attributeValue = "example attributeValue";

IntegrationLogRecord integrationLogRecordInstance = new IntegrationLogRecord(
    recordType: recordType,
    idType: idType,
    idValue: idValue,
    attributeName: attributeName,
    attributeValue: attributeValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

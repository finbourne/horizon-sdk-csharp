# Finbourne.Horizon.Sdk.Model.IntegrationLogActivity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTimeOffset** |  | 
**ResultingStatus** | **string** |  | 
**MessageType** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string resultingStatus = "resultingStatus";
string messageType = "example messageType";
string description = "example description";

IntegrationLogActivity integrationLogActivityInstance = new IntegrationLogActivity(
    timestamp: timestamp,
    resultingStatus: resultingStatus,
    messageType: messageType,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

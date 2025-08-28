# Finbourne.Horizon.Sdk.Model.Trigger

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**CronExpression** | **string** |  | 
**VarTimeZone** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string type = "type";
string cronExpression = "cronExpression";
string varTimeZone = "varTimeZone";

Trigger triggerInstance = new Trigger(
    type: type,
    cronExpression: cronExpression,
    varTimeZone: varTimeZone);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

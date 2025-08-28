# Finbourne.Horizon.Sdk.Model.ExternalLogRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Logid** | **long** |  | 
**Parentlogid** | **long?** |  | [optional] 
**Loglevel** | **string** |  | 
**Logstatus** | **string** |  | 
**Sourcerecordtype** | **string** |  | [optional] 
**Sourceprimaryidtype** | **string** |  | [optional] 
**Sourceprimaryidvalue** | **string** |  | [optional] 
**Targetrecordtype** | **string** |  | [optional] 
**Targetrecordaction** | **string** |  | [optional] 
**Targetprimaryidtype** | **string** |  | [optional] 
**Targetprimaryidvalue** | **string** |  | [optional] 
**Message** | **string** |  | [optional] 
**Messagetype** | **string** |  | [optional] 
**Timestamp** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string loglevel = "loglevel";
string logstatus = "logstatus";
string sourcerecordtype = "example sourcerecordtype";
string sourceprimaryidtype = "example sourceprimaryidtype";
string sourceprimaryidvalue = "example sourceprimaryidvalue";
string targetrecordtype = "example targetrecordtype";
string targetrecordaction = "example targetrecordaction";
string targetprimaryidtype = "example targetprimaryidtype";
string targetprimaryidvalue = "example targetprimaryidvalue";
string message = "example message";
string messagetype = "example messagetype";
string timestamp = "timestamp";

ExternalLogRecord externalLogRecordInstance = new ExternalLogRecord(
    logid: logid,
    parentlogid: parentlogid,
    loglevel: loglevel,
    logstatus: logstatus,
    sourcerecordtype: sourcerecordtype,
    sourceprimaryidtype: sourceprimaryidtype,
    sourceprimaryidvalue: sourceprimaryidvalue,
    targetrecordtype: targetrecordtype,
    targetrecordaction: targetrecordaction,
    targetprimaryidtype: targetprimaryidtype,
    targetprimaryidvalue: targetprimaryidvalue,
    message: message,
    messagetype: messagetype,
    timestamp: timestamp);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

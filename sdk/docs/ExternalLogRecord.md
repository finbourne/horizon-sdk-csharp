# Finbourne.Horizon.Sdk.Model.ExternalLogRecord
Represents an external log record.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Logid** | **long** | The unique log identifier. | 
**Parentlogid** | **long?** | The parent log identifier (null is allowed). | [optional] 
**Loglevel** | **string** | The log level. | 
**Logstatus** | **string** | The log status. | 
**Sourcerecordtype** | **string** | The source record type. | [optional] 
**Sourceprimaryidtype** | **string** | The source primary ID type. | [optional] 
**Sourceprimaryidvalue** | **string** | The source primary ID value. | [optional] 
**Targetrecordtype** | **string** | The target record type. | [optional] 
**Targetrecordaction** | **string** | The target record action. | [optional] 
**Targetprimaryidtype** | **string** | The target primary ID type. | [optional] 
**Targetprimaryidvalue** | **string** | The target primary ID value. | [optional] 
**Message** | **string** | The log message. | [optional] 
**Messagetype** | **string** | The message type. | [optional] 
**Timestamp** | **string** | The timestamp of the log record. | 

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

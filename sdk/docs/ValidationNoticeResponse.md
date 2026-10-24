# Finbourne.Horizon.Sdk.Model.ValidationNoticeResponse
A non-blocking finding raised when an instance was saved. The save succeeded regardless.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | \&quot;Warning\&quot; or \&quot;Information\&quot;. | 
**Field** | **string** | The configuration field the finding relates to. | 
**Message** | **string** | What was found. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string severity = "severity";
string field = "field";
string message = "message";

ValidationNoticeResponse validationNoticeResponseInstance = new ValidationNoticeResponse(
    severity: severity,
    field: field,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

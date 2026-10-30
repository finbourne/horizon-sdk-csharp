# Finbourne.Horizon.Sdk.Model.FileDestinationResponse
The destination a file delivery row describes. A Failed row carries the per-transaction FailureReason when one was recorded, falling back to the raw Error text.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Path** | **string** |  | 
**Status** | **string** |  | 
**Error** | **string** |  | [optional] 
**FailureReason** | **string** |  | [optional] 
**Name** | **string** | The configured destination name, such as the SFTP host, when one was recorded. | [optional] 
**DeliveredAt** | **DateTimeOffset?** | When the file reached the destination; null for a Failed or Pending row. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string type = "type";
string path = "path";
string status = "status";
string error = "example error";
string failureReason = "example failureReason";
string name = "example name";

FileDestinationResponse fileDestinationResponseInstance = new FileDestinationResponse(
    type: type,
    path: path,
    status: status,
    error: error,
    failureReason: failureReason,
    name: name,
    deliveredAt: deliveredAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

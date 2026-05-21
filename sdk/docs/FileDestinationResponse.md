# Finbourne.Horizon.Sdk.Model.FileDestinationResponse
record containing details of a single file destination for a run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Path** | **string** |  | 
**Status** | **string** |  | 
**Error** | **string** |  | [optional] 
**FailureReason** | **string** |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string type = "type";
string path = "path";
string status = "status";
string error = "example error";
string failureReason = "example failureReason";

FileDestinationResponse fileDestinationResponseInstance = new FileDestinationResponse(
    type: type,
    path: path,
    status: status,
    error: error,
    failureReason: failureReason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

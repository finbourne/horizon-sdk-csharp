# Finbourne.Horizon.Sdk.Model.TpfFileDeliveryResponse
Response model for TPF file delivery search results

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** |  | [optional] 
**RunStartTime** | **DateTimeOffset?** |  | [optional] 
**FileName** | **string** |  | 
**GeneratedAt** | **DateTimeOffset** |  | 
**RowCount** | **int** |  | 
**FileHash** | **string** |  | [optional] 
**DestinationType** | **string** |  | 
**DestinationPath** | **string** |  | [optional] 
**DestinationStatus** | **string** |  | 
**DestinationError** | **string** |  | [optional] 
**DestinationName** | **string** |  | [optional] 
**FileUuid** | **Guid** |  | 
**CanResend** | **bool** | Whether the data the file is rebuilt from is still retained, so a resend can be requested. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string runId = "example runId";
string fileName = "fileName";
string fileHash = "example fileHash";
string destinationType = "destinationType";
string destinationPath = "example destinationPath";
string destinationStatus = "destinationStatus";
string destinationError = "example destinationError";
string destinationName = "example destinationName";
Guid fileUuid = "fileUuid";
bool canResend = //"True";

TpfFileDeliveryResponse tpfFileDeliveryResponseInstance = new TpfFileDeliveryResponse(
    runId: runId,
    runStartTime: runStartTime,
    fileName: fileName,
    generatedAt: generatedAt,
    rowCount: rowCount,
    fileHash: fileHash,
    destinationType: destinationType,
    destinationPath: destinationPath,
    destinationStatus: destinationStatus,
    destinationError: destinationError,
    destinationName: destinationName,
    fileUuid: fileUuid,
    canResend: canResend);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

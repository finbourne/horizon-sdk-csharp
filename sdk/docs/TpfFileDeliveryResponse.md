# Finbourne.Horizon.Sdk.Model.TpfFileDeliveryResponse
Response model for TPF file delivery search results

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** | The run id of the latest execution attempt in this row&#39;s run chain (the root run, its automatic retries and resends); equals referenceId when the chain has a single attempt or no recorded execution. | [optional] 
**RunStartTime** | **DateTimeOffset?** | When the row&#39;s root run started (the batch start), not the latest attempt&#39;s start. | [optional] 
**FileName** | **string** |  | 
**GeneratedAt** | **DateTimeOffset** | When the file was built, or when the attempt failed before a file was built. | 
**RowCount** | **int** |  | 
**FileHash** | **string** |  | [optional] 
**DestinationType** | **string** |  | 
**DestinationPath** | **string** |  | [optional] 
**DestinationStatus** | **string** |  | 
**DestinationError** | **string** |  | [optional] 
**DestinationName** | **string** |  | [optional] 
**FileUuid** | **Guid** |  | 
**CanResend** | **bool** | Whether the data the file is rebuilt from is still retained, so a resend can be requested. | 
**DeliveredAt** | **DateTimeOffset?** | When the file reached the destination; null for a Failed or Pending row. | [optional] 
**Attempt** | **int?** | The highest attempt number (1-based) made for this delivery&#39;s run, including automatic retries and resends. | [optional] 
**ReferenceId** | **string** | The root run id of this row&#39;s run chain, the same value run history reports as referenceId. | [optional] 

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
string referenceId = "example referenceId";

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
    canResend: canResend,
    deliveredAt: deliveredAt,
    attempt: attempt,
    referenceId: referenceId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

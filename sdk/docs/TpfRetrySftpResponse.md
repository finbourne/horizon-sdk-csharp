# Finbourne.Horizon.Sdk.Model.TpfRetrySftpResponse
Response from retrying SFTP file delivery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | Whether the retry was successful | 
**Message** | **string** | Status message describing the result | 
**NewFileDeliveryId** | **long?** | ID of the new file delivery record created for this retry (if successful) | [optional] 
**RetriedAt** | **DateTimeOffset?** | Timestamp when the retry was executed | [optional] 
**OriginalFile** | [**TpfFileDeliveryInfo**](TpfFileDeliveryInfo.md) |  | [optional] 
**DuplicateFile** | [**TpfFileDeliveryInfo**](TpfFileDeliveryInfo.md) |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

bool success = //"True";
string message = "message";
TpfFileDeliveryInfo? originalFile = new TpfFileDeliveryInfo();

TpfFileDeliveryInfo? duplicateFile = new TpfFileDeliveryInfo();


TpfRetrySftpResponse tpfRetrySftpResponseInstance = new TpfRetrySftpResponse(
    success: success,
    message: message,
    newFileDeliveryId: newFileDeliveryId,
    retriedAt: retriedAt,
    originalFile: originalFile,
    duplicateFile: duplicateFile);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

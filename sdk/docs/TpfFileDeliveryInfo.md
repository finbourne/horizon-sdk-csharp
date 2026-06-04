# Finbourne.Horizon.Sdk.Model.TpfFileDeliveryInfo
Information about a file delivery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | File delivery ID | 
**FileName** | **string** | File name | 
**FileHash** | **string** | SHA-256 hash of the file content | 
**DestinationPath** | **string** | SFTP destination path | 
**Status** | **string** | Delivery status | 
**GeneratedAt** | **DateTimeOffset** | Timestamp when the file was originally generated | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string fileName = "fileName";
string fileHash = "fileHash";
string destinationPath = "destinationPath";
string status = "status";

TpfFileDeliveryInfo tpfFileDeliveryInfoInstance = new TpfFileDeliveryInfo(
    id: id,
    fileName: fileName,
    fileHash: fileHash,
    destinationPath: destinationPath,
    status: status,
    generatedAt: generatedAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

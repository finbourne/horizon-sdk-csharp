# Finbourne.Horizon.Sdk.Model.RunFileResponse
One delivery of a file to one destination within a run, keyed by FileUuid. A file sent to two destinations appears as two rows, so Destinations always holds exactly one element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **string** |  | 
**GeneratedAt** | **DateTimeOffset** | When the file was built, or when the attempt failed before a file was built. | 
**RowCount** | **int** |  | 
**FileHash** | **string** |  | 
**Encrypted** | **bool** |  | 
**Destinations** | [**List&lt;FileDestinationResponse&gt;**](FileDestinationResponse.md) |  | 
**TransactionIds** | **List&lt;string&gt;** |  | 
**FileUuid** | **Guid** |  | 
**FailedTransactionIds** | **List&lt;string&gt;** |  | 
**CanResend** | **bool** | Whether the data the file is rebuilt from is still retained, so a resend can be requested. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string fileName = "fileName";
string fileHash = "fileHash";
bool encrypted = //"True";
List<FileDestinationResponse> destinations = new List<FileDestinationResponse>();
List<string> transactionIds = new List<string>();
Guid fileUuid = "fileUuid";
List<string> failedTransactionIds = new List<string>();
bool canResend = //"True";

RunFileResponse runFileResponseInstance = new RunFileResponse(
    fileName: fileName,
    generatedAt: generatedAt,
    rowCount: rowCount,
    fileHash: fileHash,
    encrypted: encrypted,
    destinations: destinations,
    transactionIds: transactionIds,
    fileUuid: fileUuid,
    failedTransactionIds: failedTransactionIds,
    canResend: canResend);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

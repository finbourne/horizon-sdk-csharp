# Finbourne.Horizon.Sdk.Model.RunFileResponse
record containing details of a single file for a run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **string** |  | 
**GeneratedAt** | **DateTimeOffset** |  | 
**RowCount** | **int** |  | 
**FileHash** | **string** |  | 
**Encrypted** | **bool** |  | 
**Destinations** | [**List&lt;FileDestinationResponse&gt;**](FileDestinationResponse.md) |  | 
**TransactionIds** | **List&lt;Guid&gt;** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string fileName = "fileName";
string fileHash = "fileHash";
bool encrypted = //"True";
List<FileDestinationResponse> destinations = new List<FileDestinationResponse>();
List<Guid> transactionIds = new List<Guid>();

RunFileResponse runFileResponseInstance = new RunFileResponse(
    fileName: fileName,
    generatedAt: generatedAt,
    rowCount: rowCount,
    fileHash: fileHash,
    encrypted: encrypted,
    destinations: destinations,
    transactionIds: transactionIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

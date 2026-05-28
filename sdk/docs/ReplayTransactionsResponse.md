# Finbourne.Horizon.Sdk.Model.ReplayTransactionsResponse
Response from a replay transactions operation containing the CSV output.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchReferenceId** | **string** |  | 
**Mode** | **string** |  | 
**TransactionCount** | **int** |  | 
**CsvOutput** | **string** |  | 
**Message** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string batchReferenceId = "batchReferenceId";
string mode = "mode";
string csvOutput = "csvOutput";
string message = "message";

ReplayTransactionsResponse replayTransactionsResponseInstance = new ReplayTransactionsResponse(
    batchReferenceId: batchReferenceId,
    mode: mode,
    transactionCount: transactionCount,
    csvOutput: csvOutput,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

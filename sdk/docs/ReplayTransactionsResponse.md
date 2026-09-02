# Finbourne.Horizon.Sdk.Model.ReplayTransactionsResponse
Response from a replay transactions operation. For DryRun, Finbourne.Horizon.Integrations.Web.Dto.Integrations.TradePublicationFramework.Response.ReplayTransactionsResponse.PayloadOutput carries the preview payload in the instance's configured output format (CSV or XML); for Committed it is empty.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchReferenceId** | **string** |  | 
**Mode** | **string** |  | 
**TransactionCount** | **int** |  | 
**PayloadOutput** | **string** |  | 
**Message** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string batchReferenceId = "batchReferenceId";
string mode = "mode";
string payloadOutput = "payloadOutput";
string message = "message";

ReplayTransactionsResponse replayTransactionsResponseInstance = new ReplayTransactionsResponse(
    batchReferenceId: batchReferenceId,
    mode: mode,
    transactionCount: transactionCount,
    payloadOutput: payloadOutput,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

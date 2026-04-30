# Finbourne.Horizon.Sdk.Model.TpfTransactionSearchResponse
TPF send history record

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | Transaction identifier | 
**InstanceId** | **Guid** | Integration instance ID where the transaction was processed | 
**InstanceName** | **string** | Integration instance name | 
**BatchId** | **Guid** | Unique identifier of the batch | 
**RunStartTime** | **DateTimeOffset** | Timestamp when the batch/run started | 
**PublicationStatus** | **string** | Publication status of the transaction (Sent | Skipped | Failed) | 
**InstrumentName** | **string** | Instrument name | 
**InstrumentType** | **string** | Instrument type | 
**TradeDate** | **DateTimeOffset** | Trade date of the transaction | 
**SettlementDate** | **DateTimeOffset?** | Settlement date of the transaction | [optional] 
**SkipReason** | **string** | Reason the transaction was skipped (if applicable) | [optional] 
**FileName** | **string** | Output file associated with the publication run | [optional] 
**Destinations** | **List&lt;string&gt;** | Destinations to which the transaction was published | [optional] 
**PortfolioCode** | **string** | PortfolioCode showing portfolio code | [optional] 
**PortfolioScope** | **string** | PortfolioScope displaying portfolio scope | [optional] 
**FailureReason** | **string** | FailureReason to show failure reason | [optional] 
**InstrumentId** | **string** | InstrumentId showing instrument id of transaction | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string transactionId = "transactionId";
Guid instanceId = "instanceId";
string instanceName = "instanceName";
Guid batchId = "batchId";
string publicationStatus = "publicationStatus";
string instrumentName = "instrumentName";
string instrumentType = "instrumentType";
string skipReason = "example skipReason";
string fileName = "example fileName";
List<string> destinations = new List<string>();
string portfolioCode = "example portfolioCode";
string portfolioScope = "example portfolioScope";
string failureReason = "example failureReason";
string instrumentId = "example instrumentId";

TpfTransactionSearchResponse tpfTransactionSearchResponseInstance = new TpfTransactionSearchResponse(
    transactionId: transactionId,
    instanceId: instanceId,
    instanceName: instanceName,
    batchId: batchId,
    runStartTime: runStartTime,
    publicationStatus: publicationStatus,
    instrumentName: instrumentName,
    instrumentType: instrumentType,
    tradeDate: tradeDate,
    settlementDate: settlementDate,
    skipReason: skipReason,
    fileName: fileName,
    destinations: destinations,
    portfolioCode: portfolioCode,
    portfolioScope: portfolioScope,
    failureReason: failureReason,
    instrumentId: instrumentId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

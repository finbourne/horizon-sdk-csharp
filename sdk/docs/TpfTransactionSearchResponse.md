# Finbourne.Horizon.Sdk.Model.TpfTransactionSearchResponse
TPF send history record

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | Transaction identifier | 
**InstanceId** | **Guid** | Integration instance ID where the transaction was processed | 
**InstanceName** | **string** | Integration instance name | 
**BatchId** | **Guid** | Unique identifier of the batch | 
**RunId** | **Guid** | The run that processed the transaction for this instance, as shown in run monitoring | 
**RunStartTime** | **DateTimeOffset** | Timestamp when the batch/run started | 
**PublicationStatus** | **string** | Outcome of the transaction&#39;s build (Sent | Skipped | Failed) | 
**Outcome** | **string** | The same value as PublicationStatus under the name the screens use; PublicationStatus stays for existing clients. | 
**EventType** | **string** | The TPF event type that triggered this publication (New, Amended, Cancelled, NothingToDo, InstrumentMatured, InstrumentPartialClosure, InstrumentFullClosure, InstrumentInterestPayment, LastSentPropertyUpdated). Null for rows persisted before it was recorded, for transactions skipped as excluded, and for rows written before the build computed it (for example a transaction not found in LUSID). Never Queued: the search returns built rows only. Distinct from PublicationStatus, which says what happened to the row. | [optional] 
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
**FailureStage** | **string** | Stage at which a failed transaction failed: Build or Delivery | [optional] 
**SentAt** | **DateTimeOffset?** | When the transaction was sent, which is when its file reached a destination. Empty for Skipped and Failed rows | [optional] 
**InstrumentId** | **string** | InstrumentId showing instrument id of transaction | [optional] 
**InstrumentScope** | **string** | The scope the build resolved the instrument in; null for rows built before it was recorded | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string transactionId = "transactionId";
Guid instanceId = "instanceId";
string instanceName = "instanceName";
Guid batchId = "batchId";
Guid runId = "runId";
string publicationStatus = "publicationStatus";
string outcome = "outcome";
string eventType = "example eventType";
string instrumentName = "instrumentName";
string instrumentType = "instrumentType";
string skipReason = "example skipReason";
string fileName = "example fileName";
List<string> destinations = new List<string>();
string portfolioCode = "example portfolioCode";
string portfolioScope = "example portfolioScope";
string failureReason = "example failureReason";
string failureStage = "example failureStage";
string instrumentId = "example instrumentId";
string instrumentScope = "example instrumentScope";

TpfTransactionSearchResponse tpfTransactionSearchResponseInstance = new TpfTransactionSearchResponse(
    transactionId: transactionId,
    instanceId: instanceId,
    instanceName: instanceName,
    batchId: batchId,
    runId: runId,
    runStartTime: runStartTime,
    publicationStatus: publicationStatus,
    outcome: outcome,
    eventType: eventType,
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
    failureStage: failureStage,
    sentAt: sentAt,
    instrumentId: instrumentId,
    instrumentScope: instrumentScope);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

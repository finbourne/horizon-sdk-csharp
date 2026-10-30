# Finbourne.Horizon.Sdk.Model.TransactionResponse
Response containing details of a single transaction for a run. A transaction built twice in one batch appears once per build. FailureStage says whether a failed transaction failed while being built (Build) or while its file was being delivered (Delivery).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** |  | 
**PublicationStatus** | **string** | The outcome the screens show for this row: Sent, Skipped or Failed. | 
**PortfolioScope** | **string** |  | [optional] 
**PortfolioCode** | **string** |  | [optional] 
**InstrumentId** | **string** |  | [optional] 
**InstrumentType** | **string** |  | [optional] 
**InstrumentName** | **string** |  | [optional] 
**TradeDate** | **DateTimeOffset?** |  | [optional] 
**SettlementDate** | **DateTimeOffset?** |  | [optional] 
**Status** | **string** | The batch element&#39;s processing state as the worker left it, not the outcome; read PublicationStatus for that. | 
**SkipReason** | **string** |  | [optional] 
**FailureReason** | **string** |  | [optional] 
**OutputFileName** | **string** |  | [optional] 
**SentAt** | **DateTimeOffset?** |  | [optional] 
**Destinations** | [**List&lt;DestinationResponse&gt;**](DestinationResponse.md) |  | 
**FailureStage** | **string** |  | [optional] 
**InstrumentScope** | **string** | The scope the build resolved the instrument in; null for rows built before it was recorded. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string transactionId = "transactionId";
string publicationStatus = "publicationStatus";
string portfolioScope = "example portfolioScope";
string portfolioCode = "example portfolioCode";
string instrumentId = "example instrumentId";
string instrumentType = "example instrumentType";
string instrumentName = "example instrumentName";
string status = "status";
string skipReason = "example skipReason";
string failureReason = "example failureReason";
string outputFileName = "example outputFileName";
List<DestinationResponse> destinations = new List<DestinationResponse>();
string failureStage = "example failureStage";
string instrumentScope = "example instrumentScope";

TransactionResponse transactionResponseInstance = new TransactionResponse(
    transactionId: transactionId,
    publicationStatus: publicationStatus,
    portfolioScope: portfolioScope,
    portfolioCode: portfolioCode,
    instrumentId: instrumentId,
    instrumentType: instrumentType,
    instrumentName: instrumentName,
    tradeDate: tradeDate,
    settlementDate: settlementDate,
    status: status,
    skipReason: skipReason,
    failureReason: failureReason,
    outputFileName: outputFileName,
    sentAt: sentAt,
    destinations: destinations,
    failureStage: failureStage,
    instrumentScope: instrumentScope);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

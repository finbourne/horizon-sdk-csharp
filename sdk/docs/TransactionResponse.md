# Finbourne.Horizon.Sdk.Model.TransactionResponse
Response containing details of a single transaction for a run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** |  | 
**PublicationStatus** | **string** |  | 
**PortfolioScope** | **string** |  | [optional] 
**PortfolioCode** | **string** |  | [optional] 
**InstrumentId** | **string** |  | [optional] 
**InstrumentType** | **string** |  | [optional] 
**InstrumentName** | **string** |  | [optional] 
**TradeDate** | **DateTimeOffset?** |  | [optional] 
**SettlementDate** | **DateTimeOffset?** |  | [optional] 
**Status** | **string** |  | 
**SkipReason** | **string** |  | [optional] 
**FailureReason** | **string** |  | [optional] 
**OutputFileName** | **string** |  | [optional] 
**SentAt** | **DateTimeOffset?** |  | [optional] 
**Destinations** | [**List&lt;DestinationResponse&gt;**](DestinationResponse.md) |  | 

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
    destinations: destinations);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

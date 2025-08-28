# Finbourne.Horizon.Sdk.Model.PermIdData
PermId Data Structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Figi** | **string** | &gt;FIGI assigned to the instrument. | 
**Ticker** | **string** | Ticker assigned to the instrument | 
**Mic** | **string** | ISO market identification code(MIC) of the desired instrument(s) | 
**QuotePermId** | **string** | QuotePermId of the instrument | 
**IsPrimaryQuote** | **bool** | If the quote is primary | 
**LegalEntityIdentifier** | **string** | LEI assigned to the instrument | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string figi = "figi";
string ticker = "ticker";
string mic = "mic";
string quotePermId = "quotePermId";
bool isPrimaryQuote = //"True";
string legalEntityIdentifier = "example legalEntityIdentifier";

PermIdData permIdDataInstance = new PermIdData(
    figi: figi,
    ticker: ticker,
    mic: mic,
    quotePermId: quotePermId,
    isPrimaryQuote: isPrimaryQuote,
    legalEntityIdentifier: legalEntityIdentifier);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

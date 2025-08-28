# Finbourne.Horizon.Sdk.Model.OpenFigiData
OpenFIGI data structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Figi** | **string** | FIGI assigned to the instrument. | 
**Name** | **string** | Various attributes of the instrument | [optional] 
**Ticker** | **string** | Various attributes of the instrument | [optional] 
**ExchangeCode** | **string** | Exchange code of the desired instrument(s) | [optional] 
**Mic** | **string** | ISO market identification code(MIC) of the desired instrument(s) | [optional] 
**ExchangeName** | **string** | Exchange name of the desired instrument(s) | [optional] 
**MarketSector** | **string** | Market sector description of the desired instrument(s) | [optional] 
**GeneralSecurityType** | **string** | Enum-like attributes of the instrument | [optional] 
**SecurityType** | **string** | Enum-like attributes of the instrument | [optional] 
**SecurityDescription** | **string** | Various attributes of the instrument | [optional] 
**CompositeFigi** | **string** | Various attributes of the instrument | [optional] 
**ShareClassFigi** | **string** | Various attributes of the instrument | [optional] 
**MatchType** | **string** | Type that the instrument matched against | [optional] 
**SearchInput** | **string** | Search input used to generate this response | [optional] 
**LusidInstrumentId** | **string** | If an instrument with this FIGI exists, the LUID of that instrument in LUSID | [optional] 
**LusidInstrumentScope** | **string** | If an instrument with this FIGI exists, the Scope of that instrument in LUSID | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string figi = "figi";
string name = "example name";
string ticker = "example ticker";
string exchangeCode = "example exchangeCode";
string mic = "example mic";
string exchangeName = "example exchangeName";
string marketSector = "example marketSector";
string generalSecurityType = "example generalSecurityType";
string securityType = "example securityType";
string securityDescription = "example securityDescription";
string compositeFigi = "example compositeFigi";
string shareClassFigi = "example shareClassFigi";
string matchType = "example matchType";
string searchInput = "example searchInput";
string lusidInstrumentId = "example lusidInstrumentId";
string lusidInstrumentScope = "example lusidInstrumentScope";

OpenFigiData openFigiDataInstance = new OpenFigiData(
    figi: figi,
    name: name,
    ticker: ticker,
    exchangeCode: exchangeCode,
    mic: mic,
    exchangeName: exchangeName,
    marketSector: marketSector,
    generalSecurityType: generalSecurityType,
    securityType: securityType,
    securityDescription: securityDescription,
    compositeFigi: compositeFigi,
    shareClassFigi: shareClassFigi,
    matchType: matchType,
    searchInput: searchInput,
    lusidInstrumentId: lusidInstrumentId,
    lusidInstrumentScope: lusidInstrumentScope);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

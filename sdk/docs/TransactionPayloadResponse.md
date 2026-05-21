# Finbourne.Horizon.Sdk.Model.TransactionPayloadResponse
record containing details of a transaction payload.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Columns** | **List&lt;string&gt;** |  | 
**Values** | **Dictionary&lt;string, string&gt;** |  | 
**RawCsvRow** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<string> columns = new List<string>();
Dictionary<string, string> values = new Dictionary<string, string>();
string rawCsvRow = "rawCsvRow";

TransactionPayloadResponse transactionPayloadResponseInstance = new TransactionPayloadResponse(
    columns: columns,
    values: values,
    rawCsvRow: rawCsvRow);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

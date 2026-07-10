# Finbourne.Horizon.Sdk.Model.TransactionPayload
record containing the payload for a single transaction. Columns is compiled once from the TPF instance configuration and is identical across every item in the paginated result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** |  | 
**Columns** | **List&lt;string&gt;** |  | 
**Values** | **Dictionary&lt;string, string&gt;** |  | 
**RawCsvRow** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string transactionId = "transactionId";
List<string> columns = new List<string>();
Dictionary<string, string> values = new Dictionary<string, string>();
string rawCsvRow = "rawCsvRow";

TransactionPayload transactionPayloadInstance = new TransactionPayload(
    transactionId: transactionId,
    columns: columns,
    values: values,
    rawCsvRow: rawCsvRow);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Horizon.Sdk.Model.RowDetails
Information about the nuber of rows processed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RowsTotal** | **int?** | The number of rows processed. | [optional] 
**RowsSucceeded** | **int?** | The number of rows that were successfully processed. | [optional] 
**RowsIgnored** | **int?** | The number of rows that were not processed. | [optional] 
**RowsFailed** | **int?** | The number of rows that failed when being processed. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;


RowDetails rowDetailsInstance = new RowDetails(
    rowsTotal: rowsTotal,
    rowsSucceeded: rowsSucceeded,
    rowsIgnored: rowsIgnored,
    rowsFailed: rowsFailed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

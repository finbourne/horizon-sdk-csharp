# Finbourne.Horizon.Sdk.Model.ProcessSummary
Completed event details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndTime** | **DateTimeOffset?** |  | [optional] 
**Category** | **string** |  | [optional] 
**Status** | **string** |  | 
**Message** | **string** |  | 
**Rows** | [**RowDetails**](RowDetails.md) |  | 
**FileDetails** | [**List&lt;FileDetails&gt;**](FileDetails.md) |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string category = "example category";
string status = "status";
string message = "message";
RowDetails rows = new RowDetails();
List<FileDetails> fileDetails = new List<FileDetails>();

ProcessSummary processSummaryInstance = new ProcessSummary(
    endTime: endTime,
    category: category,
    status: status,
    message: message,
    rows: rows,
    fileDetails: fileDetails);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

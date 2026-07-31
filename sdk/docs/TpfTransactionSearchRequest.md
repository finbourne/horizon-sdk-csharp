# Finbourne.Horizon.Sdk.Model.TpfTransactionSearchRequest
Request body for the POST transaction-search endpoint. Multiple values in TransactionIds and InstrumentIdentifiers are OR'd within each filter; both filters together are AND'd.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionIds** | **List&lt;string&gt;** | One or more LUSID transaction IDs to search for (max 50). Values are OR&#39;d. | [optional] 
**InstrumentIdentifiers** | **List&lt;string&gt;** | One or more instrument identifiers in any supported format (ISIN, CUSIP, LUID, etc.) to search for (max 50). Values are OR&#39;d. | [optional] 
**InstanceId** | **string** | Instance ID to filter by. Omit or leave null to search all instances the caller has access to. | [optional] 
**From** | **DateTimeOffset?** | Start of the date range (inclusive). Defaults to 30 days ago if neither From nor To is provided. | [optional] 
**To** | **DateTimeOffset?** | End of the date range (inclusive). Defaults to now if not provided. | [optional] 
**Limit** | **int?** | Maximum number of results to return per page. | [optional] 
**Page** | **string** | Pagination token from a previous response NextPage or PreviousPage. Omit for the first page. | [optional] 
**Status** | **string** | Publication status to filter by. Valid values: Sent, Skipped, Failed. Optional. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<string> transactionIds = new List<string>();
List<string> instrumentIdentifiers = new List<string>();
string instanceId = "example instanceId";
string page = "example page";
string status = "example status";

TpfTransactionSearchRequest tpfTransactionSearchRequestInstance = new TpfTransactionSearchRequest(
    transactionIds: transactionIds,
    instrumentIdentifiers: instrumentIdentifiers,
    instanceId: instanceId,
    from: from,
    to: to,
    limit: limit,
    page: page,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

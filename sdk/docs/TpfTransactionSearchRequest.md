# Finbourne.Horizon.Sdk.Model.TpfTransactionSearchRequest
Request body for the POST transaction-search endpoint. Multiple values in TransactionIds and InstrumentIdentifiers are OR'd within each filter; both filters together are AND'd.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionIds** | **List&lt;string&gt;** | One or more LUSID transaction IDs to search for (max 50). Values are OR&#39;d. | [optional] 
**InstrumentIdentifiers** | **List&lt;string&gt;** | One or more instrument identifiers to search for (max 50). Values are OR&#39;d. Accepts LusidInstrumentId, Isin, Figi, Ticker, Cusip, Sedol or ClientInternal values. Every value is matched exactly against the stored instrument id; non-LUID values are also resolved against LUSID instruments in the default scope, whose own matching rules (including case) apply. | [optional] 
**InstanceId** | **string** | Instance ID to filter by. Omit or leave null to search all instances the caller has access to. | [optional] 
**From** | **DateTimeOffset?** | Start of the date range (inclusive). Defaults to 30 days ago if neither From nor To is provided. | [optional] 
**To** | **DateTimeOffset?** | End of the date range (inclusive). Defaults to now if not provided. | [optional] 
**Limit** | **int?** | Maximum number of results to return per page. | [optional] 
**Page** | **string** | Pagination token from a previous response NextPage or PreviousPage. Omit for the first page. | [optional] 
**Status** | **string** | Publication status to filter by. Valid values: Sent, Skipped, Failed. Optional. | [optional] 
**Filter** | **string** | Filter expression to apply to the results, in the format \&quot;property operator value\&quot; (e.g., eq, ne, gt, lt), combined with \&quot;and\&quot;/\&quot;or\&quot; as needed. Filterable properties are transactionId, instanceName, runStartTime, instrumentName, instrumentType, instrumentId, tradeDate, settlementDate, skipReason, failureReason, fileName, portfolioScope, portfolioCode, and runId. PublicationStatus is not filterable here — use the Status body parameter instead. Dates are quoted ISO-8601. Destinations is not filterable. Must remain the same across pages — the page token includes a hash of both filter and sortBy. | [optional] 
**SortBy** | **List&lt;string&gt;** | Up to two sortable fields, each optionally suffixed \&quot; ASC\&quot; or \&quot; DESC\&quot;. Deterministic tiebreakers are appended automatically: RunStartTime DESC, TransactionId ASC, BatchUuid ASC, FileName ASC. Must remain the same across pages — the page token includes a hash of both filter and sortBy. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<string> transactionIds = new List<string>();
List<string> instrumentIdentifiers = new List<string>();
string instanceId = "example instanceId";
string page = "example page";
string status = "example status";
string filter = "example filter";
List<string> sortBy = new List<string>();

TpfTransactionSearchRequest tpfTransactionSearchRequestInstance = new TpfTransactionSearchRequest(
    transactionIds: transactionIds,
    instrumentIdentifiers: instrumentIdentifiers,
    instanceId: instanceId,
    from: from,
    to: to,
    limit: limit,
    page: page,
    status: status,
    filter: filter,
    sortBy: sortBy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

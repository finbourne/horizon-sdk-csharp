# Finbourne.Horizon.Sdk.Model.PagedResourceListOfTransactionPayload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Values** | [**List&lt;TransactionPayload&gt;**](TransactionPayload.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<TransactionPayload> values = new List<TransactionPayload>();
string href = "example href";
List<Link> links = new List<Link>();

PagedResourceListOfTransactionPayload pagedResourceListOfTransactionPayloadInstance = new PagedResourceListOfTransactionPayload(
    nextPage: nextPage,
    previousPage: previousPage,
    values: values,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

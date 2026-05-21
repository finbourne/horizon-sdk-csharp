# Finbourne.Horizon.Sdk.Model.PagedResourceListOfTransactionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Values** | [**List&lt;TransactionResponse&gt;**](TransactionResponse.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<TransactionResponse> values = new List<TransactionResponse>();
string href = "example href";
List<Link> links = new List<Link>();

PagedResourceListOfTransactionResponse pagedResourceListOfTransactionResponseInstance = new PagedResourceListOfTransactionResponse(
    nextPage: nextPage,
    previousPage: previousPage,
    values: values,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

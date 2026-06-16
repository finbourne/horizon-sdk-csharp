# Finbourne.Horizon.Sdk.Model.PagedResourceListOfFailedDeliveryResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Values** | [**List&lt;FailedDeliveryResponse&gt;**](FailedDeliveryResponse.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<FailedDeliveryResponse> values = new List<FailedDeliveryResponse>();
string href = "example href";
List<Link> links = new List<Link>();

PagedResourceListOfFailedDeliveryResponse pagedResourceListOfFailedDeliveryResponseInstance = new PagedResourceListOfFailedDeliveryResponse(
    nextPage: nextPage,
    previousPage: previousPage,
    values: values,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

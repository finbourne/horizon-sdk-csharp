# Finbourne.Horizon.Sdk.Model.OnboardInstrumentResponse
Simplified structure converted from the LUSID UpsertInstrumentReponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | **List&lt;string&gt;** | The instruments which have been successfully updated or created. | 
**Failed** | **Dictionary&lt;string, string&gt;** | The instruments that could not be updated or created or were left unchanged without error along with a reason for their failure. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string href = "example href";
List<string> values = new List<string>();
Dictionary<string, string> failed = new Dictionary<string, string>();

OnboardInstrumentResponse onboardInstrumentResponseInstance = new OnboardInstrumentResponse(
    href: href,
    values: values,
    failed: failed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

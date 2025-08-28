# Finbourne.Horizon.Sdk.Model.EnrichmentResponse
Collated enrichment result information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnrichedInstruments** | **List&lt;string&gt;** |  | 
**IgnoredInstruments** | **List&lt;string&gt;** |  | 
**ErrorFileId** | **string** | Error File ID, if one was created | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<string> enrichedInstruments = new List<string>();
List<string> ignoredInstruments = new List<string>();
string errorFileId = "example errorFileId";

EnrichmentResponse enrichmentResponseInstance = new EnrichmentResponse(
    enrichedInstruments: enrichedInstruments,
    ignoredInstruments: ignoredInstruments,
    errorFileId: errorFileId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

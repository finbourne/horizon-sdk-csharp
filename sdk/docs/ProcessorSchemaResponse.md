# Finbourne.Horizon.Sdk.Model.ProcessorSchemaResponse
DTO ProcessorSchemaResponse fields with JObject

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessorName** | **string** |  | 
**VarVersion** | **string** |  | 
**ConfigurationSchema** | **Object** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string processorName = "processorName";
string varVersion = "varVersion";

ProcessorSchemaResponse processorSchemaResponseInstance = new ProcessorSchemaResponse(
    processorName: processorName,
    varVersion: varVersion,
    configurationSchema: configurationSchema);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

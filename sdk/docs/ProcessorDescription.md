# Finbourne.Horizon.Sdk.Model.ProcessorDescription
Represents a processor in the Horizon integration system.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**Category** | **string** |  | 
**IsActive** | **bool** |  | 
**IsConnectionRequired** | **bool** |  | 
**Relationships** | **List&lt;string&gt;** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string name = "name";
string displayName = "displayName";
string description = "description";
string category = "category";
bool isActive = //"True";
bool isConnectionRequired = //"True";
List<string> relationships = new List<string>();

ProcessorDescription processorDescriptionInstance = new ProcessorDescription(
    name: name,
    displayName: displayName,
    description: description,
    category: category,
    isActive: isActive,
    isConnectionRequired: isConnectionRequired,
    relationships: relationships);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

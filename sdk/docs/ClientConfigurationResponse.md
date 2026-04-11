# Finbourne.Horizon.Sdk.Model.ClientConfigurationResponse
Represents a versioned client configuration record.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The logical name of the configuration. | 
**ConfigType** | **string** | The category of configuration. | 
**MajorVersion** | **int** | The major version number. | 
**MinorVersion** | **int** | The minor version number. | 
**Value** | **string** | The JSON configuration value. | 
**IsDraft** | **bool** | Whether this version is still in draft state. Draft versions can be edited; locked versions cannot. | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string name = "name";
string configType = "configType";
string value = "value";
bool isDraft = //"True";

ClientConfigurationResponse clientConfigurationResponseInstance = new ClientConfigurationResponse(
    name: name,
    configType: configType,
    majorVersion: majorVersion,
    minorVersion: minorVersion,
    value: value,
    isDraft: isDraft);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

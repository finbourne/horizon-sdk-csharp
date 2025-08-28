# Finbourne.Horizon.Sdk.Model.FileDetails
Information associated with files

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **string** |  | 
**FileType** | **string** |  | [optional] 
**Id** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string fileName = "fileName";
string fileType = "example fileType";
string id = "id";

FileDetails fileDetailsInstance = new FileDetails(
    fileName: fileName,
    fileType: fileType,
    id: id);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

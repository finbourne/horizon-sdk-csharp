# Finbourne.Horizon.Sdk.Model.AuditFileDetails
Holds information about Horizon Audit Files

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileType** | **AuditFileType** |  | 
**FilePathAndName** | **string** | The file path and name | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string filePathAndName = "filePathAndName";

AuditFileDetails auditFileDetailsInstance = new AuditFileDetails(
    fileType: fileType,
    filePathAndName: filePathAndName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

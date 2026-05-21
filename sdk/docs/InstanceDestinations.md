# Finbourne.Horizon.Sdk.Model.InstanceDestinations
record containing details of the destinations for an instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinationType** | **string** |  | 
**Name** | **string** |  | 
**DestinationPath** | **string** |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string destinationType = "destinationType";
string name = "name";
string destinationPath = "destinationPath";

InstanceDestinations instanceDestinationsInstance = new InstanceDestinations(
    destinationType: destinationType,
    name: name,
    destinationPath: destinationPath);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

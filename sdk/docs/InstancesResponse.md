# Finbourne.Horizon.Sdk.Model.InstancesResponse
record containing a list of instances.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Instances** | [**List&lt;InstanceResponse&gt;**](InstanceResponse.md) |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<InstanceResponse> instances = new List<InstanceResponse>();

InstancesResponse instancesResponseInstance = new InstancesResponse(
    instances: instances);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

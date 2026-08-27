# Finbourne.Horizon.Sdk.Model.LatestRunsResponse
record containing the 24-hour run summary grouped by external status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **int** |  | 
**StatusCounts** | [**List&lt;RunStatusCount&gt;**](RunStatusCount.md) |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

List<RunStatusCount> statusCounts = new List<RunStatusCount>();

LatestRunsResponse latestRunsResponseInstance = new LatestRunsResponse(
    total: total,
    statusCounts: statusCounts);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

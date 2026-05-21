# Finbourne.Horizon.Sdk.Model.InstanceResponse
record containing details of a single instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**Name** | **string** |  | 
**Enabled** | **bool** |  | 
**Portfolios** | [**List&lt;TpfPortfolio&gt;**](TpfPortfolio.md) |  | 
**Schedule** | **string** |  | [optional] 
**ScheduleTimezone** | **string** |  | [optional] 
**LastRunAt** | **DateTimeOffset?** |  | [optional] 
**LastRunStatus** | **string** |  | [optional] 
**LatestRunsIn24Hours** | **string** |  | [optional] 
**Destinations** | [**List&lt;InstanceDestinations&gt;**](InstanceDestinations.md) |  | 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

Guid id = "id";
string name = "name";
bool enabled = //"True";
List<TpfPortfolio> portfolios = new List<TpfPortfolio>();
string schedule = "example schedule";
string scheduleTimezone = "example scheduleTimezone";
string lastRunStatus = "example lastRunStatus";
string latestRunsIn24Hours = "example latestRunsIn24Hours";
List<InstanceDestinations> destinations = new List<InstanceDestinations>();

InstanceResponse instanceResponseInstance = new InstanceResponse(
    id: id,
    name: name,
    enabled: enabled,
    portfolios: portfolios,
    schedule: schedule,
    scheduleTimezone: scheduleTimezone,
    lastRunAt: lastRunAt,
    lastRunStatus: lastRunStatus,
    latestRunsIn24Hours: latestRunsIn24Hours,
    destinations: destinations);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

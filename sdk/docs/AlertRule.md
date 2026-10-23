# Finbourne.Horizon.Sdk.Model.AlertRule
An alert rule on an integration instance. Finbourne.Horizon.Integrations.Web.Dto.AlertRule.Type selects the rule and decides which of the optional fields apply. A field that does not belong to the selected type is rejected.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The rule type (Allowed: MustStartBy, MaxDuration, FailedAfterRetries) | 
**Severity** | **string** | The severity alerts from this rule are raised at (Allowed: Critical, High, Medium, Low, Informational). Critical pages on-call for a client-facing outage. High needs action today. Medium is a missed or late run. Low is an overrun or record-count check. Informational never pages. Defaults per type when omitted: MustStartBy and FailedAfterRetries Medium, MaxDuration Low. | [optional] 
**TimeOfDay** | **string** | MustStartBy only. The local time of day, as HH:mm, by which a run must have started. | [optional] 
**VarTimeZone** | **string** | MustStartBy only. The IANA or Windows time zone id that TimeOfDay is expressed in. | [optional] 
**DaysOfWeek** | **List&lt;string&gt;** | MustStartBy only. The days the rule applies on, by name (e.g. Monday). Every day when omitted. | [optional] 
**GraceMinutes** | **int?** | MustStartBy only. Minutes after TimeOfDay before a missing run counts as a breach. 0 when omitted. | [optional] 
**MaxMinutes** | **int?** | MaxDuration only. Alert once a run has been running for longer than this many minutes. Minimum 10. | [optional] 
**IncludePaused** | **bool?** | MaxDuration only. Also measure paused runs. False when omitted. | [optional] 
**AlertOnFirstFailure** | **bool?** | FailedAfterRetries only. Also alert on the first failure of a retry chain, not only when the retries are exhausted. False when omitted. | [optional] 

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string type = "type";
string severity = "example severity";
string timeOfDay = "example timeOfDay";
string varTimeZone = "example varTimeZone";
List<string> daysOfWeek = new List<string>();
bool? includePaused = //"True";
bool? alertOnFirstFailure = //"True";

AlertRule alertRuleInstance = new AlertRule(
    type: type,
    severity: severity,
    timeOfDay: timeOfDay,
    varTimeZone: varTimeZone,
    daysOfWeek: daysOfWeek,
    graceMinutes: graceMinutes,
    maxMinutes: maxMinutes,
    includePaused: includePaused,
    alertOnFirstFailure: alertOnFirstFailure);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

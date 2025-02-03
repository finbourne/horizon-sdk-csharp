# Finbourne.Horizon.Sdk.Model.IIntegrationLogResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LogId** | **long** |  | [readonly] 
**RunId** | **Guid?** |  | [optional] [readonly] 
**ParentLogId** | **long?** |  | [optional] [readonly] 
**LogType** | **string** |  | [readonly] 
**FirstActivity** | **DateTimeOffset?** |  | [optional] [readonly] 
**LastActivity** | **DateTimeOffset?** |  | [optional] [readonly] 
**Status** | **string** |  | [optional] [readonly] 
**SourceRecord** | [**IntegrationLogRecord**](IntegrationLogRecord.md) |  | [optional] 
**TargetRecord** | [**IntegrationLogTargetRecord**](IntegrationLogTargetRecord.md) |  | [optional] 
**Activities** | [**List&lt;IntegrationLogActivity&gt;**](IntegrationLogActivity.md) |  | [readonly] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)


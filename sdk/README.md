<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*InstrumentApi* | [**CreateInstrument**](docs/InstrumentApi.md#createinstrument) | **POST** /api/instrument/onboarding/create | [EARLY ACCESS] CreateInstrument: Creates and masters instruments with third party vendors.
*InstrumentApi* | [**EnrichInstrument**](docs/InstrumentApi.md#enrichinstrument) | **POST** /api/instrument/onboarding/enrich | [EARLY ACCESS] EnrichInstrument: Enriches an existing LUSID instrument using vendor data. Enrichment included identifiers, properties and market data.
*InstrumentApi* | [**GetOpenFigiParameterOption**](docs/InstrumentApi.md#getopenfigiparameteroption) | **GET** /api/instrument/onboarding/search/openfigi/parameterOptions | [EARLY ACCESS] GetOpenFigiParameterOption: Get all supported market sector values for OpenFigi search
*InstrumentApi* | [**RetrievePermIdResult**](docs/InstrumentApi.md#retrievepermidresult) | **GET** /api/instrument/onboarding/search/permid/{id} | [EARLY ACCESS] RetrievePermIdResult: Retrieve PermId results from a previous query.
*InstrumentApi* | [**SearchOpenFigi**](docs/InstrumentApi.md#searchopenfigi) | **GET** /api/instrument/onboarding/search/openfigi | [EARLY ACCESS] SearchOpenFigi: Search OpenFigi for instruments that match the specified terms.
*InstrumentApi* | [**Vendors**](docs/InstrumentApi.md#vendors) | **GET** /api/instrument/onboarding/vendors | [EARLY ACCESS] Vendors: Gets the VendorProducts of any supported and licenced integrations for a given market sector and security type.
*IntegrationsApi* | [**CreateInstance**](docs/IntegrationsApi.md#createinstance) | **POST** /api/integrations/instances | [EXPERIMENTAL] CreateInstance: Create a single integration instance.
*IntegrationsApi* | [**DeleteInstance**](docs/IntegrationsApi.md#deleteinstance) | **DELETE** /api/integrations/instances/{instanceId} | [EXPERIMENTAL] DeleteInstance: Delete a single integration instance.
*IntegrationsApi* | [**ExecuteInstance**](docs/IntegrationsApi.md#executeinstance) | **POST** /api/integrations/instances/{instanceId}/execute | [EXPERIMENTAL] ExecuteInstance: Execute an integration instance.
*IntegrationsApi* | [**ExecuteInstanceWithParams**](docs/IntegrationsApi.md#executeinstancewithparams) | **POST** /api/integrations/instances/{instanceId}/executewithparams | [EXPERIMENTAL] ExecuteInstanceWithParams: Execute an integration instance with runtime parameters
*IntegrationsApi* | [**GetDataflowProcessorSchema**](docs/IntegrationsApi.md#getdataflowprocessorschema) | **GET** /api/integrations/dataflow/processors/{processorType}/schema | [EXPERIMENTAL] GetDataflowProcessorSchema: Returns processor configuration schema for a given processor type. This is used by the UI to render the configuration form for a processortype.
*IntegrationsApi* | [**GetExecutionIdsForInstance**](docs/IntegrationsApi.md#getexecutionidsforinstance) | **GET** /api/integrations/instances/{instanceId}/executions | [EXPERIMENTAL] GetExecutionIdsForInstance: Get integration instance execution ids.
*IntegrationsApi* | [**GetInstance**](docs/IntegrationsApi.md#getinstance) | **GET** /api/integrations/instances/{instanceId} | [EXPERIMENTAL] GetInstance: Get a specified instance for a given integration.
*IntegrationsApi* | [**GetInstanceOptionalPropertyMapping**](docs/IntegrationsApi.md#getinstanceoptionalpropertymapping) | **GET** /api/integrations/instances/configuration/{integration}/{instanceId} | [EXPERIMENTAL] GetInstanceOptionalPropertyMapping: Get the Optional Property Mapping for an integration instance
*IntegrationsApi* | [**GetIntegrationConfiguration**](docs/IntegrationsApi.md#getintegrationconfiguration) | **GET** /api/integrations/configuration/{integration} | [EXPERIMENTAL] GetIntegrationConfiguration: Get the Field and Property Mapping configuration for a given integration
*IntegrationsApi* | [**GetIntegrationConfigurationFields**](docs/IntegrationsApi.md#getintegrationconfigurationfields) | **GET** /api/integrations/configuration/{integration}/fields | [EXPERIMENTAL] GetIntegrationConfigurationFields: Get the Field Mapping configuration for a given integration
*IntegrationsApi* | [**GetIntegrationConfigurationProperties**](docs/IntegrationsApi.md#getintegrationconfigurationproperties) | **GET** /api/integrations/configuration/{integration}/properties | [EXPERIMENTAL] GetIntegrationConfigurationProperties: Get the Property Mapping configuration for a given integration
*IntegrationsApi* | [**GetSchema**](docs/IntegrationsApi.md#getschema) | **GET** /api/integrations/schema/{integration} | [EXPERIMENTAL] GetSchema: Get the JSON schema for the details section of an integration instance.
*IntegrationsApi* | [**ListDataflowProcessors**](docs/IntegrationsApi.md#listdataflowprocessors) | **GET** /api/integrations/dataflow/processors | [EXPERIMENTAL] ListDataflowProcessors: List processor types.
*IntegrationsApi* | [**ListInstances**](docs/IntegrationsApi.md#listinstances) | **GET** /api/integrations/instances | [EXPERIMENTAL] ListInstances: List instances across all integrations.
*IntegrationsApi* | [**ListIntegrations**](docs/IntegrationsApi.md#listintegrations) | **GET** /api/integrations | [EXPERIMENTAL] ListIntegrations: List available integrations.
*IntegrationsApi* | [**SetInstanceOptionalPropertyMapping**](docs/IntegrationsApi.md#setinstanceoptionalpropertymapping) | **PUT** /api/integrations/instances/configuration/{integration}/{instanceId} | [EXPERIMENTAL] SetInstanceOptionalPropertyMapping: Set the Optional Property Mapping for an integration instance
*IntegrationsApi* | [**UpdateInstance**](docs/IntegrationsApi.md#updateinstance) | **PUT** /api/integrations/instances/{instanceId} | [EXPERIMENTAL] UpdateInstance: Update a single integration instance.
*LogsApi* | [**GetIntegrationLogResults**](docs/LogsApi.md#getintegrationlogresults) | **GET** /api/logs | [EXPERIMENTAL] GetIntegrationLogResults: Get integration log results
*LogsApi* | [**InsertExternalLogs**](docs/LogsApi.md#insertexternallogs) | **POST** /api/logs/{instanceid}/{runid} | [EXPERIMENTAL] InsertExternalLogs: Inserts external logs into the specified ExternalApp Integration instance execution
*ProcessHistoryApi* | [**CreateCompleteEvent**](docs/ProcessHistoryApi.md#createcompleteevent) | **POST** /api/process-history/event/complete | [EARLY ACCESS] CreateCompleteEvent: Write a completed event to the Horizon Dashboard
*ProcessHistoryApi* | [**CreateUpdateEvent**](docs/ProcessHistoryApi.md#createupdateevent) | **POST** /api/process-history/event/update | [EARLY ACCESS] CreateUpdateEvent: Write an update event to the Horizon Dashboard
*ProcessHistoryApi* | [**GetLatestRuns**](docs/ProcessHistoryApi.md#getlatestruns) | **GET** /api/process-history/$latestRuns | [EARLY ACCESS] GetLatestRuns: Get latest run for each process
*ProcessHistoryApi* | [**ProcessEntryUpdates**](docs/ProcessHistoryApi.md#processentryupdates) | **POST** /api/process-history/entries/$query | [EARLY ACCESS] ProcessEntryUpdates: Get process entry updates for a query
*ProcessHistoryApi* | [**ProcessHistoryEntries**](docs/ProcessHistoryApi.md#processhistoryentries) | **POST** /api/process-history/$query | [EARLY ACCESS] ProcessHistoryEntries: Get process history entries
*RunsApi* | [**CancelInstance**](docs/RunsApi.md#cancelinstance) | **PUT** /api/runs/cancel | [EXPERIMENTAL] CancelInstance: Cancels multiple instance executions.
*RunsApi* | [**GetRunResults**](docs/RunsApi.md#getrunresults) | **GET** /api/runs | [EXPERIMENTAL] GetRunResults: Get run results
*RunsApi* | [**RerunInstance**](docs/RunsApi.md#reruninstance) | **PUT** /api/runs/{runId}/rerun | [EXPERIMENTAL] RerunInstance: Reruns a single instance execution.
*RunsApi* | [**StopInstanceExecution**](docs/RunsApi.md#stopinstanceexecution) | **PUT** /api/runs/{instanceId}/{runId}/stop | [EXPERIMENTAL] StopInstanceExecution: Stops a single instance execution.
*TradePublicationFrameworkApi* | [**GetTpfFileDeliveries**](docs/TradePublicationFrameworkApi.md#gettpffiledeliveries) | **GET** /api/trade-publication-framework/instances/{instanceId}/deliveries | [EXPERIMENTAL] GetTpfFileDeliveries: Search TPF file deliveries for a specific instance
*TradePublicationFrameworkApi* | [**GetTpfTransactionHistorySearch**](docs/TradePublicationFrameworkApi.md#gettpftransactionhistorysearch) | **GET** /api/trade-publication-framework/transactions/search | [EXPERIMENTAL] GetTpfTransactionHistorySearch: Endpoint to search TPF transaction by transaction ID and/or instrument identifier, with filtering by instance and date range
*TradePublicationFrameworkApi* | [**GetTransactionPayload**](docs/TradePublicationFrameworkApi.md#gettransactionpayload) | **GET** /api/trade-publication-framework/instances/{instanceId}/runs/{runId}/transactions/payload | [EXPERIMENTAL] GetTransactionPayload: Transaction payloads for a run, with pagination support. When transactionId is supplied the single matching payload is returned; otherwise all payloads for the instance/run are returned.
*TradePublicationFrameworkApi* | [**ListFailedDeliveries**](docs/TradePublicationFrameworkApi.md#listfaileddeliveries) | **GET** /api/trade-publication-framework/instances/{instanceId}/failed | [EXPERIMENTAL] ListFailedDeliveries: List failed deliveries for a given TPF instance, filtered by resolved state, with pagination support.
*TradePublicationFrameworkApi* | [**ListInstanceRunHistory**](docs/TradePublicationFrameworkApi.md#listinstancerunhistory) | **GET** /api/trade-publication-framework/instances/{instanceId}/runs | [EXPERIMENTAL] ListInstanceRunHistory: List run history for a given TPF instance, with pagination support.
*TradePublicationFrameworkApi* | [**ListInstancesWithStatus**](docs/TradePublicationFrameworkApi.md#listinstanceswithstatus) | **GET** /api/trade-publication-framework/instances | [EXPERIMENTAL] ListInstancesWithStatus: Lists all instances of the Trade Publication Framework (TPF).
*TradePublicationFrameworkApi* | [**ListRunFiles**](docs/TradePublicationFrameworkApi.md#listrunfiles) | **GET** /api/trade-publication-framework/instances/{instanceId}/runs/{runId}/files | [EXPERIMENTAL] ListRunFiles: List Files in a run
*TradePublicationFrameworkApi* | [**ListRunTransactions**](docs/TradePublicationFrameworkApi.md#listruntransactions) | **GET** /api/trade-publication-framework/instances/{instanceId}/runs/{runId}/transactions | [EXPERIMENTAL] ListRunTransactions: List Transactions in a run.
*TradePublicationFrameworkApi* | [**ReplayTransactions**](docs/TradePublicationFrameworkApi.md#replaytransactions) | **POST** /api/trade-publication-framework/instances/{instanceId}/replay | [EXPERIMENTAL] ReplayTransactions: Replay one or more transactions through a TPF instance
*TradePublicationFrameworkApi* | [**ResolveFailedDelivery**](docs/TradePublicationFrameworkApi.md#resolvefaileddelivery) | **PUT** /api/trade-publication-framework/instances/{instanceId}/failed/{batchReferenceId}/resolve | [EXPERIMENTAL] ResolveFailedDelivery: Resolve a failed delivery without retry
*TradePublicationFrameworkApi* | [**RetryFailedDelivery**](docs/TradePublicationFrameworkApi.md#retryfaileddelivery) | **POST** /api/trade-publication-framework/instances/{instanceId}/failed/retry | [EXPERIMENTAL] RetryFailedDelivery: Retry failed deliveries for Trade Publication Framework
*TradePublicationFrameworkApi* | [**RetryTpfSftpDelivery**](docs/TradePublicationFrameworkApi.md#retrytpfsftpdelivery) | **POST** /api/trade-publication-framework/instances/{instanceId}/files/{fileId}/retry-sftp | [EXPERIMENTAL] RetryTpfSftpDelivery: Retry SFTP delivery for a previously sent TPF file
*VendorApi* | [**GetCoreFieldMappingsForProductEntity**](docs/VendorApi.md#getcorefieldmappingsforproductentity) | **GET** /api/vendor/mappings/fields | [EARLY ACCESS] GetCoreFieldMappingsForProductEntity: Get core field mappings for a given vendor product's entity.
*VendorApi* | [**GetOptionalMappingsForProductEntity**](docs/VendorApi.md#getoptionalmappingsforproductentity) | **GET** /api/vendor/mappings/optional | [EARLY ACCESS] GetOptionalMappingsForProductEntity: Get a user defined LUSID property mappings for the specified vendor / LUSID entity.
*VendorApi* | [**GetPropertyMappingsForProductEntity**](docs/VendorApi.md#getpropertymappingsforproductentity) | **GET** /api/vendor/mappings/properties | [EARLY ACCESS] GetPropertyMappingsForProductEntity: Gets the property mappings for a given vendor product's entity
*VendorApi* | [**QueryVendors**](docs/VendorApi.md#queryvendors) | **POST** /api/vendor/$query | [EARLY ACCESS] QueryVendors: Query for vendors and their packages with entities and sub-entities.
*VendorApi* | [**SetOptionalMappingsForProductEntity**](docs/VendorApi.md#setoptionalmappingsforproductentity) | **POST** /api/vendor/mappings/optional | [EARLY ACCESS] SetOptionalMappingsForProductEntity: Create a user defined LUSID property mappings for the specified vendor / LUSID entity.
*VersionedConfigurationsApi* | [**CreateVersionedConfigurationDraft**](docs/VersionedConfigurationsApi.md#createversionedconfigurationdraft) | **POST** /api/versionedconfiguration/{configType}/{name}/draft | [EXPERIMENTAL] CreateVersionedConfigurationDraft: Create a draft versioned configuration.
*VersionedConfigurationsApi* | [**DeleteVersionedConfigurationVersion**](docs/VersionedConfigurationsApi.md#deleteversionedconfigurationversion) | **DELETE** /api/versionedconfiguration/{configType}/{name}/{majorVersion}/{minorVersion} | [EXPERIMENTAL] DeleteVersionedConfigurationVersion: Delete a versioned configuration version.
*VersionedConfigurationsApi* | [**GetVersionedConfiguration**](docs/VersionedConfigurationsApi.md#getversionedconfiguration) | **GET** /api/versionedconfiguration/{configType}/{name} | [EXPERIMENTAL] GetVersionedConfiguration: Get a versioned configuration.
*VersionedConfigurationsApi* | [**GetVersionedConfigurationTypes**](docs/VersionedConfigurationsApi.md#getversionedconfigurationtypes) | **GET** /api/versionedconfiguration/config-types | [EXPERIMENTAL] GetVersionedConfigurationTypes: List available versioned configuration types.
*VersionedConfigurationsApi* | [**ListAllVersionedConfigurations**](docs/VersionedConfigurationsApi.md#listallversionedconfigurations) | **GET** /api/versionedconfiguration/all | [EXPERIMENTAL] ListAllVersionedConfigurations: List all versioned configurations.
*VersionedConfigurationsApi* | [**ListVersionedConfigurations**](docs/VersionedConfigurationsApi.md#listversionedconfigurations) | **GET** /api/versionedconfiguration/{configType} | [EXPERIMENTAL] ListVersionedConfigurations: List versioned configurations for a config type.
*VersionedConfigurationsApi* | [**LockVersionedConfigurationVersion**](docs/VersionedConfigurationsApi.md#lockversionedconfigurationversion) | **POST** /api/versionedconfiguration/{configType}/{name}/{majorVersion}/{minorVersion}/lock | [EXPERIMENTAL] LockVersionedConfigurationVersion: Lock a versioned configuration version.
*VersionedConfigurationsApi* | [**UpdateVersionedConfigurationDraft**](docs/VersionedConfigurationsApi.md#updateversionedconfigurationdraft) | **PUT** /api/versionedconfiguration/{configType}/{name}/{majorVersion}/{minorVersion}/draft | [EXPERIMENTAL] UpdateVersionedConfigurationDraft: Update a draft versioned configuration.


<a id="documentation-for-models"></a>
## Documentation for Models

 - [AllowedParameterValue](docs/AllowedParameterValue.md)
 - [AuditCompleteRequest](docs/AuditCompleteRequest.md)
 - [AuditCompleteResponse](docs/AuditCompleteResponse.md)
 - [AuditFileDetails](docs/AuditFileDetails.md)
 - [AuditUpdateRequest](docs/AuditUpdateRequest.md)
 - [AuditUpdateResponse](docs/AuditUpdateResponse.md)
 - [CancelRunRequest](docs/CancelRunRequest.md)
 - [CreateInstanceRequest](docs/CreateInstanceRequest.md)
 - [CreateVersionedConfigurationDraftRequest](docs/CreateVersionedConfigurationDraftRequest.md)
 - [DestinationResponse](docs/DestinationResponse.md)
 - [EnrichmentResponse](docs/EnrichmentResponse.md)
 - [ExecuteInstanceResponse](docs/ExecuteInstanceResponse.md)
 - [ExternalLogInsertionRequest](docs/ExternalLogInsertionRequest.md)
 - [ExternalLogRecord](docs/ExternalLogRecord.md)
 - [FailedDeliveryResponse](docs/FailedDeliveryResponse.md)
 - [FieldMapping](docs/FieldMapping.md)
 - [FileDeliveryStatus](docs/FileDeliveryStatus.md)
 - [FileDestinationResponse](docs/FileDestinationResponse.md)
 - [FileDetails](docs/FileDetails.md)
 - [IFieldMapping](docs/IFieldMapping.md)
 - [IIntegrationLogResponse](docs/IIntegrationLogResponse.md)
 - [IPropertyMapping](docs/IPropertyMapping.md)
 - [Identifiers](docs/Identifiers.md)
 - [InstanceDestinations](docs/InstanceDestinations.md)
 - [InstanceExecutionReferenceId](docs/InstanceExecutionReferenceId.md)
 - [InstanceIdentifier](docs/InstanceIdentifier.md)
 - [InstanceResponse](docs/InstanceResponse.md)
 - [InstanceRunResponse](docs/InstanceRunResponse.md)
 - [InstancesResponse](docs/InstancesResponse.md)
 - [IntegrationCancellationResponse](docs/IntegrationCancellationResponse.md)
 - [IntegrationDescription](docs/IntegrationDescription.md)
 - [IntegrationInstance](docs/IntegrationInstance.md)
 - [IntegrationInstanceResponse](docs/IntegrationInstanceResponse.md)
 - [IntegrationLogActivity](docs/IntegrationLogActivity.md)
 - [IntegrationLogRecord](docs/IntegrationLogRecord.md)
 - [IntegrationLogTargetRecord](docs/IntegrationLogTargetRecord.md)
 - [IntegrationPropertyConfiguration](docs/IntegrationPropertyConfiguration.md)
 - [IntegrationRerunResponse](docs/IntegrationRerunResponse.md)
 - [IntegrationRunIntegration](docs/IntegrationRunIntegration.md)
 - [IntegrationRunLog](docs/IntegrationRunLog.md)
 - [IntegrationRunLogLink](docs/IntegrationRunLogLink.md)
 - [IntegrationRunResponse](docs/IntegrationRunResponse.md)
 - [IntegrationRunVersion](docs/IntegrationRunVersion.md)
 - [JSchema](docs/JSchema.md)
 - [JSchemaType](docs/JSchemaType.md)
 - [Link](docs/Link.md)
 - [LusidEntity](docs/LusidEntity.md)
 - [LusidField](docs/LusidField.md)
 - [LusidProblemDetails](docs/LusidProblemDetails.md)
 - [LusidPropertyDefinition](docs/LusidPropertyDefinition.md)
 - [LusidPropertyDefinitionOverrides](docs/LusidPropertyDefinitionOverrides.md)
 - [LusidPropertyDefinitionOverridesByType](docs/LusidPropertyDefinitionOverridesByType.md)
 - [LusidPropertyDefinitionOverridesResponse](docs/LusidPropertyDefinitionOverridesResponse.md)
 - [LusidPropertyToVendorFieldMapping](docs/LusidPropertyToVendorFieldMapping.md)
 - [LusidValidationProblemDetails](docs/LusidValidationProblemDetails.md)
 - [OnboardInstrumentRequest](docs/OnboardInstrumentRequest.md)
 - [OnboardInstrumentResponse](docs/OnboardInstrumentResponse.md)
 - [OpenFigiData](docs/OpenFigiData.md)
 - [OpenFigiParameterOptionName](docs/OpenFigiParameterOptionName.md)
 - [OpenFigiPermIdResult](docs/OpenFigiPermIdResult.md)
 - [OpenFigiSearchResult](docs/OpenFigiSearchResult.md)
 - [PagedResourceListOfFailedDeliveryResponse](docs/PagedResourceListOfFailedDeliveryResponse.md)
 - [PagedResourceListOfIFieldMapping](docs/PagedResourceListOfIFieldMapping.md)
 - [PagedResourceListOfIIntegrationLogResponse](docs/PagedResourceListOfIIntegrationLogResponse.md)
 - [PagedResourceListOfIPropertyMapping](docs/PagedResourceListOfIPropertyMapping.md)
 - [PagedResourceListOfInstanceRunResponse](docs/PagedResourceListOfInstanceRunResponse.md)
 - [PagedResourceListOfIntegrationRunResponse](docs/PagedResourceListOfIntegrationRunResponse.md)
 - [PagedResourceListOfProcessInformation](docs/PagedResourceListOfProcessInformation.md)
 - [PagedResourceListOfProcessUpdateResult](docs/PagedResourceListOfProcessUpdateResult.md)
 - [PagedResourceListOfRunFileResponse](docs/PagedResourceListOfRunFileResponse.md)
 - [PagedResourceListOfTpfFileDeliveryResponse](docs/PagedResourceListOfTpfFileDeliveryResponse.md)
 - [PagedResourceListOfTpfTransactionSearchResponse](docs/PagedResourceListOfTpfTransactionSearchResponse.md)
 - [PagedResourceListOfTransactionPayload](docs/PagedResourceListOfTransactionPayload.md)
 - [PagedResourceListOfTransactionResponse](docs/PagedResourceListOfTransactionResponse.md)
 - [PagedResourceListOfVendorProduct](docs/PagedResourceListOfVendorProduct.md)
 - [PermIdData](docs/PermIdData.md)
 - [PostProcessTask](docs/PostProcessTask.md)
 - [ProcessInformation](docs/ProcessInformation.md)
 - [ProcessSummary](docs/ProcessSummary.md)
 - [ProcessUpdateResult](docs/ProcessUpdateResult.md)
 - [ProcessorDescription](docs/ProcessorDescription.md)
 - [ProcessorSchemaResponse](docs/ProcessorSchemaResponse.md)
 - [PropertyMapping](docs/PropertyMapping.md)
 - [QueryRequest](docs/QueryRequest.md)
 - [QuerySpecification](docs/QuerySpecification.md)
 - [ReplayOptions](docs/ReplayOptions.md)
 - [ReplayTransactionsRequest](docs/ReplayTransactionsRequest.md)
 - [ReplayTransactionsResponse](docs/ReplayTransactionsResponse.md)
 - [ResolveFailedDeliveryRequest](docs/ResolveFailedDeliveryRequest.md)
 - [ResolveFailedDeliveryResponse](docs/ResolveFailedDeliveryResponse.md)
 - [ResourceId](docs/ResourceId.md)
 - [RowDetails](docs/RowDetails.md)
 - [RunFileResponse](docs/RunFileResponse.md)
 - [TpfFailedDeliveryResponse](docs/TpfFailedDeliveryResponse.md)
 - [TpfFileDeliveryInfo](docs/TpfFileDeliveryInfo.md)
 - [TpfFileDeliveryResponse](docs/TpfFileDeliveryResponse.md)
 - [TpfPortfolio](docs/TpfPortfolio.md)
 - [TpfRetryElementResult](docs/TpfRetryElementResult.md)
 - [TpfRetryFailedDeliveryRequest](docs/TpfRetryFailedDeliveryRequest.md)
 - [TpfRetrySftpResponse](docs/TpfRetrySftpResponse.md)
 - [TpfTransactionSearchResponse](docs/TpfTransactionSearchResponse.md)
 - [TransactionPayload](docs/TransactionPayload.md)
 - [TransactionResponse](docs/TransactionResponse.md)
 - [Trigger](docs/Trigger.md)
 - [UpdateInstanceRequest](docs/UpdateInstanceRequest.md)
 - [UpdateVersionedConfigurationDraftRequest](docs/UpdateVersionedConfigurationDraftRequest.md)
 - [VendorField](docs/VendorField.md)
 - [VendorProduct](docs/VendorProduct.md)
 - [VersionedConfigurationResponse](docs/VersionedConfigurationResponse.md)
 - [VersionedConfigurationTypeResponse](docs/VersionedConfigurationTypeResponse.md)


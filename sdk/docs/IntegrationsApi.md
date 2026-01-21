# Finbourne.Horizon.Sdk.Api.IntegrationsApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateInstance**](IntegrationsApi.md#createinstance) | **POST** /api/integrations/instances | [EXPERIMENTAL] CreateInstance: Create a single integration instance. |
| [**DeleteInstance**](IntegrationsApi.md#deleteinstance) | **DELETE** /api/integrations/instances/{instanceId} | [EXPERIMENTAL] DeleteInstance: Delete a single integration instance. |
| [**ExecuteInstance**](IntegrationsApi.md#executeinstance) | **POST** /api/integrations/instances/{instanceId}/execute | [EXPERIMENTAL] ExecuteInstance: Execute an integration instance. |
| [**ExecuteInstanceWithParams**](IntegrationsApi.md#executeinstancewithparams) | **POST** /api/integrations/instances/{instanceId}/executewithparams | [EXPERIMENTAL] ExecuteInstanceWithParams: Execute an integration instance with runtime parameters |
| [**GetExecutionIdsForInstance**](IntegrationsApi.md#getexecutionidsforinstance) | **GET** /api/integrations/instances/{instanceId}/executions | [EXPERIMENTAL] GetExecutionIdsForInstance: Get integration instance execution ids. |
| [**GetInstance**](IntegrationsApi.md#getinstance) | **GET** /api/integrations/instances/{instanceId} | [EXPERIMENTAL] GetInstance: Get a specified Instance for a given integration. |
| [**GetInstanceOptionalPropertyMapping**](IntegrationsApi.md#getinstanceoptionalpropertymapping) | **GET** /api/integrations/instances/configuration/{integration}/{instanceId} | [EXPERIMENTAL] GetInstanceOptionalPropertyMapping: Get the Optional Property Mapping for an Integration Instance |
| [**GetIntegrationConfiguration**](IntegrationsApi.md#getintegrationconfiguration) | **GET** /api/integrations/configuration/{integration} | [EXPERIMENTAL] GetIntegrationConfiguration: Get the Field and Property Mapping configuration for a given integration |
| [**GetIntegrationConfigurationFields**](IntegrationsApi.md#getintegrationconfigurationfields) | **GET** /api/integrations/configuration/{integration}/fields | [EXPERIMENTAL] GetIntegrationConfigurationFields: Get the Field Mapping configuration for a given integration |
| [**GetIntegrationConfigurationProperties**](IntegrationsApi.md#getintegrationconfigurationproperties) | **GET** /api/integrations/configuration/{integration}/properties | [EXPERIMENTAL] GetIntegrationConfigurationProperties: Get the Property Mapping configuration for a given integration |
| [**GetSchema**](IntegrationsApi.md#getschema) | **GET** /api/integrations/schema/{integration} | [EXPERIMENTAL] GetSchema: Get the JSON schema for the details section of an integration instance. |
| [**ListInstances**](IntegrationsApi.md#listinstances) | **GET** /api/integrations/instances | [EXPERIMENTAL] ListInstances: List instances across all integrations. |
| [**ListIntegrations**](IntegrationsApi.md#listintegrations) | **GET** /api/integrations | [EXPERIMENTAL] ListIntegrations: List available integrations. |
| [**SetInstanceOptionalPropertyMapping**](IntegrationsApi.md#setinstanceoptionalpropertymapping) | **PUT** /api/integrations/instances/configuration/{integration}/{instanceId} | [EXPERIMENTAL] SetInstanceOptionalPropertyMapping: Set the Optional Property Mapping for an Integration Instance |
| [**UpdateInstance**](IntegrationsApi.md#updateinstance) | **PUT** /api/integrations/instances/{instanceId} | [EXPERIMENTAL] UpdateInstance: Update a single integration instance. |

<a id="createinstance"></a>
# **CreateInstance**
> InstanceIdentifier CreateInstance (CreateInstanceRequest? createInstanceRequest = null)

[EXPERIMENTAL] CreateInstance: Create a single integration instance.

Creates a new instance of an integration, returning its identifier. The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var createInstanceRequest = new CreateInstanceRequest?(); // CreateInstanceRequest? | The new integration instance. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InstanceIdentifier result = apiInstance.CreateInstance(createInstanceRequest, opts: opts);

                // [EXPERIMENTAL] CreateInstance: Create a single integration instance.
                InstanceIdentifier result = apiInstance.CreateInstance(createInstanceRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.CreateInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateInstance: Create a single integration instance.
    ApiResponse<InstanceIdentifier> response = apiInstance.CreateInstanceWithHttpInfo(createInstanceRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.CreateInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createInstanceRequest** | [**CreateInstanceRequest?**](CreateInstanceRequest?.md) | The new integration instance. | [optional]  |

### Return type

[**InstanceIdentifier**](InstanceIdentifier.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Identifier of the created instance. |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The integration type does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteinstance"></a>
# **DeleteInstance**
> void DeleteInstance (string instanceId)

[EXPERIMENTAL] DeleteInstance: Delete a single integration instance.

Deletes an existing instance of an integration, returning its identifier. The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var instanceId = "instanceId_example";  // string | Instance identifier e.g. \"b64135e7-98a0-41af-a845-d86167d54cc7\".

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteInstance(instanceId, opts: opts);

                // [EXPERIMENTAL] DeleteInstance: Delete a single integration instance.
                apiInstance.DeleteInstance(instanceId);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.DeleteInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteInstance: Delete a single integration instance.
    apiInstance.DeleteInstanceWithHttpInfo(instanceId);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.DeleteInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | Instance identifier e.g. \&quot;b64135e7-98a0-41af-a845-d86167d54cc7\&quot;. |  |

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The instance does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="executeinstance"></a>
# **ExecuteInstance**
> ExecuteInstanceResponse ExecuteInstance (string instanceId)

[EXPERIMENTAL] ExecuteInstance: Execute an integration instance.

Starts execution of an instance, returning its execution identifier. The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var instanceId = "instanceId_example";  // string | Instance identifier e.g. \"b64135e7-98a0-41af-a845-d86167d54cc7\".

            try
            {
                // uncomment the below to set overrides at the request level
                // ExecuteInstanceResponse result = apiInstance.ExecuteInstance(instanceId, opts: opts);

                // [EXPERIMENTAL] ExecuteInstance: Execute an integration instance.
                ExecuteInstanceResponse result = apiInstance.ExecuteInstance(instanceId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.ExecuteInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExecuteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ExecuteInstance: Execute an integration instance.
    ApiResponse<ExecuteInstanceResponse> response = apiInstance.ExecuteInstanceWithHttpInfo(instanceId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.ExecuteInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | Instance identifier e.g. \&quot;b64135e7-98a0-41af-a845-d86167d54cc7\&quot;. |  |

### Return type

[**ExecuteInstanceResponse**](ExecuteInstanceResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The execution id |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The integration instance does not exist |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="executeinstancewithparams"></a>
# **ExecuteInstanceWithParams**
> ExecuteInstanceResponse ExecuteInstanceWithParams (string instanceId, Dictionary<string, string> requestBody)

[EXPERIMENTAL] ExecuteInstanceWithParams: Execute an integration instance with runtime parameters

Starts execution of an instance, returning its execution identifier. The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var instanceId = "instanceId_example";  // string | Instance identifier e.g. \"b64135e7-98a0-41af-a845-d86167d54cc7\".
            var requestBody = new Dictionary<string, string>(); // Dictionary<string, string> | Dictionary(string,string) of runtime parameters passed to the integration instance

            try
            {
                // uncomment the below to set overrides at the request level
                // ExecuteInstanceResponse result = apiInstance.ExecuteInstanceWithParams(instanceId, requestBody, opts: opts);

                // [EXPERIMENTAL] ExecuteInstanceWithParams: Execute an integration instance with runtime parameters
                ExecuteInstanceResponse result = apiInstance.ExecuteInstanceWithParams(instanceId, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.ExecuteInstanceWithParams: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExecuteInstanceWithParamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ExecuteInstanceWithParams: Execute an integration instance with runtime parameters
    ApiResponse<ExecuteInstanceResponse> response = apiInstance.ExecuteInstanceWithParamsWithHttpInfo(instanceId, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.ExecuteInstanceWithParamsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | Instance identifier e.g. \&quot;b64135e7-98a0-41af-a845-d86167d54cc7\&quot;. |  |
| **requestBody** | [**Dictionary&lt;string, string&gt;**](string.md) | Dictionary(string,string) of runtime parameters passed to the integration instance |  |

### Return type

[**ExecuteInstanceResponse**](ExecuteInstanceResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The execution id |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The integration instance does not exist |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getexecutionidsforinstance"></a>
# **GetExecutionIdsForInstance**
> List&lt;string&gt; GetExecutionIdsForInstance (string instanceId, int? limit = null)

[EXPERIMENTAL] GetExecutionIdsForInstance: Get integration instance execution ids.

Get the most recent execution ids for an integration instance. The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var instanceId = "instanceId_example";  // string | Instance identifier e.g. \"30dc93c6-a127-46bf-aea8-e466d720b72d\".
            var limit = 56;  // int? | Maximum number of returned execution ids (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<string> result = apiInstance.GetExecutionIdsForInstance(instanceId, limit, opts: opts);

                // [EXPERIMENTAL] GetExecutionIdsForInstance: Get integration instance execution ids.
                List<string> result = apiInstance.GetExecutionIdsForInstance(instanceId, limit);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.GetExecutionIdsForInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExecutionIdsForInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetExecutionIdsForInstance: Get integration instance execution ids.
    ApiResponse<List<string>> response = apiInstance.GetExecutionIdsForInstanceWithHttpInfo(instanceId, limit);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.GetExecutionIdsForInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | Instance identifier e.g. \&quot;30dc93c6-a127-46bf-aea8-e466d720b72d\&quot;. |  |
| **limit** | **int?** | Maximum number of returned execution ids | [optional]  |

### Return type

**List<string>**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The execution ids sorted by start date (descending) |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The integration instance does not exist |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstance"></a>
# **GetInstance**
> IntegrationInstanceResponse GetInstance (string instanceId)

[EXPERIMENTAL] GetInstance: Get a specified Instance for a given integration.

The user must be authenticated to call this method.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var instanceId = "instanceId_example";  // string | 

            try
            {
                // uncomment the below to set overrides at the request level
                // IntegrationInstanceResponse result = apiInstance.GetInstance(instanceId, opts: opts);

                // [EXPERIMENTAL] GetInstance: Get a specified Instance for a given integration.
                IntegrationInstanceResponse result = apiInstance.GetInstance(instanceId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.GetInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetInstance: Get a specified Instance for a given integration.
    ApiResponse<IntegrationInstanceResponse> response = apiInstance.GetInstanceWithHttpInfo(instanceId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.GetInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** |  |  |

### Return type

[**IntegrationInstanceResponse**](IntegrationInstanceResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The requested instance does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstanceoptionalpropertymapping"></a>
# **GetInstanceOptionalPropertyMapping**
> Dictionary&lt;string, LusidPropertyDefinitionOverridesByType&gt; GetInstanceOptionalPropertyMapping (string integration, string instanceId)

[EXPERIMENTAL] GetInstanceOptionalPropertyMapping: Get the Optional Property Mapping for an Integration Instance

Will return the full list of optional properties configured for this integration instance and any naming overrides

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var integration = "integration_example";  // string | The type of the integration e.g. \"copp-clark\".
            var instanceId = "instanceId_example";  // string | Identifier of the instance

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, LusidPropertyDefinitionOverridesByType> result = apiInstance.GetInstanceOptionalPropertyMapping(integration, instanceId, opts: opts);

                // [EXPERIMENTAL] GetInstanceOptionalPropertyMapping: Get the Optional Property Mapping for an Integration Instance
                Dictionary<string, LusidPropertyDefinitionOverridesByType> result = apiInstance.GetInstanceOptionalPropertyMapping(integration, instanceId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.GetInstanceOptionalPropertyMapping: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstanceOptionalPropertyMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetInstanceOptionalPropertyMapping: Get the Optional Property Mapping for an Integration Instance
    ApiResponse<Dictionary<string, LusidPropertyDefinitionOverridesByType>> response = apiInstance.GetInstanceOptionalPropertyMappingWithHttpInfo(integration, instanceId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.GetInstanceOptionalPropertyMappingWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **integration** | **string** | The type of the integration e.g. \&quot;copp-clark\&quot;. |  |
| **instanceId** | **string** | Identifier of the instance |  |

### Return type

[**Dictionary&lt;string, LusidPropertyDefinitionOverridesByType&gt;**](LusidPropertyDefinitionOverridesByType.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | The requested instance(s) do not exist. |  -  |
| **400** | The details of the input related failure |  -  |
| **200** | OK |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getintegrationconfiguration"></a>
# **GetIntegrationConfiguration**
> IntegrationPropertyConfiguration GetIntegrationConfiguration (string integration)

[EXPERIMENTAL] GetIntegrationConfiguration: Get the Field and Property Mapping configuration for a given integration

The user must be authenticated, entitled to call this method, but the user's domain does not need to be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var integration = "integration_example";  // string | 

            try
            {
                // uncomment the below to set overrides at the request level
                // IntegrationPropertyConfiguration result = apiInstance.GetIntegrationConfiguration(integration, opts: opts);

                // [EXPERIMENTAL] GetIntegrationConfiguration: Get the Field and Property Mapping configuration for a given integration
                IntegrationPropertyConfiguration result = apiInstance.GetIntegrationConfiguration(integration);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.GetIntegrationConfiguration: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIntegrationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetIntegrationConfiguration: Get the Field and Property Mapping configuration for a given integration
    ApiResponse<IntegrationPropertyConfiguration> response = apiInstance.GetIntegrationConfigurationWithHttpInfo(integration);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.GetIntegrationConfigurationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **integration** | **string** |  |  |

### Return type

[**IntegrationPropertyConfiguration**](IntegrationPropertyConfiguration.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The requested integration does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getintegrationconfigurationfields"></a>
# **GetIntegrationConfigurationFields**
> PagedResourceListOfIFieldMapping GetIntegrationConfigurationFields (string integration, string? filter = null, List<string>? sortBy = null, int? limit = null, string? pageToken = null)

[EXPERIMENTAL] GetIntegrationConfigurationFields: Get the Field Mapping configuration for a given integration

The user must be authenticated, entitled to call this method, but the user's domain does not need to be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var integration = "integration_example";  // string | 
            var filter = "filter_example";  // string? |  (optional) 
            var sortBy = new List<string>?(); // List<string>? |  (optional) 
            var limit = 100;  // int? |  (optional)  (default to 100)
            var pageToken = "\"\"";  // string? |  (optional)  (default to "")

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfIFieldMapping result = apiInstance.GetIntegrationConfigurationFields(integration, filter, sortBy, limit, pageToken, opts: opts);

                // [EXPERIMENTAL] GetIntegrationConfigurationFields: Get the Field Mapping configuration for a given integration
                PagedResourceListOfIFieldMapping result = apiInstance.GetIntegrationConfigurationFields(integration, filter, sortBy, limit, pageToken);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.GetIntegrationConfigurationFields: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIntegrationConfigurationFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetIntegrationConfigurationFields: Get the Field Mapping configuration for a given integration
    ApiResponse<PagedResourceListOfIFieldMapping> response = apiInstance.GetIntegrationConfigurationFieldsWithHttpInfo(integration, filter, sortBy, limit, pageToken);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.GetIntegrationConfigurationFieldsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **integration** | **string** |  |  |
| **filter** | **string?** |  | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **limit** | **int?** |  | [optional] [default to 100] |
| **pageToken** | **string?** |  | [optional] [default to &quot;&quot;] |

### Return type

[**PagedResourceListOfIFieldMapping**](PagedResourceListOfIFieldMapping.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The requested integration does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getintegrationconfigurationproperties"></a>
# **GetIntegrationConfigurationProperties**
> PagedResourceListOfIPropertyMapping GetIntegrationConfigurationProperties (string integration, string? filter = null, List<string>? sortBy = null, int? limit = null, string? pageToken = null)

[EXPERIMENTAL] GetIntegrationConfigurationProperties: Get the Property Mapping configuration for a given integration

The user must be authenticated, entitled to call this method, but the user's domain does not need to be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var integration = "integration_example";  // string | 
            var filter = "filter_example";  // string? |  (optional) 
            var sortBy = new List<string>?(); // List<string>? |  (optional) 
            var limit = 100;  // int? |  (optional)  (default to 100)
            var pageToken = "\"\"";  // string? |  (optional)  (default to "")

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfIPropertyMapping result = apiInstance.GetIntegrationConfigurationProperties(integration, filter, sortBy, limit, pageToken, opts: opts);

                // [EXPERIMENTAL] GetIntegrationConfigurationProperties: Get the Property Mapping configuration for a given integration
                PagedResourceListOfIPropertyMapping result = apiInstance.GetIntegrationConfigurationProperties(integration, filter, sortBy, limit, pageToken);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.GetIntegrationConfigurationProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIntegrationConfigurationPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetIntegrationConfigurationProperties: Get the Property Mapping configuration for a given integration
    ApiResponse<PagedResourceListOfIPropertyMapping> response = apiInstance.GetIntegrationConfigurationPropertiesWithHttpInfo(integration, filter, sortBy, limit, pageToken);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.GetIntegrationConfigurationPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **integration** | **string** |  |  |
| **filter** | **string?** |  | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **limit** | **int?** |  | [optional] [default to 100] |
| **pageToken** | **string?** |  | [optional] [default to &quot;&quot;] |

### Return type

[**PagedResourceListOfIPropertyMapping**](PagedResourceListOfIPropertyMapping.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The requested integration does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getschema"></a>
# **GetSchema**
> JSchema GetSchema (string integration)

[EXPERIMENTAL] GetSchema: Get the JSON schema for the details section of an integration instance.

The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var integration = "integration_example";  // string | The type of the integration e.g. \"copp-clark\".

            try
            {
                // uncomment the below to set overrides at the request level
                // JSchema result = apiInstance.GetSchema(integration, opts: opts);

                // [EXPERIMENTAL] GetSchema: Get the JSON schema for the details section of an integration instance.
                JSchema result = apiInstance.GetSchema(integration);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.GetSchema: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetSchema: Get the JSON schema for the details section of an integration instance.
    ApiResponse<JSchema> response = apiInstance.GetSchemaWithHttpInfo(integration);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.GetSchemaWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **integration** | **string** | The type of the integration e.g. \&quot;copp-clark\&quot;. |  |

### Return type

[**JSchema**](JSchema.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The system defined JSON schema for the details of a specified integration. |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The integration type does not exist or is not enabled. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listinstances"></a>
# **ListInstances**
> List&lt;IntegrationInstance&gt; ListInstances ()

[EXPERIMENTAL] ListInstances: List instances across all integrations.

The user must be authenticated to call this method.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // List<IntegrationInstance> result = apiInstance.ListInstances(opts: opts);

                // [EXPERIMENTAL] ListInstances: List instances across all integrations.
                List<IntegrationInstance> result = apiInstance.ListInstances();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.ListInstances: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListInstances: List instances across all integrations.
    ApiResponse<List<IntegrationInstance>> response = apiInstance.ListInstancesWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.ListInstancesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;IntegrationInstance&gt;**](IntegrationInstance.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | The requested instance(s) do not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listintegrations"></a>
# **ListIntegrations**
> List&lt;IntegrationDescription&gt; ListIntegrations ()

[EXPERIMENTAL] ListIntegrations: List available integrations.

List all available integrations. ```\"licensed\"``` indicates your domain is licensed to use this integration. To request a licence contact your [FINBOURNE sales representative](https://www.finbourne.com/contact/). Any authenticated user can call this method.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // List<IntegrationDescription> result = apiInstance.ListIntegrations(opts: opts);

                // [EXPERIMENTAL] ListIntegrations: List available integrations.
                List<IntegrationDescription> result = apiInstance.ListIntegrations();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.ListIntegrations: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListIntegrationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListIntegrations: List available integrations.
    ApiResponse<List<IntegrationDescription>> response = apiInstance.ListIntegrationsWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.ListIntegrationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;IntegrationDescription&gt;**](IntegrationDescription.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="setinstanceoptionalpropertymapping"></a>
# **SetInstanceOptionalPropertyMapping**
> Dictionary&lt;string, LusidPropertyDefinitionOverridesByType&gt; SetInstanceOptionalPropertyMapping (string instanceId, string integration, Dictionary<string, LusidPropertyDefinitionOverridesByType>? requestBody = null)

[EXPERIMENTAL] SetInstanceOptionalPropertyMapping: Set the Optional Property Mapping for an Integration Instance

The full list of properties must be supplied, the removal of a property from this list will remove it from the integration instance

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var instanceId = "instanceId_example";  // string | Identifier of the instance
            var integration = "integration_example";  // string | The type of the integration e.g. \"copp-clark\".
            var requestBody = new Dictionary<string, LusidPropertyDefinitionOverridesByType>?(); // Dictionary<string, LusidPropertyDefinitionOverridesByType>? | Properties to be included and any overrides (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, LusidPropertyDefinitionOverridesByType> result = apiInstance.SetInstanceOptionalPropertyMapping(instanceId, integration, requestBody, opts: opts);

                // [EXPERIMENTAL] SetInstanceOptionalPropertyMapping: Set the Optional Property Mapping for an Integration Instance
                Dictionary<string, LusidPropertyDefinitionOverridesByType> result = apiInstance.SetInstanceOptionalPropertyMapping(instanceId, integration, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.SetInstanceOptionalPropertyMapping: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetInstanceOptionalPropertyMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SetInstanceOptionalPropertyMapping: Set the Optional Property Mapping for an Integration Instance
    ApiResponse<Dictionary<string, LusidPropertyDefinitionOverridesByType>> response = apiInstance.SetInstanceOptionalPropertyMappingWithHttpInfo(instanceId, integration, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.SetInstanceOptionalPropertyMappingWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | Identifier of the instance |  |
| **integration** | **string** | The type of the integration e.g. \&quot;copp-clark\&quot;. |  |
| **requestBody** | [**Dictionary&lt;string, LusidPropertyDefinitionOverridesByType&gt;?**](LusidPropertyDefinitionOverridesByType.md) | Properties to be included and any overrides | [optional]  |

### Return type

[**Dictionary&lt;string, LusidPropertyDefinitionOverridesByType&gt;**](LusidPropertyDefinitionOverridesByType.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | The requested instance(s) do not exist. |  -  |
| **400** | The details of the input related failure |  -  |
| **200** | OK |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateinstance"></a>
# **UpdateInstance**
> void UpdateInstance (string instanceId, UpdateInstanceRequest? updateInstanceRequest = null)

[EXPERIMENTAL] UpdateInstance: Update a single integration instance.

Updates an existing instance of an integration, returning its identifier. The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Extensions;
using Finbourne.Horizon.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""horizonUrl"": ""https://<your-domain>.lusid.com/horizon"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IntegrationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IntegrationsApi>();
            var instanceId = "instanceId_example";  // string | Instance identifier e.g. \"b64135e7-98a0-41af-a845-d86167d54cc7\".
            var updateInstanceRequest = new UpdateInstanceRequest?(); // UpdateInstanceRequest? | The new integration instance. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.UpdateInstance(instanceId, updateInstanceRequest, opts: opts);

                // [EXPERIMENTAL] UpdateInstance: Update a single integration instance.
                apiInstance.UpdateInstance(instanceId, updateInstanceRequest);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IntegrationsApi.UpdateInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateInstance: Update a single integration instance.
    apiInstance.UpdateInstanceWithHttpInfo(instanceId, updateInstanceRequest);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IntegrationsApi.UpdateInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | Instance identifier e.g. \&quot;b64135e7-98a0-41af-a845-d86167d54cc7\&quot;. |  |
| **updateInstanceRequest** | [**UpdateInstanceRequest?**](UpdateInstanceRequest?.md) | The new integration instance. | [optional]  |

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The instance does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


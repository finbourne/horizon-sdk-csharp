# Finbourne.Horizon.Sdk.Api.ClientConfigurationsApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateClientConfigurationDraft**](ClientConfigurationsApi.md#createclientconfigurationdraft) | **POST** /api/clientconfiguration/{configType}/{name}/draft | [EXPERIMENTAL] CreateClientConfigurationDraft: Create a draft client configuration. |
| [**GetClientConfiguration**](ClientConfigurationsApi.md#getclientconfiguration) | **GET** /api/clientconfiguration/{configType}/{name} | [EXPERIMENTAL] GetClientConfiguration: Get a client configuration. |
| [**ListClientConfigurations**](ClientConfigurationsApi.md#listclientconfigurations) | **GET** /api/clientconfiguration/{configType} | [EXPERIMENTAL] ListClientConfigurations: List client configurations. |
| [**LockClientConfigurationVersion**](ClientConfigurationsApi.md#lockclientconfigurationversion) | **POST** /api/clientconfiguration/{configType}/{name}/{majorVersion}/{minorVersion}/lock | [EXPERIMENTAL] LockClientConfigurationVersion: Lock a client configuration version. |
| [**UpdateClientConfigurationDraft**](ClientConfigurationsApi.md#updateclientconfigurationdraft) | **PUT** /api/clientconfiguration/{configType}/{name}/{majorVersion}/{minorVersion}/draft | [EXPERIMENTAL] UpdateClientConfigurationDraft: Update a draft client configuration. |

<a id="createclientconfigurationdraft"></a>
# **CreateClientConfigurationDraft**
> ClientConfigurationResponse CreateClientConfigurationDraft (string configType, string name, CreateClientConfigurationDraftRequest? createClientConfigurationDraftRequest = null)

[EXPERIMENTAL] CreateClientConfigurationDraft: Create a draft client configuration.

Creates a new draft configuration record. Configurations follow a draft/locked lifecycle: create a draft here, refine it with the update endpoint, then commit it with the lock endpoint. If both majorVersion and minorVersion are omitted in the request body, the next version is assigned automatically by incrementing the minor version of the current highest version (starting at 1.0 if none exists). The user must be authenticated and entitled to call this method.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ClientConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ClientConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration.
            var name = "name_example";  // string | The logical name of the configuration.
            var createClientConfigurationDraftRequest = new CreateClientConfigurationDraftRequest?(); // CreateClientConfigurationDraftRequest? | Options for the new draft, including optional explicit version and source version. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ClientConfigurationResponse result = apiInstance.CreateClientConfigurationDraft(configType, name, createClientConfigurationDraftRequest, opts: opts);

                // [EXPERIMENTAL] CreateClientConfigurationDraft: Create a draft client configuration.
                ClientConfigurationResponse result = apiInstance.CreateClientConfigurationDraft(configType, name, createClientConfigurationDraftRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ClientConfigurationsApi.CreateClientConfigurationDraft: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateClientConfigurationDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateClientConfigurationDraft: Create a draft client configuration.
    ApiResponse<ClientConfigurationResponse> response = apiInstance.CreateClientConfigurationDraftWithHttpInfo(configType, name, createClientConfigurationDraftRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ClientConfigurationsApi.CreateClientConfigurationDraftWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configType** | **string** | The category of configuration. |  |
| **name** | **string** | The logical name of the configuration. |  |
| **createClientConfigurationDraftRequest** | [**CreateClientConfigurationDraftRequest?**](CreateClientConfigurationDraftRequest?.md) | Options for the new draft, including optional explicit version and source version. | [optional]  |

### Return type

[**ClientConfigurationResponse**](ClientConfigurationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The client does not exist. |  -  |
| **409** | A configuration with the specified version already exists. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getclientconfiguration"></a>
# **GetClientConfiguration**
> ClientConfigurationResponse GetClientConfiguration (string configType, string name, int? majorVersion = null, int? minorVersion = null)

[EXPERIMENTAL] GetClientConfiguration: Get a client configuration.

Returns a specific configuration record. When both majorVersion and minorVersion are omitted, the highest available version is returned. Both must be supplied together or both omitted. The user must be authenticated and entitled to call this method.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ClientConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ClientConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration.
            var name = "name_example";  // string | The logical name of the configuration.
            var majorVersion = 56;  // int? | The major version to retrieve. Must be supplied together with minorVersion, or both omitted. (optional) 
            var minorVersion = 56;  // int? | The minor version to retrieve. Must be supplied together with majorVersion, or both omitted. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ClientConfigurationResponse result = apiInstance.GetClientConfiguration(configType, name, majorVersion, minorVersion, opts: opts);

                // [EXPERIMENTAL] GetClientConfiguration: Get a client configuration.
                ClientConfigurationResponse result = apiInstance.GetClientConfiguration(configType, name, majorVersion, minorVersion);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ClientConfigurationsApi.GetClientConfiguration: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetClientConfiguration: Get a client configuration.
    ApiResponse<ClientConfigurationResponse> response = apiInstance.GetClientConfigurationWithHttpInfo(configType, name, majorVersion, minorVersion);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ClientConfigurationsApi.GetClientConfigurationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configType** | **string** | The category of configuration. |  |
| **name** | **string** | The logical name of the configuration. |  |
| **majorVersion** | **int?** | The major version to retrieve. Must be supplied together with minorVersion, or both omitted. | [optional]  |
| **minorVersion** | **int?** | The minor version to retrieve. Must be supplied together with majorVersion, or both omitted. | [optional]  |

### Return type

[**ClientConfigurationResponse**](ClientConfigurationResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The client or configuration does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listclientconfigurations"></a>
# **ListClientConfigurations**
> List&lt;ClientConfigurationResponse&gt; ListClientConfigurations (string configType)

[EXPERIMENTAL] ListClientConfigurations: List client configurations.

Returns all configuration records for the given config type, across all versions and states (both draft and locked), ordered by version descending. The user must be authenticated and entitled to call this method.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ClientConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ClientConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration to list.

            try
            {
                // uncomment the below to set overrides at the request level
                // List<ClientConfigurationResponse> result = apiInstance.ListClientConfigurations(configType, opts: opts);

                // [EXPERIMENTAL] ListClientConfigurations: List client configurations.
                List<ClientConfigurationResponse> result = apiInstance.ListClientConfigurations(configType);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ClientConfigurationsApi.ListClientConfigurations: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListClientConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListClientConfigurations: List client configurations.
    ApiResponse<List<ClientConfigurationResponse>> response = apiInstance.ListClientConfigurationsWithHttpInfo(configType);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ClientConfigurationsApi.ListClientConfigurationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configType** | **string** | The category of configuration to list. |  |

### Return type

[**List&lt;ClientConfigurationResponse&gt;**](ClientConfigurationResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The client does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="lockclientconfigurationversion"></a>
# **LockClientConfigurationVersion**
> ClientConfigurationResponse LockClientConfigurationVersion (string configType, string name, int majorVersion, int minorVersion)

[EXPERIMENTAL] LockClientConfigurationVersion: Lock a client configuration version.

Locks a draft configuration version, making it immutable and ready for use. Once locked, a version cannot be edited or unlocked. All versions are retained permanently. The user must be authenticated and entitled to call this method.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ClientConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ClientConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration.
            var name = "name_example";  // string | The logical name of the configuration.
            var majorVersion = 56;  // int | The major version to lock.
            var minorVersion = 56;  // int | The minor version to lock.

            try
            {
                // uncomment the below to set overrides at the request level
                // ClientConfigurationResponse result = apiInstance.LockClientConfigurationVersion(configType, name, majorVersion, minorVersion, opts: opts);

                // [EXPERIMENTAL] LockClientConfigurationVersion: Lock a client configuration version.
                ClientConfigurationResponse result = apiInstance.LockClientConfigurationVersion(configType, name, majorVersion, minorVersion);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ClientConfigurationsApi.LockClientConfigurationVersion: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the LockClientConfigurationVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] LockClientConfigurationVersion: Lock a client configuration version.
    ApiResponse<ClientConfigurationResponse> response = apiInstance.LockClientConfigurationVersionWithHttpInfo(configType, name, majorVersion, minorVersion);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ClientConfigurationsApi.LockClientConfigurationVersionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configType** | **string** | The category of configuration. |  |
| **name** | **string** | The logical name of the configuration. |  |
| **majorVersion** | **int** | The major version to lock. |  |
| **minorVersion** | **int** | The minor version to lock. |  |

### Return type

[**ClientConfigurationResponse**](ClientConfigurationResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The client or configuration version does not exist, or the version is already locked. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateclientconfigurationdraft"></a>
# **UpdateClientConfigurationDraft**
> ClientConfigurationResponse UpdateClientConfigurationDraft (string configType, string name, int majorVersion, int minorVersion, UpdateClientConfigurationDraftRequest? updateClientConfigurationDraftRequest = null)

[EXPERIMENTAL] UpdateClientConfigurationDraft: Update a draft client configuration.

Updates the value of an existing draft configuration. Only draft versions can be updated; locked versions are immutable. This endpoint can be called multiple times before locking. The user must be authenticated and entitled to call this method.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ClientConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ClientConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration.
            var name = "name_example";  // string | The logical name of the configuration.
            var majorVersion = 56;  // int | The major version of the draft to update.
            var minorVersion = 56;  // int | The minor version of the draft to update.
            var updateClientConfigurationDraftRequest = new UpdateClientConfigurationDraftRequest?(); // UpdateClientConfigurationDraftRequest? | The updated value. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ClientConfigurationResponse result = apiInstance.UpdateClientConfigurationDraft(configType, name, majorVersion, minorVersion, updateClientConfigurationDraftRequest, opts: opts);

                // [EXPERIMENTAL] UpdateClientConfigurationDraft: Update a draft client configuration.
                ClientConfigurationResponse result = apiInstance.UpdateClientConfigurationDraft(configType, name, majorVersion, minorVersion, updateClientConfigurationDraftRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ClientConfigurationsApi.UpdateClientConfigurationDraft: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateClientConfigurationDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateClientConfigurationDraft: Update a draft client configuration.
    ApiResponse<ClientConfigurationResponse> response = apiInstance.UpdateClientConfigurationDraftWithHttpInfo(configType, name, majorVersion, minorVersion, updateClientConfigurationDraftRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ClientConfigurationsApi.UpdateClientConfigurationDraftWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configType** | **string** | The category of configuration. |  |
| **name** | **string** | The logical name of the configuration. |  |
| **majorVersion** | **int** | The major version of the draft to update. |  |
| **minorVersion** | **int** | The minor version of the draft to update. |  |
| **updateClientConfigurationDraftRequest** | [**UpdateClientConfigurationDraftRequest?**](UpdateClientConfigurationDraftRequest?.md) | The updated value. | [optional]  |

### Return type

[**ClientConfigurationResponse**](ClientConfigurationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The client or configuration version does not exist, or the version is already locked. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


# Finbourne.Horizon.Sdk.Api.VersionedConfigurationsApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateVersionedConfigurationDraft**](VersionedConfigurationsApi.md#createversionedconfigurationdraft) | **POST** /api/versionedconfiguration/{configType}/{name}/draft | [EXPERIMENTAL] CreateVersionedConfigurationDraft: Create a draft versioned configuration. |
| [**GetVersionedConfiguration**](VersionedConfigurationsApi.md#getversionedconfiguration) | **GET** /api/versionedconfiguration/{configType}/{name} | [EXPERIMENTAL] GetVersionedConfiguration: Get a versioned configuration. |
| [**ListVersionedConfigurations**](VersionedConfigurationsApi.md#listversionedconfigurations) | **GET** /api/versionedconfiguration/{configType} | [EXPERIMENTAL] ListVersionedConfigurations: List versioned configurations. |
| [**LockVersionedConfigurationVersion**](VersionedConfigurationsApi.md#lockversionedconfigurationversion) | **POST** /api/versionedconfiguration/{configType}/{name}/{majorVersion}/{minorVersion}/lock | [EXPERIMENTAL] LockVersionedConfigurationVersion: Lock a versioned configuration version. |
| [**UpdateVersionedConfigurationDraft**](VersionedConfigurationsApi.md#updateversionedconfigurationdraft) | **PUT** /api/versionedconfiguration/{configType}/{name}/{majorVersion}/{minorVersion}/draft | [EXPERIMENTAL] UpdateVersionedConfigurationDraft: Update a draft versioned configuration. |

<a id="createversionedconfigurationdraft"></a>
# **CreateVersionedConfigurationDraft**
> VersionedConfigurationResponse CreateVersionedConfigurationDraft (string configType, string name, CreateVersionedConfigurationDraftRequest? createVersionedConfigurationDraftRequest = null)

[EXPERIMENTAL] CreateVersionedConfigurationDraft: Create a draft versioned configuration.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<VersionedConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<VersionedConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration.
            var name = "name_example";  // string | The logical name of the configuration.
            var createVersionedConfigurationDraftRequest = new CreateVersionedConfigurationDraftRequest?(); // CreateVersionedConfigurationDraftRequest? | Options for the new draft, including optional explicit version and source version. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedConfigurationResponse result = apiInstance.CreateVersionedConfigurationDraft(configType, name, createVersionedConfigurationDraftRequest, opts: opts);

                // [EXPERIMENTAL] CreateVersionedConfigurationDraft: Create a draft versioned configuration.
                VersionedConfigurationResponse result = apiInstance.CreateVersionedConfigurationDraft(configType, name, createVersionedConfigurationDraftRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling VersionedConfigurationsApi.CreateVersionedConfigurationDraft: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateVersionedConfigurationDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateVersionedConfigurationDraft: Create a draft versioned configuration.
    ApiResponse<VersionedConfigurationResponse> response = apiInstance.CreateVersionedConfigurationDraftWithHttpInfo(configType, name, createVersionedConfigurationDraftRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling VersionedConfigurationsApi.CreateVersionedConfigurationDraftWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configType** | **string** | The category of configuration. |  |
| **name** | **string** | The logical name of the configuration. |  |
| **createVersionedConfigurationDraftRequest** | [**CreateVersionedConfigurationDraftRequest?**](CreateVersionedConfigurationDraftRequest?.md) | Options for the new draft, including optional explicit version and source version. | [optional]  |

### Return type

[**VersionedConfigurationResponse**](VersionedConfigurationResponse.md)

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

<a id="getversionedconfiguration"></a>
# **GetVersionedConfiguration**
> VersionedConfigurationResponse GetVersionedConfiguration (string configType, string name, int? majorVersion = null, int? minorVersion = null)

[EXPERIMENTAL] GetVersionedConfiguration: Get a versioned configuration.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<VersionedConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<VersionedConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration.
            var name = "name_example";  // string | The logical name of the configuration.
            var majorVersion = 56;  // int? | The major version to retrieve. Must be supplied together with minorVersion, or both omitted. (optional) 
            var minorVersion = 56;  // int? | The minor version to retrieve. Must be supplied together with majorVersion, or both omitted. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedConfigurationResponse result = apiInstance.GetVersionedConfiguration(configType, name, majorVersion, minorVersion, opts: opts);

                // [EXPERIMENTAL] GetVersionedConfiguration: Get a versioned configuration.
                VersionedConfigurationResponse result = apiInstance.GetVersionedConfiguration(configType, name, majorVersion, minorVersion);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling VersionedConfigurationsApi.GetVersionedConfiguration: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVersionedConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetVersionedConfiguration: Get a versioned configuration.
    ApiResponse<VersionedConfigurationResponse> response = apiInstance.GetVersionedConfigurationWithHttpInfo(configType, name, majorVersion, minorVersion);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling VersionedConfigurationsApi.GetVersionedConfigurationWithHttpInfo: " + e.Message);
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

[**VersionedConfigurationResponse**](VersionedConfigurationResponse.md)

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

<a id="listversionedconfigurations"></a>
# **ListVersionedConfigurations**
> List&lt;VersionedConfigurationResponse&gt; ListVersionedConfigurations (string configType)

[EXPERIMENTAL] ListVersionedConfigurations: List versioned configurations.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<VersionedConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<VersionedConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration to list.

            try
            {
                // uncomment the below to set overrides at the request level
                // List<VersionedConfigurationResponse> result = apiInstance.ListVersionedConfigurations(configType, opts: opts);

                // [EXPERIMENTAL] ListVersionedConfigurations: List versioned configurations.
                List<VersionedConfigurationResponse> result = apiInstance.ListVersionedConfigurations(configType);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling VersionedConfigurationsApi.ListVersionedConfigurations: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListVersionedConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListVersionedConfigurations: List versioned configurations.
    ApiResponse<List<VersionedConfigurationResponse>> response = apiInstance.ListVersionedConfigurationsWithHttpInfo(configType);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling VersionedConfigurationsApi.ListVersionedConfigurationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configType** | **string** | The category of configuration to list. |  |

### Return type

[**List&lt;VersionedConfigurationResponse&gt;**](VersionedConfigurationResponse.md)

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

<a id="lockversionedconfigurationversion"></a>
# **LockVersionedConfigurationVersion**
> VersionedConfigurationResponse LockVersionedConfigurationVersion (string configType, string name, int majorVersion, int minorVersion)

[EXPERIMENTAL] LockVersionedConfigurationVersion: Lock a versioned configuration version.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<VersionedConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<VersionedConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration.
            var name = "name_example";  // string | The logical name of the configuration.
            var majorVersion = 56;  // int | The major version to lock.
            var minorVersion = 56;  // int | The minor version to lock.

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedConfigurationResponse result = apiInstance.LockVersionedConfigurationVersion(configType, name, majorVersion, minorVersion, opts: opts);

                // [EXPERIMENTAL] LockVersionedConfigurationVersion: Lock a versioned configuration version.
                VersionedConfigurationResponse result = apiInstance.LockVersionedConfigurationVersion(configType, name, majorVersion, minorVersion);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling VersionedConfigurationsApi.LockVersionedConfigurationVersion: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the LockVersionedConfigurationVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] LockVersionedConfigurationVersion: Lock a versioned configuration version.
    ApiResponse<VersionedConfigurationResponse> response = apiInstance.LockVersionedConfigurationVersionWithHttpInfo(configType, name, majorVersion, minorVersion);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling VersionedConfigurationsApi.LockVersionedConfigurationVersionWithHttpInfo: " + e.Message);
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

[**VersionedConfigurationResponse**](VersionedConfigurationResponse.md)

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

<a id="updateversionedconfigurationdraft"></a>
# **UpdateVersionedConfigurationDraft**
> VersionedConfigurationResponse UpdateVersionedConfigurationDraft (string configType, string name, int majorVersion, int minorVersion, UpdateVersionedConfigurationDraftRequest? updateVersionedConfigurationDraftRequest = null)

[EXPERIMENTAL] UpdateVersionedConfigurationDraft: Update a draft versioned configuration.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<VersionedConfigurationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<VersionedConfigurationsApi>();
            var configType = "configType_example";  // string | The category of configuration.
            var name = "name_example";  // string | The logical name of the configuration.
            var majorVersion = 56;  // int | The major version of the draft to update.
            var minorVersion = 56;  // int | The minor version of the draft to update.
            var updateVersionedConfigurationDraftRequest = new UpdateVersionedConfigurationDraftRequest?(); // UpdateVersionedConfigurationDraftRequest? | The updated value. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedConfigurationResponse result = apiInstance.UpdateVersionedConfigurationDraft(configType, name, majorVersion, minorVersion, updateVersionedConfigurationDraftRequest, opts: opts);

                // [EXPERIMENTAL] UpdateVersionedConfigurationDraft: Update a draft versioned configuration.
                VersionedConfigurationResponse result = apiInstance.UpdateVersionedConfigurationDraft(configType, name, majorVersion, minorVersion, updateVersionedConfigurationDraftRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling VersionedConfigurationsApi.UpdateVersionedConfigurationDraft: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVersionedConfigurationDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateVersionedConfigurationDraft: Update a draft versioned configuration.
    ApiResponse<VersionedConfigurationResponse> response = apiInstance.UpdateVersionedConfigurationDraftWithHttpInfo(configType, name, majorVersion, minorVersion, updateVersionedConfigurationDraftRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling VersionedConfigurationsApi.UpdateVersionedConfigurationDraftWithHttpInfo: " + e.Message);
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
| **updateVersionedConfigurationDraftRequest** | [**UpdateVersionedConfigurationDraftRequest?**](UpdateVersionedConfigurationDraftRequest?.md) | The updated value. | [optional]  |

### Return type

[**VersionedConfigurationResponse**](VersionedConfigurationResponse.md)

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


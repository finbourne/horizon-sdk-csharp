# Finbourne.Horizon.Sdk.Api.IntegrationsApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateInstance**](IntegrationsApi.md#createinstance) | **POST** /api/integrations/instances | [EXPERIMENTAL] CreateInstance: Create a single integration instance. |
| [**DeleteInstance**](IntegrationsApi.md#deleteinstance) | **DELETE** /api/integrations/instances/{instanceId} | [EXPERIMENTAL] DeleteInstance: Delete a single integration instance. |
| [**ExecuteInstance**](IntegrationsApi.md#executeinstance) | **POST** /api/integrations/instances/{instanceId}/execute | [EXPERIMENTAL] ExecuteInstance: Execute an integration instance. |
| [**GetSchema**](IntegrationsApi.md#getschema) | **GET** /api/integrations/schema/{integration} | [EXPERIMENTAL] GetSchema: Get the JSON schema for the details section of an integration instance. |
| [**ListInstances**](IntegrationsApi.md#listinstances) | **GET** /api/integrations/instances | [EXPERIMENTAL] ListInstances: List instances across all integrations. |
| [**ListIntegrations**](IntegrationsApi.md#listintegrations) | **GET** /api/integrations | [EXPERIMENTAL] ListIntegrations: List available integrations. |
| [**UpdateInstance**](IntegrationsApi.md#updateinstance) | **PUT** /api/integrations/instances/{instanceId} | [EXPERIMENTAL] UpdateInstance: Update a single integration instance. |

<a id="createinstance"></a>
# **CreateInstance**
> InstanceIdentifier CreateInstance (CreateInstanceRequest? createInstanceRequest = null)

[EXPERIMENTAL] CreateInstance: Create a single integration instance.

<br>Creates a new instance of an integration, returning its identifier.  <br />  <br />  <br>The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class CreateInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var createInstanceRequest = new CreateInstanceRequest?(); // CreateInstanceRequest? | The new integration instance. (optional) 

            try
            {
                // [EXPERIMENTAL] CreateInstance: Create a single integration instance.
                InstanceIdentifier result = apiInstance.CreateInstance(createInstanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.CreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationsApi.CreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createInstanceRequest** | [**CreateInstanceRequest?**](CreateInstanceRequest?.md) | The new integration instance. | [optional]  |

### Return type

[**InstanceIdentifier**](InstanceIdentifier.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Identifier of the created instance. |  -  |
| **404** | The integration type does not exist. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteinstance"></a>
# **DeleteInstance**
> void DeleteInstance (string instanceId)

[EXPERIMENTAL] DeleteInstance: Delete a single integration instance.

<br>Deletes an existing instance of an integration, returning its identifier.  <br />  <br />  <br>The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class DeleteInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var instanceId = "instanceId_example";  // string | Instance identifier e.g. \"b64135e7-98a0-41af-a845-d86167d54cc7\".

            try
            {
                // [EXPERIMENTAL] DeleteInstance: Delete a single integration instance.
                apiInstance.DeleteInstance(instanceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Print("Exception when calling IntegrationsApi.DeleteInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | Instance identifier e.g. \&quot;b64135e7-98a0-41af-a845-d86167d54cc7\&quot;. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The instance was deleted. |  -  |
| **404** | The instance does not exist. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="executeinstance"></a>
# **ExecuteInstance**
> ExecuteInstanceResponse ExecuteInstance (string instanceId)

[EXPERIMENTAL] ExecuteInstance: Execute an integration instance.

<br>Starts execution of an instance, returning its execution identifier.  <br />  <br />  <br>The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class ExecuteInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var instanceId = "instanceId_example";  // string | Instance identifier e.g. \"b64135e7-98a0-41af-a845-d86167d54cc7\".

            try
            {
                // [EXPERIMENTAL] ExecuteInstance: Execute an integration instance.
                ExecuteInstanceResponse result = apiInstance.ExecuteInstance(instanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.ExecuteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationsApi.ExecuteInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | Instance identifier e.g. \&quot;b64135e7-98a0-41af-a845-d86167d54cc7\&quot;. |  |

### Return type

[**ExecuteInstanceResponse**](ExecuteInstanceResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The execution id |  -  |
| **404** | The integration instance does not exist |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getschema"></a>
# **GetSchema**
> string GetSchema (string integration)

[EXPERIMENTAL] GetSchema: Get the JSON schema for the details section of an integration instance.

<br>The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class GetSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var integration = "integration_example";  // string | The type of the integration e.g. \"copp-clark\".

            try
            {
                // [EXPERIMENTAL] GetSchema: Get the JSON schema for the details section of an integration instance.
                string result = apiInstance.GetSchema(integration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    ApiResponse<string> response = apiInstance.GetSchemaWithHttpInfo(integration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationsApi.GetSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **integration** | **string** | The type of the integration e.g. \&quot;copp-clark\&quot;. |  |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The system defined JSON schema for the details of a specified integration. |  -  |
| **404** | The integration type does not exist or is not enabled. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listinstances"></a>
# **ListInstances**
> IntegrationInstance ListInstances ()

[EXPERIMENTAL] ListInstances: List instances across all integrations.

<br>The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class ListInstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi(config);

            try
            {
                // [EXPERIMENTAL] ListInstances: List instances across all integrations.
                IntegrationInstance result = apiInstance.ListInstances();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.ListInstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    ApiResponse<IntegrationInstance> response = apiInstance.ListInstancesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationsApi.ListInstancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**IntegrationInstance**](IntegrationInstance.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | The requested instance(s) do not exist. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listintegrations"></a>
# **ListIntegrations**
> List&lt;IntegrationDescription&gt; ListIntegrations ()

[EXPERIMENTAL] ListIntegrations: List available integrations.

<br>List all available integrations.  <br />  <br>    ```\"licensed\"``` indicates your domain is licensed to use this integration. To request a licence              contact your [FINBOURNE sales representative](https://www.finbourne.com/contact/).  <br />  <br>Any authenticated user can call this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class ListIntegrationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi(config);

            try
            {
                // [EXPERIMENTAL] ListIntegrations: List available integrations.
                List<IntegrationDescription> result = apiInstance.ListIntegrations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.ListIntegrations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationsApi.ListIntegrationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;IntegrationDescription&gt;**](IntegrationDescription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateinstance"></a>
# **UpdateInstance**
> void UpdateInstance (string instanceId, UpdateInstanceRequest? updateInstanceRequest = null)

[EXPERIMENTAL] UpdateInstance: Update a single integration instance.

<br>Updates an existing instance of an integration, returning its identifier.  <br />  <br />  <br>The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class UpdateInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationsApi(config);
            var instanceId = "instanceId_example";  // string | Instance identifier e.g. \"b64135e7-98a0-41af-a845-d86167d54cc7\".
            var updateInstanceRequest = new UpdateInstanceRequest?(); // UpdateInstanceRequest? | The new integration instance. (optional) 

            try
            {
                // [EXPERIMENTAL] UpdateInstance: Update a single integration instance.
                apiInstance.UpdateInstance(instanceId, updateInstanceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.UpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Print("Exception when calling IntegrationsApi.UpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | Instance identifier e.g. \&quot;b64135e7-98a0-41af-a845-d86167d54cc7\&quot;. |  |
| **updateInstanceRequest** | [**UpdateInstanceRequest?**](UpdateInstanceRequest?.md) | The new integration instance. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The instance was updated. |  -  |
| **404** | The instance does not exist. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


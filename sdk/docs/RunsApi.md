# Finbourne.Horizon.Sdk.Api.RunsApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelInstance**](RunsApi.md#cancelinstance) | **PUT** /api/runs/{runId}/cancel | [EXPERIMENTAL] CancelInstance: Cancels a single instance execution. |
| [**GetRunResults**](RunsApi.md#getrunresults) | **GET** /api/runs | [EXPERIMENTAL] GetRunResults: Get run results |
| [**RerunInstance**](RunsApi.md#reruninstance) | **PUT** /api/runs/{runId}/rerun | [EXPERIMENTAL] RerunInstance: Reruns a single instance execution. |

<a id="cancelinstance"></a>
# **CancelInstance**
> Object CancelInstance (string runId)

[EXPERIMENTAL] CancelInstance: Cancels a single instance execution.

<br>Cancels an execution instance of an integration.  <br />  <br />  <br>The execution instance must be queued, the user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RunsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RunsApi>();
            var runId = "runId_example";  // string | Run identifier e.g. \"b64135e7-98a0-41af-a845-d86167d54cc7\".

            try
            {
                // uncomment the below to set overrides at the request level
                // Object result = apiInstance.CancelInstance(runId, opts: opts);

                // [EXPERIMENTAL] CancelInstance: Cancels a single instance execution.
                Object result = apiInstance.CancelInstance(runId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RunsApi.CancelInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CancelInstance: Cancels a single instance execution.
    ApiResponse<Object> response = apiInstance.CancelInstanceWithHttpInfo(runId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RunsApi.CancelInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | Run identifier e.g. \&quot;b64135e7-98a0-41af-a845-d86167d54cc7\&quot;. |  |

### Return type

**Object**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The instance was cancelled. |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The execution does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getrunresults"></a>
# **GetRunResults**
> PagedResourceListOfIntegrationRunResponse GetRunResults (string? filter = null, List<string>? sortBy = null, int? limit = null, string? pageToken = null)

[EXPERIMENTAL] GetRunResults: Get run results

Get run results

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RunsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RunsApi>();
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 100;  // int? | When paginating, limit the results to this number. (optional)  (default to 100)
            var pageToken = "\"\"";  // string? | The pagination token to use to continue listing integration runs; this value is returned from              the previous call. If a pagination token is provided, the <i>sortBy</i> and <i>filter</i> fields must not have changed since the original request. (optional)  (default to "")

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfIntegrationRunResponse result = apiInstance.GetRunResults(filter, sortBy, limit, pageToken, opts: opts);

                // [EXPERIMENTAL] GetRunResults: Get run results
                PagedResourceListOfIntegrationRunResponse result = apiInstance.GetRunResults(filter, sortBy, limit, pageToken);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RunsApi.GetRunResults: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunResultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetRunResults: Get run results
    ApiResponse<PagedResourceListOfIntegrationRunResponse> response = apiInstance.GetRunResultsWithHttpInfo(filter, sortBy, limit, pageToken);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RunsApi.GetRunResultsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** | Expression to filter the result set. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. | [optional] [default to 100] |
| **pageToken** | **string?** | The pagination token to use to continue listing integration runs; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt; and &lt;i&gt;filter&lt;/i&gt; fields must not have changed since the original request. | [optional] [default to &quot;&quot;] |

### Return type

[**PagedResourceListOfIntegrationRunResponse**](PagedResourceListOfIntegrationRunResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Not Found |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="reruninstance"></a>
# **RerunInstance**
> IntegrationRerunResponse RerunInstance (string runId)

[EXPERIMENTAL] RerunInstance: Reruns a single instance execution.

<br>Reruns an execution instance of an integration.  <br />  <br />  <br>The user must be authenticated, entitled to call this method, and the user's domain must be licensed for the integration.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RunsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RunsApi>();
            var runId = "runId_example";  // string | Run identifier e.g. \"b64135e7-98a0-41af-a845-d86167d54cc7\".

            try
            {
                // uncomment the below to set overrides at the request level
                // IntegrationRerunResponse result = apiInstance.RerunInstance(runId, opts: opts);

                // [EXPERIMENTAL] RerunInstance: Reruns a single instance execution.
                IntegrationRerunResponse result = apiInstance.RerunInstance(runId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RunsApi.RerunInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RerunInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RerunInstance: Reruns a single instance execution.
    ApiResponse<IntegrationRerunResponse> response = apiInstance.RerunInstanceWithHttpInfo(runId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RunsApi.RerunInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | Run identifier e.g. \&quot;b64135e7-98a0-41af-a845-d86167d54cc7\&quot;. |  |

### Return type

[**IntegrationRerunResponse**](IntegrationRerunResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The instance was rerun. |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The execution does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


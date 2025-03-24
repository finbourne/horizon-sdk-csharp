# Finbourne.Horizon.Sdk.Api.LogsApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetIntegrationLogResults**](LogsApi.md#getintegrationlogresults) | **GET** /api/logs | [EXPERIMENTAL] GetIntegrationLogResults: Get integration log results |
| [**InsertExternalLogs**](LogsApi.md#insertexternallogs) | **POST** /api/logs/{instanceid}/{runid} | [EXPERIMENTAL] InsertExternalLogs: Inserts external logs into the specified ExternalApp Integration instance execution |

<a id="getintegrationlogresults"></a>
# **GetIntegrationLogResults**
> PagedResourceListOfIIntegrationLogResponse GetIntegrationLogResults (string? filter = null, List<string>? sortBy = null, int? limit = null, string? pageToken = null)

[EXPERIMENTAL] GetIntegrationLogResults: Get integration log results

Get integration log results

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<LogsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<LogsApi>();
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 100;  // int? | When paginating, limit the results to this number. (optional)  (default to 100)
            var pageToken = "\"\"";  // string? | The pagination token to use to continue listing integration logs; this value is returned from              the previous call. If a pagination token is provided, the <i>sortBy</i> and <i>filter</i> fields must not have changed since the original request.              For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional)  (default to "")

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfIIntegrationLogResponse result = apiInstance.GetIntegrationLogResults(filter, sortBy, limit, pageToken, opts: opts);

                // [EXPERIMENTAL] GetIntegrationLogResults: Get integration log results
                PagedResourceListOfIIntegrationLogResponse result = apiInstance.GetIntegrationLogResults(filter, sortBy, limit, pageToken);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LogsApi.GetIntegrationLogResults: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIntegrationLogResultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetIntegrationLogResults: Get integration log results
    ApiResponse<PagedResourceListOfIIntegrationLogResponse> response = apiInstance.GetIntegrationLogResultsWithHttpInfo(filter, sortBy, limit, pageToken);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling LogsApi.GetIntegrationLogResultsWithHttpInfo: " + e.Message);
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
| **pageToken** | **string?** | The pagination token to use to continue listing integration logs; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt; and &lt;i&gt;filter&lt;/i&gt; fields must not have changed since the original request.              For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. | [optional] [default to &quot;&quot;] |

### Return type

[**PagedResourceListOfIIntegrationLogResponse**](PagedResourceListOfIIntegrationLogResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Not Found |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="insertexternallogs"></a>
# **InsertExternalLogs**
> Object InsertExternalLogs (string instanceid, string runid, ExternalLogInsertionRequest externalLogInsertionRequest)

[EXPERIMENTAL] InsertExternalLogs: Inserts external logs into the specified ExternalApp Integration instance execution

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<LogsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<LogsApi>();
            var instanceid = "instanceid_example";  // string | 
            var runid = "runid_example";  // string | 
            var externalLogInsertionRequest = new ExternalLogInsertionRequest(); // ExternalLogInsertionRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // Object result = apiInstance.InsertExternalLogs(instanceid, runid, externalLogInsertionRequest, opts: opts);

                // [EXPERIMENTAL] InsertExternalLogs: Inserts external logs into the specified ExternalApp Integration instance execution
                Object result = apiInstance.InsertExternalLogs(instanceid, runid, externalLogInsertionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LogsApi.InsertExternalLogs: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the InsertExternalLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] InsertExternalLogs: Inserts external logs into the specified ExternalApp Integration instance execution
    ApiResponse<Object> response = apiInstance.InsertExternalLogsWithHttpInfo(instanceid, runid, externalLogInsertionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling LogsApi.InsertExternalLogsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceid** | **string** |  |  |
| **runid** | **string** |  |  |
| **externalLogInsertionRequest** | [**ExternalLogInsertionRequest**](ExternalLogInsertionRequest.md) |  |  |

### Return type

**Object**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


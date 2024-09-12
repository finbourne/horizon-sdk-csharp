# Finbourne.Horizon.Sdk.Api.RunsApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRunResults**](RunsApi.md#getrunresults) | **GET** /api/runs | [EXPERIMENTAL] GetRunResults:  |

<a id="getrunresults"></a>
# **GetRunResults**
> IntegrationRunResponse GetRunResults (string? filter = null, List<string>? sortBy = null, int? limit = null, string? pageToken = null)

[EXPERIMENTAL] GetRunResults: 

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RunsApi>();
            var filter = "filter_example";  // string? |  (optional) 
            var sortBy = new List<string>?(); // List<string>? |  (optional) 
            var limit = 10;  // int? |  (optional)  (default to 10)
            var pageToken = "\"\"";  // string? |  (optional)  (default to "")

            try
            {
                // [EXPERIMENTAL] GetRunResults: 
                IntegrationRunResponse result = apiInstance.GetRunResults(filter, sortBy, limit, pageToken);
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
    // [EXPERIMENTAL] GetRunResults: 
    ApiResponse<IntegrationRunResponse> response = apiInstance.GetRunResultsWithHttpInfo(filter, sortBy, limit, pageToken);
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
| **filter** | **string?** |  | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **limit** | **int?** |  | [optional] [default to 10] |
| **pageToken** | **string?** |  | [optional] [default to &quot;&quot;] |

### Return type

[**IntegrationRunResponse**](IntegrationRunResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


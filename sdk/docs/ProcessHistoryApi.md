# Finbourne.Horizon.Sdk.Api.ProcessHistoryApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCompleteEvent**](ProcessHistoryApi.md#createcompleteevent) | **POST** /api/process-history/event/complete | [EARLY ACCESS] CreateCompleteEvent: Write a completed event to the Horizon Dashboard |
| [**CreateUpdateEvent**](ProcessHistoryApi.md#createupdateevent) | **POST** /api/process-history/event/update | [EARLY ACCESS] CreateUpdateEvent: Write an update event to the Horizon Dashboard |
| [**GetLatestRuns**](ProcessHistoryApi.md#getlatestruns) | **GET** /api/process-history/$latestRuns | [EARLY ACCESS] GetLatestRuns: Get latest run for each process |
| [**ProcessEntryUpdates**](ProcessHistoryApi.md#processentryupdates) | **POST** /api/process-history/entries/$query | [EARLY ACCESS] ProcessEntryUpdates: Get process entry updates for a query |
| [**ProcessHistoryEntries**](ProcessHistoryApi.md#processhistoryentries) | **POST** /api/process-history/$query | [EARLY ACCESS] ProcessHistoryEntries: Get process history entries |

<a id="createcompleteevent"></a>
# **CreateCompleteEvent**
> AuditCompleteResponse CreateCompleteEvent (AuditCompleteRequest auditCompleteRequest)

[EARLY ACCESS] CreateCompleteEvent: Write a completed event to the Horizon Dashboard

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessHistoryApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessHistoryApi>();
            var auditCompleteRequest = new AuditCompleteRequest(); // AuditCompleteRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // AuditCompleteResponse result = apiInstance.CreateCompleteEvent(auditCompleteRequest, opts: opts);

                // [EARLY ACCESS] CreateCompleteEvent: Write a completed event to the Horizon Dashboard
                AuditCompleteResponse result = apiInstance.CreateCompleteEvent(auditCompleteRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessHistoryApi.CreateCompleteEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCompleteEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateCompleteEvent: Write a completed event to the Horizon Dashboard
    ApiResponse<AuditCompleteResponse> response = apiInstance.CreateCompleteEventWithHttpInfo(auditCompleteRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessHistoryApi.CreateCompleteEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auditCompleteRequest** | [**AuditCompleteRequest**](AuditCompleteRequest.md) |  |  |

### Return type

[**AuditCompleteResponse**](AuditCompleteResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createupdateevent"></a>
# **CreateUpdateEvent**
> AuditUpdateResponse CreateUpdateEvent (AuditUpdateRequest auditUpdateRequest)

[EARLY ACCESS] CreateUpdateEvent: Write an update event to the Horizon Dashboard

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessHistoryApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessHistoryApi>();
            var auditUpdateRequest = new AuditUpdateRequest(); // AuditUpdateRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // AuditUpdateResponse result = apiInstance.CreateUpdateEvent(auditUpdateRequest, opts: opts);

                // [EARLY ACCESS] CreateUpdateEvent: Write an update event to the Horizon Dashboard
                AuditUpdateResponse result = apiInstance.CreateUpdateEvent(auditUpdateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessHistoryApi.CreateUpdateEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUpdateEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateUpdateEvent: Write an update event to the Horizon Dashboard
    ApiResponse<AuditUpdateResponse> response = apiInstance.CreateUpdateEventWithHttpInfo(auditUpdateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessHistoryApi.CreateUpdateEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auditUpdateRequest** | [**AuditUpdateRequest**](AuditUpdateRequest.md) |  |  |

### Return type

[**AuditUpdateResponse**](AuditUpdateResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getlatestruns"></a>
# **GetLatestRuns**
> List&lt;ProcessInformation&gt; GetLatestRuns ()

[EARLY ACCESS] GetLatestRuns: Get latest run for each process

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessHistoryApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessHistoryApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // List<ProcessInformation> result = apiInstance.GetLatestRuns(opts: opts);

                // [EARLY ACCESS] GetLatestRuns: Get latest run for each process
                List<ProcessInformation> result = apiInstance.GetLatestRuns();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessHistoryApi.GetLatestRuns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLatestRunsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetLatestRuns: Get latest run for each process
    ApiResponse<List<ProcessInformation>> response = apiInstance.GetLatestRunsWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessHistoryApi.GetLatestRunsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ProcessInformation&gt;**](ProcessInformation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="processentryupdates"></a>
# **ProcessEntryUpdates**
> PagedResourceListOfProcessUpdateResult ProcessEntryUpdates (string runId, QueryRequest queryRequest)

[EARLY ACCESS] ProcessEntryUpdates: Get process entry updates for a query

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessHistoryApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessHistoryApi>();
            var runId = "runId_example";  // string | 
            var queryRequest = new QueryRequest(); // QueryRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfProcessUpdateResult result = apiInstance.ProcessEntryUpdates(runId, queryRequest, opts: opts);

                // [EARLY ACCESS] ProcessEntryUpdates: Get process entry updates for a query
                PagedResourceListOfProcessUpdateResult result = apiInstance.ProcessEntryUpdates(runId, queryRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessHistoryApi.ProcessEntryUpdates: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProcessEntryUpdatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ProcessEntryUpdates: Get process entry updates for a query
    ApiResponse<PagedResourceListOfProcessUpdateResult> response = apiInstance.ProcessEntryUpdatesWithHttpInfo(runId, queryRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessHistoryApi.ProcessEntryUpdatesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** |  |  |
| **queryRequest** | [**QueryRequest**](QueryRequest.md) |  |  |

### Return type

[**PagedResourceListOfProcessUpdateResult**](PagedResourceListOfProcessUpdateResult.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="processhistoryentries"></a>
# **ProcessHistoryEntries**
> PagedResourceListOfProcessInformation ProcessHistoryEntries (QueryRequest queryRequest, string? processName = null)

[EARLY ACCESS] ProcessHistoryEntries: Get process history entries

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessHistoryApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessHistoryApi>();
            var queryRequest = new QueryRequest(); // QueryRequest | 
            var processName = "processName_example";  // string? |  (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfProcessInformation result = apiInstance.ProcessHistoryEntries(queryRequest, processName, opts: opts);

                // [EARLY ACCESS] ProcessHistoryEntries: Get process history entries
                PagedResourceListOfProcessInformation result = apiInstance.ProcessHistoryEntries(queryRequest, processName);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessHistoryApi.ProcessHistoryEntries: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProcessHistoryEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ProcessHistoryEntries: Get process history entries
    ApiResponse<PagedResourceListOfProcessInformation> response = apiInstance.ProcessHistoryEntriesWithHttpInfo(queryRequest, processName);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessHistoryApi.ProcessHistoryEntriesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryRequest** | [**QueryRequest**](QueryRequest.md) |  |  |
| **processName** | **string?** |  | [optional]  |

### Return type

[**PagedResourceListOfProcessInformation**](PagedResourceListOfProcessInformation.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


# Finbourne.Horizon.Sdk.Api.TradePublicationFrameworkApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTpfTransactionHistorySearch**](TradePublicationFrameworkApi.md#gettpftransactionhistorysearch) | **GET** /api/trade-publication-framework/transactions/search | [EXPERIMENTAL] GetTpfTransactionHistorySearch: Endpoint to search TPF transaction by transaction ID and/or instrument identifier, with filtering by instance and date range |
| [**GetTransactionPayload**](TradePublicationFrameworkApi.md#gettransactionpayload) | **GET** /api/trade-publication-framework/instances/{instanceId}/runs/{runId}/transactions/{transactionId}/payload | [EXPERIMENTAL] GetTransactionPayload: Transaction payload detail |
| [**ListInstanceRunHistory**](TradePublicationFrameworkApi.md#listinstancerunhistory) | **GET** /api/trade-publication-framework/instances/{instanceId}/runs | [EXPERIMENTAL] ListInstanceRunHistory: List run history for a given TPF instance, with pagination support. |
| [**ListInstancesWithStatus**](TradePublicationFrameworkApi.md#listinstanceswithstatus) | **GET** /api/trade-publication-framework/instances | [EXPERIMENTAL] ListInstancesWithStatus: Lists all instances of the Trade Publication Framework (TPF). |
| [**ListRunFiles**](TradePublicationFrameworkApi.md#listrunfiles) | **GET** /api/trade-publication-framework/instances/{instanceId}/runs/{runId}/files | [EXPERIMENTAL] ListRunFiles: List Files in a run |
| [**ListRunTransactions**](TradePublicationFrameworkApi.md#listruntransactions) | **GET** /api/trade-publication-framework/instances/{instanceId}/runs/{runId}/transactions | [EXPERIMENTAL] ListRunTransactions: List Transactions in a run. |

<a id="gettpftransactionhistorysearch"></a>
# **GetTpfTransactionHistorySearch**
> PagedResourceListOfTpfTransactionSearchResponse GetTpfTransactionHistorySearch (string? transactionId = null, string? instrumentId = null, string? dateFrom = null, string? dateTo = null, string? status = null, string? instanceId = null, int? pageSize = null, string? pageToken = null)

[EXPERIMENTAL] GetTpfTransactionHistorySearch: Endpoint to search TPF transaction by transaction ID and/or instrument identifier, with filtering by instance and date range

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TradePublicationFrameworkApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TradePublicationFrameworkApi>();
            var transactionId = "transactionId_example";  // string? |  (optional) 
            var instrumentId = "instrumentId_example";  // string? |  (optional) 
            var dateFrom = "dateFrom_example";  // string? |  (optional) 
            var dateTo = "dateTo_example";  // string? |  (optional) 
            var status = "status_example";  // string? |  (optional) 
            var instanceId = "instanceId_example";  // string? |  (optional) 
            var pageSize = 400;  // int? |  (optional)  (default to 400)
            var pageToken = "\"\"";  // string? |  (optional)  (default to "")

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfTpfTransactionSearchResponse result = apiInstance.GetTpfTransactionHistorySearch(transactionId, instrumentId, dateFrom, dateTo, status, instanceId, pageSize, pageToken, opts: opts);

                // [EXPERIMENTAL] GetTpfTransactionHistorySearch: Endpoint to search TPF transaction by transaction ID and/or instrument identifier, with filtering by instance and date range
                PagedResourceListOfTpfTransactionSearchResponse result = apiInstance.GetTpfTransactionHistorySearch(transactionId, instrumentId, dateFrom, dateTo, status, instanceId, pageSize, pageToken);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TradePublicationFrameworkApi.GetTpfTransactionHistorySearch: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTpfTransactionHistorySearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTpfTransactionHistorySearch: Endpoint to search TPF transaction by transaction ID and/or instrument identifier, with filtering by instance and date range
    ApiResponse<PagedResourceListOfTpfTransactionSearchResponse> response = apiInstance.GetTpfTransactionHistorySearchWithHttpInfo(transactionId, instrumentId, dateFrom, dateTo, status, instanceId, pageSize, pageToken);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TradePublicationFrameworkApi.GetTpfTransactionHistorySearchWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string?** |  | [optional]  |
| **instrumentId** | **string?** |  | [optional]  |
| **dateFrom** | **string?** |  | [optional]  |
| **dateTo** | **string?** |  | [optional]  |
| **status** | **string?** |  | [optional]  |
| **instanceId** | **string?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional] [default to 400] |
| **pageToken** | **string?** |  | [optional] [default to &quot;&quot;] |

### Return type

[**PagedResourceListOfTpfTransactionSearchResponse**](PagedResourceListOfTpfTransactionSearchResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettransactionpayload"></a>
# **GetTransactionPayload**
> TransactionPayloadResponse GetTransactionPayload (string instanceId, string runId, string transactionId)

[EXPERIMENTAL] GetTransactionPayload: Transaction payload detail

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TradePublicationFrameworkApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TradePublicationFrameworkApi>();
            var instanceId = "instanceId_example";  // string | 
            var runId = "runId_example";  // string | 
            var transactionId = "transactionId_example";  // string | 

            try
            {
                // uncomment the below to set overrides at the request level
                // TransactionPayloadResponse result = apiInstance.GetTransactionPayload(instanceId, runId, transactionId, opts: opts);

                // [EXPERIMENTAL] GetTransactionPayload: Transaction payload detail
                TransactionPayloadResponse result = apiInstance.GetTransactionPayload(instanceId, runId, transactionId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TradePublicationFrameworkApi.GetTransactionPayload: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionPayloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTransactionPayload: Transaction payload detail
    ApiResponse<TransactionPayloadResponse> response = apiInstance.GetTransactionPayloadWithHttpInfo(instanceId, runId, transactionId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TradePublicationFrameworkApi.GetTransactionPayloadWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** |  |  |
| **runId** | **string** |  |  |
| **transactionId** | **string** |  |  |

### Return type

[**TransactionPayloadResponse**](TransactionPayloadResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The requested TPF instance, run, or transaction payload does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listinstancerunhistory"></a>
# **ListInstanceRunHistory**
> PagedResourceListOfInstanceRunResponse ListInstanceRunHistory (string instanceId, string? page = null, int? pageSize = null)

[EXPERIMENTAL] ListInstanceRunHistory: List run history for a given TPF instance, with pagination support.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TradePublicationFrameworkApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TradePublicationFrameworkApi>();
            var instanceId = "instanceId_example";  // string | 
            var page = "\"\"";  // string? |  (optional)  (default to "")
            var pageSize = 100;  // int? |  (optional)  (default to 100)

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfInstanceRunResponse result = apiInstance.ListInstanceRunHistory(instanceId, page, pageSize, opts: opts);

                // [EXPERIMENTAL] ListInstanceRunHistory: List run history for a given TPF instance, with pagination support.
                PagedResourceListOfInstanceRunResponse result = apiInstance.ListInstanceRunHistory(instanceId, page, pageSize);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TradePublicationFrameworkApi.ListInstanceRunHistory: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInstanceRunHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListInstanceRunHistory: List run history for a given TPF instance, with pagination support.
    ApiResponse<PagedResourceListOfInstanceRunResponse> response = apiInstance.ListInstanceRunHistoryWithHttpInfo(instanceId, page, pageSize);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TradePublicationFrameworkApi.ListInstanceRunHistoryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** |  |  |
| **page** | **string?** |  | [optional] [default to &quot;&quot;] |
| **pageSize** | **int?** |  | [optional] [default to 100] |

### Return type

[**PagedResourceListOfInstanceRunResponse**](PagedResourceListOfInstanceRunResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listinstanceswithstatus"></a>
# **ListInstancesWithStatus**
> InstancesResponse ListInstancesWithStatus ()

[EXPERIMENTAL] ListInstancesWithStatus: Lists all instances of the Trade Publication Framework (TPF).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TradePublicationFrameworkApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TradePublicationFrameworkApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // InstancesResponse result = apiInstance.ListInstancesWithStatus(opts: opts);

                // [EXPERIMENTAL] ListInstancesWithStatus: Lists all instances of the Trade Publication Framework (TPF).
                InstancesResponse result = apiInstance.ListInstancesWithStatus();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TradePublicationFrameworkApi.ListInstancesWithStatus: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInstancesWithStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListInstancesWithStatus: Lists all instances of the Trade Publication Framework (TPF).
    ApiResponse<InstancesResponse> response = apiInstance.ListInstancesWithStatusWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TradePublicationFrameworkApi.ListInstancesWithStatusWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InstancesResponse**](InstancesResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listrunfiles"></a>
# **ListRunFiles**
> PagedResourceListOfRunFileResponse ListRunFiles (string instanceId, string runId, string? page = null, int? pageSize = null)

[EXPERIMENTAL] ListRunFiles: List Files in a run

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TradePublicationFrameworkApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TradePublicationFrameworkApi>();
            var instanceId = "instanceId_example";  // string | 
            var runId = "runId_example";  // string | 
            var page = "\"\"";  // string? |  (optional)  (default to "")
            var pageSize = 100;  // int? |  (optional)  (default to 100)

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfRunFileResponse result = apiInstance.ListRunFiles(instanceId, runId, page, pageSize, opts: opts);

                // [EXPERIMENTAL] ListRunFiles: List Files in a run
                PagedResourceListOfRunFileResponse result = apiInstance.ListRunFiles(instanceId, runId, page, pageSize);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TradePublicationFrameworkApi.ListRunFiles: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRunFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListRunFiles: List Files in a run
    ApiResponse<PagedResourceListOfRunFileResponse> response = apiInstance.ListRunFilesWithHttpInfo(instanceId, runId, page, pageSize);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TradePublicationFrameworkApi.ListRunFilesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** |  |  |
| **runId** | **string** |  |  |
| **page** | **string?** |  | [optional] [default to &quot;&quot;] |
| **pageSize** | **int?** |  | [optional] [default to 100] |

### Return type

[**PagedResourceListOfRunFileResponse**](PagedResourceListOfRunFileResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The requested TPF instance or run does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listruntransactions"></a>
# **ListRunTransactions**
> PagedResourceListOfTransactionResponse ListRunTransactions (string instanceId, string runId, string status, string? page = null, int? pageSize = null)

[EXPERIMENTAL] ListRunTransactions: List Transactions in a run.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TradePublicationFrameworkApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TradePublicationFrameworkApi>();
            var instanceId = "instanceId_example";  // string | 
            var runId = "runId_example";  // string | 
            var status = "status_example";  // string | 
            var page = "\"\"";  // string? |  (optional)  (default to "")
            var pageSize = 100;  // int? |  (optional)  (default to 100)

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfTransactionResponse result = apiInstance.ListRunTransactions(instanceId, runId, status, page, pageSize, opts: opts);

                // [EXPERIMENTAL] ListRunTransactions: List Transactions in a run.
                PagedResourceListOfTransactionResponse result = apiInstance.ListRunTransactions(instanceId, runId, status, page, pageSize);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TradePublicationFrameworkApi.ListRunTransactions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRunTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListRunTransactions: List Transactions in a run.
    ApiResponse<PagedResourceListOfTransactionResponse> response = apiInstance.ListRunTransactionsWithHttpInfo(instanceId, runId, status, page, pageSize);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TradePublicationFrameworkApi.ListRunTransactionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** |  |  |
| **runId** | **string** |  |  |
| **status** | **string** |  |  |
| **page** | **string?** |  | [optional] [default to &quot;&quot;] |
| **pageSize** | **int?** |  | [optional] [default to 100] |

### Return type

[**PagedResourceListOfTransactionResponse**](PagedResourceListOfTransactionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | The requested TPF instance or run does not exist. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


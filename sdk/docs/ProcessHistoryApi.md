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
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class CreateCompleteEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessHistoryApi(config);
            var auditCompleteRequest = new AuditCompleteRequest(); // AuditCompleteRequest | 

            try
            {
                // [EARLY ACCESS] CreateCompleteEvent: Write a completed event to the Horizon Dashboard
                AuditCompleteResponse result = apiInstance.CreateCompleteEvent(auditCompleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessHistoryApi.CreateCompleteEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessHistoryApi.CreateCompleteEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auditCompleteRequest** | [**AuditCompleteRequest**](AuditCompleteRequest.md) |  |  |

### Return type

[**AuditCompleteResponse**](AuditCompleteResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createupdateevent"></a>
# **CreateUpdateEvent**
> AuditUpdateResponse CreateUpdateEvent (AuditUpdateRequest auditUpdateRequest)

[EARLY ACCESS] CreateUpdateEvent: Write an update event to the Horizon Dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class CreateUpdateEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessHistoryApi(config);
            var auditUpdateRequest = new AuditUpdateRequest(); // AuditUpdateRequest | 

            try
            {
                // [EARLY ACCESS] CreateUpdateEvent: Write an update event to the Horizon Dashboard
                AuditUpdateResponse result = apiInstance.CreateUpdateEvent(auditUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessHistoryApi.CreateUpdateEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessHistoryApi.CreateUpdateEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auditUpdateRequest** | [**AuditUpdateRequest**](AuditUpdateRequest.md) |  |  |

### Return type

[**AuditUpdateResponse**](AuditUpdateResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlatestruns"></a>
# **GetLatestRuns**
> List&lt;ProcessInformation&gt; GetLatestRuns ()

[EARLY ACCESS] GetLatestRuns: Get latest run for each process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class GetLatestRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessHistoryApi(config);

            try
            {
                // [EARLY ACCESS] GetLatestRuns: Get latest run for each process
                List<ProcessInformation> result = apiInstance.GetLatestRuns();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessHistoryApi.GetLatestRuns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessHistoryApi.GetLatestRunsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ProcessInformation&gt;**](ProcessInformation.md)

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

<a id="processentryupdates"></a>
# **ProcessEntryUpdates**
> PagedResourceListOfProcessUpdateResult ProcessEntryUpdates (QueryRequest queryRequest)

[EARLY ACCESS] ProcessEntryUpdates: Get process entry updates for a query

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class ProcessEntryUpdatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessHistoryApi(config);
            var queryRequest = new QueryRequest(); // QueryRequest | 

            try
            {
                // [EARLY ACCESS] ProcessEntryUpdates: Get process entry updates for a query
                PagedResourceListOfProcessUpdateResult result = apiInstance.ProcessEntryUpdates(queryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessHistoryApi.ProcessEntryUpdates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    ApiResponse<PagedResourceListOfProcessUpdateResult> response = apiInstance.ProcessEntryUpdatesWithHttpInfo(queryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessHistoryApi.ProcessEntryUpdatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryRequest** | [**QueryRequest**](QueryRequest.md) |  |  |

### Return type

[**PagedResourceListOfProcessUpdateResult**](PagedResourceListOfProcessUpdateResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="processhistoryentries"></a>
# **ProcessHistoryEntries**
> PagedResourceListOfProcessInformation ProcessHistoryEntries (QueryRequest queryRequest)

[EARLY ACCESS] ProcessHistoryEntries: Get process history entries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class ProcessHistoryEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessHistoryApi(config);
            var queryRequest = new QueryRequest(); // QueryRequest | 

            try
            {
                // [EARLY ACCESS] ProcessHistoryEntries: Get process history entries
                PagedResourceListOfProcessInformation result = apiInstance.ProcessHistoryEntries(queryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessHistoryApi.ProcessHistoryEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    ApiResponse<PagedResourceListOfProcessInformation> response = apiInstance.ProcessHistoryEntriesWithHttpInfo(queryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessHistoryApi.ProcessHistoryEntriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryRequest** | [**QueryRequest**](QueryRequest.md) |  |  |

### Return type

[**PagedResourceListOfProcessInformation**](PagedResourceListOfProcessInformation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


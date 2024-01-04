# Finbourne.Horizon.Sdk.Api.InstrumentApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateInstrument**](InstrumentApi.md#createinstrument) | **POST** /api/instrument/onboarding/create | [EARLY ACCESS] CreateInstrument: Creates and masters instruments with third party vendors. |
| [**EnrichInstrument**](InstrumentApi.md#enrichinstrument) | **POST** /api/instrument/onboarding/enrich | [EARLY ACCESS] EnrichInstrument: Enriches an existing LUSID instrument using vendor data. Enrichment included identifiers, properties and market data. |
| [**GetOpenFigiParameterOption**](InstrumentApi.md#getopenfigiparameteroption) | **GET** /api/instrument/onboarding/search/openfigi/parameterOptions | [EARLY ACCESS] GetOpenFigiParameterOption: Get all supported market sector values for OpenFigi search |
| [**RetrievePermIdResult**](InstrumentApi.md#retrievepermidresult) | **GET** /api/instrument/onboarding/search/permid/{id} | [EARLY ACCESS] RetrievePermIdResult: Retrieve PermId results from a previous query. |
| [**SearchOpenFigi**](InstrumentApi.md#searchopenfigi) | **GET** /api/instrument/onboarding/search/openfigi | [EARLY ACCESS] SearchOpenFigi: Search OpenFigi for instruments that match the specified terms. |
| [**Vendors**](InstrumentApi.md#vendors) | **GET** /api/instrument/onboarding/vendors | [EARLY ACCESS] Vendors: Gets the VendorProducts of any supported and licenced integrations for a given market sector and security type. |

<a id="createinstrument"></a>
# **CreateInstrument**
> OnboardInstrumentResponse CreateInstrument (OnboardInstrumentRequest onboardInstrumentRequest)

[EARLY ACCESS] CreateInstrument: Creates and masters instruments with third party vendors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class CreateInstrumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var onboardInstrumentRequest = new OnboardInstrumentRequest(); // OnboardInstrumentRequest | 

            try
            {
                // [EARLY ACCESS] CreateInstrument: Creates and masters instruments with third party vendors.
                OnboardInstrumentResponse result = apiInstance.CreateInstrument(onboardInstrumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.CreateInstrument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInstrumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateInstrument: Creates and masters instruments with third party vendors.
    ApiResponse<OnboardInstrumentResponse> response = apiInstance.CreateInstrumentWithHttpInfo(onboardInstrumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentApi.CreateInstrumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **onboardInstrumentRequest** | [**OnboardInstrumentRequest**](OnboardInstrumentRequest.md) |  |  |

### Return type

[**OnboardInstrumentResponse**](OnboardInstrumentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="enrichinstrument"></a>
# **EnrichInstrument**
> EnrichmentResponse EnrichInstrument (string vendorProductKey, Identifiers identifiers)

[EARLY ACCESS] EnrichInstrument: Enriches an existing LUSID instrument using vendor data. Enrichment included identifiers, properties and market data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class EnrichInstrumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var vendorProductKey = "vendorProductKey_example";  // string | 
            var identifiers = new Identifiers(); // Identifiers | 

            try
            {
                // [EARLY ACCESS] EnrichInstrument: Enriches an existing LUSID instrument using vendor data. Enrichment included identifiers, properties and market data.
                EnrichmentResponse result = apiInstance.EnrichInstrument(vendorProductKey, identifiers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.EnrichInstrument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnrichInstrumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] EnrichInstrument: Enriches an existing LUSID instrument using vendor data. Enrichment included identifiers, properties and market data.
    ApiResponse<EnrichmentResponse> response = apiInstance.EnrichInstrumentWithHttpInfo(vendorProductKey, identifiers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentApi.EnrichInstrumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendorProductKey** | **string** |  |  |
| **identifiers** | [**Identifiers**](Identifiers.md) |  |  |

### Return type

[**EnrichmentResponse**](EnrichmentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getopenfigiparameteroption"></a>
# **GetOpenFigiParameterOption**
> List&lt;AllowedParameterValue&gt; GetOpenFigiParameterOption (OpenFigiParameterOptionName parameterName)

[EARLY ACCESS] GetOpenFigiParameterOption: Get all supported market sector values for OpenFigi search

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class GetOpenFigiParameterOptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var parameterName = (OpenFigiParameterOptionName) "IdType";  // OpenFigiParameterOptionName | 

            try
            {
                // [EARLY ACCESS] GetOpenFigiParameterOption: Get all supported market sector values for OpenFigi search
                List<AllowedParameterValue> result = apiInstance.GetOpenFigiParameterOption(parameterName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.GetOpenFigiParameterOption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOpenFigiParameterOptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetOpenFigiParameterOption: Get all supported market sector values for OpenFigi search
    ApiResponse<List<AllowedParameterValue>> response = apiInstance.GetOpenFigiParameterOptionWithHttpInfo(parameterName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentApi.GetOpenFigiParameterOptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parameterName** | **OpenFigiParameterOptionName** |  |  |

### Return type

[**List&lt;AllowedParameterValue&gt;**](AllowedParameterValue.md)

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

<a id="retrievepermidresult"></a>
# **RetrievePermIdResult**
> List&lt;PermIdData&gt; RetrievePermIdResult (string id)

[EARLY ACCESS] RetrievePermIdResult: Retrieve PermId results from a previous query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class RetrievePermIdResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var id = "id_example";  // string | The execution ID returned by a previous query

            try
            {
                // [EARLY ACCESS] RetrievePermIdResult: Retrieve PermId results from a previous query.
                List<PermIdData> result = apiInstance.RetrievePermIdResult(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.RetrievePermIdResult: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievePermIdResultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] RetrievePermIdResult: Retrieve PermId results from a previous query.
    ApiResponse<List<PermIdData>> response = apiInstance.RetrievePermIdResultWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentApi.RetrievePermIdResultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The execution ID returned by a previous query |  |

### Return type

[**List&lt;PermIdData&gt;**](PermIdData.md)

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

<a id="searchopenfigi"></a>
# **SearchOpenFigi**
> OpenFigiSearchResult SearchOpenFigi (string query, bool usePermId, int? limit = null, string? marketSector = null)

[EARLY ACCESS] SearchOpenFigi: Search OpenFigi for instruments that match the specified terms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class SearchOpenFigiExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var query = "query_example";  // string | 
            var usePermId = false;  // bool | Should also search PermId for additional information, defaults to `false`. (default to false)
            var limit = 25;  // int? | Only affects results rom OpenFigi general text search (optional)  (default to 25)
            var marketSector = "\"All\"";  // string? | The market sector to search, defaults to `All`. (optional)  (default to "All")

            try
            {
                // [EARLY ACCESS] SearchOpenFigi: Search OpenFigi for instruments that match the specified terms.
                OpenFigiSearchResult result = apiInstance.SearchOpenFigi(query, usePermId, limit, marketSector);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.SearchOpenFigi: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchOpenFigiWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] SearchOpenFigi: Search OpenFigi for instruments that match the specified terms.
    ApiResponse<OpenFigiSearchResult> response = apiInstance.SearchOpenFigiWithHttpInfo(query, usePermId, limit, marketSector);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentApi.SearchOpenFigiWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** |  |  |
| **usePermId** | **bool** | Should also search PermId for additional information, defaults to &#x60;false&#x60;. | [default to false] |
| **limit** | **int?** | Only affects results rom OpenFigi general text search | [optional] [default to 25] |
| **marketSector** | **string?** | The market sector to search, defaults to &#x60;All&#x60;. | [optional] [default to &quot;All&quot;] |

### Return type

[**OpenFigiSearchResult**](OpenFigiSearchResult.md)

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

<a id="vendors"></a>
# **Vendors**
> List&lt;VendorProduct&gt; Vendors (string marketSector, string securityType, int? limit = null)

[EARLY ACCESS] Vendors: Gets the VendorProducts of any supported and licenced integrations for a given market sector and security type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class VendorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var marketSector = "marketSector_example";  // string | 
            var securityType = "securityType_example";  // string | 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // [EARLY ACCESS] Vendors: Gets the VendorProducts of any supported and licenced integrations for a given market sector and security type.
                List<VendorProduct> result = apiInstance.Vendors(marketSector, securityType, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.Vendors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] Vendors: Gets the VendorProducts of any supported and licenced integrations for a given market sector and security type.
    ApiResponse<List<VendorProduct>> response = apiInstance.VendorsWithHttpInfo(marketSector, securityType, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentApi.VendorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **marketSector** | **string** |  |  |
| **securityType** | **string** |  |  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**List&lt;VendorProduct&gt;**](VendorProduct.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentApi>();
            var onboardInstrumentRequest = new OnboardInstrumentRequest(); // OnboardInstrumentRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // OnboardInstrumentResponse result = apiInstance.CreateInstrument(onboardInstrumentRequest, opts: opts);

                // [EARLY ACCESS] CreateInstrument: Creates and masters instruments with third party vendors.
                OnboardInstrumentResponse result = apiInstance.CreateInstrument(onboardInstrumentRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentApi.CreateInstrument: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentApi.CreateInstrumentWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **onboardInstrumentRequest** | [**OnboardInstrumentRequest**](OnboardInstrumentRequest.md) |  |  |

### Return type

[**OnboardInstrumentResponse**](OnboardInstrumentResponse.md)

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

<a id="enrichinstrument"></a>
# **EnrichInstrument**
> EnrichmentResponse EnrichInstrument (string vendorProductKey, Identifiers identifiers)

[EARLY ACCESS] EnrichInstrument: Enriches an existing LUSID instrument using vendor data. Enrichment included identifiers, properties and market data.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentApi>();
            var vendorProductKey = "vendorProductKey_example";  // string | 
            var identifiers = new Identifiers(); // Identifiers | 

            try
            {
                // uncomment the below to set overrides at the request level
                // EnrichmentResponse result = apiInstance.EnrichInstrument(vendorProductKey, identifiers, opts: opts);

                // [EARLY ACCESS] EnrichInstrument: Enriches an existing LUSID instrument using vendor data. Enrichment included identifiers, properties and market data.
                EnrichmentResponse result = apiInstance.EnrichInstrument(vendorProductKey, identifiers);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentApi.EnrichInstrument: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentApi.EnrichInstrumentWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendorProductKey** | **string** |  |  |
| **identifiers** | [**Identifiers**](Identifiers.md) |  |  |

### Return type

[**EnrichmentResponse**](EnrichmentResponse.md)

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

<a id="getopenfigiparameteroption"></a>
# **GetOpenFigiParameterOption**
> List&lt;AllowedParameterValue&gt; GetOpenFigiParameterOption (OpenFigiParameterOptionName parameterName)

[EARLY ACCESS] GetOpenFigiParameterOption: Get all supported market sector values for OpenFigi search

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentApi>();
            var parameterName = (OpenFigiParameterOptionName) "IdType";  // OpenFigiParameterOptionName | OpenFigi API Parameters that have a restricted / permitted range of values.

            try
            {
                // uncomment the below to set overrides at the request level
                // List<AllowedParameterValue> result = apiInstance.GetOpenFigiParameterOption(parameterName, opts: opts);

                // [EARLY ACCESS] GetOpenFigiParameterOption: Get all supported market sector values for OpenFigi search
                List<AllowedParameterValue> result = apiInstance.GetOpenFigiParameterOption(parameterName);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentApi.GetOpenFigiParameterOption: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentApi.GetOpenFigiParameterOptionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parameterName** | **OpenFigiParameterOptionName** | OpenFigi API Parameters that have a restricted / permitted range of values. |  |

### Return type

[**List&lt;AllowedParameterValue&gt;**](AllowedParameterValue.md)

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

<a id="retrievepermidresult"></a>
# **RetrievePermIdResult**
> List&lt;PermIdData&gt; RetrievePermIdResult (string id)

[EARLY ACCESS] RetrievePermIdResult: Retrieve PermId results from a previous query.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentApi>();
            var id = "id_example";  // string | The execution ID returned by a previous query

            try
            {
                // uncomment the below to set overrides at the request level
                // List<PermIdData> result = apiInstance.RetrievePermIdResult(id, opts: opts);

                // [EARLY ACCESS] RetrievePermIdResult: Retrieve PermId results from a previous query.
                List<PermIdData> result = apiInstance.RetrievePermIdResult(id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentApi.RetrievePermIdResult: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentApi.RetrievePermIdResultWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The execution ID returned by a previous query |  |

### Return type

[**List&lt;PermIdData&gt;**](PermIdData.md)

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

<a id="searchopenfigi"></a>
# **SearchOpenFigi**
> OpenFigiSearchResult SearchOpenFigi (string query, bool usePermId, int? limit = null, string? marketSector = null)

[EARLY ACCESS] SearchOpenFigi: Search OpenFigi for instruments that match the specified terms.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentApi>();
            var query = "query_example";  // string | 
            var usePermId = false;  // bool | Should also search PermId for additional information, defaults to `false`. (default to false)
            var limit = 25;  // int? | Only affects results rom OpenFigi general text search (optional)  (default to 25)
            var marketSector = "\"All\"";  // string? | The market sector to search, defaults to `All`. (optional)  (default to "All")

            try
            {
                // uncomment the below to set overrides at the request level
                // OpenFigiSearchResult result = apiInstance.SearchOpenFigi(query, usePermId, limit, marketSector, opts: opts);

                // [EARLY ACCESS] SearchOpenFigi: Search OpenFigi for instruments that match the specified terms.
                OpenFigiSearchResult result = apiInstance.SearchOpenFigi(query, usePermId, limit, marketSector);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentApi.SearchOpenFigi: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentApi.SearchOpenFigiWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

<a id="vendors"></a>
# **Vendors**
> List&lt;VendorProduct&gt; Vendors (string marketSector, string securityType, string generalSecurityType)

[EARLY ACCESS] Vendors: Gets the VendorProducts of any supported and licenced integrations for a given market sector and security type.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentApi>();
            var marketSector = "marketSector_example";  // string | 
            var securityType = "securityType_example";  // string | 
            var generalSecurityType = "generalSecurityType_example";  // string | 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<VendorProduct> result = apiInstance.Vendors(marketSector, securityType, generalSecurityType, opts: opts);

                // [EARLY ACCESS] Vendors: Gets the VendorProducts of any supported and licenced integrations for a given market sector and security type.
                List<VendorProduct> result = apiInstance.Vendors(marketSector, securityType, generalSecurityType);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentApi.Vendors: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    ApiResponse<List<VendorProduct>> response = apiInstance.VendorsWithHttpInfo(marketSector, securityType, generalSecurityType);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentApi.VendorsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **marketSector** | **string** |  |  |
| **securityType** | **string** |  |  |
| **generalSecurityType** | **string** |  |  |

### Return type

[**List&lt;VendorProduct&gt;**](VendorProduct.md)

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


# Finbourne.Horizon.Sdk.Api.VendorApi

All URIs are relative to *https://fbn-prd.lusid.com/horizon*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCoreFieldMappingsForProductEntity**](VendorApi.md#getcorefieldmappingsforproductentity) | **GET** /api/vendor/mappings/fields | [EARLY ACCESS] GetCoreFieldMappingsForProductEntity: Get core field mappings for a given vendor product&#39;s entity. |
| [**GetOptionalMappingsForProductEntity**](VendorApi.md#getoptionalmappingsforproductentity) | **GET** /api/vendor/mappings/optional | [EARLY ACCESS] GetOptionalMappingsForProductEntity: Get a user defined LUSID property mappings for the specified vendor / LUSID entity. |
| [**GetPropertyMappingsForProductEntity**](VendorApi.md#getpropertymappingsforproductentity) | **GET** /api/vendor/mappings/properties | [EARLY ACCESS] GetPropertyMappingsForProductEntity: Gets the property mappings for a given vendor product&#39;s entity |
| [**QueryVendors**](VendorApi.md#queryvendors) | **POST** /api/vendor/$query | [EARLY ACCESS] QueryVendors: Query for vendors and their packages with entities and sub-entities. |
| [**SetOptionalMappingsForProductEntity**](VendorApi.md#setoptionalmappingsforproductentity) | **POST** /api/vendor/mappings/optional | [EARLY ACCESS] SetOptionalMappingsForProductEntity: Create a user defined LUSID property mappings for the specified vendor / LUSID entity. |

<a id="getcorefieldmappingsforproductentity"></a>
# **GetCoreFieldMappingsForProductEntity**
> List&lt;LusidField&gt; GetCoreFieldMappingsForProductEntity (string vendorName, string productName, string lusidEntityType, string? lusidEntitySubType = null)

[EARLY ACCESS] GetCoreFieldMappingsForProductEntity: Get core field mappings for a given vendor product's entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class GetCoreFieldMappingsForProductEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorApi(config);
            var vendorName = "vendorName_example";  // string | 
            var productName = "productName_example";  // string | 
            var lusidEntityType = "lusidEntityType_example";  // string | 
            var lusidEntitySubType = "lusidEntitySubType_example";  // string? |  (optional) 

            try
            {
                // [EARLY ACCESS] GetCoreFieldMappingsForProductEntity: Get core field mappings for a given vendor product's entity.
                List<LusidField> result = apiInstance.GetCoreFieldMappingsForProductEntity(vendorName, productName, lusidEntityType, lusidEntitySubType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorApi.GetCoreFieldMappingsForProductEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCoreFieldMappingsForProductEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetCoreFieldMappingsForProductEntity: Get core field mappings for a given vendor product's entity.
    ApiResponse<List<LusidField>> response = apiInstance.GetCoreFieldMappingsForProductEntityWithHttpInfo(vendorName, productName, lusidEntityType, lusidEntitySubType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorApi.GetCoreFieldMappingsForProductEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendorName** | **string** |  |  |
| **productName** | **string** |  |  |
| **lusidEntityType** | **string** |  |  |
| **lusidEntitySubType** | **string?** |  | [optional]  |

### Return type

[**List&lt;LusidField&gt;**](LusidField.md)

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

<a id="getoptionalmappingsforproductentity"></a>
# **GetOptionalMappingsForProductEntity**
> Dictionary&lt;string, LusidPropertyDefinitionOverrides&gt; GetOptionalMappingsForProductEntity (string vendorName, string productName, string lusidEntityType, string? lusidEntitySubType = null)

[EARLY ACCESS] GetOptionalMappingsForProductEntity: Get a user defined LUSID property mappings for the specified vendor / LUSID entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class GetOptionalMappingsForProductEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorApi(config);
            var vendorName = "vendorName_example";  // string | 
            var productName = "productName_example";  // string | 
            var lusidEntityType = "lusidEntityType_example";  // string | 
            var lusidEntitySubType = "lusidEntitySubType_example";  // string? |  (optional) 

            try
            {
                // [EARLY ACCESS] GetOptionalMappingsForProductEntity: Get a user defined LUSID property mappings for the specified vendor / LUSID entity.
                Dictionary<string, LusidPropertyDefinitionOverrides> result = apiInstance.GetOptionalMappingsForProductEntity(vendorName, productName, lusidEntityType, lusidEntitySubType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorApi.GetOptionalMappingsForProductEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOptionalMappingsForProductEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetOptionalMappingsForProductEntity: Get a user defined LUSID property mappings for the specified vendor / LUSID entity.
    ApiResponse<Dictionary<string, LusidPropertyDefinitionOverrides>> response = apiInstance.GetOptionalMappingsForProductEntityWithHttpInfo(vendorName, productName, lusidEntityType, lusidEntitySubType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorApi.GetOptionalMappingsForProductEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendorName** | **string** |  |  |
| **productName** | **string** |  |  |
| **lusidEntityType** | **string** |  |  |
| **lusidEntitySubType** | **string?** |  | [optional]  |

### Return type

[**Dictionary&lt;string, LusidPropertyDefinitionOverrides&gt;**](LusidPropertyDefinitionOverrides.md)

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

<a id="getpropertymappingsforproductentity"></a>
# **GetPropertyMappingsForProductEntity**
> List&lt;LusidPropertyToVendorFieldMapping&gt; GetPropertyMappingsForProductEntity (string vendorName, string productName, string lusidEntityType, string? lusidEntitySubType = null)

[EARLY ACCESS] GetPropertyMappingsForProductEntity: Gets the property mappings for a given vendor product's entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class GetPropertyMappingsForProductEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorApi(config);
            var vendorName = "vendorName_example";  // string | 
            var productName = "productName_example";  // string | 
            var lusidEntityType = "lusidEntityType_example";  // string | 
            var lusidEntitySubType = "lusidEntitySubType_example";  // string? |  (optional) 

            try
            {
                // [EARLY ACCESS] GetPropertyMappingsForProductEntity: Gets the property mappings for a given vendor product's entity
                List<LusidPropertyToVendorFieldMapping> result = apiInstance.GetPropertyMappingsForProductEntity(vendorName, productName, lusidEntityType, lusidEntitySubType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorApi.GetPropertyMappingsForProductEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPropertyMappingsForProductEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetPropertyMappingsForProductEntity: Gets the property mappings for a given vendor product's entity
    ApiResponse<List<LusidPropertyToVendorFieldMapping>> response = apiInstance.GetPropertyMappingsForProductEntityWithHttpInfo(vendorName, productName, lusidEntityType, lusidEntitySubType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorApi.GetPropertyMappingsForProductEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendorName** | **string** |  |  |
| **productName** | **string** |  |  |
| **lusidEntityType** | **string** |  |  |
| **lusidEntitySubType** | **string?** |  | [optional]  |

### Return type

[**List&lt;LusidPropertyToVendorFieldMapping&gt;**](LusidPropertyToVendorFieldMapping.md)

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

<a id="queryvendors"></a>
# **QueryVendors**
> PagedResourceListOfVendorProduct QueryVendors (Object body)

[EARLY ACCESS] QueryVendors: Query for vendors and their packages with entities and sub-entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class QueryVendorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorApi(config);
            var body = null;  // Object | 

            try
            {
                // [EARLY ACCESS] QueryVendors: Query for vendors and their packages with entities and sub-entities.
                PagedResourceListOfVendorProduct result = apiInstance.QueryVendors(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorApi.QueryVendors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryVendorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] QueryVendors: Query for vendors and their packages with entities and sub-entities.
    ApiResponse<PagedResourceListOfVendorProduct> response = apiInstance.QueryVendorsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorApi.QueryVendorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

### Return type

[**PagedResourceListOfVendorProduct**](PagedResourceListOfVendorProduct.md)

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

<a id="setoptionalmappingsforproductentity"></a>
# **SetOptionalMappingsForProductEntity**
> Dictionary&lt;string, LusidPropertyDefinitionOverridesResponse&gt; SetOptionalMappingsForProductEntity (string vendorName, string productName, string lusidEntityType, Dictionary<string, LusidPropertyDefinitionOverrides> requestBody, string? lusidEntitySubType = null)

[EARLY ACCESS] SetOptionalMappingsForProductEntity: Create a user defined LUSID property mappings for the specified vendor / LUSID entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Horizon.Sdk.Api;
using Finbourne.Horizon.Sdk.Client;
using Finbourne.Horizon.Sdk.Model;

namespace Example
{
    public class SetOptionalMappingsForProductEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/horizon";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorApi(config);
            var vendorName = "vendorName_example";  // string | 
            var productName = "productName_example";  // string | 
            var lusidEntityType = "lusidEntityType_example";  // string | 
            var requestBody = new Dictionary<string, LusidPropertyDefinitionOverrides>(); // Dictionary<string, LusidPropertyDefinitionOverrides> | 
            var lusidEntitySubType = "lusidEntitySubType_example";  // string? |  (optional) 

            try
            {
                // [EARLY ACCESS] SetOptionalMappingsForProductEntity: Create a user defined LUSID property mappings for the specified vendor / LUSID entity.
                Dictionary<string, LusidPropertyDefinitionOverridesResponse> result = apiInstance.SetOptionalMappingsForProductEntity(vendorName, productName, lusidEntityType, requestBody, lusidEntitySubType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorApi.SetOptionalMappingsForProductEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetOptionalMappingsForProductEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] SetOptionalMappingsForProductEntity: Create a user defined LUSID property mappings for the specified vendor / LUSID entity.
    ApiResponse<Dictionary<string, LusidPropertyDefinitionOverridesResponse>> response = apiInstance.SetOptionalMappingsForProductEntityWithHttpInfo(vendorName, productName, lusidEntityType, requestBody, lusidEntitySubType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorApi.SetOptionalMappingsForProductEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vendorName** | **string** |  |  |
| **productName** | **string** |  |  |
| **lusidEntityType** | **string** |  |  |
| **requestBody** | [**Dictionary&lt;string, LusidPropertyDefinitionOverrides&gt;**](LusidPropertyDefinitionOverrides.md) |  |  |
| **lusidEntitySubType** | **string?** |  | [optional]  |

### Return type

[**Dictionary&lt;string, LusidPropertyDefinitionOverridesResponse&gt;**](LusidPropertyDefinitionOverridesResponse.md)

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


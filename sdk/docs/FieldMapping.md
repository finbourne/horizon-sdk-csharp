# Finbourne.Horizon.Sdk.Model.FieldMapping
Mapping from a set of Vendor Fields to a LUSID core entity field

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The LUSID core entity field | 
**DefaultValue** | **string** | Default value if needed | [optional] 
**VendorFields** | [**List&lt;VendorField&gt;**](VendorField.md) | Fields that will be used to map to this field | 
**TransformationDescription** | **string** | The transformation, if required, to map from VendorFields to the LUSID Property | [optional] 
**EntityType** | **string** | The LUSID Entity this is valid for | 
**EntitySubType** | **string** | The LUSID Entity sub type this is valid for | [optional] 
**Versions** | **List&lt;string&gt;** | The versions of the Vendor integration this mapping is valid for | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)


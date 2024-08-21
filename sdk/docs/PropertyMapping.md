# Finbourne.Horizon.Sdk.Model.PropertyMapping
Mapping from a set of VendorFields to a LUSID Property

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Property** | [**LusidPropertyDefinition**](LusidPropertyDefinition.md) |  | 
**VendorFields** | [**List&lt;VendorField&gt;**](VendorField.md) | Fields that will be used to map to this Property Definition | 
**Optionality** | **Optionality** |  | 
**EntityType** | **string** | The LUSID Entity this is valid for | 
**EntitySubType** | **string** | The LUSID Entity sub type this is valid for | [optional] 
**TransformationDescription** | **string** | The transformation, if required, to map from VendorFields to the LUSID Property | [optional] 
**Versions** | **List&lt;string&gt;** | The versions of the Vendor integration this mapping is valid for | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)


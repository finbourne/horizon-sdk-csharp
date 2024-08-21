# Finbourne.Horizon.Sdk.Model.LusidField
A field on a LUSID entity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The name of the LUSID field. | 
**DefaultValue** | **string** | The default value for the field. | [optional] 
**VendorPackages** | **List&lt;string&gt;** | The vendor package that contributes to this LUSID field. | 
**VendorNamespaces** | **List&lt;string&gt;** | The vendor namespace that contributes to this LUSID field. | 
**VendorFields** | **List&lt;string&gt;** | The underlying fields on the vendor package that contribute to this LUSID field | 
**TransformationDescription** | **string** | A description of how the vendor package&#39;s field(s) get mapped to the LUSID field | [optional] 
**EntityType** | **string** | LUSID Entity this refers to (e.g. Instrument) | 
**EntitySubType** | **string** | Sub-Entity this field refers to (e.g. Equity) | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)


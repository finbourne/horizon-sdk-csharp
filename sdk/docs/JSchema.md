# Finbourne.Horizon.Sdk.Model.JSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SchemaVersion** | **string** |  | [optional] 
**Valid** | **bool?** |  | [optional] 
**Reference** | **string** |  | [optional] 
**Ref** | [**JSchema**](JSchema.md) |  | [optional] 
**RecursiveReference** | **string** |  | [optional] 
**RecursiveAnchor** | **bool?** |  | [optional] 
**Id** | **string** |  | [optional] 
**Anchor** | **string** |  | [optional] 
**Type** | **JSchemaType** |  | [optional] 
**Default** | **Object** |  | [optional] 
**Properties** | [**Dictionary&lt;string, JSchema&gt;**](JSchema.md) |  | [readonly] 
**Items** | [**List&lt;JSchema&gt;**](JSchema.md) |  | [readonly] 
**ItemsPositionValidation** | **bool** |  | 
**Required** | **List&lt;string&gt;** |  | [readonly] 
**AllOf** | [**List&lt;JSchema&gt;**](JSchema.md) |  | [readonly] 
**AnyOf** | [**List&lt;JSchema&gt;**](JSchema.md) |  | [readonly] 
**OneOf** | [**List&lt;JSchema&gt;**](JSchema.md) |  | [readonly] 
**If** | [**JSchema**](JSchema.md) |  | [optional] 
**Then** | [**JSchema**](JSchema.md) |  | [optional] 
**Else** | [**JSchema**](JSchema.md) |  | [optional] 
**Not** | [**JSchema**](JSchema.md) |  | [optional] 
**Contains** | [**JSchema**](JSchema.md) |  | [optional] 
**PropertyNames** | [**JSchema**](JSchema.md) |  | [optional] 
**Enum** | **List&lt;Object&gt;** |  | [readonly] 
**Const** | **Object** |  | [optional] 
**UniqueItems** | **bool** |  | 
**MinimumLength** | **long?** |  | [optional] 
**MaximumLength** | **long?** |  | [optional] 
**Minimum** | **decimal?** |  | [optional] 
**Maximum** | **decimal?** |  | [optional] 
**ExclusiveMinimum** | **bool** |  | 
**ExclusiveMaximum** | **bool** |  | 
**MinimumItems** | **long?** |  | [optional] 
**MaximumItems** | **long?** |  | [optional] 
**MinimumProperties** | **long?** |  | [optional] 
**MaximumProperties** | **long?** |  | [optional] 
**MinimumContains** | **long?** |  | [optional] 
**MaximumContains** | **long?** |  | [optional] 
**ContentEncoding** | **string** |  | [optional] 
**ContentMediaType** | **string** |  | [optional] 
**WriteOnly** | **bool?** |  | [optional] 
**ReadOnly** | **bool?** |  | [optional] 
**ExtensionData** | **Dictionary&lt;string, Object&gt;** |  | [readonly] 
**Title** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**MultipleOf** | **decimal?** |  | [optional] 
**Pattern** | **string** |  | [optional] 
**Dependencies** | **Dictionary&lt;string, Object&gt;** |  | [readonly] 
**DependentRequired** | **Dictionary&lt;string, List&lt;string&gt;&gt;** |  | [readonly] 
**DependentSchemas** | [**Dictionary&lt;string, JSchema&gt;**](JSchema.md) |  | [readonly] 
**PatternProperties** | [**Dictionary&lt;string, JSchema&gt;**](JSchema.md) |  | [readonly] 
**AdditionalProperties** | [**JSchema**](JSchema.md) |  | [optional] 
**AllowAdditionalProperties** | **bool** |  | 
**AllowAdditionalPropertiesSpecified** | **bool** |  | 
**UnevaluatedProperties** | [**JSchema**](JSchema.md) |  | [optional] 
**AllowUnevaluatedProperties** | **bool?** |  | [optional] 
**AdditionalItems** | [**JSchema**](JSchema.md) |  | [optional] 
**AllowAdditionalItems** | **bool** |  | 
**AllowAdditionalItemsSpecified** | **bool** |  | 
**UnevaluatedItems** | [**JSchema**](JSchema.md) |  | [optional] 
**AllowUnevaluatedItems** | **bool?** |  | [optional] 
**Format** | **string** |  | [optional] 
**Validators** | **List&lt;Object&gt;** |  | [readonly] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)


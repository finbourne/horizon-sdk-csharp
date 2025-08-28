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

```csharp
using Finbourne.Horizon.Sdk.Model;
using System;

string schemaVersion = "example schemaVersion";
bool? valid = //"True";
string reference = "example reference";
JSchema? ref = new JSchema();

string recursiveReference = "example recursiveReference";
bool? recursiveAnchor = //"True";
string id = "example id";
string anchor = "example anchor";
Dictionary<string, JSchema> properties = new Dictionary<string, JSchema>();
List<JSchema> items = new List<JSchema>();
bool itemsPositionValidation = //"True";
List<string> required = new List<string>();
List<JSchema> allOf = new List<JSchema>();
List<JSchema> anyOf = new List<JSchema>();
List<JSchema> oneOf = new List<JSchema>();
JSchema? if = new JSchema();

JSchema? then = new JSchema();

JSchema? else = new JSchema();

JSchema? not = new JSchema();

JSchema? contains = new JSchema();

JSchema? propertyNames = new JSchema();

List<Object> enum = new List<Object>();
bool uniqueItems = //"True";
bool exclusiveMinimum = //"True";
bool exclusiveMaximum = //"True";
string contentEncoding = "example contentEncoding";
string contentMediaType = "example contentMediaType";
bool? writeOnly = //"True";
bool? readOnly = //"True";
Dictionary<string, Object> extensionData = new Dictionary<string, Object>();
string title = "example title";
string description = "example description";
string pattern = "example pattern";
Dictionary<string, Object> dependencies = new Dictionary<string, Object>();
Dictionary<string, List<string>> dependentRequired = new Dictionary<string, List<string>>();
Dictionary<string, JSchema> dependentSchemas = new Dictionary<string, JSchema>();
Dictionary<string, JSchema> patternProperties = new Dictionary<string, JSchema>();
JSchema? additionalProperties = new JSchema();

bool allowAdditionalProperties = //"True";
bool allowAdditionalPropertiesSpecified = //"True";
JSchema? unevaluatedProperties = new JSchema();

bool? allowUnevaluatedProperties = //"True";
JSchema? additionalItems = new JSchema();

bool allowAdditionalItems = //"True";
bool allowAdditionalItemsSpecified = //"True";
JSchema? unevaluatedItems = new JSchema();

bool? allowUnevaluatedItems = //"True";
string format = "example format";
List<Object> validators = new List<Object>();

JSchema jSchemaInstance = new JSchema(
    schemaVersion: schemaVersion,
    valid: valid,
    reference: reference,
    ref: ref,
    recursiveReference: recursiveReference,
    recursiveAnchor: recursiveAnchor,
    id: id,
    anchor: anchor,
    type: type,
    default: default,
    properties: properties,
    items: items,
    itemsPositionValidation: itemsPositionValidation,
    required: required,
    allOf: allOf,
    anyOf: anyOf,
    oneOf: oneOf,
    if: if,
    then: then,
    else: else,
    not: not,
    contains: contains,
    propertyNames: propertyNames,
    enum: enum,
    const: const,
    uniqueItems: uniqueItems,
    minimumLength: minimumLength,
    maximumLength: maximumLength,
    minimum: minimum,
    maximum: maximum,
    exclusiveMinimum: exclusiveMinimum,
    exclusiveMaximum: exclusiveMaximum,
    minimumItems: minimumItems,
    maximumItems: maximumItems,
    minimumProperties: minimumProperties,
    maximumProperties: maximumProperties,
    minimumContains: minimumContains,
    maximumContains: maximumContains,
    contentEncoding: contentEncoding,
    contentMediaType: contentMediaType,
    writeOnly: writeOnly,
    readOnly: readOnly,
    extensionData: extensionData,
    title: title,
    description: description,
    multipleOf: multipleOf,
    pattern: pattern,
    dependencies: dependencies,
    dependentRequired: dependentRequired,
    dependentSchemas: dependentSchemas,
    patternProperties: patternProperties,
    additionalProperties: additionalProperties,
    allowAdditionalProperties: allowAdditionalProperties,
    allowAdditionalPropertiesSpecified: allowAdditionalPropertiesSpecified,
    unevaluatedProperties: unevaluatedProperties,
    allowUnevaluatedProperties: allowUnevaluatedProperties,
    additionalItems: additionalItems,
    allowAdditionalItems: allowAdditionalItems,
    allowAdditionalItemsSpecified: allowAdditionalItemsSpecified,
    unevaluatedItems: unevaluatedItems,
    allowUnevaluatedItems: allowUnevaluatedItems,
    format: format,
    validators: validators);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

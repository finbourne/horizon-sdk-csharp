/*
 * FINBOURNE Horizon API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Horizon.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Horizon.Sdk.Model
{
    /// <summary>
    /// A field on a LUSID entity
    /// </summary>
    [DataContract(Name = "LusidField")]
    public partial class LusidField : IEquatable<LusidField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LusidField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LusidField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LusidField" /> class.
        /// </summary>
        /// <param name="fieldName">The name of the LUSID field. (required).</param>
        /// <param name="defaultValue">The default value for the field..</param>
        /// <param name="vendorPackages">The vendor package that contributes to this LUSID field. (required).</param>
        /// <param name="vendorNamespaces">The vendor namespace that contributes to this LUSID field. (required).</param>
        /// <param name="vendorFields">The underlying fields on the vendor package that contribute to this LUSID field (required).</param>
        /// <param name="transformationDescription">A description of how the vendor package&#39;s field(s) get mapped to the LUSID field.</param>
        /// <param name="entityType">LUSID Entity this refers to (e.g. Instrument) (required).</param>
        /// <param name="entitySubType">Sub-Entity this field refers to (e.g. Equity).</param>
        public LusidField(string fieldName = default(string), string defaultValue = default(string), List<string> vendorPackages = default(List<string>), List<string> vendorNamespaces = default(List<string>), List<string> vendorFields = default(List<string>), string transformationDescription = default(string), string entityType = default(string), string entitySubType = default(string))
        {
            // to ensure "fieldName" is required (not null)
            if (fieldName == null)
            {
                throw new ArgumentNullException("fieldName is a required property for LusidField and cannot be null");
            }
            this.FieldName = fieldName;
            // to ensure "vendorPackages" is required (not null)
            if (vendorPackages == null)
            {
                throw new ArgumentNullException("vendorPackages is a required property for LusidField and cannot be null");
            }
            this.VendorPackages = vendorPackages;
            // to ensure "vendorNamespaces" is required (not null)
            if (vendorNamespaces == null)
            {
                throw new ArgumentNullException("vendorNamespaces is a required property for LusidField and cannot be null");
            }
            this.VendorNamespaces = vendorNamespaces;
            // to ensure "vendorFields" is required (not null)
            if (vendorFields == null)
            {
                throw new ArgumentNullException("vendorFields is a required property for LusidField and cannot be null");
            }
            this.VendorFields = vendorFields;
            // to ensure "entityType" is required (not null)
            if (entityType == null)
            {
                throw new ArgumentNullException("entityType is a required property for LusidField and cannot be null");
            }
            this.EntityType = entityType;
            this.DefaultValue = defaultValue;
            this.TransformationDescription = transformationDescription;
            this.EntitySubType = entitySubType;
        }

        /// <summary>
        /// The name of the LUSID field.
        /// </summary>
        /// <value>The name of the LUSID field.</value>
        [DataMember(Name = "fieldName", IsRequired = true, EmitDefaultValue = true)]
        public string FieldName { get; set; }

        /// <summary>
        /// The default value for the field.
        /// </summary>
        /// <value>The default value for the field.</value>
        [DataMember(Name = "defaultValue", EmitDefaultValue = true)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The vendor package that contributes to this LUSID field.
        /// </summary>
        /// <value>The vendor package that contributes to this LUSID field.</value>
        [DataMember(Name = "vendorPackages", IsRequired = true, EmitDefaultValue = true)]
        public List<string> VendorPackages { get; set; }

        /// <summary>
        /// The vendor namespace that contributes to this LUSID field.
        /// </summary>
        /// <value>The vendor namespace that contributes to this LUSID field.</value>
        [DataMember(Name = "vendorNamespaces", IsRequired = true, EmitDefaultValue = true)]
        public List<string> VendorNamespaces { get; set; }

        /// <summary>
        /// The underlying fields on the vendor package that contribute to this LUSID field
        /// </summary>
        /// <value>The underlying fields on the vendor package that contribute to this LUSID field</value>
        [DataMember(Name = "vendorFields", IsRequired = true, EmitDefaultValue = true)]
        public List<string> VendorFields { get; set; }

        /// <summary>
        /// A description of how the vendor package&#39;s field(s) get mapped to the LUSID field
        /// </summary>
        /// <value>A description of how the vendor package&#39;s field(s) get mapped to the LUSID field</value>
        [DataMember(Name = "transformationDescription", EmitDefaultValue = true)]
        public string TransformationDescription { get; set; }

        /// <summary>
        /// LUSID Entity this refers to (e.g. Instrument)
        /// </summary>
        /// <value>LUSID Entity this refers to (e.g. Instrument)</value>
        [DataMember(Name = "entityType", IsRequired = true, EmitDefaultValue = true)]
        public string EntityType { get; set; }

        /// <summary>
        /// Sub-Entity this field refers to (e.g. Equity)
        /// </summary>
        /// <value>Sub-Entity this field refers to (e.g. Equity)</value>
        [DataMember(Name = "entitySubType", EmitDefaultValue = true)]
        public string EntitySubType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LusidField {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  VendorPackages: ").Append(VendorPackages).Append("\n");
            sb.Append("  VendorNamespaces: ").Append(VendorNamespaces).Append("\n");
            sb.Append("  VendorFields: ").Append(VendorFields).Append("\n");
            sb.Append("  TransformationDescription: ").Append(TransformationDescription).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  EntitySubType: ").Append(EntitySubType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LusidField);
        }

        /// <summary>
        /// Returns true if LusidField instances are equal
        /// </summary>
        /// <param name="input">Instance of LusidField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LusidField input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.VendorPackages == input.VendorPackages ||
                    this.VendorPackages != null &&
                    input.VendorPackages != null &&
                    this.VendorPackages.SequenceEqual(input.VendorPackages)
                ) && 
                (
                    this.VendorNamespaces == input.VendorNamespaces ||
                    this.VendorNamespaces != null &&
                    input.VendorNamespaces != null &&
                    this.VendorNamespaces.SequenceEqual(input.VendorNamespaces)
                ) && 
                (
                    this.VendorFields == input.VendorFields ||
                    this.VendorFields != null &&
                    input.VendorFields != null &&
                    this.VendorFields.SequenceEqual(input.VendorFields)
                ) && 
                (
                    this.TransformationDescription == input.TransformationDescription ||
                    (this.TransformationDescription != null &&
                    this.TransformationDescription.Equals(input.TransformationDescription))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.EntitySubType == input.EntitySubType ||
                    (this.EntitySubType != null &&
                    this.EntitySubType.Equals(input.EntitySubType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FieldName != null)
                {
                    hashCode = (hashCode * 59) + this.FieldName.GetHashCode();
                }
                if (this.DefaultValue != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultValue.GetHashCode();
                }
                if (this.VendorPackages != null)
                {
                    hashCode = (hashCode * 59) + this.VendorPackages.GetHashCode();
                }
                if (this.VendorNamespaces != null)
                {
                    hashCode = (hashCode * 59) + this.VendorNamespaces.GetHashCode();
                }
                if (this.VendorFields != null)
                {
                    hashCode = (hashCode * 59) + this.VendorFields.GetHashCode();
                }
                if (this.TransformationDescription != null)
                {
                    hashCode = (hashCode * 59) + this.TransformationDescription.GetHashCode();
                }
                if (this.EntityType != null)
                {
                    hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                }
                if (this.EntitySubType != null)
                {
                    hashCode = (hashCode * 59) + this.EntitySubType.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // FieldName (string) minLength
            if (this.FieldName != null && this.FieldName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FieldName, length must be greater than 1.", new [] { "FieldName" });
            }

            yield break;
        }
    }
}

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
    /// Override values for property Display Name and Description
    /// </summary>
    [DataContract(Name = "LusidPropertyDefinitionOverrides")]
    public partial class LusidPropertyDefinitionOverrides : IEquatable<LusidPropertyDefinitionOverrides>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LusidPropertyDefinitionOverrides" /> class.
        /// </summary>
        /// <param name="displayNameOverride">displayNameOverride.</param>
        /// <param name="descriptionOverride">descriptionOverride.</param>
        public LusidPropertyDefinitionOverrides(string displayNameOverride = default(string), string descriptionOverride = default(string))
        {
            this.DisplayNameOverride = displayNameOverride;
            this.DescriptionOverride = descriptionOverride;
        }

        /// <summary>
        /// Gets or Sets DisplayNameOverride
        /// </summary>
        [DataMember(Name = "displayNameOverride", EmitDefaultValue = true)]
        public string DisplayNameOverride { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionOverride
        /// </summary>
        [DataMember(Name = "descriptionOverride", EmitDefaultValue = true)]
        public string DescriptionOverride { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LusidPropertyDefinitionOverrides {\n");
            sb.Append("  DisplayNameOverride: ").Append(DisplayNameOverride).Append("\n");
            sb.Append("  DescriptionOverride: ").Append(DescriptionOverride).Append("\n");
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
            return this.Equals(input as LusidPropertyDefinitionOverrides);
        }

        /// <summary>
        /// Returns true if LusidPropertyDefinitionOverrides instances are equal
        /// </summary>
        /// <param name="input">Instance of LusidPropertyDefinitionOverrides to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LusidPropertyDefinitionOverrides input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayNameOverride == input.DisplayNameOverride ||
                    (this.DisplayNameOverride != null &&
                    this.DisplayNameOverride.Equals(input.DisplayNameOverride))
                ) && 
                (
                    this.DescriptionOverride == input.DescriptionOverride ||
                    (this.DescriptionOverride != null &&
                    this.DescriptionOverride.Equals(input.DescriptionOverride))
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
                if (this.DisplayNameOverride != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayNameOverride.GetHashCode();
                }
                if (this.DescriptionOverride != null)
                {
                    hashCode = (hashCode * 59) + this.DescriptionOverride.GetHashCode();
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
            // DisplayNameOverride (string) maxLength
            if (this.DisplayNameOverride != null && this.DisplayNameOverride.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayNameOverride, length must be less than 1024.", new [] { "DisplayNameOverride" });
            }

            // DisplayNameOverride (string) minLength
            if (this.DisplayNameOverride != null && this.DisplayNameOverride.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayNameOverride, length must be greater than 0.", new [] { "DisplayNameOverride" });
            }

            // DescriptionOverride (string) maxLength
            if (this.DescriptionOverride != null && this.DescriptionOverride.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DescriptionOverride, length must be less than 1024.", new [] { "DescriptionOverride" });
            }

            // DescriptionOverride (string) minLength
            if (this.DescriptionOverride != null && this.DescriptionOverride.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DescriptionOverride, length must be greater than 0.", new [] { "DescriptionOverride" });
            }

            yield break;
        }
    }
}

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
    /// IntegrationRerunResponse
    /// </summary>
    [DataContract(Name = "IntegrationRerunResponse")]
    public partial class IntegrationRerunResponse : IEquatable<IntegrationRerunResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationRerunResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntegrationRerunResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationRerunResponse" /> class.
        /// </summary>
        /// <param name="runId">runId (required).</param>
        public IntegrationRerunResponse(InstanceExecutionReferenceId runId = default(InstanceExecutionReferenceId))
        {
            // to ensure "runId" is required (not null)
            if (runId == null)
            {
                throw new ArgumentNullException("runId is a required property for IntegrationRerunResponse and cannot be null");
            }
            this.RunId = runId;
        }

        /// <summary>
        /// Gets or Sets RunId
        /// </summary>
        [DataMember(Name = "runId", IsRequired = true, EmitDefaultValue = true)]
        public InstanceExecutionReferenceId RunId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntegrationRerunResponse {\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
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
            return this.Equals(input as IntegrationRerunResponse);
        }

        /// <summary>
        /// Returns true if IntegrationRerunResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationRerunResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationRerunResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RunId == input.RunId ||
                    (this.RunId != null &&
                    this.RunId.Equals(input.RunId))
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
                if (this.RunId != null)
                {
                    hashCode = (hashCode * 59) + this.RunId.GetHashCode();
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
            yield break;
        }
    }
}
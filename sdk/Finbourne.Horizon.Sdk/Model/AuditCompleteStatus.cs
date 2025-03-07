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
    /// The set of available completion statuses
    /// </summary>
    /// <value>The set of available completion statuses</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditCompleteStatus
    {
        /// <summary>
        /// Enum Succeeded for value: Succeeded
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded = 1,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 2,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 3
    }

}

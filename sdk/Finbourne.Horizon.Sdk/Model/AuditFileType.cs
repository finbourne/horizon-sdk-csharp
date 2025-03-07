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
    /// Available Horizon Audit File Types
    /// </summary>
    /// <value>Available Horizon Audit File Types</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditFileType
    {
        /// <summary>
        /// Enum SourceData for value: SourceData
        /// </summary>
        [EnumMember(Value = "SourceData")]
        SourceData = 1,

        /// <summary>
        /// Enum Info for value: Info
        /// </summary>
        [EnumMember(Value = "Info")]
        Info = 2,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 3
    }

}

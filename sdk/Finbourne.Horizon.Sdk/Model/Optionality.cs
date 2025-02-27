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
    /// The optionality status of a property mapping for a particular vendor product entity field
    /// </summary>
    /// <value>The optionality status of a property mapping for a particular vendor product entity field</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Optionality
    {
        /// <summary>
        /// Enum Mandatory for value: Mandatory
        /// </summary>
        [EnumMember(Value = "Mandatory")]
        Mandatory = 1,

        /// <summary>
        /// Enum Suggested for value: Suggested
        /// </summary>
        [EnumMember(Value = "Suggested")]
        Suggested = 2,

        /// <summary>
        /// Enum Optional for value: Optional
        /// </summary>
        [EnumMember(Value = "Optional")]
        Optional = 3
    }

}

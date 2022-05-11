// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type EducationAssignmentGrade.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EducationAssignmentGrade>))]
    public partial class EducationAssignmentGrade
    {

        ///<summary>
        /// The internal EducationAssignmentGrade constructor
        ///</summary>
        protected internal EducationAssignmentGrade()
        {
            // Don't allow initialization of abstract complex types
        }

        /// <summary>
        /// Gets or sets gradedBy.
        /// User who did the grading.
        /// </summary>
        [JsonPropertyName("gradedBy")]
        public IdentitySet GradedBy { get; set; }
    
        /// <summary>
        /// Gets or sets gradedDateTime.
        /// Moment in time when the grade was applied to this submission object. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("gradedDateTime")]
        public DateTimeOffset? GradedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
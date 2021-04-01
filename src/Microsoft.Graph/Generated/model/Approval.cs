// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Approval.
    /// </summary>
    public partial class Approval : Entity
    {
    
		///<summary>
		/// The Approval constructor
		///</summary>
        public Approval()
        {
            this.ODataType = "microsoft.graph.approval";
        }
	
        /// <summary>
        /// Gets or sets stages.
        /// A collection of stages in the approval decision.
        /// </summary>
        [JsonPropertyName("stages")]
        public IApprovalStagesCollectionPage Stages { get; set; }
    
    }
}

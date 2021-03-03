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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Print Task.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrintTask : Entity
    {
    
		///<summary>
		/// The PrintTask constructor
		///</summary>
        public PrintTask()
        {
            this.ODataType = "microsoft.graph.printTask";
        }
	
        /// <summary>
        /// Gets or sets parent url.
        /// The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ParentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The current execution status of this printTask. The calling application is responsible for updating this status when processing is finished, unless the related printJob has been redirected to another printer. Failure to report completion will result in the related print job being blocked from printing and eventually deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public PrintTaskStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets definition.
        /// The printTaskDefinition that was used to create this task. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "definition", Required = Newtonsoft.Json.Required.Default)]
        public PrintTaskDefinition Definition { get; set; }
    
        /// <summary>
        /// Gets or sets trigger.
        /// The printTaskTrigger that triggered this task's execution. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trigger", Required = Newtonsoft.Json.Required.Default)]
        public PrintTaskTrigger Trigger { get; set; }
    
    }
}

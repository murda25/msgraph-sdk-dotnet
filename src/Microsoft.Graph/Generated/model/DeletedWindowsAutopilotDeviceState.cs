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
    /// The type DeletedWindowsAutopilotDeviceState.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeletedWindowsAutopilotDeviceState>))]
    public partial class DeletedWindowsAutopilotDeviceState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedWindowsAutopilotDeviceState"/> class.
        /// </summary>
        public DeletedWindowsAutopilotDeviceState()
        {
            this.ODataType = "microsoft.graph.deletedWindowsAutopilotDeviceState";
        }

        /// <summary>
        /// Gets or sets deletionState.
        /// Device deletion state. Possible values are: unknown, failed, accepted, error.
        /// </summary>
        [JsonPropertyName("deletionState")]
        public WindowsAutopilotDeviceDeletionState? DeletionState { get; set; }
    
        /// <summary>
        /// Gets or sets deviceRegistrationId.
        /// ZTD Device Registration ID .
        /// </summary>
        [JsonPropertyName("deviceRegistrationId")]
        public string DeviceRegistrationId { get; set; }
    
        /// <summary>
        /// Gets or sets errorMessage.
        /// Device deletion error message.
        /// </summary>
        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }
    
        /// <summary>
        /// Gets or sets serialNumber.
        /// Autopilot Device Serial Number
        /// </summary>
        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }
    
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
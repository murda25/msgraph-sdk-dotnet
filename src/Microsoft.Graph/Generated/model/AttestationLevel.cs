// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AttestationLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AttestationLevel
    {
    
        /// <summary>
        /// Attested
        /// </summary>
        Attested = 0,
	
        /// <summary>
        /// Not Attested
        /// </summary>
        NotAttested = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}

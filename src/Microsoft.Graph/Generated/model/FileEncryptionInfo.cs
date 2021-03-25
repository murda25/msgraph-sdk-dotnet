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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type FileEncryptionInfo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class FileEncryptionInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileEncryptionInfo"/> class.
        /// </summary>
        public FileEncryptionInfo()
        {
            this.ODataType = "microsoft.graph.fileEncryptionInfo";
        }

        /// <summary>
        /// Gets or sets encryptionKey.
        /// The key used to encrypt the file content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionKey", Required = Newtonsoft.Json.Required.Default)]
        public byte[] EncryptionKey { get; set; }
    
        /// <summary>
        /// Gets or sets fileDigest.
        /// The file digest prior to encryption.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileDigest", Required = Newtonsoft.Json.Required.Default)]
        public byte[] FileDigest { get; set; }
    
        /// <summary>
        /// Gets or sets fileDigestAlgorithm.
        /// The file digest algorithm.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileDigestAlgorithm", Required = Newtonsoft.Json.Required.Default)]
        public string FileDigestAlgorithm { get; set; }
    
        /// <summary>
        /// Gets or sets initializationVector.
        /// The initialization vector used for the encryption algorithm.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initializationVector", Required = Newtonsoft.Json.Required.Default)]
        public byte[] InitializationVector { get; set; }
    
        /// <summary>
        /// Gets or sets mac.
        /// The hash of the encrypted file content + IV (content hash).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mac", Required = Newtonsoft.Json.Required.Default)]
        public byte[] Mac { get; set; }
    
        /// <summary>
        /// Gets or sets macKey.
        /// The key used to get mac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "macKey", Required = Newtonsoft.Json.Required.Default)]
        public byte[] MacKey { get; set; }
    
        /// <summary>
        /// Gets or sets profileIdentifier.
        /// The profile identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string ProfileIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}

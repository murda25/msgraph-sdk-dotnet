using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Windows Information Protection Proxied Domain Collection</summary>
    public class WindowsInformationProtectionProxiedDomainCollection : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name</summary>
        public string DisplayName { get; set; }
        /// <summary>Collection of proxied domains</summary>
        public List<ProxiedDomain> ProxiedDomains { get; set; }
        /// <summary>
        /// Instantiates a new windowsInformationProtectionProxiedDomainCollection and sets the default values.
        /// </summary>
        public WindowsInformationProtectionProxiedDomainCollection() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsInformationProtectionProxiedDomainCollection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionProxiedDomainCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"proxiedDomains", n => { ProxiedDomains = n.GetCollectionOfObjectValues<ProxiedDomain>(ProxiedDomain.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ProxiedDomain>("proxiedDomains", ProxiedDomains);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
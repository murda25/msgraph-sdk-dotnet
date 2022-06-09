using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class SecurityVendorInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.</summary>
        public string Provider {
            get { return BackingStore?.Get<string>(nameof(Provider)); }
            set { BackingStore?.Set(nameof(Provider), value); }
        }
        /// <summary>Version of the provider or subprovider, if it exists, that generated the alert. Required</summary>
        public string ProviderVersion {
            get { return BackingStore?.Get<string>(nameof(ProviderVersion)); }
            set { BackingStore?.Set(nameof(ProviderVersion), value); }
        }
        /// <summary>Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.</summary>
        public string SubProvider {
            get { return BackingStore?.Get<string>(nameof(SubProvider)); }
            set { BackingStore?.Set(nameof(SubProvider), value); }
        }
        /// <summary>Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required</summary>
        public string Vendor {
            get { return BackingStore?.Get<string>(nameof(Vendor)); }
            set { BackingStore?.Set(nameof(Vendor), value); }
        }
        /// <summary>
        /// Instantiates a new securityVendorInformation and sets the default values.
        /// </summary>
        public SecurityVendorInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SecurityVendorInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityVendorInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"provider", n => { Provider = n.GetStringValue(); } },
                {"providerVersion", n => { ProviderVersion = n.GetStringValue(); } },
                {"subProvider", n => { SubProvider = n.GetStringValue(); } },
                {"vendor", n => { Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("providerVersion", ProviderVersion);
            writer.WriteStringValue("subProvider", SubProvider);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class X509CertificateUserBinding : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The priority property</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>The userProperty property</summary>
        public string UserProperty {
            get { return BackingStore?.Get<string>("userProperty"); }
            set { BackingStore?.Set("userProperty", value); }
        }
        /// <summary>The x509CertificateField property</summary>
        public string X509CertificateField {
            get { return BackingStore?.Get<string>("x509CertificateField"); }
            set { BackingStore?.Set("x509CertificateField", value); }
        }
        /// <summary>
        /// Instantiates a new x509CertificateUserBinding and sets the default values.
        /// </summary>
        public X509CertificateUserBinding() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.x509CertificateUserBinding";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static X509CertificateUserBinding CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new X509CertificateUserBinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"userProperty", n => { UserProperty = n.GetStringValue(); } },
                {"x509CertificateField", n => { X509CertificateField = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("userProperty", UserProperty);
            writer.WriteStringValue("x509CertificateField", X509CertificateField);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class DataSubject : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Email of the data subject.</summary>
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
        /// <summary>First name of the data subject.</summary>
        public string FirstName {
            get { return BackingStore?.Get<string>("firstName"); }
            set { BackingStore?.Set("firstName", value); }
        }
        /// <summary>Last Name of the data subject.</summary>
        public string LastName {
            get { return BackingStore?.Get<string>("lastName"); }
            set { BackingStore?.Set("lastName", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The country/region of residency. The residency information is uesed only for internal reporting but not for the content search.</summary>
        public string Residency {
            get { return BackingStore?.Get<string>("residency"); }
            set { BackingStore?.Set("residency", value); }
        }
        /// <summary>
        /// Instantiates a new dataSubject and sets the default values.
        /// </summary>
        public DataSubject() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.dataSubject";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DataSubject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"email", n => { Email = n.GetStringValue(); } },
                {"firstName", n => { FirstName = n.GetStringValue(); } },
                {"lastName", n => { LastName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"residency", n => { Residency = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("firstName", FirstName);
            writer.WriteStringValue("lastName", LastName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("residency", Residency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
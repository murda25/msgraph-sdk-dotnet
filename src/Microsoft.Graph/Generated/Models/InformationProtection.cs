using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class InformationProtection : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The bitlocker property</summary>
        public Microsoft.Graph.Models.Bitlocker Bitlocker {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Bitlocker>("bitlocker"); }
            set { BackingStore?.Set("bitlocker", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The threatAssessmentRequests property</summary>
        public List<ThreatAssessmentRequest> ThreatAssessmentRequests {
            get { return BackingStore?.Get<List<ThreatAssessmentRequest>>("threatAssessmentRequests"); }
            set { BackingStore?.Set("threatAssessmentRequests", value); }
        }
        /// <summary>
        /// Instantiates a new InformationProtection and sets the default values.
        /// </summary>
        public InformationProtection() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InformationProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bitlocker", n => { Bitlocker = n.GetObjectValue<Microsoft.Graph.Models.Bitlocker>(Microsoft.Graph.Models.Bitlocker.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"threatAssessmentRequests", n => { ThreatAssessmentRequests = n.GetCollectionOfObjectValues<ThreatAssessmentRequest>(ThreatAssessmentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.Bitlocker>("bitlocker", Bitlocker);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<ThreatAssessmentRequest>("threatAssessmentRequests", ThreatAssessmentRequests);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

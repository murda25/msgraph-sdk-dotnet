using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the informationProtection singleton.</summary>
    public class InformationProtection : Entity, IParsable {
        /// <summary>The bitlocker property</summary>
        public Microsoft.Graph.Models.Bitlocker Bitlocker { get; set; }
        /// <summary>The threatAssessmentRequests property</summary>
        public List<ThreatAssessmentRequest> ThreatAssessmentRequests { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new InformationProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"bitlocker", (o,n) => { (o as InformationProtection).Bitlocker = n.GetObjectValue<Microsoft.Graph.Models.Bitlocker>(Microsoft.Graph.Models.Bitlocker.CreateFromDiscriminatorValue); } },
                {"threatAssessmentRequests", (o,n) => { (o as InformationProtection).ThreatAssessmentRequests = n.GetCollectionOfObjectValues<ThreatAssessmentRequest>(ThreatAssessmentRequest.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.Bitlocker>("bitlocker", Bitlocker);
            writer.WriteCollectionOfObjectValues<ThreatAssessmentRequest>("threatAssessmentRequests", ThreatAssessmentRequests);
        }
    }
}
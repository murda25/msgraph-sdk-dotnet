using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AccessPackageApprovalStage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The durationBeforeAutomaticDenial property</summary>
        public TimeSpan? DurationBeforeAutomaticDenial { get; set; }
        /// <summary>The durationBeforeEscalation property</summary>
        public TimeSpan? DurationBeforeEscalation { get; set; }
        /// <summary>The escalationApprovers property</summary>
        public List<SubjectSet> EscalationApprovers { get; set; }
        /// <summary>The fallbackEscalationApprovers property</summary>
        public List<SubjectSet> FallbackEscalationApprovers { get; set; }
        /// <summary>The fallbackPrimaryApprovers property</summary>
        public List<SubjectSet> FallbackPrimaryApprovers { get; set; }
        /// <summary>The isApproverJustificationRequired property</summary>
        public bool? IsApproverJustificationRequired { get; set; }
        /// <summary>The isEscalationEnabled property</summary>
        public bool? IsEscalationEnabled { get; set; }
        /// <summary>The primaryApprovers property</summary>
        public List<SubjectSet> PrimaryApprovers { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageApprovalStage and sets the default values.
        /// </summary>
        public AccessPackageApprovalStage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageApprovalStage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageApprovalStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"durationBeforeAutomaticDenial", (o,n) => { (o as AccessPackageApprovalStage).DurationBeforeAutomaticDenial = n.GetTimeSpanValue(); } },
                {"durationBeforeEscalation", (o,n) => { (o as AccessPackageApprovalStage).DurationBeforeEscalation = n.GetTimeSpanValue(); } },
                {"escalationApprovers", (o,n) => { (o as AccessPackageApprovalStage).EscalationApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"fallbackEscalationApprovers", (o,n) => { (o as AccessPackageApprovalStage).FallbackEscalationApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"fallbackPrimaryApprovers", (o,n) => { (o as AccessPackageApprovalStage).FallbackPrimaryApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"isApproverJustificationRequired", (o,n) => { (o as AccessPackageApprovalStage).IsApproverJustificationRequired = n.GetBoolValue(); } },
                {"isEscalationEnabled", (o,n) => { (o as AccessPackageApprovalStage).IsEscalationEnabled = n.GetBoolValue(); } },
                {"primaryApprovers", (o,n) => { (o as AccessPackageApprovalStage).PrimaryApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("durationBeforeAutomaticDenial", DurationBeforeAutomaticDenial);
            writer.WriteTimeSpanValue("durationBeforeEscalation", DurationBeforeEscalation);
            writer.WriteCollectionOfObjectValues<SubjectSet>("escalationApprovers", EscalationApprovers);
            writer.WriteCollectionOfObjectValues<SubjectSet>("fallbackEscalationApprovers", FallbackEscalationApprovers);
            writer.WriteCollectionOfObjectValues<SubjectSet>("fallbackPrimaryApprovers", FallbackPrimaryApprovers);
            writer.WriteBoolValue("isApproverJustificationRequired", IsApproverJustificationRequired);
            writer.WriteBoolValue("isEscalationEnabled", IsEscalationEnabled);
            writer.WriteCollectionOfObjectValues<SubjectSet>("primaryApprovers", PrimaryApprovers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

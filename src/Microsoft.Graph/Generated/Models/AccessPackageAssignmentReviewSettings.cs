using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AccessPackageAssignmentReviewSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The default decision to apply if the access is not reviewed. The possible values are: keepAccess, removeAccess, acceptAccessRecommendation, unknownFutureValue.</summary>
        public AccessReviewExpirationBehavior? ExpirationBehavior { get; set; }
        /// <summary>This collection specifies the users who will be the fallback reviewers when the primary reviewers don&apos;t respond.</summary>
        public List<SubjectSet> FallbackReviewers { get; set; }
        /// <summary>If true, access reviews are required for assignments through this policy.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Specifies whether to display recommendations to the reviewer. The default value is true.</summary>
        public bool? IsRecommendationEnabled { get; set; }
        /// <summary>Specifies whether the reviewer must provide justification for the approval. The default value is true.</summary>
        public bool? IsReviewerJustificationRequired { get; set; }
        /// <summary>Specifies whether the principals can review their own assignments.</summary>
        public bool? IsSelfReview { get; set; }
        /// <summary>This collection specifies the users or group of users who will review the access package assignments.</summary>
        public List<SubjectSet> PrimaryReviewers { get; set; }
        /// <summary>When the first review should start and how often it should recur.</summary>
        public EntitlementManagementSchedule Schedule { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageAssignmentReviewSettings and sets the default values.
        /// </summary>
        public AccessPackageAssignmentReviewSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageAssignmentReviewSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentReviewSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expirationBehavior", (o,n) => { (o as AccessPackageAssignmentReviewSettings).ExpirationBehavior = n.GetEnumValue<AccessReviewExpirationBehavior>(); } },
                {"fallbackReviewers", (o,n) => { (o as AccessPackageAssignmentReviewSettings).FallbackReviewers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"isEnabled", (o,n) => { (o as AccessPackageAssignmentReviewSettings).IsEnabled = n.GetBoolValue(); } },
                {"isRecommendationEnabled", (o,n) => { (o as AccessPackageAssignmentReviewSettings).IsRecommendationEnabled = n.GetBoolValue(); } },
                {"isReviewerJustificationRequired", (o,n) => { (o as AccessPackageAssignmentReviewSettings).IsReviewerJustificationRequired = n.GetBoolValue(); } },
                {"isSelfReview", (o,n) => { (o as AccessPackageAssignmentReviewSettings).IsSelfReview = n.GetBoolValue(); } },
                {"primaryReviewers", (o,n) => { (o as AccessPackageAssignmentReviewSettings).PrimaryReviewers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"schedule", (o,n) => { (o as AccessPackageAssignmentReviewSettings).Schedule = n.GetObjectValue<EntitlementManagementSchedule>(EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessReviewExpirationBehavior>("expirationBehavior", ExpirationBehavior);
            writer.WriteCollectionOfObjectValues<SubjectSet>("fallbackReviewers", FallbackReviewers);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isRecommendationEnabled", IsRecommendationEnabled);
            writer.WriteBoolValue("isReviewerJustificationRequired", IsReviewerJustificationRequired);
            writer.WriteBoolValue("isSelfReview", IsSelfReview);
            writer.WriteCollectionOfObjectValues<SubjectSet>("primaryReviewers", PrimaryReviewers);
            writer.WriteObjectValue<EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

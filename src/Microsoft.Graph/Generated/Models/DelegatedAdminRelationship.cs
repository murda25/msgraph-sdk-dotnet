using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class DelegatedAdminRelationship : Entity, IParsable {
        /// <summary>The accessAssignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminAccessAssignment>? AccessAssignments {
            get { return BackingStore?.Get<List<DelegatedAdminAccessAssignment>?>("accessAssignments"); }
            set { BackingStore?.Set("accessAssignments", value); }
        }
#nullable restore
#else
        public List<DelegatedAdminAccessAssignment> AccessAssignments {
            get { return BackingStore?.Get<List<DelegatedAdminAccessAssignment>>("accessAssignments"); }
            set { BackingStore?.Set("accessAssignments", value); }
        }
#endif
        /// <summary>The accessDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DelegatedAdminAccessDetails? AccessDetails {
            get { return BackingStore?.Get<DelegatedAdminAccessDetails?>("accessDetails"); }
            set { BackingStore?.Set("accessDetails", value); }
        }
#nullable restore
#else
        public DelegatedAdminAccessDetails AccessDetails {
            get { return BackingStore?.Get<DelegatedAdminAccessDetails>("accessDetails"); }
            set { BackingStore?.Set("accessDetails", value); }
        }
#endif
        /// <summary>The activatedDateTime property</summary>
        public DateTimeOffset? ActivatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("activatedDateTime"); }
            set { BackingStore?.Set("activatedDateTime", value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DelegatedAdminRelationshipCustomerParticipant? Customer {
            get { return BackingStore?.Get<DelegatedAdminRelationshipCustomerParticipant?>("customer"); }
            set { BackingStore?.Set("customer", value); }
        }
#nullable restore
#else
        public DelegatedAdminRelationshipCustomerParticipant Customer {
            get { return BackingStore?.Get<DelegatedAdminRelationshipCustomerParticipant>("customer"); }
            set { BackingStore?.Set("customer", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The duration property</summary>
        public TimeSpan? Duration {
            get { return BackingStore?.Get<TimeSpan?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>The endDateTime property</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminRelationshipOperation>? Operations {
            get { return BackingStore?.Get<List<DelegatedAdminRelationshipOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<DelegatedAdminRelationshipOperation> Operations {
            get { return BackingStore?.Get<List<DelegatedAdminRelationshipOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The requests property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminRelationshipRequest>? Requests {
            get { return BackingStore?.Get<List<DelegatedAdminRelationshipRequest>?>("requests"); }
            set { BackingStore?.Set("requests", value); }
        }
#nullable restore
#else
        public List<DelegatedAdminRelationshipRequest> Requests {
            get { return BackingStore?.Get<List<DelegatedAdminRelationshipRequest>>("requests"); }
            set { BackingStore?.Set("requests", value); }
        }
#endif
        /// <summary>The status property</summary>
        public DelegatedAdminRelationshipStatus? Status {
            get { return BackingStore?.Get<DelegatedAdminRelationshipStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DelegatedAdminRelationship CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminRelationship();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessAssignments", n => { AccessAssignments = n.GetCollectionOfObjectValues<DelegatedAdminAccessAssignment>(DelegatedAdminAccessAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessDetails", n => { AccessDetails = n.GetObjectValue<DelegatedAdminAccessDetails>(DelegatedAdminAccessDetails.CreateFromDiscriminatorValue); } },
                {"activatedDateTime", n => { ActivatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<DelegatedAdminRelationshipCustomerParticipant>(DelegatedAdminRelationshipCustomerParticipant.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<DelegatedAdminRelationshipOperation>(DelegatedAdminRelationshipOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"requests", n => { Requests = n.GetCollectionOfObjectValues<DelegatedAdminRelationshipRequest>(DelegatedAdminRelationshipRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<DelegatedAdminRelationshipStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DelegatedAdminAccessAssignment>("accessAssignments", AccessAssignments);
            writer.WriteObjectValue<DelegatedAdminAccessDetails>("accessDetails", AccessDetails);
            writer.WriteDateTimeOffsetValue("activatedDateTime", ActivatedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DelegatedAdminRelationshipCustomerParticipant>("customer", Customer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteTimeSpanValue("duration", Duration);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<DelegatedAdminRelationshipOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<DelegatedAdminRelationshipRequest>("requests", Requests);
            writer.WriteEnumValue<DelegatedAdminRelationshipStatus>("status", Status);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class DirectoryAudit : Entity, IParsable {
        /// <summary>Indicates the date and time the activity was performed. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ActivityDateTime)); }
            set { BackingStore?.Set(nameof(ActivityDateTime), value); }
        }
        /// <summary>Indicates the activity name or the operation name (E.g. &apos;Create User&apos;, &apos;Add member to group&apos;). For a list of activities logged, refer to Azure Ad activity list.</summary>
        public string ActivityDisplayName {
            get { return BackingStore?.Get<string>(nameof(ActivityDisplayName)); }
            set { BackingStore?.Set(nameof(ActivityDisplayName), value); }
        }
        /// <summary>Indicates additional details on the activity.</summary>
        public List<KeyValue> AdditionalDetails {
            get { return BackingStore?.Get<List<KeyValue>>(nameof(AdditionalDetails)); }
            set { BackingStore?.Set(nameof(AdditionalDetails), value); }
        }
        /// <summary>Indicates which resource category that&apos;s targeted by the activity. (For example: User Management, Group Management etc..)</summary>
        public string Category {
            get { return BackingStore?.Get<string>(nameof(Category)); }
            set { BackingStore?.Set(nameof(Category), value); }
        }
        /// <summary>Indicates a unique ID that helps correlate activities that span across various services. Can be used to trace logs across services.</summary>
        public string CorrelationId {
            get { return BackingStore?.Get<string>(nameof(CorrelationId)); }
            set { BackingStore?.Set(nameof(CorrelationId), value); }
        }
        /// <summary>The initiatedBy property</summary>
        public AuditActivityInitiator InitiatedBy {
            get { return BackingStore?.Get<AuditActivityInitiator>(nameof(InitiatedBy)); }
            set { BackingStore?.Set(nameof(InitiatedBy), value); }
        }
        /// <summary>Indicates information on which service initiated the activity (For example: Self-service Password Management, Core Directory, B2C, Invited Users, Microsoft Identity Manager, Privileged Identity Management.</summary>
        public string LoggedByService {
            get { return BackingStore?.Get<string>(nameof(LoggedByService)); }
            set { BackingStore?.Set(nameof(LoggedByService), value); }
        }
        /// <summary>Indicates the type of operation that was performed. The possible values include but are not limited to the following: Add, Assign, Update, Unassign, and Delete.</summary>
        public string OperationType {
            get { return BackingStore?.Get<string>(nameof(OperationType)); }
            set { BackingStore?.Set(nameof(OperationType), value); }
        }
        /// <summary>Indicates the result of the activity. Possible values are: success, failure, timeout, unknownFutureValue.</summary>
        public OperationResult? Result {
            get { return BackingStore?.Get<OperationResult?>(nameof(Result)); }
            set { BackingStore?.Set(nameof(Result), value); }
        }
        /// <summary>Indicates the reason for failure if the result is failure or timeout.</summary>
        public string ResultReason {
            get { return BackingStore?.Get<string>(nameof(ResultReason)); }
            set { BackingStore?.Set(nameof(ResultReason), value); }
        }
        /// <summary>Information about the resource that changed due to the activity.</summary>
        public List<TargetResource> TargetResources {
            get { return BackingStore?.Get<List<TargetResource>>(nameof(TargetResources)); }
            set { BackingStore?.Set(nameof(TargetResources), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DirectoryAudit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryAudit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityDisplayName", n => { ActivityDisplayName = n.GetStringValue(); } },
                {"additionalDetails", n => { AdditionalDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"initiatedBy", n => { InitiatedBy = n.GetObjectValue<AuditActivityInitiator>(AuditActivityInitiator.CreateFromDiscriminatorValue); } },
                {"loggedByService", n => { LoggedByService = n.GetStringValue(); } },
                {"operationType", n => { OperationType = n.GetStringValue(); } },
                {"result", n => { Result = n.GetEnumValue<OperationResult>(); } },
                {"resultReason", n => { ResultReason = n.GetStringValue(); } },
                {"targetResources", n => { TargetResources = n.GetCollectionOfObjectValues<TargetResource>(TargetResource.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("activityDisplayName", ActivityDisplayName);
            writer.WriteCollectionOfObjectValues<KeyValue>("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteObjectValue<AuditActivityInitiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("loggedByService", LoggedByService);
            writer.WriteStringValue("operationType", OperationType);
            writer.WriteEnumValue<OperationResult>("result", Result);
            writer.WriteStringValue("resultReason", ResultReason);
            writer.WriteCollectionOfObjectValues<TargetResource>("targetResources", TargetResources);
        }
    }
}
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class RetentionEvent : Entity, IParsable {
        /// <summary>The user who created the retentionEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.IdentitySet? CreatedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.IdentitySet CreatedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The date time when the retentionEvent was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Optional information about the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Name of the event.</summary>
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
        /// <summary>The eventPropagationResults property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EventPropagationResult>? EventPropagationResults {
            get { return BackingStore?.Get<List<EventPropagationResult>?>("eventPropagationResults"); }
            set { BackingStore?.Set("eventPropagationResults", value); }
        }
#nullable restore
#else
        public List<EventPropagationResult> EventPropagationResults {
            get { return BackingStore?.Get<List<EventPropagationResult>>("eventPropagationResults"); }
            set { BackingStore?.Set("eventPropagationResults", value); }
        }
#endif
        /// <summary>Represents the workload (SharePoint Online, OneDrive for Business, Exchange Online) and identification information associated with a retention event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EventQuery>? EventQueries {
            get { return BackingStore?.Get<List<EventQuery>?>("eventQueries"); }
            set { BackingStore?.Set("eventQueries", value); }
        }
#nullable restore
#else
        public List<EventQuery> EventQueries {
            get { return BackingStore?.Get<List<EventQuery>>("eventQueries"); }
            set { BackingStore?.Set("eventQueries", value); }
        }
#endif
        /// <summary>The eventStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RetentionEventStatus? EventStatus {
            get { return BackingStore?.Get<RetentionEventStatus?>("eventStatus"); }
            set { BackingStore?.Set("eventStatus", value); }
        }
#nullable restore
#else
        public RetentionEventStatus EventStatus {
            get { return BackingStore?.Get<RetentionEventStatus>("eventStatus"); }
            set { BackingStore?.Set("eventStatus", value); }
        }
#endif
        /// <summary>Optional time when the event should be triggered.</summary>
        public DateTimeOffset? EventTriggerDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("eventTriggerDateTime"); }
            set { BackingStore?.Set("eventTriggerDateTime", value); }
        }
        /// <summary>The user who last modified the retentionEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.IdentitySet? LastModifiedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The latest date time when the retentionEvent was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Last time the status of the event was updated.</summary>
        public DateTimeOffset? LastStatusUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastStatusUpdateDateTime"); }
            set { BackingStore?.Set("lastStatusUpdateDateTime", value); }
        }
        /// <summary>Specifies the event that will start the retention period for labels that use this event type when an event is created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.RetentionEventType? RetentionEventType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.RetentionEventType?>("retentionEventType"); }
            set { BackingStore?.Set("retentionEventType", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.RetentionEventType RetentionEventType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.RetentionEventType>("retentionEventType"); }
            set { BackingStore?.Set("retentionEventType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RetentionEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetentionEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Models.IdentitySet>(Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"eventPropagationResults", n => { EventPropagationResults = n.GetCollectionOfObjectValues<EventPropagationResult>(EventPropagationResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eventQueries", n => { EventQueries = n.GetCollectionOfObjectValues<EventQuery>(EventQuery.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eventStatus", n => { EventStatus = n.GetObjectValue<RetentionEventStatus>(RetentionEventStatus.CreateFromDiscriminatorValue); } },
                {"eventTriggerDateTime", n => { EventTriggerDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Models.IdentitySet>(Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastStatusUpdateDateTime", n => { LastStatusUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"retentionEventType", n => { RetentionEventType = n.GetObjectValue<Microsoft.Graph.Models.Security.RetentionEventType>(Microsoft.Graph.Models.Security.RetentionEventType.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<EventPropagationResult>("eventPropagationResults", EventPropagationResults);
            writer.WriteCollectionOfObjectValues<EventQuery>("eventQueries", EventQueries);
            writer.WriteObjectValue<RetentionEventStatus>("eventStatus", EventStatus);
            writer.WriteDateTimeOffsetValue("eventTriggerDateTime", EventTriggerDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastStatusUpdateDateTime", LastStatusUpdateDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.RetentionEventType>("retentionEventType", RetentionEventType);
        }
    }
}

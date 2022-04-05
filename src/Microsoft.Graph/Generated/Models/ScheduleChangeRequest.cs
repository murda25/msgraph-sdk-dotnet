using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ScheduleChangeRequest : ChangeTrackedEntity, IParsable {
        /// <summary>The assignedTo property</summary>
        public ScheduleChangeRequestActor? AssignedTo { get; set; }
        /// <summary>The managerActionDateTime property</summary>
        public DateTimeOffset? ManagerActionDateTime { get; set; }
        /// <summary>The managerActionMessage property</summary>
        public string ManagerActionMessage { get; set; }
        /// <summary>The managerUserId property</summary>
        public string ManagerUserId { get; set; }
        /// <summary>The senderDateTime property</summary>
        public DateTimeOffset? SenderDateTime { get; set; }
        /// <summary>The senderMessage property</summary>
        public string SenderMessage { get; set; }
        /// <summary>The senderUserId property</summary>
        public string SenderUserId { get; set; }
        /// <summary>The state property</summary>
        public ScheduleChangeState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ScheduleChangeRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScheduleChangeRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignedTo", (o,n) => { (o as ScheduleChangeRequest).AssignedTo = n.GetEnumValue<ScheduleChangeRequestActor>(); } },
                {"managerActionDateTime", (o,n) => { (o as ScheduleChangeRequest).ManagerActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managerActionMessage", (o,n) => { (o as ScheduleChangeRequest).ManagerActionMessage = n.GetStringValue(); } },
                {"managerUserId", (o,n) => { (o as ScheduleChangeRequest).ManagerUserId = n.GetStringValue(); } },
                {"senderDateTime", (o,n) => { (o as ScheduleChangeRequest).SenderDateTime = n.GetDateTimeOffsetValue(); } },
                {"senderMessage", (o,n) => { (o as ScheduleChangeRequest).SenderMessage = n.GetStringValue(); } },
                {"senderUserId", (o,n) => { (o as ScheduleChangeRequest).SenderUserId = n.GetStringValue(); } },
                {"state", (o,n) => { (o as ScheduleChangeRequest).State = n.GetEnumValue<ScheduleChangeState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ScheduleChangeRequestActor>("assignedTo", AssignedTo);
            writer.WriteDateTimeOffsetValue("managerActionDateTime", ManagerActionDateTime);
            writer.WriteStringValue("managerActionMessage", ManagerActionMessage);
            writer.WriteStringValue("managerUserId", ManagerUserId);
            writer.WriteDateTimeOffsetValue("senderDateTime", SenderDateTime);
            writer.WriteStringValue("senderMessage", SenderMessage);
            writer.WriteStringValue("senderUserId", SenderUserId);
            writer.WriteEnumValue<ScheduleChangeState>("state", State);
        }
    }
}
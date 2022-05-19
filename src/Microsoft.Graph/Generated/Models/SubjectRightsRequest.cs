using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the privacy singleton.</summary>
    public class SubjectRightsRequest : Entity, IParsable {
        /// <summary>Identity that the request is assigned to.</summary>
        public Identity AssignedTo {
            get { return BackingStore?.Get<Identity>(nameof(AssignedTo)); }
            set { BackingStore?.Set(nameof(AssignedTo), value); }
        }
        /// <summary>The date and time when the request was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ClosedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ClosedDateTime)); }
            set { BackingStore?.Set(nameof(ClosedDateTime), value); }
        }
        /// <summary>Identity information for the entity that created the request.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The date and time when the request was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Information about the data subject.</summary>
        public Microsoft.Graph.Models.DataSubject DataSubject {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DataSubject>(nameof(DataSubject)); }
            set { BackingStore?.Set(nameof(DataSubject), value); }
        }
        /// <summary>The type of the data subject. Possible values are: customer, currentEmployee, formerEmployee, prospectiveEmployee, student, teacher, faculty, other, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.DataSubjectType? DataSubjectType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DataSubjectType?>(nameof(DataSubjectType)); }
            set { BackingStore?.Set(nameof(DataSubjectType), value); }
        }
        /// <summary>Description for the request.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The name of the request.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Collection of history change events.</summary>
        public List<SubjectRightsRequestHistory> History {
            get { return BackingStore?.Get<List<SubjectRightsRequestHistory>>(nameof(History)); }
            set { BackingStore?.Set(nameof(History), value); }
        }
        /// <summary>Insight about the request.</summary>
        public SubjectRightsRequestDetail Insight {
            get { return BackingStore?.Get<SubjectRightsRequestDetail>(nameof(Insight)); }
            set { BackingStore?.Set(nameof(Insight), value); }
        }
        /// <summary>The date and time when the request is internally due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? InternalDueDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(InternalDueDateTime)); }
            set { BackingStore?.Set(nameof(InternalDueDateTime), value); }
        }
        /// <summary>Identity information for the entity that last modified the request.</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>The date and time when the request was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>List of notes associated with the request.</summary>
        public List<AuthoredNote> Notes {
            get { return BackingStore?.Get<List<AuthoredNote>>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>List of regulations that this request will fulfill.</summary>
        public List<string> Regulations {
            get { return BackingStore?.Get<List<string>>(nameof(Regulations)); }
            set { BackingStore?.Set(nameof(Regulations), value); }
        }
        /// <summary>Information about the different stages for the request.</summary>
        public List<SubjectRightsRequestStageDetail> Stages {
            get { return BackingStore?.Get<List<SubjectRightsRequestStageDetail>>(nameof(Stages)); }
            set { BackingStore?.Set(nameof(Stages), value); }
        }
        /// <summary>The status of the request. Possible values are: active, closed, unknownFutureValue.</summary>
        public SubjectRightsRequestStatus? Status {
            get { return BackingStore?.Get<SubjectRightsRequestStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>Information about the Microsoft Teams team that was created for the request.</summary>
        public Microsoft.Graph.Models.Team Team {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Team>(nameof(Team)); }
            set { BackingStore?.Set(nameof(Team), value); }
        }
        /// <summary>The type of the request. Possible values are: export, delete, access, tagForAction, unknownFutureValue.</summary>
        public SubjectRightsRequestType? Type {
            get { return BackingStore?.Get<SubjectRightsRequestType?>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SubjectRightsRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTo", n => { AssignedTo = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dataSubject", n => { DataSubject = n.GetObjectValue<Microsoft.Graph.Models.DataSubject>(Microsoft.Graph.Models.DataSubject.CreateFromDiscriminatorValue); } },
                {"dataSubjectType", n => { DataSubjectType = n.GetEnumValue<DataSubjectType>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"history", n => { History = n.GetCollectionOfObjectValues<SubjectRightsRequestHistory>(SubjectRightsRequestHistory.CreateFromDiscriminatorValue).ToList(); } },
                {"insight", n => { Insight = n.GetObjectValue<SubjectRightsRequestDetail>(SubjectRightsRequestDetail.CreateFromDiscriminatorValue); } },
                {"internalDueDateTime", n => { InternalDueDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", n => { Notes = n.GetCollectionOfObjectValues<AuthoredNote>(AuthoredNote.CreateFromDiscriminatorValue).ToList(); } },
                {"regulations", n => { Regulations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"stages", n => { Stages = n.GetCollectionOfObjectValues<SubjectRightsRequestStageDetail>(SubjectRightsRequestStageDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"status", n => { Status = n.GetEnumValue<SubjectRightsRequestStatus>(); } },
                {"team", n => { Team = n.GetObjectValue<Microsoft.Graph.Models.Team>(Microsoft.Graph.Models.Team.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<SubjectRightsRequestType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Identity>("assignedTo", AssignedTo);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Models.DataSubject>("dataSubject", DataSubject);
            writer.WriteEnumValue<DataSubjectType>("dataSubjectType", DataSubjectType);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<SubjectRightsRequestHistory>("history", History);
            writer.WriteObjectValue<SubjectRightsRequestDetail>("insight", Insight);
            writer.WriteDateTimeOffsetValue("internalDueDateTime", InternalDueDateTime);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<AuthoredNote>("notes", Notes);
            writer.WriteCollectionOfPrimitiveValues<string>("regulations", Regulations);
            writer.WriteCollectionOfObjectValues<SubjectRightsRequestStageDetail>("stages", Stages);
            writer.WriteEnumValue<SubjectRightsRequestStatus>("status", Status);
            writer.WriteObjectValue<Microsoft.Graph.Models.Team>("team", Team);
            writer.WriteEnumValue<SubjectRightsRequestType>("type", Type);
        }
    }
}

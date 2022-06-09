using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the educationRoot singleton.</summary>
    public class EducationSubmission : Entity, IParsable {
        /// <summary>The outcomes property</summary>
        public List<EducationOutcome> Outcomes {
            get { return BackingStore?.Get<List<EducationOutcome>>(nameof(Outcomes)); }
            set { BackingStore?.Set(nameof(Outcomes), value); }
        }
        /// <summary>User who moved the status of this submission to reassigned.</summary>
        public IdentitySet ReassignedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(ReassignedBy)); }
            set { BackingStore?.Set(nameof(ReassignedBy), value); }
        }
        /// <summary>Moment in time when the submission was reassigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReassignedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ReassignedDateTime)); }
            set { BackingStore?.Set(nameof(ReassignedDateTime), value); }
        }
        /// <summary>Who this submission is assigned to.</summary>
        public EducationSubmissionRecipient Recipient {
            get { return BackingStore?.Get<EducationSubmissionRecipient>(nameof(Recipient)); }
            set { BackingStore?.Set(nameof(Recipient), value); }
        }
        /// <summary>The resources property</summary>
        public List<EducationSubmissionResource> Resources {
            get { return BackingStore?.Get<List<EducationSubmissionResource>>(nameof(Resources)); }
            set { BackingStore?.Set(nameof(Resources), value); }
        }
        /// <summary>Folder where all file resources for this submission need to be stored.</summary>
        public string ResourcesFolderUrl {
            get { return BackingStore?.Get<string>(nameof(ResourcesFolderUrl)); }
            set { BackingStore?.Set(nameof(ResourcesFolderUrl), value); }
        }
        /// <summary>User who moved the status of this submission to returned.</summary>
        public IdentitySet ReturnedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(ReturnedBy)); }
            set { BackingStore?.Set(nameof(ReturnedBy), value); }
        }
        /// <summary>Moment in time when the submission was returned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReturnedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ReturnedDateTime)); }
            set { BackingStore?.Set(nameof(ReturnedDateTime), value); }
        }
        /// <summary>Read-only. Possible values are: working, submitted, released, returned, unknownFutureValue and reassigned. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: reassigned.</summary>
        public EducationSubmissionStatus? Status {
            get { return BackingStore?.Get<EducationSubmissionStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>User who moved the resource into the submitted state.</summary>
        public IdentitySet SubmittedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(SubmittedBy)); }
            set { BackingStore?.Set(nameof(SubmittedBy), value); }
        }
        /// <summary>Moment in time when the submission was moved into the submitted state. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? SubmittedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(SubmittedDateTime)); }
            set { BackingStore?.Set(nameof(SubmittedDateTime), value); }
        }
        /// <summary>The submittedResources property</summary>
        public List<EducationSubmissionResource> SubmittedResources {
            get { return BackingStore?.Get<List<EducationSubmissionResource>>(nameof(SubmittedResources)); }
            set { BackingStore?.Set(nameof(SubmittedResources), value); }
        }
        /// <summary>User who moved the resource from submitted into the working state.</summary>
        public IdentitySet UnsubmittedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(UnsubmittedBy)); }
            set { BackingStore?.Set(nameof(UnsubmittedBy), value); }
        }
        /// <summary>Moment in time when the submission was moved from submitted into the working state. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? UnsubmittedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(UnsubmittedDateTime)); }
            set { BackingStore?.Set(nameof(UnsubmittedDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationSubmission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSubmission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"outcomes", n => { Outcomes = n.GetCollectionOfObjectValues<EducationOutcome>(EducationOutcome.CreateFromDiscriminatorValue).ToList(); } },
                {"reassignedBy", n => { ReassignedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"reassignedDateTime", n => { ReassignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipient", n => { Recipient = n.GetObjectValue<EducationSubmissionRecipient>(EducationSubmissionRecipient.CreateFromDiscriminatorValue); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<EducationSubmissionResource>(EducationSubmissionResource.CreateFromDiscriminatorValue).ToList(); } },
                {"resourcesFolderUrl", n => { ResourcesFolderUrl = n.GetStringValue(); } },
                {"returnedBy", n => { ReturnedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"returnedDateTime", n => { ReturnedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<EducationSubmissionStatus>(); } },
                {"submittedBy", n => { SubmittedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"submittedDateTime", n => { SubmittedDateTime = n.GetDateTimeOffsetValue(); } },
                {"submittedResources", n => { SubmittedResources = n.GetCollectionOfObjectValues<EducationSubmissionResource>(EducationSubmissionResource.CreateFromDiscriminatorValue).ToList(); } },
                {"unsubmittedBy", n => { UnsubmittedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"unsubmittedDateTime", n => { UnsubmittedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EducationOutcome>("outcomes", Outcomes);
            writer.WriteObjectValue<IdentitySet>("reassignedBy", ReassignedBy);
            writer.WriteDateTimeOffsetValue("reassignedDateTime", ReassignedDateTime);
            writer.WriteObjectValue<EducationSubmissionRecipient>("recipient", Recipient);
            writer.WriteCollectionOfObjectValues<EducationSubmissionResource>("resources", Resources);
            writer.WriteStringValue("resourcesFolderUrl", ResourcesFolderUrl);
            writer.WriteObjectValue<IdentitySet>("returnedBy", ReturnedBy);
            writer.WriteDateTimeOffsetValue("returnedDateTime", ReturnedDateTime);
            writer.WriteEnumValue<EducationSubmissionStatus>("status", Status);
            writer.WriteObjectValue<IdentitySet>("submittedBy", SubmittedBy);
            writer.WriteDateTimeOffsetValue("submittedDateTime", SubmittedDateTime);
            writer.WriteCollectionOfObjectValues<EducationSubmissionResource>("submittedResources", SubmittedResources);
            writer.WriteObjectValue<IdentitySet>("unsubmittedBy", UnsubmittedBy);
            writer.WriteDateTimeOffsetValue("unsubmittedDateTime", UnsubmittedDateTime);
        }
    }
}
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the educationRoot singleton.</summary>
    public class EducationClass : Entity, IParsable {
        /// <summary>All categories associated with this class. Nullable.</summary>
        public List<EducationCategory> AssignmentCategories {
            get { return BackingStore?.Get<List<EducationCategory>>(nameof(AssignmentCategories)); }
            set { BackingStore?.Set(nameof(AssignmentCategories), value); }
        }
        /// <summary>Specifies class-level defaults respected by new assignments created in the class.</summary>
        public EducationAssignmentDefaults AssignmentDefaults {
            get { return BackingStore?.Get<EducationAssignmentDefaults>(nameof(AssignmentDefaults)); }
            set { BackingStore?.Set(nameof(AssignmentDefaults), value); }
        }
        /// <summary>All assignments associated with this class. Nullable.</summary>
        public List<EducationAssignment> Assignments {
            get { return BackingStore?.Get<List<EducationAssignment>>(nameof(Assignments)); }
            set { BackingStore?.Set(nameof(Assignments), value); }
        }
        /// <summary>Specifies class-level assignments settings.</summary>
        public EducationAssignmentSettings AssignmentSettings {
            get { return BackingStore?.Get<EducationAssignmentSettings>(nameof(AssignmentSettings)); }
            set { BackingStore?.Set(nameof(AssignmentSettings), value); }
        }
        /// <summary>Class code used by the school to identify the class.</summary>
        public string ClassCode {
            get { return BackingStore?.Get<string>(nameof(ClassCode)); }
            set { BackingStore?.Set(nameof(ClassCode), value); }
        }
        /// <summary>Course information for the class.</summary>
        public EducationCourse Course {
            get { return BackingStore?.Get<EducationCourse>(nameof(Course)); }
            set { BackingStore?.Set(nameof(Course), value); }
        }
        /// <summary>Entity who created the class.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>Description of the class.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Name of the class.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>ID of the class from the syncing system.</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>(nameof(ExternalId)); }
            set { BackingStore?.Set(nameof(ExternalId), value); }
        }
        /// <summary>Name of the class in the syncing system.</summary>
        public string ExternalName {
            get { return BackingStore?.Get<string>(nameof(ExternalName)); }
            set { BackingStore?.Set(nameof(ExternalName), value); }
        }
        /// <summary>The type of external source this resource was generated from (automatically determined from externalSourceDetail). Possible values are: sis, lms, or manual.</summary>
        public EducationExternalSource? ExternalSource {
            get { return BackingStore?.Get<EducationExternalSource?>(nameof(ExternalSource)); }
            set { BackingStore?.Set(nameof(ExternalSource), value); }
        }
        /// <summary>The name of the external source this resources was generated from.</summary>
        public string ExternalSourceDetail {
            get { return BackingStore?.Get<string>(nameof(ExternalSourceDetail)); }
            set { BackingStore?.Set(nameof(ExternalSourceDetail), value); }
        }
        /// <summary>Grade level of the class.</summary>
        public string Grade {
            get { return BackingStore?.Get<string>(nameof(Grade)); }
            set { BackingStore?.Set(nameof(Grade), value); }
        }
        /// <summary>The underlying Microsoft 365 group object.</summary>
        public Microsoft.Graph.Models.Group Group {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Group>(nameof(Group)); }
            set { BackingStore?.Set(nameof(Group), value); }
        }
        /// <summary>Mail name for sending email to all members, if this is enabled.</summary>
        public string MailNickname {
            get { return BackingStore?.Get<string>(nameof(MailNickname)); }
            set { BackingStore?.Set(nameof(MailNickname), value); }
        }
        /// <summary>All users in the class. Nullable.</summary>
        public List<EducationUser> Members {
            get { return BackingStore?.Get<List<EducationUser>>(nameof(Members)); }
            set { BackingStore?.Set(nameof(Members), value); }
        }
        /// <summary>All schools that this class is associated with. Nullable.</summary>
        public List<EducationSchool> Schools {
            get { return BackingStore?.Get<List<EducationSchool>>(nameof(Schools)); }
            set { BackingStore?.Set(nameof(Schools), value); }
        }
        /// <summary>All teachers in the class. Nullable.</summary>
        public List<EducationUser> Teachers {
            get { return BackingStore?.Get<List<EducationUser>>(nameof(Teachers)); }
            set { BackingStore?.Set(nameof(Teachers), value); }
        }
        /// <summary>Term for the class.</summary>
        public EducationTerm Term {
            get { return BackingStore?.Get<EducationTerm>(nameof(Term)); }
            set { BackingStore?.Set(nameof(Term), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationClass CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationClass();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignmentCategories", n => { AssignmentCategories = n.GetCollectionOfObjectValues<EducationCategory>(EducationCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"assignmentDefaults", n => { AssignmentDefaults = n.GetObjectValue<EducationAssignmentDefaults>(EducationAssignmentDefaults.CreateFromDiscriminatorValue); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<EducationAssignment>(EducationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"assignmentSettings", n => { AssignmentSettings = n.GetObjectValue<EducationAssignmentSettings>(EducationAssignmentSettings.CreateFromDiscriminatorValue); } },
                {"classCode", n => { ClassCode = n.GetStringValue(); } },
                {"course", n => { Course = n.GetObjectValue<EducationCourse>(EducationCourse.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"externalName", n => { ExternalName = n.GetStringValue(); } },
                {"externalSource", n => { ExternalSource = n.GetEnumValue<EducationExternalSource>(); } },
                {"externalSourceDetail", n => { ExternalSourceDetail = n.GetStringValue(); } },
                {"grade", n => { Grade = n.GetStringValue(); } },
                {"group", n => { Group = n.GetObjectValue<Microsoft.Graph.Models.Group>(Microsoft.Graph.Models.Group.CreateFromDiscriminatorValue); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<EducationUser>(EducationUser.CreateFromDiscriminatorValue).ToList(); } },
                {"schools", n => { Schools = n.GetCollectionOfObjectValues<EducationSchool>(EducationSchool.CreateFromDiscriminatorValue).ToList(); } },
                {"teachers", n => { Teachers = n.GetCollectionOfObjectValues<EducationUser>(EducationUser.CreateFromDiscriminatorValue).ToList(); } },
                {"term", n => { Term = n.GetObjectValue<EducationTerm>(EducationTerm.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EducationCategory>("assignmentCategories", AssignmentCategories);
            writer.WriteObjectValue<EducationAssignmentDefaults>("assignmentDefaults", AssignmentDefaults);
            writer.WriteCollectionOfObjectValues<EducationAssignment>("assignments", Assignments);
            writer.WriteObjectValue<EducationAssignmentSettings>("assignmentSettings", AssignmentSettings);
            writer.WriteStringValue("classCode", ClassCode);
            writer.WriteObjectValue<EducationCourse>("course", Course);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalName", ExternalName);
            writer.WriteEnumValue<EducationExternalSource>("externalSource", ExternalSource);
            writer.WriteStringValue("externalSourceDetail", ExternalSourceDetail);
            writer.WriteStringValue("grade", Grade);
            writer.WriteObjectValue<Microsoft.Graph.Models.Group>("group", Group);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteCollectionOfObjectValues<EducationUser>("members", Members);
            writer.WriteCollectionOfObjectValues<EducationSchool>("schools", Schools);
            writer.WriteCollectionOfObjectValues<EducationUser>("teachers", Teachers);
            writer.WriteObjectValue<EducationTerm>("term", Term);
        }
    }
}
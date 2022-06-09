using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class OrgContact : DirectoryObject, IParsable {
        /// <summary>Postal addresses for this organizational contact. For now a contact can only have one physical address.</summary>
        public List<PhysicalOfficeAddress> Addresses {
            get { return BackingStore?.Get<List<PhysicalOfficeAddress>>(nameof(Addresses)); }
            set { BackingStore?.Set(nameof(Addresses), value); }
        }
        /// <summary>Name of the company that this organizational contact belong to. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string CompanyName {
            get { return BackingStore?.Get<string>(nameof(CompanyName)); }
            set { BackingStore?.Set(nameof(CompanyName), value); }
        }
        /// <summary>The name for the department in which the contact works. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string Department {
            get { return BackingStore?.Get<string>(nameof(Department)); }
            set { BackingStore?.Set(nameof(Department), value); }
        }
        /// <summary>The contact&apos;s direct reports. (The users and contacts that have their manager property set to this contact.) Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> DirectReports {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(DirectReports)); }
            set { BackingStore?.Set(nameof(DirectReports), value); }
        }
        /// <summary>Display name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>First name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string GivenName {
            get { return BackingStore?.Get<string>(nameof(GivenName)); }
            set { BackingStore?.Set(nameof(GivenName), value); }
        }
        /// <summary>Job title for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string JobTitle {
            get { return BackingStore?.Get<string>(nameof(JobTitle)); }
            set { BackingStore?.Set(nameof(JobTitle), value); }
        }
        /// <summary>The SMTP address for the contact, for example, &apos;jeff@contoso.onmicrosoft.com&apos;. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string Mail {
            get { return BackingStore?.Get<string>(nameof(Mail)); }
            set { BackingStore?.Set(nameof(Mail), value); }
        }
        /// <summary>Email alias (portion of email address pre-pending the @ symbol) for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string MailNickname {
            get { return BackingStore?.Get<string>(nameof(MailNickname)); }
            set { BackingStore?.Set(nameof(MailNickname), value); }
        }
        /// <summary>The user or contact that is this contact&apos;s manager. Read-only. Supports $expand.</summary>
        public DirectoryObject Manager {
            get { return BackingStore?.Get<DirectoryObject>(nameof(Manager)); }
            set { BackingStore?.Set(nameof(Manager), value); }
        }
        /// <summary>Groups that this contact is a member of. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(MemberOf)); }
            set { BackingStore?.Set(nameof(MemberOf), value); }
        }
        /// <summary>Date and time when this organizational contact was last synchronized from on-premises AD. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(OnPremisesLastSyncDateTime)); }
            set { BackingStore?.Set(nameof(OnPremisesLastSyncDateTime), value); }
        }
        /// <summary>List of any synchronization provisioning errors for this organizational contact. Supports $filter (eq, not).</summary>
        public List<OnPremisesProvisioningError> OnPremisesProvisioningErrors {
            get { return BackingStore?.Get<List<OnPremisesProvisioningError>>(nameof(OnPremisesProvisioningErrors)); }
            set { BackingStore?.Set(nameof(OnPremisesProvisioningErrors), value); }
        }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced and now mastered in Exchange; null if this object has never been synced from an on-premises directory (default).  Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled {
            get { return BackingStore?.Get<bool?>(nameof(OnPremisesSyncEnabled)); }
            set { BackingStore?.Set(nameof(OnPremisesSyncEnabled), value); }
        }
        /// <summary>List of phones for this organizational contact. Phone types can be mobile, business, and businessFax. Only one of each type can ever be present in the collection. Supports $filter (eq, ne, not, in).</summary>
        public List<Phone> Phones {
            get { return BackingStore?.Get<List<Phone>>(nameof(Phones)); }
            set { BackingStore?.Set(nameof(Phones), value); }
        }
        /// <summary>For example: &apos;SMTP: bob@contoso.com&apos;, &apos;smtp: bob@sales.contoso.com&apos;. The any operator is required for filter expressions on multi-valued properties. Supports $filter (eq, not, ge, le, startsWith, and counting empty collections).</summary>
        public List<string> ProxyAddresses {
            get { return BackingStore?.Get<List<string>>(nameof(ProxyAddresses)); }
            set { BackingStore?.Set(nameof(ProxyAddresses), value); }
        }
        /// <summary>Last name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values)</summary>
        public string Surname {
            get { return BackingStore?.Get<string>(nameof(Surname)); }
            set { BackingStore?.Set(nameof(Surname), value); }
        }
        /// <summary>The transitiveMemberOf property</summary>
        public List<DirectoryObject> TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(TransitiveMemberOf)); }
            set { BackingStore?.Set(nameof(TransitiveMemberOf), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OrgContact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrgContact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addresses", n => { Addresses = n.GetCollectionOfObjectValues<PhysicalOfficeAddress>(PhysicalOfficeAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"directReports", n => { DirectReports = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"mail", n => { Mail = n.GetStringValue(); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"manager", n => { Manager = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesProvisioningErrors", n => { OnPremisesProvisioningErrors = n.GetCollectionOfObjectValues<OnPremisesProvisioningError>(OnPremisesProvisioningError.CreateFromDiscriminatorValue).ToList(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"phones", n => { Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue).ToList(); } },
                {"proxyAddresses", n => { ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PhysicalOfficeAddress>("addresses", Addresses);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("directReports", DirectReports);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("mail", Mail);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteObjectValue<DirectoryObject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteCollectionOfObjectValues<OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteStringValue("surname", Surname);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
        }
    }
}
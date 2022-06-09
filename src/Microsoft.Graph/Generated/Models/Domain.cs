using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the collection of domain entities.</summary>
    public class Domain : Entity, IParsable {
        /// <summary>Indicates the configured authentication type for the domain. The value is either Managed or Federated. Managed indicates a cloud managed domain where Azure AD performs user authentication. Federated indicates authentication is federated with an identity provider such as the tenant&apos;s on-premises Active Directory via Active Directory Federation Services. This property is read-only and is not nullable.</summary>
        public string AuthenticationType {
            get { return BackingStore?.Get<string>(nameof(AuthenticationType)); }
            set { BackingStore?.Set(nameof(AuthenticationType), value); }
        }
        /// <summary>This property is always null except when the verify action is used. When the verify action is used, a domain entity is returned in the response. The availabilityStatus property of the domain entity in the response is either AvailableImmediately or EmailVerifiedDomainTakeoverScheduled.</summary>
        public string AvailabilityStatus {
            get { return BackingStore?.Get<string>(nameof(AvailabilityStatus)); }
            set { BackingStore?.Set(nameof(AvailabilityStatus), value); }
        }
        /// <summary>The objects such as users and groups that reference the domain ID. Read-only, Nullable. Supports $expand and $filter by the OData type of objects returned. For example /domains/{domainId}/domainNameReferences/microsoft.graph.user and /domains/{domainId}/domainNameReferences/microsoft.graph.group.</summary>
        public List<DirectoryObject> DomainNameReferences {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(DomainNameReferences)); }
            set { BackingStore?.Set(nameof(DomainNameReferences), value); }
        }
        /// <summary>Domain settings configured by customer when federated with Azure AD. Supports $expand.</summary>
        public List<InternalDomainFederation> FederationConfiguration {
            get { return BackingStore?.Get<List<InternalDomainFederation>>(nameof(FederationConfiguration)); }
            set { BackingStore?.Set(nameof(FederationConfiguration), value); }
        }
        /// <summary>The value of the property is false if the DNS record management of the domain has been delegated to Microsoft 365. Otherwise, the value is true. Not nullable</summary>
        public bool? IsAdminManaged {
            get { return BackingStore?.Get<bool?>(nameof(IsAdminManaged)); }
            set { BackingStore?.Set(nameof(IsAdminManaged), value); }
        }
        /// <summary>true if this is the default domain that is used for user creation. There is only one default domain per company. Not nullable</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>(nameof(IsDefault)); }
            set { BackingStore?.Set(nameof(IsDefault), value); }
        }
        /// <summary>true if this is the initial domain created by Microsoft Online Services (companyname.onmicrosoft.com). There is only one initial domain per company. Not nullable</summary>
        public bool? IsInitial {
            get { return BackingStore?.Get<bool?>(nameof(IsInitial)); }
            set { BackingStore?.Set(nameof(IsInitial), value); }
        }
        /// <summary>true if the domain is a verified root domain. Otherwise, false if the domain is a subdomain or unverified. Not nullable</summary>
        public bool? IsRoot {
            get { return BackingStore?.Get<bool?>(nameof(IsRoot)); }
            set { BackingStore?.Set(nameof(IsRoot), value); }
        }
        /// <summary>true if the domain has completed domain ownership verification. Not nullable</summary>
        public bool? IsVerified {
            get { return BackingStore?.Get<bool?>(nameof(IsVerified)); }
            set { BackingStore?.Set(nameof(IsVerified), value); }
        }
        /// <summary>The manufacturer property</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>The model property</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>Specifies the number of days before a user receives notification that their password will expire. If the property is not set, a default value of 14 days will be used.</summary>
        public int? PasswordNotificationWindowInDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordNotificationWindowInDays)); }
            set { BackingStore?.Set(nameof(PasswordNotificationWindowInDays), value); }
        }
        /// <summary>Specifies the length of time that a password is valid before it must be changed. If the property is not set, a default value of 90 days will be used.</summary>
        public int? PasswordValidityPeriodInDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordValidityPeriodInDays)); }
            set { BackingStore?.Set(nameof(PasswordValidityPeriodInDays), value); }
        }
        /// <summary>DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services. Read-only, Nullable. Supports $expand.</summary>
        public List<DomainDnsRecord> ServiceConfigurationRecords {
            get { return BackingStore?.Get<List<DomainDnsRecord>>(nameof(ServiceConfigurationRecords)); }
            set { BackingStore?.Set(nameof(ServiceConfigurationRecords), value); }
        }
        /// <summary>Status of asynchronous operations scheduled for the domain.</summary>
        public DomainState State {
            get { return BackingStore?.Get<DomainState>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>The capabilities assigned to the domain. Can include 0, 1 or more of following values: Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline,SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune. The values which you can add/remove using Graph API include: Email, OfficeCommunicationsOnline, Yammer. Not nullable.</summary>
        public List<string> SupportedServices {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedServices)); }
            set { BackingStore?.Set(nameof(SupportedServices), value); }
        }
        /// <summary>DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD. Read-only, Nullable. Supports $expand.</summary>
        public List<DomainDnsRecord> VerificationDnsRecords {
            get { return BackingStore?.Get<List<DomainDnsRecord>>(nameof(VerificationDnsRecords)); }
            set { BackingStore?.Set(nameof(VerificationDnsRecords), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Domain CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Domain();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationType", n => { AuthenticationType = n.GetStringValue(); } },
                {"availabilityStatus", n => { AvailabilityStatus = n.GetStringValue(); } },
                {"domainNameReferences", n => { DomainNameReferences = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"federationConfiguration", n => { FederationConfiguration = n.GetCollectionOfObjectValues<InternalDomainFederation>(InternalDomainFederation.CreateFromDiscriminatorValue).ToList(); } },
                {"isAdminManaged", n => { IsAdminManaged = n.GetBoolValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isInitial", n => { IsInitial = n.GetBoolValue(); } },
                {"isRoot", n => { IsRoot = n.GetBoolValue(); } },
                {"isVerified", n => { IsVerified = n.GetBoolValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"passwordNotificationWindowInDays", n => { PasswordNotificationWindowInDays = n.GetIntValue(); } },
                {"passwordValidityPeriodInDays", n => { PasswordValidityPeriodInDays = n.GetIntValue(); } },
                {"serviceConfigurationRecords", n => { ServiceConfigurationRecords = n.GetCollectionOfObjectValues<DomainDnsRecord>(DomainDnsRecord.CreateFromDiscriminatorValue).ToList(); } },
                {"state", n => { State = n.GetObjectValue<DomainState>(DomainState.CreateFromDiscriminatorValue); } },
                {"supportedServices", n => { SupportedServices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"verificationDnsRecords", n => { VerificationDnsRecords = n.GetCollectionOfObjectValues<DomainDnsRecord>(DomainDnsRecord.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("authenticationType", AuthenticationType);
            writer.WriteStringValue("availabilityStatus", AvailabilityStatus);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("domainNameReferences", DomainNameReferences);
            writer.WriteCollectionOfObjectValues<InternalDomainFederation>("federationConfiguration", FederationConfiguration);
            writer.WriteBoolValue("isAdminManaged", IsAdminManaged);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isInitial", IsInitial);
            writer.WriteBoolValue("isRoot", IsRoot);
            writer.WriteBoolValue("isVerified", IsVerified);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteIntValue("passwordNotificationWindowInDays", PasswordNotificationWindowInDays);
            writer.WriteIntValue("passwordValidityPeriodInDays", PasswordValidityPeriodInDays);
            writer.WriteCollectionOfObjectValues<DomainDnsRecord>("serviceConfigurationRecords", ServiceConfigurationRecords);
            writer.WriteObjectValue<DomainState>("state", State);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedServices", SupportedServices);
            writer.WriteCollectionOfObjectValues<DomainDnsRecord>("verificationDnsRecords", VerificationDnsRecords);
        }
    }
}
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class Device : DirectoryObject, IParsable {
        /// <summary>true if the account is enabled; otherwise, false. Default is true.  Supports $filter (eq, ne, not, in). Only callers in Global Administrator and Cloud Device Administrator roles can set this property.</summary>
        public bool? AccountEnabled {
            get { return BackingStore?.Get<bool?>(nameof(AccountEnabled)); }
            set { BackingStore?.Set(nameof(AccountEnabled), value); }
        }
        /// <summary>For internal use only. Not nullable. Supports $filter (eq, not, ge, le).</summary>
        public List<AlternativeSecurityId> AlternativeSecurityIds {
            get { return BackingStore?.Get<List<AlternativeSecurityId>>(nameof(AlternativeSecurityIds)); }
            set { BackingStore?.Set(nameof(AlternativeSecurityIds), value); }
        }
        /// <summary>The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter (eq, ne, not, ge, le, and eq on null values) and $orderBy.</summary>
        public DateTimeOffset? ApproximateLastSignInDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ApproximateLastSignInDateTime)); }
            set { BackingStore?.Set(nameof(ApproximateLastSignInDateTime), value); }
        }
        /// <summary>The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ComplianceExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ComplianceExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ComplianceExpirationDateTime), value); }
        }
        /// <summary>Identifier set by Azure Device Registration Service at the time of registration. Supports $filter (eq, ne, not, startsWith).</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>For internal use only. Set to null.</summary>
        public string DeviceMetadata {
            get { return BackingStore?.Get<string>(nameof(DeviceMetadata)); }
            set { BackingStore?.Set(nameof(DeviceMetadata), value); }
        }
        /// <summary>For internal use only.</summary>
        public int? DeviceVersion {
            get { return BackingStore?.Get<int?>(nameof(DeviceVersion)); }
            set { BackingStore?.Set(nameof(DeviceVersion), value); }
        }
        /// <summary>The display name for the device. Required. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The collection of open extensions defined for the device. Read-only. Nullable.</summary>
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>(nameof(Extensions)); }
            set { BackingStore?.Set(nameof(Extensions), value); }
        }
        /// <summary>true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).</summary>
        public bool? IsCompliant {
            get { return BackingStore?.Get<bool?>(nameof(IsCompliant)); }
            set { BackingStore?.Set(nameof(IsCompliant), value); }
        }
        /// <summary>true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).</summary>
        public bool? IsManaged {
            get { return BackingStore?.Get<bool?>(nameof(IsManaged)); }
            set { BackingStore?.Set(nameof(IsManaged), value); }
        }
        /// <summary>Application identifier used to register device into MDM. Read-only. Supports $filter (eq, ne, not, startsWith).</summary>
        public string MdmAppId {
            get { return BackingStore?.Get<string>(nameof(MdmAppId)); }
            set { BackingStore?.Set(nameof(MdmAppId), value); }
        }
        /// <summary>Groups and administrative units that this device is a member of. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(MemberOf)); }
            set { BackingStore?.Set(nameof(MemberOf), value); }
        }
        /// <summary>The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Read-only. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(OnPremisesLastSyncDateTime)); }
            set { BackingStore?.Set(nameof(OnPremisesLastSyncDateTime), value); }
        }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled {
            get { return BackingStore?.Get<bool?>(nameof(OnPremisesSyncEnabled)); }
            set { BackingStore?.Set(nameof(OnPremisesSyncEnabled), value); }
        }
        /// <summary>The type of operating system on the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).</summary>
        public string OperatingSystem {
            get { return BackingStore?.Get<string>(nameof(OperatingSystem)); }
            set { BackingStore?.Set(nameof(OperatingSystem), value); }
        }
        /// <summary>Operating system version of the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).</summary>
        public string OperatingSystemVersion {
            get { return BackingStore?.Get<string>(nameof(OperatingSystemVersion)); }
            set { BackingStore?.Set(nameof(OperatingSystemVersion), value); }
        }
        /// <summary>For internal use only. Not nullable. Supports $filter (eq, not, ge, le, startsWith, and counting empty collections).</summary>
        public List<string> PhysicalIds {
            get { return BackingStore?.Get<List<string>>(nameof(PhysicalIds)); }
            set { BackingStore?.Set(nameof(PhysicalIds), value); }
        }
        /// <summary>The profile type of the device. Possible values: RegisteredDevice (default), SecureVM, Printer, Shared, IoT.</summary>
        public string ProfileType {
            get { return BackingStore?.Get<string>(nameof(ProfileType)); }
            set { BackingStore?.Set(nameof(ProfileType), value); }
        }
        /// <summary>The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> RegisteredOwners {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(RegisteredOwners)); }
            set { BackingStore?.Set(nameof(RegisteredOwners), value); }
        }
        /// <summary>Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> RegisteredUsers {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(RegisteredUsers)); }
            set { BackingStore?.Set(nameof(RegisteredUsers), value); }
        }
        /// <summary>List of labels applied to the device by the system. Supports $filter (eq when counting empty collections).</summary>
        public List<string> SystemLabels {
            get { return BackingStore?.Get<List<string>>(nameof(SystemLabels)); }
            set { BackingStore?.Set(nameof(SystemLabels), value); }
        }
        /// <summary>Groups and administrative units that this device is a member of. This operation is transitive. Supports $expand.</summary>
        public List<DirectoryObject> TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(TransitiveMemberOf)); }
            set { BackingStore?.Set(nameof(TransitiveMemberOf), value); }
        }
        /// <summary>Type of trust for the joined device. Read-only. Possible values: Workplace (indicates bring your own personal devices), AzureAd (Cloud only joined devices), ServerAd (on-premises domain joined devices joined to Azure AD). For more details, see Introduction to device management in Azure Active Directory</summary>
        public string TrustType {
            get { return BackingStore?.Get<string>(nameof(TrustType)); }
            set { BackingStore?.Set(nameof(TrustType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Device CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Device();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountEnabled", n => { AccountEnabled = n.GetBoolValue(); } },
                {"alternativeSecurityIds", n => { AlternativeSecurityIds = n.GetCollectionOfObjectValues<AlternativeSecurityId>(AlternativeSecurityId.CreateFromDiscriminatorValue).ToList(); } },
                {"approximateLastSignInDateTime", n => { ApproximateLastSignInDateTime = n.GetDateTimeOffsetValue(); } },
                {"complianceExpirationDateTime", n => { ComplianceExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceMetadata", n => { DeviceMetadata = n.GetStringValue(); } },
                {"deviceVersion", n => { DeviceVersion = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"isCompliant", n => { IsCompliant = n.GetBoolValue(); } },
                {"isManaged", n => { IsManaged = n.GetBoolValue(); } },
                {"mdmAppId", n => { MdmAppId = n.GetStringValue(); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"operatingSystemVersion", n => { OperatingSystemVersion = n.GetStringValue(); } },
                {"physicalIds", n => { PhysicalIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"profileType", n => { ProfileType = n.GetStringValue(); } },
                {"registeredOwners", n => { RegisteredOwners = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"registeredUsers", n => { RegisteredUsers = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"systemLabels", n => { SystemLabels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"trustType", n => { TrustType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<AlternativeSecurityId>("alternativeSecurityIds", AlternativeSecurityIds);
            writer.WriteDateTimeOffsetValue("approximateLastSignInDateTime", ApproximateLastSignInDateTime);
            writer.WriteDateTimeOffsetValue("complianceExpirationDateTime", ComplianceExpirationDateTime);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceMetadata", DeviceMetadata);
            writer.WriteIntValue("deviceVersion", DeviceVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("isCompliant", IsCompliant);
            writer.WriteBoolValue("isManaged", IsManaged);
            writer.WriteStringValue("mdmAppId", MdmAppId);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("operatingSystemVersion", OperatingSystemVersion);
            writer.WriteCollectionOfPrimitiveValues<string>("physicalIds", PhysicalIds);
            writer.WriteStringValue("profileType", ProfileType);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("registeredOwners", RegisteredOwners);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("registeredUsers", RegisteredUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("systemLabels", SystemLabels);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteStringValue("trustType", TrustType);
        }
    }
}

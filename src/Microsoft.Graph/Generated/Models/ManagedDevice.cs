using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Devices that are managed or pre-enrolled through Intune</summary>
    public class ManagedDevice : Entity, IParsable {
        /// <summary>Code that allows the Activation Lock on a device to be bypassed. This property is read-only.</summary>
        public string ActivationLockBypassCode {
            get { return BackingStore?.Get<string>(nameof(ActivationLockBypassCode)); }
            set { BackingStore?.Set(nameof(ActivationLockBypassCode), value); }
        }
        /// <summary>Android security patch level. This property is read-only.</summary>
        public string AndroidSecurityPatchLevel {
            get { return BackingStore?.Get<string>(nameof(AndroidSecurityPatchLevel)); }
            set { BackingStore?.Set(nameof(AndroidSecurityPatchLevel), value); }
        }
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
        public string AzureADDeviceId {
            get { return BackingStore?.Get<string>(nameof(AzureADDeviceId)); }
            set { BackingStore?.Set(nameof(AzureADDeviceId), value); }
        }
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AzureADRegistered {
            get { return BackingStore?.Get<bool?>(nameof(AzureADRegistered)); }
            set { BackingStore?.Set(nameof(AzureADRegistered), value); }
        }
        /// <summary>The DateTime when device compliance grace period expires. This property is read-only.</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ComplianceGracePeriodExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ComplianceGracePeriodExpirationDateTime), value); }
        }
        /// <summary>Compliance state of the device. This property is read-only. Possible values are: unknown, compliant, noncompliant, conflict, error, inGracePeriod, configManager.</summary>
        public Microsoft.Graph.Models.ComplianceState? ComplianceState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ComplianceState?>(nameof(ComplianceState)); }
            set { BackingStore?.Set(nameof(ComplianceState), value); }
        }
        /// <summary>ConfigrMgr client enabled features. This property is read-only.</summary>
        public Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures>(nameof(ConfigurationManagerClientEnabledFeatures)); }
            set { BackingStore?.Set(nameof(ConfigurationManagerClientEnabledFeatures), value); }
        }
        /// <summary>List of ComplexType deviceActionResult objects. This property is read-only.</summary>
        public List<DeviceActionResult> DeviceActionResults {
            get { return BackingStore?.Get<List<DeviceActionResult>>(nameof(DeviceActionResults)); }
            set { BackingStore?.Set(nameof(DeviceActionResults), value); }
        }
        /// <summary>Device category</summary>
        public Microsoft.Graph.Models.DeviceCategory DeviceCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceCategory>(nameof(DeviceCategory)); }
            set { BackingStore?.Set(nameof(DeviceCategory), value); }
        }
        /// <summary>Device category display name. This property is read-only.</summary>
        public string DeviceCategoryDisplayName {
            get { return BackingStore?.Get<string>(nameof(DeviceCategoryDisplayName)); }
            set { BackingStore?.Set(nameof(DeviceCategoryDisplayName), value); }
        }
        /// <summary>Device compliance policy states for this device.</summary>
        public List<DeviceCompliancePolicyState> DeviceCompliancePolicyStates {
            get { return BackingStore?.Get<List<DeviceCompliancePolicyState>>(nameof(DeviceCompliancePolicyStates)); }
            set { BackingStore?.Set(nameof(DeviceCompliancePolicyStates), value); }
        }
        /// <summary>Device configuration states for this device.</summary>
        public List<DeviceConfigurationState> DeviceConfigurationStates {
            get { return BackingStore?.Get<List<DeviceConfigurationState>>(nameof(DeviceConfigurationStates)); }
            set { BackingStore?.Set(nameof(DeviceConfigurationStates), value); }
        }
        /// <summary>Enrollment type of the device. This property is read-only. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement, windowsAzureADJoinUsingDeviceAuth, appleUserEnrollment, appleUserEnrollmentWithServiceAccount, azureAdJoinUsingAzureVmExtension, androidEnterpriseDedicatedDevice, androidEnterpriseFullyManaged, androidEnterpriseCorporateWorkProfile.</summary>
        public Microsoft.Graph.Models.DeviceEnrollmentType? DeviceEnrollmentType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceEnrollmentType?>(nameof(DeviceEnrollmentType)); }
            set { BackingStore?.Set(nameof(DeviceEnrollmentType), value); }
        }
        /// <summary>The device health attestation state. This property is read-only.</summary>
        public Microsoft.Graph.Models.DeviceHealthAttestationState DeviceHealthAttestationState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceHealthAttestationState>(nameof(DeviceHealthAttestationState)); }
            set { BackingStore?.Set(nameof(DeviceHealthAttestationState), value); }
        }
        /// <summary>Name of the device. This property is read-only.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>(nameof(DeviceName)); }
            set { BackingStore?.Set(nameof(DeviceName), value); }
        }
        /// <summary>Device registration state. This property is read-only. Possible values are: notRegistered, registered, revoked, keyConflict, approvalPending, certificateReset, notRegisteredPendingEnrollment, unknown.</summary>
        public Microsoft.Graph.Models.DeviceRegistrationState? DeviceRegistrationState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceRegistrationState?>(nameof(DeviceRegistrationState)); }
            set { BackingStore?.Set(nameof(DeviceRegistrationState), value); }
        }
        /// <summary>Whether the device is Exchange ActiveSync activated. This property is read-only.</summary>
        public bool? EasActivated {
            get { return BackingStore?.Get<bool?>(nameof(EasActivated)); }
            set { BackingStore?.Set(nameof(EasActivated), value); }
        }
        /// <summary>Exchange ActivationSync activation time of the device. This property is read-only.</summary>
        public DateTimeOffset? EasActivationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EasActivationDateTime)); }
            set { BackingStore?.Set(nameof(EasActivationDateTime), value); }
        }
        /// <summary>Exchange ActiveSync Id of the device. This property is read-only.</summary>
        public string EasDeviceId {
            get { return BackingStore?.Get<string>(nameof(EasDeviceId)); }
            set { BackingStore?.Set(nameof(EasDeviceId), value); }
        }
        /// <summary>Email(s) for the user associated with the device. This property is read-only.</summary>
        public string EmailAddress {
            get { return BackingStore?.Get<string>(nameof(EmailAddress)); }
            set { BackingStore?.Set(nameof(EmailAddress), value); }
        }
        /// <summary>Enrollment time of the device. This property is read-only.</summary>
        public DateTimeOffset? EnrolledDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EnrolledDateTime)); }
            set { BackingStore?.Set(nameof(EnrolledDateTime), value); }
        }
        /// <summary>Ethernet MAC. This property is read-only.</summary>
        public string EthernetMacAddress {
            get { return BackingStore?.Get<string>(nameof(EthernetMacAddress)); }
            set { BackingStore?.Set(nameof(EthernetMacAddress), value); }
        }
        /// <summary>The Access State of the device in Exchange. This property is read-only. Possible values are: none, unknown, allowed, blocked, quarantined.</summary>
        public DeviceManagementExchangeAccessState? ExchangeAccessState {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessState?>(nameof(ExchangeAccessState)); }
            set { BackingStore?.Set(nameof(ExchangeAccessState), value); }
        }
        /// <summary>The reason for the device&apos;s access state in Exchange. This property is read-only. Possible values are: none, unknown, exchangeGlobalRule, exchangeIndividualRule, exchangeDeviceRule, exchangeUpgrade, exchangeMailboxPolicy, other, compliant, notCompliant, notEnrolled, unknownLocation, mfaRequired, azureADBlockDueToAccessPolicy, compromisedPassword, deviceNotKnownWithManagedApp.</summary>
        public DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessStateReason?>(nameof(ExchangeAccessStateReason)); }
            set { BackingStore?.Set(nameof(ExchangeAccessStateReason), value); }
        }
        /// <summary>Last time the device contacted Exchange. This property is read-only.</summary>
        public DateTimeOffset? ExchangeLastSuccessfulSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExchangeLastSuccessfulSyncDateTime)); }
            set { BackingStore?.Set(nameof(ExchangeLastSuccessfulSyncDateTime), value); }
        }
        /// <summary>Free Storage in Bytes. This property is read-only.</summary>
        public long? FreeStorageSpaceInBytes {
            get { return BackingStore?.Get<long?>(nameof(FreeStorageSpaceInBytes)); }
            set { BackingStore?.Set(nameof(FreeStorageSpaceInBytes), value); }
        }
        /// <summary>Integrated Circuit Card Identifier, it is A SIM card&apos;s unique identification number. This property is read-only.</summary>
        public string Iccid {
            get { return BackingStore?.Get<string>(nameof(Iccid)); }
            set { BackingStore?.Set(nameof(Iccid), value); }
        }
        /// <summary>IMEI. This property is read-only.</summary>
        public string Imei {
            get { return BackingStore?.Get<string>(nameof(Imei)); }
            set { BackingStore?.Set(nameof(Imei), value); }
        }
        /// <summary>Device encryption status. This property is read-only.</summary>
        public bool? IsEncrypted {
            get { return BackingStore?.Get<bool?>(nameof(IsEncrypted)); }
            set { BackingStore?.Set(nameof(IsEncrypted), value); }
        }
        /// <summary>Device supervised status. This property is read-only.</summary>
        public bool? IsSupervised {
            get { return BackingStore?.Get<bool?>(nameof(IsSupervised)); }
            set { BackingStore?.Set(nameof(IsSupervised), value); }
        }
        /// <summary>whether the device is jail broken or rooted. This property is read-only.</summary>
        public string JailBroken {
            get { return BackingStore?.Get<string>(nameof(JailBroken)); }
            set { BackingStore?.Set(nameof(JailBroken), value); }
        }
        /// <summary>The date and time that the device last completed a successful sync with Intune. This property is read-only.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSyncDateTime)); }
            set { BackingStore?.Set(nameof(LastSyncDateTime), value); }
        }
        /// <summary>Automatically generated name to identify a device. Can be overwritten to a user friendly name.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceName)); }
            set { BackingStore?.Set(nameof(ManagedDeviceName), value); }
        }
        /// <summary>Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;. Possible values are: unknown, company, personal.</summary>
        public Microsoft.Graph.Models.ManagedDeviceOwnerType? ManagedDeviceOwnerType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ManagedDeviceOwnerType?>(nameof(ManagedDeviceOwnerType)); }
            set { BackingStore?.Set(nameof(ManagedDeviceOwnerType), value); }
        }
        /// <summary>Management channel of the device. Intune, EAS, etc. This property is read-only. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController, microsoft365ManagedMdm, msSense, intuneAosp.</summary>
        public ManagementAgentType? ManagementAgent {
            get { return BackingStore?.Get<ManagementAgentType?>(nameof(ManagementAgent)); }
            set { BackingStore?.Set(nameof(ManagementAgent), value); }
        }
        /// <summary>Manufacturer of the device. This property is read-only.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>MEID. This property is read-only.</summary>
        public string Meid {
            get { return BackingStore?.Get<string>(nameof(Meid)); }
            set { BackingStore?.Set(nameof(Meid), value); }
        }
        /// <summary>Model of the device. This property is read-only.</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>Notes on the device created by IT Admin</summary>
        public string Notes {
            get { return BackingStore?.Get<string>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>Operating system of the device. Windows, iOS, etc. This property is read-only.</summary>
        public string OperatingSystem {
            get { return BackingStore?.Get<string>(nameof(OperatingSystem)); }
            set { BackingStore?.Set(nameof(OperatingSystem), value); }
        }
        /// <summary>Operating system version of the device. This property is read-only.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only. This property is read-only. Possible values are: unknown, activated, deactivated, secured, lowSeverity, mediumSeverity, highSeverity, unresponsive, compromised, misconfigured.</summary>
        public ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState {
            get { return BackingStore?.Get<ManagedDevicePartnerReportedHealthState?>(nameof(PartnerReportedThreatState)); }
            set { BackingStore?.Set(nameof(PartnerReportedThreatState), value); }
        }
        /// <summary>Phone number of the device. This property is read-only.</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>(nameof(PhoneNumber)); }
            set { BackingStore?.Set(nameof(PhoneNumber), value); }
        }
        /// <summary>Total Memory in Bytes. This property is read-only.</summary>
        public long? PhysicalMemoryInBytes {
            get { return BackingStore?.Get<long?>(nameof(PhysicalMemoryInBytes)); }
            set { BackingStore?.Set(nameof(PhysicalMemoryInBytes), value); }
        }
        /// <summary>An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.</summary>
        public string RemoteAssistanceSessionErrorDetails {
            get { return BackingStore?.Get<string>(nameof(RemoteAssistanceSessionErrorDetails)); }
            set { BackingStore?.Set(nameof(RemoteAssistanceSessionErrorDetails), value); }
        }
        /// <summary>Url that allows a Remote Assistance session to be established with the device. This property is read-only.</summary>
        public string RemoteAssistanceSessionUrl {
            get { return BackingStore?.Get<string>(nameof(RemoteAssistanceSessionUrl)); }
            set { BackingStore?.Set(nameof(RemoteAssistanceSessionUrl), value); }
        }
        /// <summary>SerialNumber. This property is read-only.</summary>
        public string SerialNumber {
            get { return BackingStore?.Get<string>(nameof(SerialNumber)); }
            set { BackingStore?.Set(nameof(SerialNumber), value); }
        }
        /// <summary>Subscriber Carrier. This property is read-only.</summary>
        public string SubscriberCarrier {
            get { return BackingStore?.Get<string>(nameof(SubscriberCarrier)); }
            set { BackingStore?.Set(nameof(SubscriberCarrier), value); }
        }
        /// <summary>Total Storage in Bytes. This property is read-only.</summary>
        public long? TotalStorageSpaceInBytes {
            get { return BackingStore?.Get<long?>(nameof(TotalStorageSpaceInBytes)); }
            set { BackingStore?.Set(nameof(TotalStorageSpaceInBytes), value); }
        }
        /// <summary>Unique Device Identifier for iOS and macOS devices. This property is read-only.</summary>
        public string Udid {
            get { return BackingStore?.Get<string>(nameof(Udid)); }
            set { BackingStore?.Set(nameof(Udid), value); }
        }
        /// <summary>User display name. This property is read-only.</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>(nameof(UserDisplayName)); }
            set { BackingStore?.Set(nameof(UserDisplayName), value); }
        }
        /// <summary>Unique Identifier for the user associated with the device. This property is read-only.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>Device user principal name. This property is read-only.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>Wi-Fi MAC. This property is read-only.</summary>
        public string WiFiMacAddress {
            get { return BackingStore?.Get<string>(nameof(WiFiMacAddress)); }
            set { BackingStore?.Set(nameof(WiFiMacAddress), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activationLockBypassCode", n => { ActivationLockBypassCode = n.GetStringValue(); } },
                {"androidSecurityPatchLevel", n => { AndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"azureADDeviceId", n => { AzureADDeviceId = n.GetStringValue(); } },
                {"azureADRegistered", n => { AzureADRegistered = n.GetBoolValue(); } },
                {"complianceGracePeriodExpirationDateTime", n => { ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"complianceState", n => { ComplianceState = n.GetEnumValue<ComplianceState>(); } },
                {"configurationManagerClientEnabledFeatures", n => { ConfigurationManagerClientEnabledFeatures = n.GetObjectValue<Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures>(Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures.CreateFromDiscriminatorValue); } },
                {"deviceActionResults", n => { DeviceActionResults = n.GetCollectionOfObjectValues<DeviceActionResult>(DeviceActionResult.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCategory", n => { DeviceCategory = n.GetObjectValue<Microsoft.Graph.Models.DeviceCategory>(Microsoft.Graph.Models.DeviceCategory.CreateFromDiscriminatorValue); } },
                {"deviceCategoryDisplayName", n => { DeviceCategoryDisplayName = n.GetStringValue(); } },
                {"deviceCompliancePolicyStates", n => { DeviceCompliancePolicyStates = n.GetCollectionOfObjectValues<DeviceCompliancePolicyState>(DeviceCompliancePolicyState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationStates", n => { DeviceConfigurationStates = n.GetCollectionOfObjectValues<DeviceConfigurationState>(DeviceConfigurationState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceEnrollmentType", n => { DeviceEnrollmentType = n.GetEnumValue<DeviceEnrollmentType>(); } },
                {"deviceHealthAttestationState", n => { DeviceHealthAttestationState = n.GetObjectValue<Microsoft.Graph.Models.DeviceHealthAttestationState>(Microsoft.Graph.Models.DeviceHealthAttestationState.CreateFromDiscriminatorValue); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceRegistrationState", n => { DeviceRegistrationState = n.GetEnumValue<DeviceRegistrationState>(); } },
                {"easActivated", n => { EasActivated = n.GetBoolValue(); } },
                {"easActivationDateTime", n => { EasActivationDateTime = n.GetDateTimeOffsetValue(); } },
                {"easDeviceId", n => { EasDeviceId = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"enrolledDateTime", n => { EnrolledDateTime = n.GetDateTimeOffsetValue(); } },
                {"ethernetMacAddress", n => { EthernetMacAddress = n.GetStringValue(); } },
                {"exchangeAccessState", n => { ExchangeAccessState = n.GetEnumValue<DeviceManagementExchangeAccessState>(); } },
                {"exchangeAccessStateReason", n => { ExchangeAccessStateReason = n.GetEnumValue<DeviceManagementExchangeAccessStateReason>(); } },
                {"exchangeLastSuccessfulSyncDateTime", n => { ExchangeLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"freeStorageSpaceInBytes", n => { FreeStorageSpaceInBytes = n.GetLongValue(); } },
                {"iccid", n => { Iccid = n.GetStringValue(); } },
                {"imei", n => { Imei = n.GetStringValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"isSupervised", n => { IsSupervised = n.GetBoolValue(); } },
                {"jailBroken", n => { JailBroken = n.GetStringValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"managedDeviceOwnerType", n => { ManagedDeviceOwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
                {"managementAgent", n => { ManagementAgent = n.GetEnumValue<ManagementAgentType>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"meid", n => { Meid = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"partnerReportedThreatState", n => { PartnerReportedThreatState = n.GetEnumValue<ManagedDevicePartnerReportedHealthState>(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"physicalMemoryInBytes", n => { PhysicalMemoryInBytes = n.GetLongValue(); } },
                {"remoteAssistanceSessionErrorDetails", n => { RemoteAssistanceSessionErrorDetails = n.GetStringValue(); } },
                {"remoteAssistanceSessionUrl", n => { RemoteAssistanceSessionUrl = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"subscriberCarrier", n => { SubscriberCarrier = n.GetStringValue(); } },
                {"totalStorageSpaceInBytes", n => { TotalStorageSpaceInBytes = n.GetLongValue(); } },
                {"udid", n => { Udid = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"wiFiMacAddress", n => { WiFiMacAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activationLockBypassCode", ActivationLockBypassCode);
            writer.WriteStringValue("androidSecurityPatchLevel", AndroidSecurityPatchLevel);
            writer.WriteStringValue("azureADDeviceId", AzureADDeviceId);
            writer.WriteBoolValue("azureADRegistered", AzureADRegistered);
            writer.WriteDateTimeOffsetValue("complianceGracePeriodExpirationDateTime", ComplianceGracePeriodExpirationDateTime);
            writer.WriteEnumValue<ComplianceState>("complianceState", ComplianceState);
            writer.WriteObjectValue<Microsoft.Graph.Models.ConfigurationManagerClientEnabledFeatures>("configurationManagerClientEnabledFeatures", ConfigurationManagerClientEnabledFeatures);
            writer.WriteCollectionOfObjectValues<DeviceActionResult>("deviceActionResults", DeviceActionResults);
            writer.WriteObjectValue<Microsoft.Graph.Models.DeviceCategory>("deviceCategory", DeviceCategory);
            writer.WriteStringValue("deviceCategoryDisplayName", DeviceCategoryDisplayName);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicyState>("deviceCompliancePolicyStates", DeviceCompliancePolicyStates);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationState>("deviceConfigurationStates", DeviceConfigurationStates);
            writer.WriteEnumValue<DeviceEnrollmentType>("deviceEnrollmentType", DeviceEnrollmentType);
            writer.WriteObjectValue<Microsoft.Graph.Models.DeviceHealthAttestationState>("deviceHealthAttestationState", DeviceHealthAttestationState);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DeviceRegistrationState>("deviceRegistrationState", DeviceRegistrationState);
            writer.WriteBoolValue("easActivated", EasActivated);
            writer.WriteDateTimeOffsetValue("easActivationDateTime", EasActivationDateTime);
            writer.WriteStringValue("easDeviceId", EasDeviceId);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteDateTimeOffsetValue("enrolledDateTime", EnrolledDateTime);
            writer.WriteStringValue("ethernetMacAddress", EthernetMacAddress);
            writer.WriteEnumValue<DeviceManagementExchangeAccessState>("exchangeAccessState", ExchangeAccessState);
            writer.WriteEnumValue<DeviceManagementExchangeAccessStateReason>("exchangeAccessStateReason", ExchangeAccessStateReason);
            writer.WriteDateTimeOffsetValue("exchangeLastSuccessfulSyncDateTime", ExchangeLastSuccessfulSyncDateTime);
            writer.WriteLongValue("freeStorageSpaceInBytes", FreeStorageSpaceInBytes);
            writer.WriteStringValue("iccid", Iccid);
            writer.WriteStringValue("imei", Imei);
            writer.WriteBoolValue("isEncrypted", IsEncrypted);
            writer.WriteBoolValue("isSupervised", IsSupervised);
            writer.WriteStringValue("jailBroken", JailBroken);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteEnumValue<ManagedDeviceOwnerType>("managedDeviceOwnerType", ManagedDeviceOwnerType);
            writer.WriteEnumValue<ManagementAgentType>("managementAgent", ManagementAgent);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("meid", Meid);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteEnumValue<ManagedDevicePartnerReportedHealthState>("partnerReportedThreatState", PartnerReportedThreatState);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteLongValue("physicalMemoryInBytes", PhysicalMemoryInBytes);
            writer.WriteStringValue("remoteAssistanceSessionErrorDetails", RemoteAssistanceSessionErrorDetails);
            writer.WriteStringValue("remoteAssistanceSessionUrl", RemoteAssistanceSessionUrl);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("subscriberCarrier", SubscriberCarrier);
            writer.WriteLongValue("totalStorageSpaceInBytes", TotalStorageSpaceInBytes);
            writer.WriteStringValue("udid", Udid);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("wiFiMacAddress", WiFiMacAddress);
        }
    }
}

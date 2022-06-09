using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ManagedAppProtection : ManagedAppPolicy, IParsable {
        /// <summary>Data storage locations where a user may store managed data.</summary>
        public List<string> AllowedDataStorageLocations {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedDataStorageLocations)); }
            set { BackingStore?.Set(nameof(AllowedDataStorageLocations), value); }
        }
        /// <summary>Sources from which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedInboundDataTransferSources {
            get { return BackingStore?.Get<ManagedAppDataTransferLevel?>(nameof(AllowedInboundDataTransferSources)); }
            set { BackingStore?.Set(nameof(AllowedInboundDataTransferSources), value); }
        }
        /// <summary>The level to which the clipboard may be shared between apps on the managed device. Possible values are: allApps, managedAppsWithPasteIn, managedApps, blocked.</summary>
        public ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel {
            get { return BackingStore?.Get<ManagedAppClipboardSharingLevel?>(nameof(AllowedOutboundClipboardSharingLevel)); }
            set { BackingStore?.Set(nameof(AllowedOutboundClipboardSharingLevel), value); }
        }
        /// <summary>Destinations to which data is allowed to be transferred. Possible values are: allApps, managedApps, none.</summary>
        public ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations {
            get { return BackingStore?.Get<ManagedAppDataTransferLevel?>(nameof(AllowedOutboundDataTransferDestinations)); }
            set { BackingStore?.Set(nameof(AllowedOutboundDataTransferDestinations), value); }
        }
        /// <summary>Indicates whether contacts can be synced to the user&apos;s device.</summary>
        public bool? ContactSyncBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ContactSyncBlocked)); }
            set { BackingStore?.Set(nameof(ContactSyncBlocked), value); }
        }
        /// <summary>Indicates whether the backup of a managed app&apos;s data is blocked.</summary>
        public bool? DataBackupBlocked {
            get { return BackingStore?.Get<bool?>(nameof(DataBackupBlocked)); }
            set { BackingStore?.Set(nameof(DataBackupBlocked), value); }
        }
        /// <summary>Indicates whether device compliance is required.</summary>
        public bool? DeviceComplianceRequired {
            get { return BackingStore?.Get<bool?>(nameof(DeviceComplianceRequired)); }
            set { BackingStore?.Set(nameof(DeviceComplianceRequired), value); }
        }
        /// <summary>Indicates whether use of the app pin is required if the device pin is set.</summary>
        public bool? DisableAppPinIfDevicePinIsSet {
            get { return BackingStore?.Get<bool?>(nameof(DisableAppPinIfDevicePinIsSet)); }
            set { BackingStore?.Set(nameof(DisableAppPinIfDevicePinIsSet), value); }
        }
        /// <summary>Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FingerprintBlocked {
            get { return BackingStore?.Get<bool?>(nameof(FingerprintBlocked)); }
            set { BackingStore?.Set(nameof(FingerprintBlocked), value); }
        }
        /// <summary>Indicates in which managed browser(s) that internet links should be opened. When this property is configured, ManagedBrowserToOpenLinksRequired should be true. Possible values are: notConfigured, microsoftEdge.</summary>
        public ManagedBrowserType? ManagedBrowser {
            get { return BackingStore?.Get<ManagedBrowserType?>(nameof(ManagedBrowser)); }
            set { BackingStore?.Set(nameof(ManagedBrowser), value); }
        }
        /// <summary>Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)</summary>
        public bool? ManagedBrowserToOpenLinksRequired {
            get { return BackingStore?.Get<bool?>(nameof(ManagedBrowserToOpenLinksRequired)); }
            set { BackingStore?.Set(nameof(ManagedBrowserToOpenLinksRequired), value); }
        }
        /// <summary>Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</summary>
        public int? MaximumPinRetries {
            get { return BackingStore?.Get<int?>(nameof(MaximumPinRetries)); }
            set { BackingStore?.Set(nameof(MaximumPinRetries), value); }
        }
        /// <summary>Minimum pin length required for an app-level pin if PinRequired is set to True</summary>
        public int? MinimumPinLength {
            get { return BackingStore?.Get<int?>(nameof(MinimumPinLength)); }
            set { BackingStore?.Set(nameof(MinimumPinLength), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredAppVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredAppVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredAppVersion), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredOsVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredOsVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredOsVersion), value); }
        }
        /// <summary>Versions less than the specified version will result in warning message on the managed app.</summary>
        public string MinimumWarningAppVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWarningAppVersion)); }
            set { BackingStore?.Set(nameof(MinimumWarningAppVersion), value); }
        }
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data.</summary>
        public string MinimumWarningOsVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWarningOsVersion)); }
            set { BackingStore?.Set(nameof(MinimumWarningOsVersion), value); }
        }
        /// <summary>Indicates whether organizational credentials are required for app use.</summary>
        public bool? OrganizationalCredentialsRequired {
            get { return BackingStore?.Get<bool?>(nameof(OrganizationalCredentialsRequired)); }
            set { BackingStore?.Set(nameof(OrganizationalCredentialsRequired), value); }
        }
        /// <summary>TimePeriod before the all-level pin must be reset if PinRequired is set to True.</summary>
        public TimeSpan? PeriodBeforePinReset {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodBeforePinReset)); }
            set { BackingStore?.Set(nameof(PeriodBeforePinReset), value); }
        }
        /// <summary>The period after which access is checked when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeAccessCheck {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodOfflineBeforeAccessCheck)); }
            set { BackingStore?.Set(nameof(PeriodOfflineBeforeAccessCheck), value); }
        }
        /// <summary>The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</summary>
        public TimeSpan? PeriodOfflineBeforeWipeIsEnforced {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodOfflineBeforeWipeIsEnforced)); }
            set { BackingStore?.Set(nameof(PeriodOfflineBeforeWipeIsEnforced), value); }
        }
        /// <summary>The period after which access is checked when the device is connected to the internet.</summary>
        public TimeSpan? PeriodOnlineBeforeAccessCheck {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodOnlineBeforeAccessCheck)); }
            set { BackingStore?.Set(nameof(PeriodOnlineBeforeAccessCheck), value); }
        }
        /// <summary>Character set which may be used for an app-level pin if PinRequired is set to True. Possible values are: numeric, alphanumericAndSymbol.</summary>
        public ManagedAppPinCharacterSet? PinCharacterSet {
            get { return BackingStore?.Get<ManagedAppPinCharacterSet?>(nameof(PinCharacterSet)); }
            set { BackingStore?.Set(nameof(PinCharacterSet), value); }
        }
        /// <summary>Indicates whether an app-level pin is required.</summary>
        public bool? PinRequired {
            get { return BackingStore?.Get<bool?>(nameof(PinRequired)); }
            set { BackingStore?.Set(nameof(PinRequired), value); }
        }
        /// <summary>Indicates whether printing is allowed from managed apps.</summary>
        public bool? PrintBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PrintBlocked)); }
            set { BackingStore?.Set(nameof(PrintBlocked), value); }
        }
        /// <summary>Indicates whether users may use the &apos;Save As&apos; menu item to save a copy of protected files.</summary>
        public bool? SaveAsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(SaveAsBlocked)); }
            set { BackingStore?.Set(nameof(SaveAsBlocked), value); }
        }
        /// <summary>Indicates whether simplePin is blocked.</summary>
        public bool? SimplePinBlocked {
            get { return BackingStore?.Get<bool?>(nameof(SimplePinBlocked)); }
            set { BackingStore?.Set(nameof(SimplePinBlocked), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedDataStorageLocations", n => { AllowedDataStorageLocations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"allowedInboundDataTransferSources", n => { AllowedInboundDataTransferSources = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"allowedOutboundClipboardSharingLevel", n => { AllowedOutboundClipboardSharingLevel = n.GetEnumValue<ManagedAppClipboardSharingLevel>(); } },
                {"allowedOutboundDataTransferDestinations", n => { AllowedOutboundDataTransferDestinations = n.GetEnumValue<ManagedAppDataTransferLevel>(); } },
                {"contactSyncBlocked", n => { ContactSyncBlocked = n.GetBoolValue(); } },
                {"dataBackupBlocked", n => { DataBackupBlocked = n.GetBoolValue(); } },
                {"deviceComplianceRequired", n => { DeviceComplianceRequired = n.GetBoolValue(); } },
                {"disableAppPinIfDevicePinIsSet", n => { DisableAppPinIfDevicePinIsSet = n.GetBoolValue(); } },
                {"fingerprintBlocked", n => { FingerprintBlocked = n.GetBoolValue(); } },
                {"managedBrowser", n => { ManagedBrowser = n.GetEnumValue<ManagedBrowserType>(); } },
                {"managedBrowserToOpenLinksRequired", n => { ManagedBrowserToOpenLinksRequired = n.GetBoolValue(); } },
                {"maximumPinRetries", n => { MaximumPinRetries = n.GetIntValue(); } },
                {"minimumPinLength", n => { MinimumPinLength = n.GetIntValue(); } },
                {"minimumRequiredAppVersion", n => { MinimumRequiredAppVersion = n.GetStringValue(); } },
                {"minimumRequiredOsVersion", n => { MinimumRequiredOsVersion = n.GetStringValue(); } },
                {"minimumWarningAppVersion", n => { MinimumWarningAppVersion = n.GetStringValue(); } },
                {"minimumWarningOsVersion", n => { MinimumWarningOsVersion = n.GetStringValue(); } },
                {"organizationalCredentialsRequired", n => { OrganizationalCredentialsRequired = n.GetBoolValue(); } },
                {"periodBeforePinReset", n => { PeriodBeforePinReset = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeAccessCheck", n => { PeriodOfflineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeWipeIsEnforced", n => { PeriodOfflineBeforeWipeIsEnforced = n.GetTimeSpanValue(); } },
                {"periodOnlineBeforeAccessCheck", n => { PeriodOnlineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"pinCharacterSet", n => { PinCharacterSet = n.GetEnumValue<ManagedAppPinCharacterSet>(); } },
                {"pinRequired", n => { PinRequired = n.GetBoolValue(); } },
                {"printBlocked", n => { PrintBlocked = n.GetBoolValue(); } },
                {"saveAsBlocked", n => { SaveAsBlocked = n.GetBoolValue(); } },
                {"simplePinBlocked", n => { SimplePinBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedDataStorageLocations", AllowedDataStorageLocations);
            writer.WriteEnumValue<ManagedAppDataTransferLevel>("allowedInboundDataTransferSources", AllowedInboundDataTransferSources);
            writer.WriteEnumValue<ManagedAppClipboardSharingLevel>("allowedOutboundClipboardSharingLevel", AllowedOutboundClipboardSharingLevel);
            writer.WriteEnumValue<ManagedAppDataTransferLevel>("allowedOutboundDataTransferDestinations", AllowedOutboundDataTransferDestinations);
            writer.WriteBoolValue("contactSyncBlocked", ContactSyncBlocked);
            writer.WriteBoolValue("dataBackupBlocked", DataBackupBlocked);
            writer.WriteBoolValue("deviceComplianceRequired", DeviceComplianceRequired);
            writer.WriteBoolValue("disableAppPinIfDevicePinIsSet", DisableAppPinIfDevicePinIsSet);
            writer.WriteBoolValue("fingerprintBlocked", FingerprintBlocked);
            writer.WriteEnumValue<ManagedBrowserType>("managedBrowser", ManagedBrowser);
            writer.WriteBoolValue("managedBrowserToOpenLinksRequired", ManagedBrowserToOpenLinksRequired);
            writer.WriteIntValue("maximumPinRetries", MaximumPinRetries);
            writer.WriteIntValue("minimumPinLength", MinimumPinLength);
            writer.WriteStringValue("minimumRequiredAppVersion", MinimumRequiredAppVersion);
            writer.WriteStringValue("minimumRequiredOsVersion", MinimumRequiredOsVersion);
            writer.WriteStringValue("minimumWarningAppVersion", MinimumWarningAppVersion);
            writer.WriteStringValue("minimumWarningOsVersion", MinimumWarningOsVersion);
            writer.WriteBoolValue("organizationalCredentialsRequired", OrganizationalCredentialsRequired);
            writer.WriteTimeSpanValue("periodBeforePinReset", PeriodBeforePinReset);
            writer.WriteTimeSpanValue("periodOfflineBeforeAccessCheck", PeriodOfflineBeforeAccessCheck);
            writer.WriteTimeSpanValue("periodOfflineBeforeWipeIsEnforced", PeriodOfflineBeforeWipeIsEnforced);
            writer.WriteTimeSpanValue("periodOnlineBeforeAccessCheck", PeriodOnlineBeforeAccessCheck);
            writer.WriteEnumValue<ManagedAppPinCharacterSet>("pinCharacterSet", PinCharacterSet);
            writer.WriteBoolValue("pinRequired", PinRequired);
            writer.WriteBoolValue("printBlocked", PrintBlocked);
            writer.WriteBoolValue("saveAsBlocked", SaveAsBlocked);
            writer.WriteBoolValue("simplePinBlocked", SimplePinBlocked);
        }
    }
}

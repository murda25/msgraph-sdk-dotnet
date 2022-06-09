using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Windows10EndpointProtectionConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Allow persisting user generated data inside the App Guard Containter (favorites, cookies, web passwords, etc.)</summary>
        public bool? ApplicationGuardAllowPersistence {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPersistence)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPersistence), value); }
        }
        /// <summary>Allow printing to Local Printers from Container</summary>
        public bool? ApplicationGuardAllowPrintToLocalPrinters {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPrintToLocalPrinters)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPrintToLocalPrinters), value); }
        }
        /// <summary>Allow printing to Network Printers from Container</summary>
        public bool? ApplicationGuardAllowPrintToNetworkPrinters {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPrintToNetworkPrinters)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPrintToNetworkPrinters), value); }
        }
        /// <summary>Allow printing to PDF from Container</summary>
        public bool? ApplicationGuardAllowPrintToPDF {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPrintToPDF)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPrintToPDF), value); }
        }
        /// <summary>Allow printing to XPS from Container</summary>
        public bool? ApplicationGuardAllowPrintToXPS {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardAllowPrintToXPS)); }
            set { BackingStore?.Set(nameof(ApplicationGuardAllowPrintToXPS), value); }
        }
        /// <summary>Block clipboard to share data from Host to Container, or from Container to Host, or both ways, or neither ways. Possible values are: notConfigured, blockBoth, blockHostToContainer, blockContainerToHost, blockNone.</summary>
        public ApplicationGuardBlockClipboardSharingType? ApplicationGuardBlockClipboardSharing {
            get { return BackingStore?.Get<ApplicationGuardBlockClipboardSharingType?>(nameof(ApplicationGuardBlockClipboardSharing)); }
            set { BackingStore?.Set(nameof(ApplicationGuardBlockClipboardSharing), value); }
        }
        /// <summary>Block clipboard to transfer image file, text file or neither of them. Possible values are: notConfigured, blockImageAndTextFile, blockImageFile, blockNone, blockTextFile.</summary>
        public ApplicationGuardBlockFileTransferType? ApplicationGuardBlockFileTransfer {
            get { return BackingStore?.Get<ApplicationGuardBlockFileTransferType?>(nameof(ApplicationGuardBlockFileTransfer)); }
            set { BackingStore?.Set(nameof(ApplicationGuardBlockFileTransfer), value); }
        }
        /// <summary>Block enterprise sites to load non-enterprise content, such as third party plug-ins</summary>
        public bool? ApplicationGuardBlockNonEnterpriseContent {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardBlockNonEnterpriseContent)); }
            set { BackingStore?.Set(nameof(ApplicationGuardBlockNonEnterpriseContent), value); }
        }
        /// <summary>Enable Windows Defender Application Guard</summary>
        public bool? ApplicationGuardEnabled {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardEnabled)); }
            set { BackingStore?.Set(nameof(ApplicationGuardEnabled), value); }
        }
        /// <summary>Force auditing will persist Windows logs and events to meet security/compliance criteria (sample events are user login-logoff, use of privilege rights, software installation, system changes, etc.)</summary>
        public bool? ApplicationGuardForceAuditing {
            get { return BackingStore?.Get<bool?>(nameof(ApplicationGuardForceAuditing)); }
            set { BackingStore?.Set(nameof(ApplicationGuardForceAuditing), value); }
        }
        /// <summary>Enables the Admin to choose what types of app to allow on devices. Possible values are: notConfigured, enforceComponentsAndStoreApps, auditComponentsAndStoreApps, enforceComponentsStoreAppsAndSmartlocker, auditComponentsStoreAppsAndSmartlocker.</summary>
        public AppLockerApplicationControlType? AppLockerApplicationControl {
            get { return BackingStore?.Get<AppLockerApplicationControlType?>(nameof(AppLockerApplicationControl)); }
            set { BackingStore?.Set(nameof(AppLockerApplicationControl), value); }
        }
        /// <summary>Allows the Admin to disable the warning prompt for other disk encryption on the user machines.</summary>
        public bool? BitLockerDisableWarningForOtherDiskEncryption {
            get { return BackingStore?.Get<bool?>(nameof(BitLockerDisableWarningForOtherDiskEncryption)); }
            set { BackingStore?.Set(nameof(BitLockerDisableWarningForOtherDiskEncryption), value); }
        }
        /// <summary>Allows the admin to require encryption to be turned on using BitLocker. This policy is valid only for a mobile SKU.</summary>
        public bool? BitLockerEnableStorageCardEncryptionOnMobile {
            get { return BackingStore?.Get<bool?>(nameof(BitLockerEnableStorageCardEncryptionOnMobile)); }
            set { BackingStore?.Set(nameof(BitLockerEnableStorageCardEncryptionOnMobile), value); }
        }
        /// <summary>Allows the admin to require encryption to be turned on using BitLocker.</summary>
        public bool? BitLockerEncryptDevice {
            get { return BackingStore?.Get<bool?>(nameof(BitLockerEncryptDevice)); }
            set { BackingStore?.Set(nameof(BitLockerEncryptDevice), value); }
        }
        /// <summary>BitLocker Removable Drive Policy.</summary>
        public Microsoft.Graph.Models.BitLockerRemovableDrivePolicy BitLockerRemovableDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Models.BitLockerRemovableDrivePolicy>(nameof(BitLockerRemovableDrivePolicy)); }
            set { BackingStore?.Set(nameof(BitLockerRemovableDrivePolicy), value); }
        }
        /// <summary>List of folder paths to be added to the list of protected folders</summary>
        public List<string> DefenderAdditionalGuardedFolders {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderAdditionalGuardedFolders)); }
            set { BackingStore?.Set(nameof(DefenderAdditionalGuardedFolders), value); }
        }
        /// <summary>List of exe files and folders to be excluded from attack surface reduction rules</summary>
        public List<string> DefenderAttackSurfaceReductionExcludedPaths {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderAttackSurfaceReductionExcludedPaths)); }
            set { BackingStore?.Set(nameof(DefenderAttackSurfaceReductionExcludedPaths), value); }
        }
        /// <summary>Xml content containing information regarding exploit protection details.</summary>
        public byte[] DefenderExploitProtectionXml {
            get { return BackingStore?.Get<byte[]>(nameof(DefenderExploitProtectionXml)); }
            set { BackingStore?.Set(nameof(DefenderExploitProtectionXml), value); }
        }
        /// <summary>Name of the file from which DefenderExploitProtectionXml was obtained.</summary>
        public string DefenderExploitProtectionXmlFileName {
            get { return BackingStore?.Get<string>(nameof(DefenderExploitProtectionXmlFileName)); }
            set { BackingStore?.Set(nameof(DefenderExploitProtectionXmlFileName), value); }
        }
        /// <summary>List of paths to exe that are allowed to access protected folders</summary>
        public List<string> DefenderGuardedFoldersAllowedAppPaths {
            get { return BackingStore?.Get<List<string>>(nameof(DefenderGuardedFoldersAllowedAppPaths)); }
            set { BackingStore?.Set(nameof(DefenderGuardedFoldersAllowedAppPaths), value); }
        }
        /// <summary>Indicates whether or not to block user from overriding Exploit Protection settings.</summary>
        public bool? DefenderSecurityCenterBlockExploitProtectionOverride {
            get { return BackingStore?.Get<bool?>(nameof(DefenderSecurityCenterBlockExploitProtectionOverride)); }
            set { BackingStore?.Set(nameof(DefenderSecurityCenterBlockExploitProtectionOverride), value); }
        }
        /// <summary>Blocks stateful FTP connections to the device</summary>
        public bool? FirewallBlockStatefulFTP {
            get { return BackingStore?.Get<bool?>(nameof(FirewallBlockStatefulFTP)); }
            set { BackingStore?.Set(nameof(FirewallBlockStatefulFTP), value); }
        }
        /// <summary>Specify how the certificate revocation list is to be enforced. Possible values are: deviceDefault, none, attempt, require.</summary>
        public FirewallCertificateRevocationListCheckMethodType? FirewallCertificateRevocationListCheckMethod {
            get { return BackingStore?.Get<FirewallCertificateRevocationListCheckMethodType?>(nameof(FirewallCertificateRevocationListCheckMethod)); }
            set { BackingStore?.Set(nameof(FirewallCertificateRevocationListCheckMethod), value); }
        }
        /// <summary>Configures the idle timeout for security associations, in seconds, from 300 to 3600 inclusive. This is the period after which security associations will expire and be deleted. Valid values 300 to 3600</summary>
        public int? FirewallIdleTimeoutForSecurityAssociationInSeconds {
            get { return BackingStore?.Get<int?>(nameof(FirewallIdleTimeoutForSecurityAssociationInSeconds)); }
            set { BackingStore?.Set(nameof(FirewallIdleTimeoutForSecurityAssociationInSeconds), value); }
        }
        /// <summary>Configures IPSec exemptions to allow both IPv4 and IPv6 DHCP traffic</summary>
        public bool? FirewallIPSecExemptionsAllowDHCP {
            get { return BackingStore?.Get<bool?>(nameof(FirewallIPSecExemptionsAllowDHCP)); }
            set { BackingStore?.Set(nameof(FirewallIPSecExemptionsAllowDHCP), value); }
        }
        /// <summary>Configures IPSec exemptions to allow ICMP</summary>
        public bool? FirewallIPSecExemptionsAllowICMP {
            get { return BackingStore?.Get<bool?>(nameof(FirewallIPSecExemptionsAllowICMP)); }
            set { BackingStore?.Set(nameof(FirewallIPSecExemptionsAllowICMP), value); }
        }
        /// <summary>Configures IPSec exemptions to allow neighbor discovery IPv6 ICMP type-codes</summary>
        public bool? FirewallIPSecExemptionsAllowNeighborDiscovery {
            get { return BackingStore?.Get<bool?>(nameof(FirewallIPSecExemptionsAllowNeighborDiscovery)); }
            set { BackingStore?.Set(nameof(FirewallIPSecExemptionsAllowNeighborDiscovery), value); }
        }
        /// <summary>Configures IPSec exemptions to allow router discovery IPv6 ICMP type-codes</summary>
        public bool? FirewallIPSecExemptionsAllowRouterDiscovery {
            get { return BackingStore?.Get<bool?>(nameof(FirewallIPSecExemptionsAllowRouterDiscovery)); }
            set { BackingStore?.Set(nameof(FirewallIPSecExemptionsAllowRouterDiscovery), value); }
        }
        /// <summary>If an authentication set is not fully supported by a keying module, direct the module to ignore only unsupported authentication suites rather than the entire set</summary>
        public bool? FirewallMergeKeyingModuleSettings {
            get { return BackingStore?.Get<bool?>(nameof(FirewallMergeKeyingModuleSettings)); }
            set { BackingStore?.Set(nameof(FirewallMergeKeyingModuleSettings), value); }
        }
        /// <summary>Configures how packet queueing should be applied in the tunnel gateway scenario. Possible values are: deviceDefault, disabled, queueInbound, queueOutbound, queueBoth.</summary>
        public FirewallPacketQueueingMethodType? FirewallPacketQueueingMethod {
            get { return BackingStore?.Get<FirewallPacketQueueingMethodType?>(nameof(FirewallPacketQueueingMethod)); }
            set { BackingStore?.Set(nameof(FirewallPacketQueueingMethod), value); }
        }
        /// <summary>Select the preshared key encoding to be used. Possible values are: deviceDefault, none, utF8.</summary>
        public FirewallPreSharedKeyEncodingMethodType? FirewallPreSharedKeyEncodingMethod {
            get { return BackingStore?.Get<FirewallPreSharedKeyEncodingMethodType?>(nameof(FirewallPreSharedKeyEncodingMethod)); }
            set { BackingStore?.Set(nameof(FirewallPreSharedKeyEncodingMethod), value); }
        }
        /// <summary>Configures the firewall profile settings for domain networks</summary>
        public WindowsFirewallNetworkProfile FirewallProfileDomain {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile>(nameof(FirewallProfileDomain)); }
            set { BackingStore?.Set(nameof(FirewallProfileDomain), value); }
        }
        /// <summary>Configures the firewall profile settings for private networks</summary>
        public WindowsFirewallNetworkProfile FirewallProfilePrivate {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile>(nameof(FirewallProfilePrivate)); }
            set { BackingStore?.Set(nameof(FirewallProfilePrivate), value); }
        }
        /// <summary>Configures the firewall profile settings for public networks</summary>
        public WindowsFirewallNetworkProfile FirewallProfilePublic {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile>(nameof(FirewallProfilePublic)); }
            set { BackingStore?.Set(nameof(FirewallProfilePublic), value); }
        }
        /// <summary>Allows IT Admins to control whether users can can ignore SmartScreen warnings and run malicious files.</summary>
        public bool? SmartScreenBlockOverrideForFiles {
            get { return BackingStore?.Get<bool?>(nameof(SmartScreenBlockOverrideForFiles)); }
            set { BackingStore?.Set(nameof(SmartScreenBlockOverrideForFiles), value); }
        }
        /// <summary>Allows IT Admins to configure SmartScreen for Windows.</summary>
        public bool? SmartScreenEnableInShell {
            get { return BackingStore?.Get<bool?>(nameof(SmartScreenEnableInShell)); }
            set { BackingStore?.Set(nameof(SmartScreenEnableInShell), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10EndpointProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10EndpointProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationGuardAllowPersistence", n => { ApplicationGuardAllowPersistence = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToLocalPrinters", n => { ApplicationGuardAllowPrintToLocalPrinters = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToNetworkPrinters", n => { ApplicationGuardAllowPrintToNetworkPrinters = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToPDF", n => { ApplicationGuardAllowPrintToPDF = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToXPS", n => { ApplicationGuardAllowPrintToXPS = n.GetBoolValue(); } },
                {"applicationGuardBlockClipboardSharing", n => { ApplicationGuardBlockClipboardSharing = n.GetEnumValue<ApplicationGuardBlockClipboardSharingType>(); } },
                {"applicationGuardBlockFileTransfer", n => { ApplicationGuardBlockFileTransfer = n.GetEnumValue<ApplicationGuardBlockFileTransferType>(); } },
                {"applicationGuardBlockNonEnterpriseContent", n => { ApplicationGuardBlockNonEnterpriseContent = n.GetBoolValue(); } },
                {"applicationGuardEnabled", n => { ApplicationGuardEnabled = n.GetBoolValue(); } },
                {"applicationGuardForceAuditing", n => { ApplicationGuardForceAuditing = n.GetBoolValue(); } },
                {"appLockerApplicationControl", n => { AppLockerApplicationControl = n.GetEnumValue<AppLockerApplicationControlType>(); } },
                {"bitLockerDisableWarningForOtherDiskEncryption", n => { BitLockerDisableWarningForOtherDiskEncryption = n.GetBoolValue(); } },
                {"bitLockerEnableStorageCardEncryptionOnMobile", n => { BitLockerEnableStorageCardEncryptionOnMobile = n.GetBoolValue(); } },
                {"bitLockerEncryptDevice", n => { BitLockerEncryptDevice = n.GetBoolValue(); } },
                {"bitLockerRemovableDrivePolicy", n => { BitLockerRemovableDrivePolicy = n.GetObjectValue<Microsoft.Graph.Models.BitLockerRemovableDrivePolicy>(Microsoft.Graph.Models.BitLockerRemovableDrivePolicy.CreateFromDiscriminatorValue); } },
                {"defenderAdditionalGuardedFolders", n => { DefenderAdditionalGuardedFolders = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderAttackSurfaceReductionExcludedPaths", n => { DefenderAttackSurfaceReductionExcludedPaths = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderExploitProtectionXml", n => { DefenderExploitProtectionXml = n.GetByteArrayValue(); } },
                {"defenderExploitProtectionXmlFileName", n => { DefenderExploitProtectionXmlFileName = n.GetStringValue(); } },
                {"defenderGuardedFoldersAllowedAppPaths", n => { DefenderGuardedFoldersAllowedAppPaths = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"defenderSecurityCenterBlockExploitProtectionOverride", n => { DefenderSecurityCenterBlockExploitProtectionOverride = n.GetBoolValue(); } },
                {"firewallBlockStatefulFTP", n => { FirewallBlockStatefulFTP = n.GetBoolValue(); } },
                {"firewallCertificateRevocationListCheckMethod", n => { FirewallCertificateRevocationListCheckMethod = n.GetEnumValue<FirewallCertificateRevocationListCheckMethodType>(); } },
                {"firewallIdleTimeoutForSecurityAssociationInSeconds", n => { FirewallIdleTimeoutForSecurityAssociationInSeconds = n.GetIntValue(); } },
                {"firewallIPSecExemptionsAllowDHCP", n => { FirewallIPSecExemptionsAllowDHCP = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowICMP", n => { FirewallIPSecExemptionsAllowICMP = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowNeighborDiscovery", n => { FirewallIPSecExemptionsAllowNeighborDiscovery = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowRouterDiscovery", n => { FirewallIPSecExemptionsAllowRouterDiscovery = n.GetBoolValue(); } },
                {"firewallMergeKeyingModuleSettings", n => { FirewallMergeKeyingModuleSettings = n.GetBoolValue(); } },
                {"firewallPacketQueueingMethod", n => { FirewallPacketQueueingMethod = n.GetEnumValue<FirewallPacketQueueingMethodType>(); } },
                {"firewallPreSharedKeyEncodingMethod", n => { FirewallPreSharedKeyEncodingMethod = n.GetEnumValue<FirewallPreSharedKeyEncodingMethodType>(); } },
                {"firewallProfileDomain", n => { FirewallProfileDomain = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallProfilePrivate", n => { FirewallProfilePrivate = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallProfilePublic", n => { FirewallProfilePublic = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"smartScreenBlockOverrideForFiles", n => { SmartScreenBlockOverrideForFiles = n.GetBoolValue(); } },
                {"smartScreenEnableInShell", n => { SmartScreenEnableInShell = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("applicationGuardAllowPersistence", ApplicationGuardAllowPersistence);
            writer.WriteBoolValue("applicationGuardAllowPrintToLocalPrinters", ApplicationGuardAllowPrintToLocalPrinters);
            writer.WriteBoolValue("applicationGuardAllowPrintToNetworkPrinters", ApplicationGuardAllowPrintToNetworkPrinters);
            writer.WriteBoolValue("applicationGuardAllowPrintToPDF", ApplicationGuardAllowPrintToPDF);
            writer.WriteBoolValue("applicationGuardAllowPrintToXPS", ApplicationGuardAllowPrintToXPS);
            writer.WriteEnumValue<ApplicationGuardBlockClipboardSharingType>("applicationGuardBlockClipboardSharing", ApplicationGuardBlockClipboardSharing);
            writer.WriteEnumValue<ApplicationGuardBlockFileTransferType>("applicationGuardBlockFileTransfer", ApplicationGuardBlockFileTransfer);
            writer.WriteBoolValue("applicationGuardBlockNonEnterpriseContent", ApplicationGuardBlockNonEnterpriseContent);
            writer.WriteBoolValue("applicationGuardEnabled", ApplicationGuardEnabled);
            writer.WriteBoolValue("applicationGuardForceAuditing", ApplicationGuardForceAuditing);
            writer.WriteEnumValue<AppLockerApplicationControlType>("appLockerApplicationControl", AppLockerApplicationControl);
            writer.WriteBoolValue("bitLockerDisableWarningForOtherDiskEncryption", BitLockerDisableWarningForOtherDiskEncryption);
            writer.WriteBoolValue("bitLockerEnableStorageCardEncryptionOnMobile", BitLockerEnableStorageCardEncryptionOnMobile);
            writer.WriteBoolValue("bitLockerEncryptDevice", BitLockerEncryptDevice);
            writer.WriteObjectValue<Microsoft.Graph.Models.BitLockerRemovableDrivePolicy>("bitLockerRemovableDrivePolicy", BitLockerRemovableDrivePolicy);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderAdditionalGuardedFolders", DefenderAdditionalGuardedFolders);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderAttackSurfaceReductionExcludedPaths", DefenderAttackSurfaceReductionExcludedPaths);
            writer.WriteByteArrayValue("defenderExploitProtectionXml", DefenderExploitProtectionXml);
            writer.WriteStringValue("defenderExploitProtectionXmlFileName", DefenderExploitProtectionXmlFileName);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderGuardedFoldersAllowedAppPaths", DefenderGuardedFoldersAllowedAppPaths);
            writer.WriteBoolValue("defenderSecurityCenterBlockExploitProtectionOverride", DefenderSecurityCenterBlockExploitProtectionOverride);
            writer.WriteBoolValue("firewallBlockStatefulFTP", FirewallBlockStatefulFTP);
            writer.WriteEnumValue<FirewallCertificateRevocationListCheckMethodType>("firewallCertificateRevocationListCheckMethod", FirewallCertificateRevocationListCheckMethod);
            writer.WriteIntValue("firewallIdleTimeoutForSecurityAssociationInSeconds", FirewallIdleTimeoutForSecurityAssociationInSeconds);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowDHCP", FirewallIPSecExemptionsAllowDHCP);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowICMP", FirewallIPSecExemptionsAllowICMP);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowNeighborDiscovery", FirewallIPSecExemptionsAllowNeighborDiscovery);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowRouterDiscovery", FirewallIPSecExemptionsAllowRouterDiscovery);
            writer.WriteBoolValue("firewallMergeKeyingModuleSettings", FirewallMergeKeyingModuleSettings);
            writer.WriteEnumValue<FirewallPacketQueueingMethodType>("firewallPacketQueueingMethod", FirewallPacketQueueingMethod);
            writer.WriteEnumValue<FirewallPreSharedKeyEncodingMethodType>("firewallPreSharedKeyEncodingMethod", FirewallPreSharedKeyEncodingMethod);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfileDomain", FirewallProfileDomain);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfilePrivate", FirewallProfilePrivate);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfilePublic", FirewallProfilePublic);
            writer.WriteBoolValue("smartScreenBlockOverrideForFiles", SmartScreenBlockOverrideForFiles);
            writer.WriteBoolValue("smartScreenEnableInShell", SmartScreenEnableInShell);
        }
    }
}

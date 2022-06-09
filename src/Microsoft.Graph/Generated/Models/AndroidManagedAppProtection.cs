using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AndroidManagedAppProtection : TargetedManagedAppProtection, IParsable {
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps {
            get { return BackingStore?.Get<List<ManagedMobileApp>>(nameof(Apps)); }
            set { BackingStore?.Set(nameof(Apps), value); }
        }
        /// <summary>Friendly name of the preferred custom browser to open weblink on Android.</summary>
        public string CustomBrowserDisplayName {
            get { return BackingStore?.Get<string>(nameof(CustomBrowserDisplayName)); }
            set { BackingStore?.Set(nameof(CustomBrowserDisplayName), value); }
        }
        /// <summary>Unique identifier of a custom browser to open weblink on Android.</summary>
        public string CustomBrowserPackageId {
            get { return BackingStore?.Get<string>(nameof(CustomBrowserPackageId)); }
            set { BackingStore?.Set(nameof(CustomBrowserPackageId), value); }
        }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount {
            get { return BackingStore?.Get<int?>(nameof(DeployedAppCount)); }
            set { BackingStore?.Set(nameof(DeployedAppCount), value); }
        }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary {
            get { return BackingStore?.Get<ManagedAppPolicyDeploymentSummary>(nameof(DeploymentSummary)); }
            set { BackingStore?.Set(nameof(DeploymentSummary), value); }
        }
        /// <summary>When this setting is enabled, app level encryption is disabled if device level encryption is enabled</summary>
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(DisableAppEncryptionIfDeviceEncryptionIsEnabled)); }
            set { BackingStore?.Set(nameof(DisableAppEncryptionIfDeviceEncryptionIsEnabled), value); }
        }
        /// <summary>Indicates whether application data for managed apps should be encrypted</summary>
        public bool? EncryptAppData {
            get { return BackingStore?.Get<bool?>(nameof(EncryptAppData)); }
            set { BackingStore?.Set(nameof(EncryptAppData), value); }
        }
        /// <summary>Define the oldest required Android security patch level a user can have to gain secure access to the app.</summary>
        public string MinimumRequiredPatchVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredPatchVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredPatchVersion), value); }
        }
        /// <summary>Define the oldest recommended Android security patch level a user can have for secure access to the app.</summary>
        public string MinimumWarningPatchVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWarningPatchVersion)); }
            set { BackingStore?.Set(nameof(MinimumWarningPatchVersion), value); }
        }
        /// <summary>Indicates whether a managed user can take screen captures of managed apps</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ScreenCaptureBlocked)); }
            set { BackingStore?.Set(nameof(ScreenCaptureBlocked), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"customBrowserDisplayName", n => { CustomBrowserDisplayName = n.GetStringValue(); } },
                {"customBrowserPackageId", n => { CustomBrowserPackageId = n.GetStringValue(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"disableAppEncryptionIfDeviceEncryptionIsEnabled", n => { DisableAppEncryptionIfDeviceEncryptionIsEnabled = n.GetBoolValue(); } },
                {"encryptAppData", n => { EncryptAppData = n.GetBoolValue(); } },
                {"minimumRequiredPatchVersion", n => { MinimumRequiredPatchVersion = n.GetStringValue(); } },
                {"minimumWarningPatchVersion", n => { MinimumWarningPatchVersion = n.GetStringValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteStringValue("customBrowserDisplayName", CustomBrowserDisplayName);
            writer.WriteStringValue("customBrowserPackageId", CustomBrowserPackageId);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("disableAppEncryptionIfDeviceEncryptionIsEnabled", DisableAppEncryptionIfDeviceEncryptionIsEnabled);
            writer.WriteBoolValue("encryptAppData", EncryptAppData);
            writer.WriteStringValue("minimumRequiredPatchVersion", MinimumRequiredPatchVersion);
            writer.WriteStringValue("minimumWarningPatchVersion", MinimumWarningPatchVersion);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
        }
    }
}

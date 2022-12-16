using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// This class contains compliance settings for Windows 10.
    /// </summary>
    public class Windows10CompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled</summary>
        public bool? BitLockerEnabled {
            get { return BackingStore?.Get<bool?>("bitLockerEnabled"); }
            set { BackingStore?.Set("bitLockerEnabled", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation.</summary>
        public bool? CodeIntegrityEnabled {
            get { return BackingStore?.Get<bool?>("codeIntegrityEnabled"); }
            set { BackingStore?.Set("codeIntegrityEnabled", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.</summary>
        public bool? EarlyLaunchAntiMalwareDriverEnabled {
            get { return BackingStore?.Get<bool?>("earlyLaunchAntiMalwareDriverEnabled"); }
            set { BackingStore?.Set("earlyLaunchAntiMalwareDriverEnabled", value); }
        }
        /// <summary>Maximum Windows Phone version.</summary>
        public string MobileOsMaximumVersion {
            get { return BackingStore?.Get<string>("mobileOsMaximumVersion"); }
            set { BackingStore?.Set("mobileOsMaximumVersion", value); }
        }
        /// <summary>Minimum Windows Phone version.</summary>
        public string MobileOsMinimumVersion {
            get { return BackingStore?.Get<string>("mobileOsMinimumVersion"); }
            set { BackingStore?.Set("mobileOsMinimumVersion", value); }
        }
        /// <summary>Maximum Windows 10 version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
        /// <summary>Minimum Windows 10 version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
        }
        /// <summary>Indicates whether or not to block simple password.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>("passwordBlockSimple"); }
            set { BackingStore?.Set("passwordBlockSimple", value); }
        }
        /// <summary>The password expiration in days.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>("passwordMinimumCharacterSetCount"); }
            set { BackingStore?.Set("passwordMinimumCharacterSetCount", value); }
        }
        /// <summary>The minimum password length.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeLock"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeLock", value); }
        }
        /// <summary>The number of previous passwords to prevent re-use of.</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Require a password to unlock Windows device.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>("passwordRequired"); }
            set { BackingStore?.Set("passwordRequired", value); }
        }
        /// <summary>Require a password to unlock an idle device.</summary>
        public bool? PasswordRequiredToUnlockFromIdle {
            get { return BackingStore?.Get<bool?>("passwordRequiredToUnlockFromIdle"); }
            set { BackingStore?.Set("passwordRequiredToUnlockFromIdle", value); }
        }
        /// <summary>Possible values of required passwords.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation.</summary>
        public bool? RequireHealthyDeviceReport {
            get { return BackingStore?.Get<bool?>("requireHealthyDeviceReport"); }
            set { BackingStore?.Set("requireHealthyDeviceReport", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.</summary>
        public bool? SecureBootEnabled {
            get { return BackingStore?.Get<bool?>("secureBootEnabled"); }
            set { BackingStore?.Set("secureBootEnabled", value); }
        }
        /// <summary>Require encryption on windows devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>("storageRequireEncryption"); }
            set { BackingStore?.Set("storageRequireEncryption", value); }
        }
        /// <summary>
        /// Instantiates a new windows10CompliancePolicy and sets the default values.
        /// </summary>
        public Windows10CompliancePolicy() : base() {
            OdataType = "#microsoft.graph.windows10CompliancePolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10CompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10CompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bitLockerEnabled", n => { BitLockerEnabled = n.GetBoolValue(); } },
                {"codeIntegrityEnabled", n => { CodeIntegrityEnabled = n.GetBoolValue(); } },
                {"earlyLaunchAntiMalwareDriverEnabled", n => { EarlyLaunchAntiMalwareDriverEnabled = n.GetBoolValue(); } },
                {"mobileOsMaximumVersion", n => { MobileOsMaximumVersion = n.GetStringValue(); } },
                {"mobileOsMinimumVersion", n => { MobileOsMinimumVersion = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordBlockSimple", n => { PasswordBlockSimple = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredToUnlockFromIdle", n => { PasswordRequiredToUnlockFromIdle = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"requireHealthyDeviceReport", n => { RequireHealthyDeviceReport = n.GetBoolValue(); } },
                {"secureBootEnabled", n => { SecureBootEnabled = n.GetBoolValue(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("bitLockerEnabled", BitLockerEnabled);
            writer.WriteBoolValue("codeIntegrityEnabled", CodeIntegrityEnabled);
            writer.WriteBoolValue("earlyLaunchAntiMalwareDriverEnabled", EarlyLaunchAntiMalwareDriverEnabled);
            writer.WriteStringValue("mobileOsMaximumVersion", MobileOsMaximumVersion);
            writer.WriteStringValue("mobileOsMinimumVersion", MobileOsMinimumVersion);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("passwordBlockSimple", PasswordBlockSimple);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteBoolValue("passwordRequiredToUnlockFromIdle", PasswordRequiredToUnlockFromIdle);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("requireHealthyDeviceReport", RequireHealthyDeviceReport);
            writer.WriteBoolValue("secureBootEnabled", SecureBootEnabled);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
        }
    }
}

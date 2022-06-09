using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Windows10CompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled</summary>
        public bool? BitLockerEnabled {
            get { return BackingStore?.Get<bool?>(nameof(BitLockerEnabled)); }
            set { BackingStore?.Set(nameof(BitLockerEnabled), value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation.</summary>
        public bool? CodeIntegrityEnabled {
            get { return BackingStore?.Get<bool?>(nameof(CodeIntegrityEnabled)); }
            set { BackingStore?.Set(nameof(CodeIntegrityEnabled), value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.</summary>
        public bool? EarlyLaunchAntiMalwareDriverEnabled {
            get { return BackingStore?.Get<bool?>(nameof(EarlyLaunchAntiMalwareDriverEnabled)); }
            set { BackingStore?.Set(nameof(EarlyLaunchAntiMalwareDriverEnabled), value); }
        }
        /// <summary>Maximum Windows Phone version.</summary>
        public string MobileOsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(MobileOsMaximumVersion)); }
            set { BackingStore?.Set(nameof(MobileOsMaximumVersion), value); }
        }
        /// <summary>Minimum Windows Phone version.</summary>
        public string MobileOsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(MobileOsMinimumVersion)); }
            set { BackingStore?.Set(nameof(MobileOsMinimumVersion), value); }
        }
        /// <summary>Maximum Windows 10 version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMaximumVersion)); }
            set { BackingStore?.Set(nameof(OsMaximumVersion), value); }
        }
        /// <summary>Minimum Windows 10 version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMinimumVersion)); }
            set { BackingStore?.Set(nameof(OsMinimumVersion), value); }
        }
        /// <summary>Indicates whether or not to block simple password.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockSimple)); }
            set { BackingStore?.Set(nameof(PasswordBlockSimple), value); }
        }
        /// <summary>The password expiration in days.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumCharacterSetCount)); }
            set { BackingStore?.Set(nameof(PasswordMinimumCharacterSetCount), value); }
        }
        /// <summary>The minimum password length.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeLock)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeLock), value); }
        }
        /// <summary>The number of previous passwords to prevent re-use of.</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordBlockCount)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordBlockCount), value); }
        }
        /// <summary>Require a password to unlock Windows device.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequired)); }
            set { BackingStore?.Set(nameof(PasswordRequired), value); }
        }
        /// <summary>Require a password to unlock an idle device.</summary>
        public bool? PasswordRequiredToUnlockFromIdle {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequiredToUnlockFromIdle)); }
            set { BackingStore?.Set(nameof(PasswordRequiredToUnlockFromIdle), value); }
        }
        /// <summary>The required password type. Possible values are: deviceDefault, alphanumeric, numeric.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation.</summary>
        public bool? RequireHealthyDeviceReport {
            get { return BackingStore?.Get<bool?>(nameof(RequireHealthyDeviceReport)); }
            set { BackingStore?.Set(nameof(RequireHealthyDeviceReport), value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.</summary>
        public bool? SecureBootEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SecureBootEnabled)); }
            set { BackingStore?.Set(nameof(SecureBootEnabled), value); }
        }
        /// <summary>Require encryption on windows devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireEncryption), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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

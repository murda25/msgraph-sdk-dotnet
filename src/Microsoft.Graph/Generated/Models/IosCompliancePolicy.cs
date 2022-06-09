using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class IosCompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Require that devices have enabled device threat protection .</summary>
        public bool? DeviceThreatProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(DeviceThreatProtectionEnabled)); }
            set { BackingStore?.Set(nameof(DeviceThreatProtectionEnabled), value); }
        }
        /// <summary>Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>(nameof(DeviceThreatProtectionRequiredSecurityLevel)); }
            set { BackingStore?.Set(nameof(DeviceThreatProtectionRequiredSecurityLevel), value); }
        }
        /// <summary>Indicates whether or not to require a managed email profile.</summary>
        public bool? ManagedEmailProfileRequired {
            get { return BackingStore?.Get<bool?>(nameof(ManagedEmailProfileRequired)); }
            set { BackingStore?.Set(nameof(ManagedEmailProfileRequired), value); }
        }
        /// <summary>Maximum IOS version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMaximumVersion)); }
            set { BackingStore?.Set(nameof(OsMaximumVersion), value); }
        }
        /// <summary>Minimum IOS version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMinimumVersion)); }
            set { BackingStore?.Set(nameof(OsMinimumVersion), value); }
        }
        /// <summary>Indicates whether or not to block simple passcodes.</summary>
        public bool? PasscodeBlockSimple {
            get { return BackingStore?.Get<bool?>(nameof(PasscodeBlockSimple)); }
            set { BackingStore?.Set(nameof(PasscodeBlockSimple), value); }
        }
        /// <summary>Number of days before the passcode expires. Valid values 1 to 65535</summary>
        public int? PasscodeExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasscodeExpirationDays)); }
            set { BackingStore?.Set(nameof(PasscodeExpirationDays), value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasscodeMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>(nameof(PasscodeMinimumCharacterSetCount)); }
            set { BackingStore?.Set(nameof(PasscodeMinimumCharacterSetCount), value); }
        }
        /// <summary>Minimum length of passcode. Valid values 4 to 14</summary>
        public int? PasscodeMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasscodeMinimumLength)); }
            set { BackingStore?.Set(nameof(PasscodeMinimumLength), value); }
        }
        /// <summary>Minutes of inactivity before a passcode is required.</summary>
        public int? PasscodeMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>(nameof(PasscodeMinutesOfInactivityBeforeLock)); }
            set { BackingStore?.Set(nameof(PasscodeMinutesOfInactivityBeforeLock), value); }
        }
        /// <summary>Number of previous passcodes to block. Valid values 1 to 24</summary>
        public int? PasscodePreviousPasscodeBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasscodePreviousPasscodeBlockCount)); }
            set { BackingStore?.Set(nameof(PasscodePreviousPasscodeBlockCount), value); }
        }
        /// <summary>Indicates whether or not to require a passcode.</summary>
        public bool? PasscodeRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasscodeRequired)); }
            set { BackingStore?.Set(nameof(PasscodeRequired), value); }
        }
        /// <summary>The required passcode type. Possible values are: deviceDefault, alphanumeric, numeric.</summary>
        public RequiredPasswordType? PasscodeRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>(nameof(PasscodeRequiredType)); }
            set { BackingStore?.Set(nameof(PasscodeRequiredType), value); }
        }
        /// <summary>Devices must not be jailbroken or rooted.</summary>
        public bool? SecurityBlockJailbrokenDevices {
            get { return BackingStore?.Get<bool?>(nameof(SecurityBlockJailbrokenDevices)); }
            set { BackingStore?.Set(nameof(SecurityBlockJailbrokenDevices), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"managedEmailProfileRequired", n => { ManagedEmailProfileRequired = n.GetBoolValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passcodeBlockSimple", n => { PasscodeBlockSimple = n.GetBoolValue(); } },
                {"passcodeExpirationDays", n => { PasscodeExpirationDays = n.GetIntValue(); } },
                {"passcodeMinimumCharacterSetCount", n => { PasscodeMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passcodeMinimumLength", n => { PasscodeMinimumLength = n.GetIntValue(); } },
                {"passcodeMinutesOfInactivityBeforeLock", n => { PasscodeMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passcodePreviousPasscodeBlockCount", n => { PasscodePreviousPasscodeBlockCount = n.GetIntValue(); } },
                {"passcodeRequired", n => { PasscodeRequired = n.GetBoolValue(); } },
                {"passcodeRequiredType", n => { PasscodeRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"securityBlockJailbrokenDevices", n => { SecurityBlockJailbrokenDevices = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("managedEmailProfileRequired", ManagedEmailProfileRequired);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("passcodeBlockSimple", PasscodeBlockSimple);
            writer.WriteIntValue("passcodeExpirationDays", PasscodeExpirationDays);
            writer.WriteIntValue("passcodeMinimumCharacterSetCount", PasscodeMinimumCharacterSetCount);
            writer.WriteIntValue("passcodeMinimumLength", PasscodeMinimumLength);
            writer.WriteIntValue("passcodeMinutesOfInactivityBeforeLock", PasscodeMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passcodePreviousPasscodeBlockCount", PasscodePreviousPasscodeBlockCount);
            writer.WriteBoolValue("passcodeRequired", PasscodeRequired);
            writer.WriteEnumValue<RequiredPasswordType>("passcodeRequiredType", PasscodeRequiredType);
            writer.WriteBoolValue("securityBlockJailbrokenDevices", SecurityBlockJailbrokenDevices);
        }
    }
}

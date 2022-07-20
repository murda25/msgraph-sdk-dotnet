using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class WindowsInformationProtectionPolicy : WindowsInformationProtection, IParsable {
        /// <summary>Offline interval before app data is wiped (days)</summary>
        public int? DaysWithoutContactBeforeUnenroll {
            get { return BackingStore?.Get<int?>("daysWithoutContactBeforeUnenroll"); }
            set { BackingStore?.Set("daysWithoutContactBeforeUnenroll", value); }
        }
        /// <summary>Enrollment url for the MDM</summary>
        public string MdmEnrollmentUrl {
            get { return BackingStore?.Get<string>("mdmEnrollmentUrl"); }
            set { BackingStore?.Set("mdmEnrollmentUrl", value); }
        }
        /// <summary>Specifies the maximum amount of time (in minutes) allowed after the device is idle that will cause the device to become PIN or password locked.   Range is an integer X where 0 &lt;= X &lt;= 999.</summary>
        public int? MinutesOfInactivityBeforeDeviceLock {
            get { return BackingStore?.Get<int?>("minutesOfInactivityBeforeDeviceLock"); }
            set { BackingStore?.Set("minutesOfInactivityBeforeDeviceLock", value); }
        }
        /// <summary>Integer value that specifies the number of past PINs that can be associated to a user account that can&apos;t be reused. The largest number you can configure for this policy setting is 50. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then storage of previous PINs is not required. This node was added in Windows 10, version 1511. Default is 0.</summary>
        public int? NumberOfPastPinsRemembered {
            get { return BackingStore?.Get<int?>("numberOfPastPinsRemembered"); }
            set { BackingStore?.Set("numberOfPastPinsRemembered", value); }
        }
        /// <summary>The number of authentication failures allowed before the device will be wiped. A value of 0 disables device wipe functionality. Range is an integer X where 4 &lt;= X &lt;= 16 for desktop and 0 &lt;= X &lt;= 999 for mobile devices.</summary>
        public int? PasswordMaximumAttemptCount {
            get { return BackingStore?.Get<int?>("passwordMaximumAttemptCount"); }
            set { BackingStore?.Set("passwordMaximumAttemptCount", value); }
        }
        /// <summary>Integer value specifies the period of time (in days) that a PIN can be used before the system requires the user to change it. The largest number you can configure for this policy setting is 730. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then the user&apos;s PIN will never expire. This node was added in Windows 10, version 1511. Default is 0.</summary>
        public int? PinExpirationDays {
            get { return BackingStore?.Get<int?>("pinExpirationDays"); }
            set { BackingStore?.Set("pinExpirationDays", value); }
        }
        /// <summary>Pin Character Requirements</summary>
        public WindowsInformationProtectionPinCharacterRequirements? PinLowercaseLetters {
            get { return BackingStore?.Get<WindowsInformationProtectionPinCharacterRequirements?>("pinLowercaseLetters"); }
            set { BackingStore?.Set("pinLowercaseLetters", value); }
        }
        /// <summary>Integer value that sets the minimum number of characters required for the PIN. Default value is 4. The lowest number you can configure for this policy setting is 4. The largest number you can configure must be less than the number configured in the Maximum PIN length policy setting or the number 127, whichever is the lowest.</summary>
        public int? PinMinimumLength {
            get { return BackingStore?.Get<int?>("pinMinimumLength"); }
            set { BackingStore?.Set("pinMinimumLength", value); }
        }
        /// <summary>Pin Character Requirements</summary>
        public WindowsInformationProtectionPinCharacterRequirements? PinSpecialCharacters {
            get { return BackingStore?.Get<WindowsInformationProtectionPinCharacterRequirements?>("pinSpecialCharacters"); }
            set { BackingStore?.Set("pinSpecialCharacters", value); }
        }
        /// <summary>Pin Character Requirements</summary>
        public WindowsInformationProtectionPinCharacterRequirements? PinUppercaseLetters {
            get { return BackingStore?.Get<WindowsInformationProtectionPinCharacterRequirements?>("pinUppercaseLetters"); }
            set { BackingStore?.Set("pinUppercaseLetters", value); }
        }
        /// <summary>New property in RS2, pending documentation</summary>
        public bool? RevokeOnMdmHandoffDisabled {
            get { return BackingStore?.Get<bool?>("revokeOnMdmHandoffDisabled"); }
            set { BackingStore?.Set("revokeOnMdmHandoffDisabled", value); }
        }
        /// <summary>Boolean value that sets Windows Hello for Business as a method for signing into Windows.</summary>
        public bool? WindowsHelloForBusinessBlocked {
            get { return BackingStore?.Get<bool?>("windowsHelloForBusinessBlocked"); }
            set { BackingStore?.Set("windowsHelloForBusinessBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsInformationProtectionPolicy and sets the default values.
        /// </summary>
        public WindowsInformationProtectionPolicy() : base() {
            OdataType = "#microsoft.graph.windowsInformationProtectionPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsInformationProtectionPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"daysWithoutContactBeforeUnenroll", n => { DaysWithoutContactBeforeUnenroll = n.GetIntValue(); } },
                {"mdmEnrollmentUrl", n => { MdmEnrollmentUrl = n.GetStringValue(); } },
                {"minutesOfInactivityBeforeDeviceLock", n => { MinutesOfInactivityBeforeDeviceLock = n.GetIntValue(); } },
                {"numberOfPastPinsRemembered", n => { NumberOfPastPinsRemembered = n.GetIntValue(); } },
                {"passwordMaximumAttemptCount", n => { PasswordMaximumAttemptCount = n.GetIntValue(); } },
                {"pinExpirationDays", n => { PinExpirationDays = n.GetIntValue(); } },
                {"pinLowercaseLetters", n => { PinLowercaseLetters = n.GetEnumValue<WindowsInformationProtectionPinCharacterRequirements>(); } },
                {"pinMinimumLength", n => { PinMinimumLength = n.GetIntValue(); } },
                {"pinSpecialCharacters", n => { PinSpecialCharacters = n.GetEnumValue<WindowsInformationProtectionPinCharacterRequirements>(); } },
                {"pinUppercaseLetters", n => { PinUppercaseLetters = n.GetEnumValue<WindowsInformationProtectionPinCharacterRequirements>(); } },
                {"revokeOnMdmHandoffDisabled", n => { RevokeOnMdmHandoffDisabled = n.GetBoolValue(); } },
                {"windowsHelloForBusinessBlocked", n => { WindowsHelloForBusinessBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("daysWithoutContactBeforeUnenroll", DaysWithoutContactBeforeUnenroll);
            writer.WriteStringValue("mdmEnrollmentUrl", MdmEnrollmentUrl);
            writer.WriteIntValue("minutesOfInactivityBeforeDeviceLock", MinutesOfInactivityBeforeDeviceLock);
            writer.WriteIntValue("numberOfPastPinsRemembered", NumberOfPastPinsRemembered);
            writer.WriteIntValue("passwordMaximumAttemptCount", PasswordMaximumAttemptCount);
            writer.WriteIntValue("pinExpirationDays", PinExpirationDays);
            writer.WriteEnumValue<WindowsInformationProtectionPinCharacterRequirements>("pinLowercaseLetters", PinLowercaseLetters);
            writer.WriteIntValue("pinMinimumLength", PinMinimumLength);
            writer.WriteEnumValue<WindowsInformationProtectionPinCharacterRequirements>("pinSpecialCharacters", PinSpecialCharacters);
            writer.WriteEnumValue<WindowsInformationProtectionPinCharacterRequirements>("pinUppercaseLetters", PinUppercaseLetters);
            writer.WriteBoolValue("revokeOnMdmHandoffDisabled", RevokeOnMdmHandoffDisabled);
            writer.WriteBoolValue("windowsHelloForBusinessBlocked", WindowsHelloForBusinessBlocked);
        }
    }
}
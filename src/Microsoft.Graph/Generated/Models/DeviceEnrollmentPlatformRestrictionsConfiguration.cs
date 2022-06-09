using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class DeviceEnrollmentPlatformRestrictionsConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Android restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction AndroidRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>(nameof(AndroidRestriction)); }
            set { BackingStore?.Set(nameof(AndroidRestriction), value); }
        }
        /// <summary>Ios restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction IosRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>(nameof(IosRestriction)); }
            set { BackingStore?.Set(nameof(IosRestriction), value); }
        }
        /// <summary>Mac restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction MacOSRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>(nameof(MacOSRestriction)); }
            set { BackingStore?.Set(nameof(MacOSRestriction), value); }
        }
        /// <summary>Windows mobile restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction WindowsMobileRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>(nameof(WindowsMobileRestriction)); }
            set { BackingStore?.Set(nameof(WindowsMobileRestriction), value); }
        }
        /// <summary>Windows restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction WindowsRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>(nameof(WindowsRestriction)); }
            set { BackingStore?.Set(nameof(WindowsRestriction), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceEnrollmentPlatformRestrictionsConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentPlatformRestrictionsConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidRestriction", n => { AndroidRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"iosRestriction", n => { IosRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"macOSRestriction", n => { MacOSRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"windowsMobileRestriction", n => { WindowsMobileRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"windowsRestriction", n => { WindowsRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("androidRestriction", AndroidRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("iosRestriction", IosRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("macOSRestriction", MacOSRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("windowsMobileRestriction", WindowsMobileRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("windowsRestriction", WindowsRestriction);
        }
    }
}

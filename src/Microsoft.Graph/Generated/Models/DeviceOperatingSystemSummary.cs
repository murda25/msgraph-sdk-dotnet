using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Device operating system summary.</summary>
    public class DeviceOperatingSystemSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Number of android device count.</summary>
        public int? AndroidCount {
            get { return BackingStore?.Get<int?>(nameof(AndroidCount)); }
            set { BackingStore?.Set(nameof(AndroidCount), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of iOS device count.</summary>
        public int? IosCount {
            get { return BackingStore?.Get<int?>(nameof(IosCount)); }
            set { BackingStore?.Set(nameof(IosCount), value); }
        }
        /// <summary>Number of Mac OS X device count.</summary>
        public int? MacOSCount {
            get { return BackingStore?.Get<int?>(nameof(MacOSCount)); }
            set { BackingStore?.Set(nameof(MacOSCount), value); }
        }
        /// <summary>Number of unknown device count.</summary>
        public int? UnknownCount {
            get { return BackingStore?.Get<int?>(nameof(UnknownCount)); }
            set { BackingStore?.Set(nameof(UnknownCount), value); }
        }
        /// <summary>Number of Windows device count.</summary>
        public int? WindowsCount {
            get { return BackingStore?.Get<int?>(nameof(WindowsCount)); }
            set { BackingStore?.Set(nameof(WindowsCount), value); }
        }
        /// <summary>Number of Windows mobile device count.</summary>
        public int? WindowsMobileCount {
            get { return BackingStore?.Get<int?>(nameof(WindowsMobileCount)); }
            set { BackingStore?.Set(nameof(WindowsMobileCount), value); }
        }
        /// <summary>
        /// Instantiates a new deviceOperatingSystemSummary and sets the default values.
        /// </summary>
        public DeviceOperatingSystemSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceOperatingSystemSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceOperatingSystemSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"androidCount", n => { AndroidCount = n.GetIntValue(); } },
                {"iosCount", n => { IosCount = n.GetIntValue(); } },
                {"macOSCount", n => { MacOSCount = n.GetIntValue(); } },
                {"unknownCount", n => { UnknownCount = n.GetIntValue(); } },
                {"windowsCount", n => { WindowsCount = n.GetIntValue(); } },
                {"windowsMobileCount", n => { WindowsMobileCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("androidCount", AndroidCount);
            writer.WriteIntValue("iosCount", IosCount);
            writer.WriteIntValue("macOSCount", MacOSCount);
            writer.WriteIntValue("unknownCount", UnknownCount);
            writer.WriteIntValue("windowsCount", WindowsCount);
            writer.WriteIntValue("windowsMobileCount", WindowsMobileCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

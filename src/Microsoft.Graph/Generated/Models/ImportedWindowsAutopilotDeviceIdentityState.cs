using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ImportedWindowsAutopilotDeviceIdentityState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device error code reported by Device Directory Service(DDS).</summary>
        public int? DeviceErrorCode {
            get { return BackingStore?.Get<int?>(nameof(DeviceErrorCode)); }
            set { BackingStore?.Set(nameof(DeviceErrorCode), value); }
        }
        /// <summary>Device error name reported by Device Directory Service(DDS).</summary>
        public string DeviceErrorName {
            get { return BackingStore?.Get<string>(nameof(DeviceErrorName)); }
            set { BackingStore?.Set(nameof(DeviceErrorName), value); }
        }
        /// <summary>Device status reported by Device Directory Service(DDS). Possible values are: unknown, pending, partial, complete, error.</summary>
        public ImportedWindowsAutopilotDeviceIdentityImportStatus? DeviceImportStatus {
            get { return BackingStore?.Get<ImportedWindowsAutopilotDeviceIdentityImportStatus?>(nameof(DeviceImportStatus)); }
            set { BackingStore?.Set(nameof(DeviceImportStatus), value); }
        }
        /// <summary>Device Registration ID for successfully added device reported by Device Directory Service(DDS).</summary>
        public string DeviceRegistrationId {
            get { return BackingStore?.Get<string>(nameof(DeviceRegistrationId)); }
            set { BackingStore?.Set(nameof(DeviceRegistrationId), value); }
        }
        /// <summary>
        /// Instantiates a new importedWindowsAutopilotDeviceIdentityState and sets the default values.
        /// </summary>
        public ImportedWindowsAutopilotDeviceIdentityState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ImportedWindowsAutopilotDeviceIdentityState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportedWindowsAutopilotDeviceIdentityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceErrorCode", n => { DeviceErrorCode = n.GetIntValue(); } },
                {"deviceErrorName", n => { DeviceErrorName = n.GetStringValue(); } },
                {"deviceImportStatus", n => { DeviceImportStatus = n.GetEnumValue<ImportedWindowsAutopilotDeviceIdentityImportStatus>(); } },
                {"deviceRegistrationId", n => { DeviceRegistrationId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceErrorCode", DeviceErrorCode);
            writer.WriteStringValue("deviceErrorName", DeviceErrorName);
            writer.WriteEnumValue<ImportedWindowsAutopilotDeviceIdentityImportStatus>("deviceImportStatus", DeviceImportStatus);
            writer.WriteStringValue("deviceRegistrationId", DeviceRegistrationId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
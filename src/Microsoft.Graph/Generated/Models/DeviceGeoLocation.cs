using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Device location</summary>
    public class DeviceGeoLocation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Altitude, given in meters above sea level</summary>
        public double? Altitude {
            get { return BackingStore?.Get<double?>("altitude"); }
            set { BackingStore?.Set("altitude", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Heading in degrees from true north</summary>
        public double? Heading {
            get { return BackingStore?.Get<double?>("heading"); }
            set { BackingStore?.Set("heading", value); }
        }
        /// <summary>Accuracy of longitude and latitude in meters</summary>
        public double? HorizontalAccuracy {
            get { return BackingStore?.Get<double?>("horizontalAccuracy"); }
            set { BackingStore?.Set("horizontalAccuracy", value); }
        }
        /// <summary>Time at which location was recorded, relative to UTC</summary>
        public DateTimeOffset? LastCollectedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCollectedDateTime"); }
            set { BackingStore?.Set("lastCollectedDateTime", value); }
        }
        /// <summary>Latitude coordinate of the device&apos;s location</summary>
        public double? Latitude {
            get { return BackingStore?.Get<double?>("latitude"); }
            set { BackingStore?.Set("latitude", value); }
        }
        /// <summary>Longitude coordinate of the device&apos;s location</summary>
        public double? Longitude {
            get { return BackingStore?.Get<double?>("longitude"); }
            set { BackingStore?.Set("longitude", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Speed the device is traveling in meters per second</summary>
        public double? Speed {
            get { return BackingStore?.Get<double?>("speed"); }
            set { BackingStore?.Set("speed", value); }
        }
        /// <summary>Accuracy of altitude in meters</summary>
        public double? VerticalAccuracy {
            get { return BackingStore?.Get<double?>("verticalAccuracy"); }
            set { BackingStore?.Set("verticalAccuracy", value); }
        }
        /// <summary>
        /// Instantiates a new deviceGeoLocation and sets the default values.
        /// </summary>
        public DeviceGeoLocation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceGeoLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceGeoLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"altitude", n => { Altitude = n.GetDoubleValue(); } },
                {"heading", n => { Heading = n.GetDoubleValue(); } },
                {"horizontalAccuracy", n => { HorizontalAccuracy = n.GetDoubleValue(); } },
                {"lastCollectedDateTime", n => { LastCollectedDateTime = n.GetDateTimeOffsetValue(); } },
                {"latitude", n => { Latitude = n.GetDoubleValue(); } },
                {"longitude", n => { Longitude = n.GetDoubleValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"speed", n => { Speed = n.GetDoubleValue(); } },
                {"verticalAccuracy", n => { VerticalAccuracy = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("altitude", Altitude);
            writer.WriteDoubleValue("heading", Heading);
            writer.WriteDoubleValue("horizontalAccuracy", HorizontalAccuracy);
            writer.WriteDateTimeOffsetValue("lastCollectedDateTime", LastCollectedDateTime);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDoubleValue("speed", Speed);
            writer.WriteDoubleValue("verticalAccuracy", VerticalAccuracy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class Photo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Camera manufacturer. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CameraMake {
            get { return BackingStore?.Get<string?>("cameraMake"); }
            set { BackingStore?.Set("cameraMake", value); }
        }
#nullable restore
#else
        public string CameraMake {
            get { return BackingStore?.Get<string>("cameraMake"); }
            set { BackingStore?.Set("cameraMake", value); }
        }
#endif
        /// <summary>Camera model. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CameraModel {
            get { return BackingStore?.Get<string?>("cameraModel"); }
            set { BackingStore?.Set("cameraModel", value); }
        }
#nullable restore
#else
        public string CameraModel {
            get { return BackingStore?.Get<string>("cameraModel"); }
            set { BackingStore?.Set("cameraModel", value); }
        }
#endif
        /// <summary>The denominator for the exposure time fraction from the camera. Read-only.</summary>
        public double? ExposureDenominator {
            get { return BackingStore?.Get<double?>("exposureDenominator"); }
            set { BackingStore?.Set("exposureDenominator", value); }
        }
        /// <summary>The numerator for the exposure time fraction from the camera. Read-only.</summary>
        public double? ExposureNumerator {
            get { return BackingStore?.Get<double?>("exposureNumerator"); }
            set { BackingStore?.Set("exposureNumerator", value); }
        }
        /// <summary>The F-stop value from the camera. Read-only.</summary>
        public double? FNumber {
            get { return BackingStore?.Get<double?>("fNumber"); }
            set { BackingStore?.Set("fNumber", value); }
        }
        /// <summary>The focal length from the camera. Read-only.</summary>
        public double? FocalLength {
            get { return BackingStore?.Get<double?>("focalLength"); }
            set { BackingStore?.Set("focalLength", value); }
        }
        /// <summary>The ISO value from the camera. Read-only.</summary>
        public int? Iso {
            get { return BackingStore?.Get<int?>("iso"); }
            set { BackingStore?.Set("iso", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The orientation value from the camera. Writable on OneDrive Personal.</summary>
        public int? Orientation {
            get { return BackingStore?.Get<int?>("orientation"); }
            set { BackingStore?.Set("orientation", value); }
        }
        /// <summary>Represents the date and time the photo was taken. Read-only.</summary>
        public DateTimeOffset? TakenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("takenDateTime"); }
            set { BackingStore?.Set("takenDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new photo and sets the default values.
        /// </summary>
        public Photo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Photo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Photo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cameraMake", n => { CameraMake = n.GetStringValue(); } },
                {"cameraModel", n => { CameraModel = n.GetStringValue(); } },
                {"exposureDenominator", n => { ExposureDenominator = n.GetDoubleValue(); } },
                {"exposureNumerator", n => { ExposureNumerator = n.GetDoubleValue(); } },
                {"fNumber", n => { FNumber = n.GetDoubleValue(); } },
                {"focalLength", n => { FocalLength = n.GetDoubleValue(); } },
                {"iso", n => { Iso = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"orientation", n => { Orientation = n.GetIntValue(); } },
                {"takenDateTime", n => { TakenDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cameraMake", CameraMake);
            writer.WriteStringValue("cameraModel", CameraModel);
            writer.WriteDoubleValue("exposureDenominator", ExposureDenominator);
            writer.WriteDoubleValue("exposureNumerator", ExposureNumerator);
            writer.WriteDoubleValue("fNumber", FNumber);
            writer.WriteDoubleValue("focalLength", FocalLength);
            writer.WriteIntValue("iso", Iso);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("orientation", Orientation);
            writer.WriteDateTimeOffsetValue("takenDateTime", TakenDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

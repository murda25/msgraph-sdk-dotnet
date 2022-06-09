using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.CallRecords {
    public class DeviceInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Name of the capture device driver used by the media endpoint.</summary>
        public string CaptureDeviceDriver {
            get { return BackingStore?.Get<string>(nameof(CaptureDeviceDriver)); }
            set { BackingStore?.Set(nameof(CaptureDeviceDriver), value); }
        }
        /// <summary>Name of the capture device used by the media endpoint.</summary>
        public string CaptureDeviceName {
            get { return BackingStore?.Get<string>(nameof(CaptureDeviceName)); }
            set { BackingStore?.Set(nameof(CaptureDeviceName), value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected the capture device was not working properly.</summary>
        public float? CaptureNotFunctioningEventRatio {
            get { return BackingStore?.Get<float?>(nameof(CaptureNotFunctioningEventRatio)); }
            set { BackingStore?.Set(nameof(CaptureNotFunctioningEventRatio), value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected the CPU resources available were insufficient and caused poor quality of the audio sent and received.</summary>
        public float? CpuInsufficentEventRatio {
            get { return BackingStore?.Get<float?>(nameof(CpuInsufficentEventRatio)); }
            set { BackingStore?.Set(nameof(CpuInsufficentEventRatio), value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected clipping in the captured audio that caused poor quality of the audio being sent.</summary>
        public float? DeviceClippingEventRatio {
            get { return BackingStore?.Get<float?>(nameof(DeviceClippingEventRatio)); }
            set { BackingStore?.Set(nameof(DeviceClippingEventRatio), value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected glitches or gaps in the audio played or captured that caused poor quality of the audio being sent or received.</summary>
        public float? DeviceGlitchEventRatio {
            get { return BackingStore?.Get<float?>(nameof(DeviceGlitchEventRatio)); }
            set { BackingStore?.Set(nameof(DeviceGlitchEventRatio), value); }
        }
        /// <summary>Number of times during the call that the media endpoint detected howling or screeching audio.</summary>
        public int? HowlingEventCount {
            get { return BackingStore?.Get<int?>(nameof(HowlingEventCount)); }
            set { BackingStore?.Set(nameof(HowlingEventCount), value); }
        }
        /// <summary>The root mean square (RMS) of the incoming signal of up to the first 30 seconds of the call.</summary>
        public float? InitialSignalLevelRootMeanSquare {
            get { return BackingStore?.Get<float?>(nameof(InitialSignalLevelRootMeanSquare)); }
            set { BackingStore?.Set(nameof(InitialSignalLevelRootMeanSquare), value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected low speech level that caused poor quality of the audio being sent.</summary>
        public float? LowSpeechLevelEventRatio {
            get { return BackingStore?.Get<float?>(nameof(LowSpeechLevelEventRatio)); }
            set { BackingStore?.Set(nameof(LowSpeechLevelEventRatio), value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected low speech to noise level that caused poor quality of the audio being sent.</summary>
        public float? LowSpeechToNoiseEventRatio {
            get { return BackingStore?.Get<float?>(nameof(LowSpeechToNoiseEventRatio)); }
            set { BackingStore?.Set(nameof(LowSpeechToNoiseEventRatio), value); }
        }
        /// <summary>Glitches per 5 minute interval for the media endpoint&apos;s microphone.</summary>
        public float? MicGlitchRate {
            get { return BackingStore?.Get<float?>(nameof(MicGlitchRate)); }
            set { BackingStore?.Set(nameof(MicGlitchRate), value); }
        }
        /// <summary>Average energy level of received audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.</summary>
        public int? ReceivedNoiseLevel {
            get { return BackingStore?.Get<int?>(nameof(ReceivedNoiseLevel)); }
            set { BackingStore?.Set(nameof(ReceivedNoiseLevel), value); }
        }
        /// <summary>Average energy level of received audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.</summary>
        public int? ReceivedSignalLevel {
            get { return BackingStore?.Get<int?>(nameof(ReceivedSignalLevel)); }
            set { BackingStore?.Set(nameof(ReceivedSignalLevel), value); }
        }
        /// <summary>Name of the render device driver used by the media endpoint.</summary>
        public string RenderDeviceDriver {
            get { return BackingStore?.Get<string>(nameof(RenderDeviceDriver)); }
            set { BackingStore?.Set(nameof(RenderDeviceDriver), value); }
        }
        /// <summary>Name of the render device used by the media endpoint.</summary>
        public string RenderDeviceName {
            get { return BackingStore?.Get<string>(nameof(RenderDeviceName)); }
            set { BackingStore?.Set(nameof(RenderDeviceName), value); }
        }
        /// <summary>Fraction of the call that media endpoint detected device render is muted.</summary>
        public float? RenderMuteEventRatio {
            get { return BackingStore?.Get<float?>(nameof(RenderMuteEventRatio)); }
            set { BackingStore?.Set(nameof(RenderMuteEventRatio), value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected the render device was not working properly.</summary>
        public float? RenderNotFunctioningEventRatio {
            get { return BackingStore?.Get<float?>(nameof(RenderNotFunctioningEventRatio)); }
            set { BackingStore?.Set(nameof(RenderNotFunctioningEventRatio), value); }
        }
        /// <summary>Fraction of the call that media endpoint detected device render volume is set to 0.</summary>
        public float? RenderZeroVolumeEventRatio {
            get { return BackingStore?.Get<float?>(nameof(RenderZeroVolumeEventRatio)); }
            set { BackingStore?.Set(nameof(RenderZeroVolumeEventRatio), value); }
        }
        /// <summary>Average energy level of sent audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.</summary>
        public int? SentNoiseLevel {
            get { return BackingStore?.Get<int?>(nameof(SentNoiseLevel)); }
            set { BackingStore?.Set(nameof(SentNoiseLevel), value); }
        }
        /// <summary>Average energy level of sent audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.</summary>
        public int? SentSignalLevel {
            get { return BackingStore?.Get<int?>(nameof(SentSignalLevel)); }
            set { BackingStore?.Set(nameof(SentSignalLevel), value); }
        }
        /// <summary>Glitches per 5 minute internal for the media endpoint&apos;s loudspeaker.</summary>
        public float? SpeakerGlitchRate {
            get { return BackingStore?.Get<float?>(nameof(SpeakerGlitchRate)); }
            set { BackingStore?.Set(nameof(SpeakerGlitchRate), value); }
        }
        /// <summary>
        /// Instantiates a new deviceInfo and sets the default values.
        /// </summary>
        public DeviceInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"captureDeviceDriver", n => { CaptureDeviceDriver = n.GetStringValue(); } },
                {"captureDeviceName", n => { CaptureDeviceName = n.GetStringValue(); } },
                {"captureNotFunctioningEventRatio", n => { CaptureNotFunctioningEventRatio = n.GetFloatValue(); } },
                {"cpuInsufficentEventRatio", n => { CpuInsufficentEventRatio = n.GetFloatValue(); } },
                {"deviceClippingEventRatio", n => { DeviceClippingEventRatio = n.GetFloatValue(); } },
                {"deviceGlitchEventRatio", n => { DeviceGlitchEventRatio = n.GetFloatValue(); } },
                {"howlingEventCount", n => { HowlingEventCount = n.GetIntValue(); } },
                {"initialSignalLevelRootMeanSquare", n => { InitialSignalLevelRootMeanSquare = n.GetFloatValue(); } },
                {"lowSpeechLevelEventRatio", n => { LowSpeechLevelEventRatio = n.GetFloatValue(); } },
                {"lowSpeechToNoiseEventRatio", n => { LowSpeechToNoiseEventRatio = n.GetFloatValue(); } },
                {"micGlitchRate", n => { MicGlitchRate = n.GetFloatValue(); } },
                {"receivedNoiseLevel", n => { ReceivedNoiseLevel = n.GetIntValue(); } },
                {"receivedSignalLevel", n => { ReceivedSignalLevel = n.GetIntValue(); } },
                {"renderDeviceDriver", n => { RenderDeviceDriver = n.GetStringValue(); } },
                {"renderDeviceName", n => { RenderDeviceName = n.GetStringValue(); } },
                {"renderMuteEventRatio", n => { RenderMuteEventRatio = n.GetFloatValue(); } },
                {"renderNotFunctioningEventRatio", n => { RenderNotFunctioningEventRatio = n.GetFloatValue(); } },
                {"renderZeroVolumeEventRatio", n => { RenderZeroVolumeEventRatio = n.GetFloatValue(); } },
                {"sentNoiseLevel", n => { SentNoiseLevel = n.GetIntValue(); } },
                {"sentSignalLevel", n => { SentSignalLevel = n.GetIntValue(); } },
                {"speakerGlitchRate", n => { SpeakerGlitchRate = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("captureDeviceDriver", CaptureDeviceDriver);
            writer.WriteStringValue("captureDeviceName", CaptureDeviceName);
            writer.WriteFloatValue("captureNotFunctioningEventRatio", CaptureNotFunctioningEventRatio);
            writer.WriteFloatValue("cpuInsufficentEventRatio", CpuInsufficentEventRatio);
            writer.WriteFloatValue("deviceClippingEventRatio", DeviceClippingEventRatio);
            writer.WriteFloatValue("deviceGlitchEventRatio", DeviceGlitchEventRatio);
            writer.WriteIntValue("howlingEventCount", HowlingEventCount);
            writer.WriteFloatValue("initialSignalLevelRootMeanSquare", InitialSignalLevelRootMeanSquare);
            writer.WriteFloatValue("lowSpeechLevelEventRatio", LowSpeechLevelEventRatio);
            writer.WriteFloatValue("lowSpeechToNoiseEventRatio", LowSpeechToNoiseEventRatio);
            writer.WriteFloatValue("micGlitchRate", MicGlitchRate);
            writer.WriteIntValue("receivedNoiseLevel", ReceivedNoiseLevel);
            writer.WriteIntValue("receivedSignalLevel", ReceivedSignalLevel);
            writer.WriteStringValue("renderDeviceDriver", RenderDeviceDriver);
            writer.WriteStringValue("renderDeviceName", RenderDeviceName);
            writer.WriteFloatValue("renderMuteEventRatio", RenderMuteEventRatio);
            writer.WriteFloatValue("renderNotFunctioningEventRatio", RenderNotFunctioningEventRatio);
            writer.WriteFloatValue("renderZeroVolumeEventRatio", RenderZeroVolumeEventRatio);
            writer.WriteIntValue("sentNoiseLevel", SentNoiseLevel);
            writer.WriteIntValue("sentSignalLevel", SentSignalLevel);
            writer.WriteFloatValue("speakerGlitchRate", SpeakerGlitchRate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class TopicModelingSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether the themes model should dynamically optimize the number of generated topics. To learn more, see Adjust maximum number of themes dynamically.</summary>
        public bool? DynamicallyAdjustTopicCount {
            get { return BackingStore?.Get<bool?>("dynamicallyAdjustTopicCount"); }
            set { BackingStore?.Set("dynamicallyAdjustTopicCount", value); }
        }
        /// <summary>Indicates whether the themes model should exclude numbers while parsing document texts. To learn more, see Include numbers in themes.</summary>
        public bool? IgnoreNumbers {
            get { return BackingStore?.Get<bool?>("ignoreNumbers"); }
            set { BackingStore?.Set("ignoreNumbers", value); }
        }
        /// <summary>Indicates whether themes model is enabled for the case.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
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
        /// <summary>The total number of topics that the themes model will generate for a review set. To learn more, see Maximum number of themes.</summary>
        public int? TopicCount {
            get { return BackingStore?.Get<int?>("topicCount"); }
            set { BackingStore?.Set("topicCount", value); }
        }
        /// <summary>
        /// Instantiates a new topicModelingSettings and sets the default values.
        /// </summary>
        public TopicModelingSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TopicModelingSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TopicModelingSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dynamicallyAdjustTopicCount", n => { DynamicallyAdjustTopicCount = n.GetBoolValue(); } },
                {"ignoreNumbers", n => { IgnoreNumbers = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"topicCount", n => { TopicCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("dynamicallyAdjustTopicCount", DynamicallyAdjustTopicCount);
            writer.WriteBoolValue("ignoreNumbers", IgnoreNumbers);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("topicCount", TopicCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

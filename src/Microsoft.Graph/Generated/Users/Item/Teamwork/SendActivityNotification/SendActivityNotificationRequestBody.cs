using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Users.Item.Teamwork.SendActivityNotification {
    /// <summary>Provides operations to call the sendActivityNotification method.</summary>
    public class SendActivityNotificationRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The activityType property</summary>
        public string ActivityType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The chainId property</summary>
        public long? ChainId { get; set; }
        /// <summary>The previewText property</summary>
        public ItemBody PreviewText { get; set; }
        /// <summary>The templateParameters property</summary>
        public List<Microsoft.Graph.Models.KeyValuePair> TemplateParameters { get; set; }
        /// <summary>The topic property</summary>
        public TeamworkActivityTopic Topic { get; set; }
        /// <summary>
        /// Instantiates a new sendActivityNotificationRequestBody and sets the default values.
        /// </summary>
        public SendActivityNotificationRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SendActivityNotificationRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendActivityNotificationRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"activityType", (o,n) => { (o as SendActivityNotificationRequestBody).ActivityType = n.GetStringValue(); } },
                {"chainId", (o,n) => { (o as SendActivityNotificationRequestBody).ChainId = n.GetLongValue(); } },
                {"previewText", (o,n) => { (o as SendActivityNotificationRequestBody).PreviewText = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"templateParameters", (o,n) => { (o as SendActivityNotificationRequestBody).TemplateParameters = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.KeyValuePair>(Microsoft.Graph.Models.KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"topic", (o,n) => { (o as SendActivityNotificationRequestBody).Topic = n.GetObjectValue<TeamworkActivityTopic>(TeamworkActivityTopic.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteLongValue("chainId", ChainId);
            writer.WriteObjectValue<ItemBody>("previewText", PreviewText);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.KeyValuePair>("templateParameters", TemplateParameters);
            writer.WriteObjectValue<TeamworkActivityTopic>("topic", Topic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
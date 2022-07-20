using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ChannelUnsetAsFavoriteByDefaultEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Unique identifier of the channel.</summary>
        public string ChannelId {
            get { return BackingStore?.Get<string>("channelId"); }
            set { BackingStore?.Set("channelId", value); }
        }
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
        /// <summary>
        /// Instantiates a new ChannelUnsetAsFavoriteByDefaultEventMessageDetail and sets the default values.
        /// </summary>
        public ChannelUnsetAsFavoriteByDefaultEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.channelUnsetAsFavoriteByDefaultEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ChannelUnsetAsFavoriteByDefaultEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChannelUnsetAsFavoriteByDefaultEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"channelId", n => { ChannelId = n.GetStringValue(); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("channelId", ChannelId);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}
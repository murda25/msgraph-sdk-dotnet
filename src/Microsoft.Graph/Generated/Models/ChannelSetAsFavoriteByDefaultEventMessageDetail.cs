// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ChannelSetAsFavoriteByDefaultEventMessageDetail : EventMessageDetail, IParsable 
    {
        /// <summary>Unique identifier of the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChannelId {
            get { return BackingStore?.Get<string?>("channelId"); }
            set { BackingStore?.Set("channelId", value); }
        }
#nullable restore
#else
        public string ChannelId {
            get { return BackingStore?.Get<string>("channelId"); }
            set { BackingStore?.Set("channelId", value); }
        }
#endif
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Initiator {
            get { return BackingStore?.Get<IdentitySet?>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#nullable restore
#else
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ChannelSetAsFavoriteByDefaultEventMessageDetail"/> and sets the default values.
        /// </summary>
        public ChannelSetAsFavoriteByDefaultEventMessageDetail() : base()
        {
            OdataType = "#microsoft.graph.channelSetAsFavoriteByDefaultEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ChannelSetAsFavoriteByDefaultEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ChannelSetAsFavoriteByDefaultEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChannelSetAsFavoriteByDefaultEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"channelId", n => { ChannelId = n.GetStringValue(); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("channelId", ChannelId);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}

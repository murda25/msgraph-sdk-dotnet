using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ChatRenamedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>The updated name of the chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChatDisplayName {
            get { return BackingStore?.Get<string?>("chatDisplayName"); }
            set { BackingStore?.Set("chatDisplayName", value); }
        }
#nullable restore
#else
        public string ChatDisplayName {
            get { return BackingStore?.Get<string>("chatDisplayName"); }
            set { BackingStore?.Set("chatDisplayName", value); }
        }
#endif
        /// <summary>Unique identifier of the chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChatId {
            get { return BackingStore?.Get<string?>("chatId"); }
            set { BackingStore?.Set("chatId", value); }
        }
#nullable restore
#else
        public string ChatId {
            get { return BackingStore?.Get<string>("chatId"); }
            set { BackingStore?.Set("chatId", value); }
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
        /// Instantiates a new ChatRenamedEventMessageDetail and sets the default values.
        /// </summary>
        public ChatRenamedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.chatRenamedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ChatRenamedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatRenamedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"chatDisplayName", n => { ChatDisplayName = n.GetStringValue(); } },
                {"chatId", n => { ChatId = n.GetStringValue(); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("chatDisplayName", ChatDisplayName);
            writer.WriteStringValue("chatId", ChatId);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}

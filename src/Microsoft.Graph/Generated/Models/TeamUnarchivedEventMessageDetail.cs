using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class TeamUnarchivedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
        /// <summary>Unique identifier of the team.</summary>
        public string TeamId {
            get { return BackingStore?.Get<string>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
        /// <summary>
        /// Instantiates a new TeamUnarchivedEventMessageDetail and sets the default values.
        /// </summary>
        public TeamUnarchivedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.teamUnarchivedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamUnarchivedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamUnarchivedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"teamId", n => { TeamId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteStringValue("teamId", TeamId);
        }
    }
}
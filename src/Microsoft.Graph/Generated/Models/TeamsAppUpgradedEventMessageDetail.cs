// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class TeamsAppUpgradedEventMessageDetail : EventMessageDetail, IParsable 
    {
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
        /// <summary>Display name of the teamsApp.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsAppDisplayName {
            get { return BackingStore?.Get<string?>("teamsAppDisplayName"); }
            set { BackingStore?.Set("teamsAppDisplayName", value); }
        }
#nullable restore
#else
        public string TeamsAppDisplayName {
            get { return BackingStore?.Get<string>("teamsAppDisplayName"); }
            set { BackingStore?.Set("teamsAppDisplayName", value); }
        }
#endif
        /// <summary>Unique identifier of the teamsApp.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsAppId {
            get { return BackingStore?.Get<string?>("teamsAppId"); }
            set { BackingStore?.Set("teamsAppId", value); }
        }
#nullable restore
#else
        public string TeamsAppId {
            get { return BackingStore?.Get<string>("teamsAppId"); }
            set { BackingStore?.Set("teamsAppId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamsAppUpgradedEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamsAppUpgradedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAppUpgradedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"teamsAppDisplayName", n => { TeamsAppDisplayName = n.GetStringValue(); } },
                {"teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteStringValue("teamsAppDisplayName", TeamsAppDisplayName);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
        }
    }
}

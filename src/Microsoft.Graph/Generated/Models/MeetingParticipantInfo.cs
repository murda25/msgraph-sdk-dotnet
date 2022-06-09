using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class MeetingParticipantInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Identity information of the participant.</summary>
        public IdentitySet Identity {
            get { return BackingStore?.Get<IdentitySet>(nameof(Identity)); }
            set { BackingStore?.Set(nameof(Identity), value); }
        }
        /// <summary>Specifies the participant&apos;s role in the meeting.</summary>
        public OnlineMeetingRole? Role {
            get { return BackingStore?.Get<OnlineMeetingRole?>(nameof(Role)); }
            set { BackingStore?.Set(nameof(Role), value); }
        }
        /// <summary>User principal name of the participant.</summary>
        public string Upn {
            get { return BackingStore?.Get<string>(nameof(Upn)); }
            set { BackingStore?.Set(nameof(Upn), value); }
        }
        /// <summary>
        /// Instantiates a new meetingParticipantInfo and sets the default values.
        /// </summary>
        public MeetingParticipantInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MeetingParticipantInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingParticipantInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"identity", n => { Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"role", n => { Role = n.GetEnumValue<OnlineMeetingRole>(); } },
                {"upn", n => { Upn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteEnumValue<OnlineMeetingRole>("role", Role);
            writer.WriteStringValue("upn", Upn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Root.Checkin {
    /// <summary>Provides operations to call the checkin method.</summary>
    public class CheckinPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The checkInAs property</summary>
        public string CheckInAs {
            get { return BackingStore?.Get<string>(nameof(CheckInAs)); }
            set { BackingStore?.Set(nameof(CheckInAs), value); }
        }
        /// <summary>The comment property</summary>
        public string Comment {
            get { return BackingStore?.Get<string>(nameof(Comment)); }
            set { BackingStore?.Set(nameof(Comment), value); }
        }
        /// <summary>
        /// Instantiates a new checkinPostRequestBody and sets the default values.
        /// </summary>
        public CheckinPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CheckinPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CheckinPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"checkInAs", n => { CheckInAs = n.GetStringValue(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("checkInAs", CheckInAs);
            writer.WriteStringValue("comment", Comment);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
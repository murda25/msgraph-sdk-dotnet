using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class ProfilePhoto : Entity, IParsable {
        /// <summary>The height of the photo. Read-only.</summary>
        public int? Height {
            get { return BackingStore?.Get<int?>(nameof(Height)); }
            set { BackingStore?.Set(nameof(Height), value); }
        }
        /// <summary>The width of the photo. Read-only.</summary>
        public int? Width {
            get { return BackingStore?.Get<int?>(nameof(Width)); }
            set { BackingStore?.Set(nameof(Width), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProfilePhoto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProfilePhoto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"height", n => { Height = n.GetIntValue(); } },
                {"width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("height", Height);
            writer.WriteIntValue("width", Width);
        }
    }
}
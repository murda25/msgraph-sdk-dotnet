using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Identity : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identity&apos;s display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won&apos;t show up as having changed when using delta.</summary>
        public string DisplayName { get; set; }
        /// <summary>Unique identifier for the identity.</summary>
        public string Id { get; set; }
        /// <summary>
        /// Instantiates a new identity and sets the default values.
        /// </summary>
        public Identity() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Identity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Identity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as Identity).DisplayName = n.GetStringValue(); } },
                {"id", (o,n) => { (o as Identity).Id = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
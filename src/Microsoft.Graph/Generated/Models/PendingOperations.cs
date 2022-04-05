using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class PendingOperations : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A property that indicates that an operation that might update the binary content of a file is pending completion.</summary>
        public Microsoft.Graph.Models.PendingContentUpdate PendingContentUpdate { get; set; }
        /// <summary>
        /// Instantiates a new pendingOperations and sets the default values.
        /// </summary>
        public PendingOperations() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PendingOperations CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PendingOperations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"pendingContentUpdate", (o,n) => { (o as PendingOperations).PendingContentUpdate = n.GetObjectValue<Microsoft.Graph.Models.PendingContentUpdate>(Microsoft.Graph.Models.PendingContentUpdate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.PendingContentUpdate>("pendingContentUpdate", PendingContentUpdate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
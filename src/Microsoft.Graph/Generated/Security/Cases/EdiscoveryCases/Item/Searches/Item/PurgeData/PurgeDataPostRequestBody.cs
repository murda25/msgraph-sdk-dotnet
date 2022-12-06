using Microsoft.Graph.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.PurgeData {
    /// <summary>Provides operations to call the purgeData method.</summary>
    public class PurgeDataPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The purgeAreas property</summary>
        public Microsoft.Graph.Models.Security.PurgeAreas? PurgeAreas {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.PurgeAreas?>("purgeAreas"); }
            set { BackingStore?.Set("purgeAreas", value); }
        }
        /// <summary>The purgeType property</summary>
        public Microsoft.Graph.Models.Security.PurgeType? PurgeType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.PurgeType?>("purgeType"); }
            set { BackingStore?.Set("purgeType", value); }
        }
        /// <summary>
        /// Instantiates a new purgeDataPostRequestBody and sets the default values.
        /// </summary>
        public PurgeDataPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PurgeDataPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PurgeDataPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"purgeAreas", n => { PurgeAreas = n.GetEnumValue<PurgeAreas>(); } },
                {"purgeType", n => { PurgeType = n.GetEnumValue<PurgeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PurgeAreas>("purgeAreas", PurgeAreas);
            writer.WriteEnumValue<PurgeType>("purgeType", PurgeType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
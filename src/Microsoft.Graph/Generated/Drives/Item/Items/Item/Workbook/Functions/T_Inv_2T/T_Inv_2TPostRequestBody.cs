// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.T_Inv_2T {
    public class T_Inv_2TPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The degFreedom property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? DegFreedom {
            get { return BackingStore?.Get<Json?>("degFreedom"); }
            set { BackingStore?.Set("degFreedom", value); }
        }
#nullable restore
#else
        public Json DegFreedom {
            get { return BackingStore?.Get<Json>("degFreedom"); }
            set { BackingStore?.Set("degFreedom", value); }
        }
#endif
        /// <summary>The probability property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Probability {
            get { return BackingStore?.Get<Json?>("probability"); }
            set { BackingStore?.Set("probability", value); }
        }
#nullable restore
#else
        public Json Probability {
            get { return BackingStore?.Get<Json>("probability"); }
            set { BackingStore?.Set("probability", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new t_Inv_2TPostRequestBody and sets the default values.
        /// </summary>
        public T_Inv_2TPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static T_Inv_2TPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new T_Inv_2TPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"degFreedom", n => { DegFreedom = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"probability", n => { Probability = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("degFreedom", DegFreedom);
            writer.WriteObjectValue<Json>("probability", Probability);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

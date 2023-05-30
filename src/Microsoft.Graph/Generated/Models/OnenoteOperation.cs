using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class OnenoteOperation : Operation, IParsable {
        /// <summary>The error returned by the operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnenoteOperationError? Error {
            get { return BackingStore?.Get<OnenoteOperationError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public OnenoteOperationError Error {
            get { return BackingStore?.Get<OnenoteOperationError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>The operation percent complete if the operation is still in running status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PercentComplete {
            get { return BackingStore?.Get<string?>("percentComplete"); }
            set { BackingStore?.Set("percentComplete", value); }
        }
#nullable restore
#else
        public string PercentComplete {
            get { return BackingStore?.Get<string>("percentComplete"); }
            set { BackingStore?.Set("percentComplete", value); }
        }
#endif
        /// <summary>The resource id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId {
            get { return BackingStore?.Get<string?>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#nullable restore
#else
        public string ResourceId {
            get { return BackingStore?.Get<string>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#endif
        /// <summary>The resource URI for the object. For example, the resource URI for a copied page or section.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceLocation {
            get { return BackingStore?.Get<string?>("resourceLocation"); }
            set { BackingStore?.Set("resourceLocation", value); }
        }
#nullable restore
#else
        public string ResourceLocation {
            get { return BackingStore?.Get<string>("resourceLocation"); }
            set { BackingStore?.Set("resourceLocation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnenoteOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnenoteOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"error", n => { Error = n.GetObjectValue<OnenoteOperationError>(OnenoteOperationError.CreateFromDiscriminatorValue); } },
                {"percentComplete", n => { PercentComplete = n.GetStringValue(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"resourceLocation", n => { ResourceLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnenoteOperationError>("error", Error);
            writer.WriteStringValue("percentComplete", PercentComplete);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("resourceLocation", ResourceLocation);
        }
    }
}

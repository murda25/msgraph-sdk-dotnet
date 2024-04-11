// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class StandardWebPart : WebPart, IParsable 
    {
        /// <summary>The containerTextWebPartId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerTextWebPartId {
            get { return BackingStore?.Get<string?>("containerTextWebPartId"); }
            set { BackingStore?.Set("containerTextWebPartId", value); }
        }
#nullable restore
#else
        public string ContainerTextWebPartId {
            get { return BackingStore?.Get<string>("containerTextWebPartId"); }
            set { BackingStore?.Set("containerTextWebPartId", value); }
        }
#endif
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WebPartData? Data {
            get { return BackingStore?.Get<WebPartData?>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#nullable restore
#else
        public WebPartData Data {
            get { return BackingStore?.Get<WebPartData>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#endif
        /// <summary>The webPartType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebPartType {
            get { return BackingStore?.Get<string?>("webPartType"); }
            set { BackingStore?.Set("webPartType", value); }
        }
#nullable restore
#else
        public string WebPartType {
            get { return BackingStore?.Get<string>("webPartType"); }
            set { BackingStore?.Set("webPartType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="StandardWebPart"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new StandardWebPart CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StandardWebPart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"containerTextWebPartId", n => { ContainerTextWebPartId = n.GetStringValue(); } },
                {"data", n => { Data = n.GetObjectValue<WebPartData>(WebPartData.CreateFromDiscriminatorValue); } },
                {"webPartType", n => { WebPartType = n.GetStringValue(); } },
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
            writer.WriteStringValue("containerTextWebPartId", ContainerTextWebPartId);
            writer.WriteObjectValue<WebPartData>("data", Data);
            writer.WriteStringValue("webPartType", WebPartType);
        }
    }
}

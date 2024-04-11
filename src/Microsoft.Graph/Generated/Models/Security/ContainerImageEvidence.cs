// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class ContainerImageEvidence : AlertEvidence, IParsable 
    {
        /// <summary>The digest image entity, in case this is a tag image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContainerImageEvidence? DigestImage {
            get { return BackingStore?.Get<ContainerImageEvidence?>("digestImage"); }
            set { BackingStore?.Set("digestImage", value); }
        }
#nullable restore
#else
        public ContainerImageEvidence DigestImage {
            get { return BackingStore?.Get<ContainerImageEvidence>("digestImage"); }
            set { BackingStore?.Set("digestImage", value); }
        }
#endif
        /// <summary>The unique identifier for the container image entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageId {
            get { return BackingStore?.Get<string?>("imageId"); }
            set { BackingStore?.Set("imageId", value); }
        }
#nullable restore
#else
        public string ImageId {
            get { return BackingStore?.Get<string>("imageId"); }
            set { BackingStore?.Set("imageId", value); }
        }
#endif
        /// <summary>The container registry for this image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContainerRegistryEvidence? Registry {
            get { return BackingStore?.Get<ContainerRegistryEvidence?>("registry"); }
            set { BackingStore?.Set("registry", value); }
        }
#nullable restore
#else
        public ContainerRegistryEvidence Registry {
            get { return BackingStore?.Get<ContainerRegistryEvidence>("registry"); }
            set { BackingStore?.Set("registry", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ContainerImageEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ContainerImageEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContainerImageEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"digestImage", n => { DigestImage = n.GetObjectValue<ContainerImageEvidence>(ContainerImageEvidence.CreateFromDiscriminatorValue); } },
                {"imageId", n => { ImageId = n.GetStringValue(); } },
                {"registry", n => { Registry = n.GetObjectValue<ContainerRegistryEvidence>(ContainerRegistryEvidence.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ContainerImageEvidence>("digestImage", DigestImage);
            writer.WriteStringValue("imageId", ImageId);
            writer.WriteObjectValue<ContainerRegistryEvidence>("registry", Registry);
        }
    }
}

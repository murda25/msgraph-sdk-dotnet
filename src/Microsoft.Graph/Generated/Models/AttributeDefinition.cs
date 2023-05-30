using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AttributeDefinition : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The anchor property</summary>
        public bool? Anchor {
            get { return BackingStore?.Get<bool?>("anchor"); }
            set { BackingStore?.Set("anchor", value); }
        }
        /// <summary>The apiExpressions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<StringKeyStringValuePair>? ApiExpressions {
            get { return BackingStore?.Get<List<StringKeyStringValuePair>?>("apiExpressions"); }
            set { BackingStore?.Set("apiExpressions", value); }
        }
#nullable restore
#else
        public List<StringKeyStringValuePair> ApiExpressions {
            get { return BackingStore?.Get<List<StringKeyStringValuePair>>("apiExpressions"); }
            set { BackingStore?.Set("apiExpressions", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The caseExact property</summary>
        public bool? CaseExact {
            get { return BackingStore?.Get<bool?>("caseExact"); }
            set { BackingStore?.Set("caseExact", value); }
        }
        /// <summary>The defaultValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultValue {
            get { return BackingStore?.Get<string?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#nullable restore
#else
        public string DefaultValue {
            get { return BackingStore?.Get<string>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#endif
        /// <summary>The flowNullValues property</summary>
        public bool? FlowNullValues {
            get { return BackingStore?.Get<bool?>("flowNullValues"); }
            set { BackingStore?.Set("flowNullValues", value); }
        }
        /// <summary>The metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttributeDefinitionMetadataEntry>? Metadata {
            get { return BackingStore?.Get<List<AttributeDefinitionMetadataEntry>?>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#nullable restore
#else
        public List<AttributeDefinitionMetadataEntry> Metadata {
            get { return BackingStore?.Get<List<AttributeDefinitionMetadataEntry>>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#endif
        /// <summary>The multivalued property</summary>
        public bool? Multivalued {
            get { return BackingStore?.Get<bool?>("multivalued"); }
            set { BackingStore?.Set("multivalued", value); }
        }
        /// <summary>The mutability property</summary>
        public Microsoft.Graph.Models.Mutability? Mutability {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Mutability?>("mutability"); }
            set { BackingStore?.Set("mutability", value); }
        }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The referencedObjects property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ReferencedObject>? ReferencedObjects {
            get { return BackingStore?.Get<List<ReferencedObject>?>("referencedObjects"); }
            set { BackingStore?.Set("referencedObjects", value); }
        }
#nullable restore
#else
        public List<ReferencedObject> ReferencedObjects {
            get { return BackingStore?.Get<List<ReferencedObject>>("referencedObjects"); }
            set { BackingStore?.Set("referencedObjects", value); }
        }
#endif
        /// <summary>The required property</summary>
        public bool? Required {
            get { return BackingStore?.Get<bool?>("required"); }
            set { BackingStore?.Set("required", value); }
        }
        /// <summary>The type property</summary>
        public AttributeType? Type {
            get { return BackingStore?.Get<AttributeType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new attributeDefinition and sets the default values.
        /// </summary>
        public AttributeDefinition() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttributeDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttributeDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"anchor", n => { Anchor = n.GetBoolValue(); } },
                {"apiExpressions", n => { ApiExpressions = n.GetCollectionOfObjectValues<StringKeyStringValuePair>(StringKeyStringValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"caseExact", n => { CaseExact = n.GetBoolValue(); } },
                {"defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                {"flowNullValues", n => { FlowNullValues = n.GetBoolValue(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<AttributeDefinitionMetadataEntry>(AttributeDefinitionMetadataEntry.CreateFromDiscriminatorValue)?.ToList(); } },
                {"multivalued", n => { Multivalued = n.GetBoolValue(); } },
                {"mutability", n => { Mutability = n.GetEnumValue<Mutability>(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"referencedObjects", n => { ReferencedObjects = n.GetCollectionOfObjectValues<ReferencedObject>(ReferencedObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
                {"type", n => { Type = n.GetEnumValue<AttributeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("anchor", Anchor);
            writer.WriteCollectionOfObjectValues<StringKeyStringValuePair>("apiExpressions", ApiExpressions);
            writer.WriteBoolValue("caseExact", CaseExact);
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteBoolValue("flowNullValues", FlowNullValues);
            writer.WriteCollectionOfObjectValues<AttributeDefinitionMetadataEntry>("metadata", Metadata);
            writer.WriteBoolValue("multivalued", Multivalued);
            writer.WriteEnumValue<Mutability>("mutability", Mutability);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<ReferencedObject>("referencedObjects", ReferencedObjects);
            writer.WriteBoolValue("required", Required);
            writer.WriteEnumValue<AttributeType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

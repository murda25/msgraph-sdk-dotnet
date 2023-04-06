using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// The history for the site modifications
    /// </summary>
    public class BrowserSiteHistory : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Boolean attribute that controls the behavior of redirected sites</summary>
        public bool? AllowRedirect {
            get { return BackingStore?.Get<bool?>("allowRedirect"); }
            set { BackingStore?.Set("allowRedirect", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The content for the site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment {
            get { return BackingStore?.Get<string?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public string Comment {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>Controls what compatibility setting is used for specific sites or domains</summary>
        public BrowserSiteCompatibilityMode? CompatibilityMode {
            get { return BackingStore?.Get<BrowserSiteCompatibilityMode?>("compatibilityMode"); }
            set { BackingStore?.Set("compatibilityMode", value); }
        }
        /// <summary>The user who modified the site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The merge type of the site</summary>
        public BrowserSiteMergeType? MergeType {
            get { return BackingStore?.Get<BrowserSiteMergeType?>("mergeType"); }
            set { BackingStore?.Set("mergeType", value); }
        }
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
        /// <summary>The time the site was last published</summary>
        public DateTimeOffset? PublishedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("publishedDateTime"); }
            set { BackingStore?.Set("publishedDateTime", value); }
        }
        /// <summary>The render mode in Edge client that the site is supposed to open in</summary>
        public BrowserSiteTargetEnvironment? TargetEnvironment {
            get { return BackingStore?.Get<BrowserSiteTargetEnvironment?>("targetEnvironment"); }
            set { BackingStore?.Set("targetEnvironment", value); }
        }
        /// <summary>
        /// Instantiates a new browserSiteHistory and sets the default values.
        /// </summary>
        public BrowserSiteHistory() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BrowserSiteHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BrowserSiteHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowRedirect", n => { AllowRedirect = n.GetBoolValue(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"compatibilityMode", n => { CompatibilityMode = n.GetEnumValue<BrowserSiteCompatibilityMode>(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"mergeType", n => { MergeType = n.GetEnumValue<BrowserSiteMergeType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"publishedDateTime", n => { PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                {"targetEnvironment", n => { TargetEnvironment = n.GetEnumValue<BrowserSiteTargetEnvironment>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowRedirect", AllowRedirect);
            writer.WriteStringValue("comment", Comment);
            writer.WriteEnumValue<BrowserSiteCompatibilityMode>("compatibilityMode", CompatibilityMode);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteEnumValue<BrowserSiteMergeType>("mergeType", MergeType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteEnumValue<BrowserSiteTargetEnvironment>("targetEnvironment", TargetEnvironment);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

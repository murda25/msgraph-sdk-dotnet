// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SharingLink : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>The app the link is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Application {
            get { return BackingStore?.Get<Identity?>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#nullable restore
#else
        public Identity Application {
            get { return BackingStore?.Get<Identity>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>If true then the user can only use this link to view the item on the web, and cannot use it to download the contents of the item. Only for OneDrive for Business and SharePoint.</summary>
        public bool? PreventsDownload {
            get { return BackingStore?.Get<bool?>("preventsDownload"); }
            set { BackingStore?.Set("preventsDownload", value); }
        }
        /// <summary>The scope of the link represented by this permission. Value anonymous indicates the link is usable by anyone, organization indicates the link is only usable for users signed into the same tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scope {
            get { return BackingStore?.Get<string?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#nullable restore
#else
        public string Scope {
            get { return BackingStore?.Get<string>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>The type of the link created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>For embed links, this property contains the HTML code for an &lt;iframe&gt; element that will embed the item in a webpage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebHtml {
            get { return BackingStore?.Get<string?>("webHtml"); }
            set { BackingStore?.Set("webHtml", value); }
        }
#nullable restore
#else
        public string WebHtml {
            get { return BackingStore?.Get<string>("webHtml"); }
            set { BackingStore?.Set("webHtml", value); }
        }
#endif
        /// <summary>A URL that opens the item in the browser on the OneDrive website.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SharingLink"/> and sets the default values.
        /// </summary>
        public SharingLink()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SharingLink"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SharingLink CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharingLink();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"application", n => { Application = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"preventsDownload", n => { PreventsDownload = n.GetBoolValue(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"webHtml", n => { WebHtml = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Identity>("application", Application);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("preventsDownload", PreventsDownload);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("webHtml", WebHtml);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

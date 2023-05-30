using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class OnenoteSection : OnenoteEntityHierarchyModel, IParsable {
        /// <summary>Indicates whether this is the user&apos;s default section. Read-only.</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>Links for opening the section. The oneNoteClientURL link opens the section in the OneNote native client if it&apos;s installed. The oneNoteWebURL link opens the section in OneNote on the web.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SectionLinks? Links {
            get { return BackingStore?.Get<SectionLinks?>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#nullable restore
#else
        public SectionLinks Links {
            get { return BackingStore?.Get<SectionLinks>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#endif
        /// <summary>The collection of pages in the section.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenotePage>? Pages {
            get { return BackingStore?.Get<List<OnenotePage>?>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#nullable restore
#else
        public List<OnenotePage> Pages {
            get { return BackingStore?.Get<List<OnenotePage>>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#endif
        /// <summary>The pages endpoint where you can get details for all the pages in the section. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PagesUrl {
            get { return BackingStore?.Get<string?>("pagesUrl"); }
            set { BackingStore?.Set("pagesUrl", value); }
        }
#nullable restore
#else
        public string PagesUrl {
            get { return BackingStore?.Get<string>("pagesUrl"); }
            set { BackingStore?.Set("pagesUrl", value); }
        }
#endif
        /// <summary>The notebook that contains the section.  Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Notebook? ParentNotebook {
            get { return BackingStore?.Get<Notebook?>("parentNotebook"); }
            set { BackingStore?.Set("parentNotebook", value); }
        }
#nullable restore
#else
        public Notebook ParentNotebook {
            get { return BackingStore?.Get<Notebook>("parentNotebook"); }
            set { BackingStore?.Set("parentNotebook", value); }
        }
#endif
        /// <summary>The section group that contains the section.  Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SectionGroup? ParentSectionGroup {
            get { return BackingStore?.Get<SectionGroup?>("parentSectionGroup"); }
            set { BackingStore?.Set("parentSectionGroup", value); }
        }
#nullable restore
#else
        public SectionGroup ParentSectionGroup {
            get { return BackingStore?.Get<SectionGroup>("parentSectionGroup"); }
            set { BackingStore?.Set("parentSectionGroup", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new onenoteSection and sets the default values.
        /// </summary>
        public OnenoteSection() : base() {
            OdataType = "#microsoft.graph.onenoteSection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnenoteSection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnenoteSection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"links", n => { Links = n.GetObjectValue<SectionLinks>(SectionLinks.CreateFromDiscriminatorValue); } },
                {"pages", n => { Pages = n.GetCollectionOfObjectValues<OnenotePage>(OnenotePage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pagesUrl", n => { PagesUrl = n.GetStringValue(); } },
                {"parentNotebook", n => { ParentNotebook = n.GetObjectValue<Notebook>(Notebook.CreateFromDiscriminatorValue); } },
                {"parentSectionGroup", n => { ParentSectionGroup = n.GetObjectValue<SectionGroup>(SectionGroup.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteObjectValue<SectionLinks>("links", Links);
            writer.WriteCollectionOfObjectValues<OnenotePage>("pages", Pages);
            writer.WriteStringValue("pagesUrl", PagesUrl);
            writer.WriteObjectValue<Notebook>("parentNotebook", ParentNotebook);
            writer.WriteObjectValue<SectionGroup>("parentSectionGroup", ParentSectionGroup);
        }
    }
}

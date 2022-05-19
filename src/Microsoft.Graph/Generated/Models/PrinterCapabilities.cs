using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class PrinterCapabilities : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A list of supported bottom margins(in microns) for the printer.</summary>
        public List<int?> BottomMargins {
            get { return BackingStore?.Get<List<int?>>(nameof(BottomMargins)); }
            set { BackingStore?.Set(nameof(BottomMargins), value); }
        }
        /// <summary>True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.</summary>
        public bool? Collation {
            get { return BackingStore?.Get<bool?>(nameof(Collation)); }
            set { BackingStore?.Set(nameof(Collation), value); }
        }
        /// <summary>The color modes supported by the printer. Valid values are described in the following table.</summary>
        public List<string> ColorModes {
            get { return BackingStore?.Get<List<string>>(nameof(ColorModes)); }
            set { BackingStore?.Set(nameof(ColorModes), value); }
        }
        /// <summary>A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.</summary>
        public List<string> ContentTypes {
            get { return BackingStore?.Get<List<string>>(nameof(ContentTypes)); }
            set { BackingStore?.Set(nameof(ContentTypes), value); }
        }
        /// <summary>The range of copies per job supported by the printer.</summary>
        public IntegerRange CopiesPerJob {
            get { return BackingStore?.Get<IntegerRange>(nameof(CopiesPerJob)); }
            set { BackingStore?.Set(nameof(CopiesPerJob), value); }
        }
        /// <summary>The list of print resolutions in DPI that are supported by the printer.</summary>
        public List<int?> Dpis {
            get { return BackingStore?.Get<List<int?>>(nameof(Dpis)); }
            set { BackingStore?.Set(nameof(Dpis), value); }
        }
        /// <summary>The list of duplex modes that are supported by the printer. Valid values are described in the following table.</summary>
        public List<string> DuplexModes {
            get { return BackingStore?.Get<List<string>>(nameof(DuplexModes)); }
            set { BackingStore?.Set(nameof(DuplexModes), value); }
        }
        /// <summary>The list of feed orientations that are supported by the printer.</summary>
        public List<string> FeedOrientations {
            get { return BackingStore?.Get<List<string>>(nameof(FeedOrientations)); }
            set { BackingStore?.Set(nameof(FeedOrientations), value); }
        }
        /// <summary>Finishing processes the printer supports for a printed document.</summary>
        public List<string> Finishings {
            get { return BackingStore?.Get<List<string>>(nameof(Finishings)); }
            set { BackingStore?.Set(nameof(Finishings), value); }
        }
        /// <summary>Supported input bins for the printer.</summary>
        public List<string> InputBins {
            get { return BackingStore?.Get<List<string>>(nameof(InputBins)); }
            set { BackingStore?.Set(nameof(InputBins), value); }
        }
        /// <summary>True if color printing is supported by the printer; false otherwise. Read-only.</summary>
        public bool? IsColorPrintingSupported {
            get { return BackingStore?.Get<bool?>(nameof(IsColorPrintingSupported)); }
            set { BackingStore?.Set(nameof(IsColorPrintingSupported), value); }
        }
        /// <summary>True if the printer supports printing by page ranges; false otherwise.</summary>
        public bool? IsPageRangeSupported {
            get { return BackingStore?.Get<bool?>(nameof(IsPageRangeSupported)); }
            set { BackingStore?.Set(nameof(IsPageRangeSupported), value); }
        }
        /// <summary>A list of supported left margins(in microns) for the printer.</summary>
        public List<int?> LeftMargins {
            get { return BackingStore?.Get<List<int?>>(nameof(LeftMargins)); }
            set { BackingStore?.Set(nameof(LeftMargins), value); }
        }
        /// <summary>The media (i.e., paper) colors supported by the printer.</summary>
        public List<string> MediaColors {
            get { return BackingStore?.Get<List<string>>(nameof(MediaColors)); }
            set { BackingStore?.Set(nameof(MediaColors), value); }
        }
        /// <summary>The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes. Valid values are in the following table.</summary>
        public List<string> MediaSizes {
            get { return BackingStore?.Get<List<string>>(nameof(MediaSizes)); }
            set { BackingStore?.Set(nameof(MediaSizes), value); }
        }
        /// <summary>The media types supported by the printer.</summary>
        public List<string> MediaTypes {
            get { return BackingStore?.Get<List<string>>(nameof(MediaTypes)); }
            set { BackingStore?.Set(nameof(MediaTypes), value); }
        }
        /// <summary>The presentation directions supported by the printer. Supported values are described in the following table.</summary>
        public List<string> MultipageLayouts {
            get { return BackingStore?.Get<List<string>>(nameof(MultipageLayouts)); }
            set { BackingStore?.Set(nameof(MultipageLayouts), value); }
        }
        /// <summary>The print orientations supported by the printer. Valid values are described in the following table.</summary>
        public List<string> Orientations {
            get { return BackingStore?.Get<List<string>>(nameof(Orientations)); }
            set { BackingStore?.Set(nameof(Orientations), value); }
        }
        /// <summary>The printer&apos;s supported output bins (trays).</summary>
        public List<string> OutputBins {
            get { return BackingStore?.Get<List<string>>(nameof(OutputBins)); }
            set { BackingStore?.Set(nameof(OutputBins), value); }
        }
        /// <summary>Supported number of Input Pages to impose upon a single Impression.</summary>
        public List<int?> PagesPerSheet {
            get { return BackingStore?.Get<List<int?>>(nameof(PagesPerSheet)); }
            set { BackingStore?.Set(nameof(PagesPerSheet), value); }
        }
        /// <summary>The print qualities supported by the printer.</summary>
        public List<string> Qualities {
            get { return BackingStore?.Get<List<string>>(nameof(Qualities)); }
            set { BackingStore?.Set(nameof(Qualities), value); }
        }
        /// <summary>A list of supported right margins(in microns) for the printer.</summary>
        public List<int?> RightMargins {
            get { return BackingStore?.Get<List<int?>>(nameof(RightMargins)); }
            set { BackingStore?.Set(nameof(RightMargins), value); }
        }
        /// <summary>Supported print scalings.</summary>
        public List<string> Scalings {
            get { return BackingStore?.Get<List<string>>(nameof(Scalings)); }
            set { BackingStore?.Set(nameof(Scalings), value); }
        }
        /// <summary>True if the printer supports scaling PDF pages to match the print media size; false otherwise.</summary>
        public bool? SupportsFitPdfToPage {
            get { return BackingStore?.Get<bool?>(nameof(SupportsFitPdfToPage)); }
            set { BackingStore?.Set(nameof(SupportsFitPdfToPage), value); }
        }
        /// <summary>A list of supported top margins(in microns) for the printer.</summary>
        public List<int?> TopMargins {
            get { return BackingStore?.Get<List<int?>>(nameof(TopMargins)); }
            set { BackingStore?.Set(nameof(TopMargins), value); }
        }
        /// <summary>
        /// Instantiates a new printerCapabilities and sets the default values.
        /// </summary>
        public PrinterCapabilities() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrinterCapabilities CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bottomMargins", n => { BottomMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"collation", n => { Collation = n.GetBoolValue(); } },
                {"colorModes", n => { ColorModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"copiesPerJob", n => { CopiesPerJob = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"dpis", n => { Dpis = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"duplexModes", n => { DuplexModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"feedOrientations", n => { FeedOrientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"finishings", n => { Finishings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"inputBins", n => { InputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isColorPrintingSupported", n => { IsColorPrintingSupported = n.GetBoolValue(); } },
                {"isPageRangeSupported", n => { IsPageRangeSupported = n.GetBoolValue(); } },
                {"leftMargins", n => { LeftMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"mediaColors", n => { MediaColors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaSizes", n => { MediaSizes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaTypes", n => { MediaTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"multipageLayouts", n => { MultipageLayouts = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"orientations", n => { Orientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"outputBins", n => { OutputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"pagesPerSheet", n => { PagesPerSheet = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"qualities", n => { Qualities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"rightMargins", n => { RightMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"scalings", n => { Scalings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportsFitPdfToPage", n => { SupportsFitPdfToPage = n.GetBoolValue(); } },
                {"topMargins", n => { TopMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("bottomMargins", BottomMargins);
            writer.WriteBoolValue("collation", Collation);
            writer.WriteCollectionOfPrimitiveValues<string>("colorModes", ColorModes);
            writer.WriteCollectionOfPrimitiveValues<string>("contentTypes", ContentTypes);
            writer.WriteObjectValue<IntegerRange>("copiesPerJob", CopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<int?>("dpis", Dpis);
            writer.WriteCollectionOfPrimitiveValues<string>("duplexModes", DuplexModes);
            writer.WriteCollectionOfPrimitiveValues<string>("feedOrientations", FeedOrientations);
            writer.WriteCollectionOfPrimitiveValues<string>("finishings", Finishings);
            writer.WriteCollectionOfPrimitiveValues<string>("inputBins", InputBins);
            writer.WriteBoolValue("isColorPrintingSupported", IsColorPrintingSupported);
            writer.WriteBoolValue("isPageRangeSupported", IsPageRangeSupported);
            writer.WriteCollectionOfPrimitiveValues<int?>("leftMargins", LeftMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaColors", MediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaSizes", MediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaTypes", MediaTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("multipageLayouts", MultipageLayouts);
            writer.WriteCollectionOfPrimitiveValues<string>("orientations", Orientations);
            writer.WriteCollectionOfPrimitiveValues<string>("outputBins", OutputBins);
            writer.WriteCollectionOfPrimitiveValues<int?>("pagesPerSheet", PagesPerSheet);
            writer.WriteCollectionOfPrimitiveValues<string>("qualities", Qualities);
            writer.WriteCollectionOfPrimitiveValues<int?>("rightMargins", RightMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("scalings", Scalings);
            writer.WriteBoolValue("supportsFitPdfToPage", SupportsFitPdfToPage);
            writer.WriteCollectionOfPrimitiveValues<int?>("topMargins", TopMargins);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

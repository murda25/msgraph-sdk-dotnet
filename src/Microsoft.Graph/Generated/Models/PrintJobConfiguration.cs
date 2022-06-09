using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class PrintJobConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Whether the printer should collate pages wehen printing multiple copies of a multi-page document.</summary>
        public bool? Collate {
            get { return BackingStore?.Get<bool?>(nameof(Collate)); }
            set { BackingStore?.Set(nameof(Collate), value); }
        }
        /// <summary>The color mode the printer should use to print the job. Valid values are described in the table below. Read-only.</summary>
        public PrintColorMode? ColorMode {
            get { return BackingStore?.Get<PrintColorMode?>(nameof(ColorMode)); }
            set { BackingStore?.Set(nameof(ColorMode), value); }
        }
        /// <summary>The number of copies that should be printed. Read-only.</summary>
        public int? Copies {
            get { return BackingStore?.Get<int?>(nameof(Copies)); }
            set { BackingStore?.Set(nameof(Copies), value); }
        }
        /// <summary>The resolution to use when printing the job, expressed in dots per inch (DPI). Read-only.</summary>
        public int? Dpi {
            get { return BackingStore?.Get<int?>(nameof(Dpi)); }
            set { BackingStore?.Set(nameof(Dpi), value); }
        }
        /// <summary>The duplex mode the printer should use when printing the job. Valid values are described in the table below. Read-only.</summary>
        public PrintDuplexMode? DuplexMode {
            get { return BackingStore?.Get<PrintDuplexMode?>(nameof(DuplexMode)); }
            set { BackingStore?.Set(nameof(DuplexMode), value); }
        }
        /// <summary>The orientation to use when feeding media into the printer. Valid values are described in the following table. Read-only.</summary>
        public PrinterFeedOrientation? FeedOrientation {
            get { return BackingStore?.Get<PrinterFeedOrientation?>(nameof(FeedOrientation)); }
            set { BackingStore?.Set(nameof(FeedOrientation), value); }
        }
        /// <summary>Finishing processes to use when printing.</summary>
        public List<string> Finishings {
            get { return BackingStore?.Get<List<string>>(nameof(Finishings)); }
            set { BackingStore?.Set(nameof(Finishings), value); }
        }
        /// <summary>The fitPdfToPage property</summary>
        public bool? FitPdfToPage {
            get { return BackingStore?.Get<bool?>(nameof(FitPdfToPage)); }
            set { BackingStore?.Set(nameof(FitPdfToPage), value); }
        }
        /// <summary>The input bin (tray) to use when printing. See the printer&apos;s capabilities for a list of supported input bins.</summary>
        public string InputBin {
            get { return BackingStore?.Get<string>(nameof(InputBin)); }
            set { BackingStore?.Set(nameof(InputBin), value); }
        }
        /// <summary>The margin settings to use when printing.</summary>
        public PrintMargin Margin {
            get { return BackingStore?.Get<PrintMargin>(nameof(Margin)); }
            set { BackingStore?.Set(nameof(Margin), value); }
        }
        /// <summary>The media sizeto use when printing. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.</summary>
        public string MediaSize {
            get { return BackingStore?.Get<string>(nameof(MediaSize)); }
            set { BackingStore?.Set(nameof(MediaSize), value); }
        }
        /// <summary>The default media (such as paper) type to print the document on.</summary>
        public string MediaType {
            get { return BackingStore?.Get<string>(nameof(MediaType)); }
            set { BackingStore?.Set(nameof(MediaType), value); }
        }
        /// <summary>The direction to lay out pages when multiple pages are being printed per sheet. Valid values are described in the following table.</summary>
        public PrintMultipageLayout? MultipageLayout {
            get { return BackingStore?.Get<PrintMultipageLayout?>(nameof(MultipageLayout)); }
            set { BackingStore?.Set(nameof(MultipageLayout), value); }
        }
        /// <summary>The orientation setting the printer should use when printing the job. Valid values are described in the following table.</summary>
        public PrintOrientation? Orientation {
            get { return BackingStore?.Get<PrintOrientation?>(nameof(Orientation)); }
            set { BackingStore?.Set(nameof(Orientation), value); }
        }
        /// <summary>The output bin to place completed prints into. See the printer&apos;s capabilities for a list of supported output bins.</summary>
        public string OutputBin {
            get { return BackingStore?.Get<string>(nameof(OutputBin)); }
            set { BackingStore?.Set(nameof(OutputBin), value); }
        }
        /// <summary>The page ranges to print. Read-only.</summary>
        public List<IntegerRange> PageRanges {
            get { return BackingStore?.Get<List<IntegerRange>>(nameof(PageRanges)); }
            set { BackingStore?.Set(nameof(PageRanges), value); }
        }
        /// <summary>The number of document pages to print on each sheet.</summary>
        public int? PagesPerSheet {
            get { return BackingStore?.Get<int?>(nameof(PagesPerSheet)); }
            set { BackingStore?.Set(nameof(PagesPerSheet), value); }
        }
        /// <summary>The print quality to use when printing the job. Valid values are described in the table below. Read-only.</summary>
        public PrintQuality? Quality {
            get { return BackingStore?.Get<PrintQuality?>(nameof(Quality)); }
            set { BackingStore?.Set(nameof(Quality), value); }
        }
        /// <summary>Specifies how the printer should scale the document data to fit the requested media. Valid values are described in the following table.</summary>
        public PrintScaling? Scaling {
            get { return BackingStore?.Get<PrintScaling?>(nameof(Scaling)); }
            set { BackingStore?.Set(nameof(Scaling), value); }
        }
        /// <summary>
        /// Instantiates a new printJobConfiguration and sets the default values.
        /// </summary>
        public PrintJobConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrintJobConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintJobConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"collate", n => { Collate = n.GetBoolValue(); } },
                {"colorMode", n => { ColorMode = n.GetEnumValue<PrintColorMode>(); } },
                {"copies", n => { Copies = n.GetIntValue(); } },
                {"dpi", n => { Dpi = n.GetIntValue(); } },
                {"duplexMode", n => { DuplexMode = n.GetEnumValue<PrintDuplexMode>(); } },
                {"feedOrientation", n => { FeedOrientation = n.GetEnumValue<PrinterFeedOrientation>(); } },
                {"finishings", n => { Finishings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fitPdfToPage", n => { FitPdfToPage = n.GetBoolValue(); } },
                {"inputBin", n => { InputBin = n.GetStringValue(); } },
                {"margin", n => { Margin = n.GetObjectValue<PrintMargin>(PrintMargin.CreateFromDiscriminatorValue); } },
                {"mediaSize", n => { MediaSize = n.GetStringValue(); } },
                {"mediaType", n => { MediaType = n.GetStringValue(); } },
                {"multipageLayout", n => { MultipageLayout = n.GetEnumValue<PrintMultipageLayout>(); } },
                {"orientation", n => { Orientation = n.GetEnumValue<PrintOrientation>(); } },
                {"outputBin", n => { OutputBin = n.GetStringValue(); } },
                {"pageRanges", n => { PageRanges = n.GetCollectionOfObjectValues<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue).ToList(); } },
                {"pagesPerSheet", n => { PagesPerSheet = n.GetIntValue(); } },
                {"quality", n => { Quality = n.GetEnumValue<PrintQuality>(); } },
                {"scaling", n => { Scaling = n.GetEnumValue<PrintScaling>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("collate", Collate);
            writer.WriteEnumValue<PrintColorMode>("colorMode", ColorMode);
            writer.WriteIntValue("copies", Copies);
            writer.WriteIntValue("dpi", Dpi);
            writer.WriteEnumValue<PrintDuplexMode>("duplexMode", DuplexMode);
            writer.WriteEnumValue<PrinterFeedOrientation>("feedOrientation", FeedOrientation);
            writer.WriteCollectionOfPrimitiveValues<string>("finishings", Finishings);
            writer.WriteBoolValue("fitPdfToPage", FitPdfToPage);
            writer.WriteStringValue("inputBin", InputBin);
            writer.WriteObjectValue<PrintMargin>("margin", Margin);
            writer.WriteStringValue("mediaSize", MediaSize);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteEnumValue<PrintMultipageLayout>("multipageLayout", MultipageLayout);
            writer.WriteEnumValue<PrintOrientation>("orientation", Orientation);
            writer.WriteStringValue("outputBin", OutputBin);
            writer.WriteCollectionOfObjectValues<IntegerRange>("pageRanges", PageRanges);
            writer.WriteIntValue("pagesPerSheet", PagesPerSheet);
            writer.WriteEnumValue<PrintQuality>("quality", Quality);
            writer.WriteEnumValue<PrintScaling>("scaling", Scaling);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
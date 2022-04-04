using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>The resource that represents an instance of Enrollment Failure Reports.</summary>
    public class ReportRoot : Entity, IParsable {
        /// <summary>The dailyPrintUsageByPrinter property</summary>
        public List<PrintUsageByPrinter> DailyPrintUsageByPrinter { get; set; }
        /// <summary>The dailyPrintUsageByUser property</summary>
        public List<PrintUsageByUser> DailyPrintUsageByUser { get; set; }
        /// <summary>The monthlyPrintUsageByPrinter property</summary>
        public List<PrintUsageByPrinter> MonthlyPrintUsageByPrinter { get; set; }
        /// <summary>The monthlyPrintUsageByUser property</summary>
        public List<PrintUsageByUser> MonthlyPrintUsageByUser { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ReportRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReportRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"dailyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).DailyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageByUser", (o,n) => { (o as ReportRoot).DailyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>(PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageByUser", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>(PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageByPrinter", DailyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageByUser", DailyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageByPrinter", MonthlyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageByUser", MonthlyPrintUsageByUser);
        }
    }
}

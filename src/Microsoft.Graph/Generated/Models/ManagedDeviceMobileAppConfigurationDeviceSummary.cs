using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ManagedDeviceMobileAppConfigurationDeviceSummary : Entity, IParsable {
        /// <summary>Version of the policy for that overview</summary>
        public int? ConfigurationVersion {
            get { return BackingStore?.Get<int?>("configurationVersion"); }
            set { BackingStore?.Set("configurationVersion", value); }
        }
        /// <summary>Number of error devices</summary>
        public int? ErrorCount {
            get { return BackingStore?.Get<int?>("errorCount"); }
            set { BackingStore?.Set("errorCount", value); }
        }
        /// <summary>Number of failed devices</summary>
        public int? FailedCount {
            get { return BackingStore?.Get<int?>("failedCount"); }
            set { BackingStore?.Set("failedCount", value); }
        }
        /// <summary>Last update time</summary>
        public DateTimeOffset? LastUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdateDateTime"); }
            set { BackingStore?.Set("lastUpdateDateTime", value); }
        }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableCount {
            get { return BackingStore?.Get<int?>("notApplicableCount"); }
            set { BackingStore?.Set("notApplicableCount", value); }
        }
        /// <summary>Number of pending devices</summary>
        public int? PendingCount {
            get { return BackingStore?.Get<int?>("pendingCount"); }
            set { BackingStore?.Set("pendingCount", value); }
        }
        /// <summary>Number of succeeded devices</summary>
        public int? SuccessCount {
            get { return BackingStore?.Get<int?>("successCount"); }
            set { BackingStore?.Set("successCount", value); }
        }
        /// <summary>
        /// Instantiates a new managedDeviceMobileAppConfigurationDeviceSummary and sets the default values.
        /// </summary>
        public ManagedDeviceMobileAppConfigurationDeviceSummary() : base() {
            OdataType = "#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDeviceMobileAppConfigurationDeviceSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceMobileAppConfigurationDeviceSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationVersion", n => { ConfigurationVersion = n.GetIntValue(); } },
                {"errorCount", n => { ErrorCount = n.GetIntValue(); } },
                {"failedCount", n => { FailedCount = n.GetIntValue(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                {"pendingCount", n => { PendingCount = n.GetIntValue(); } },
                {"successCount", n => { SuccessCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("configurationVersion", ConfigurationVersion);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("failedCount", FailedCount);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("pendingCount", PendingCount);
            writer.WriteIntValue("successCount", SuccessCount);
        }
    }
}
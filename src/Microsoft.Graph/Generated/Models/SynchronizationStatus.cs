using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SynchronizationStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The code property</summary>
        public SynchronizationStatusCode? Code {
            get { return BackingStore?.Get<SynchronizationStatusCode?>("code"); }
            set { BackingStore?.Set("code", value); }
        }
        /// <summary>The countSuccessiveCompleteFailures property</summary>
        public long? CountSuccessiveCompleteFailures {
            get { return BackingStore?.Get<long?>("countSuccessiveCompleteFailures"); }
            set { BackingStore?.Set("countSuccessiveCompleteFailures", value); }
        }
        /// <summary>The escrowsPruned property</summary>
        public bool? EscrowsPruned {
            get { return BackingStore?.Get<bool?>("escrowsPruned"); }
            set { BackingStore?.Set("escrowsPruned", value); }
        }
        /// <summary>The lastExecution property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationTaskExecution? LastExecution {
            get { return BackingStore?.Get<SynchronizationTaskExecution?>("lastExecution"); }
            set { BackingStore?.Set("lastExecution", value); }
        }
#nullable restore
#else
        public SynchronizationTaskExecution LastExecution {
            get { return BackingStore?.Get<SynchronizationTaskExecution>("lastExecution"); }
            set { BackingStore?.Set("lastExecution", value); }
        }
#endif
        /// <summary>The lastSuccessfulExecution property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationTaskExecution? LastSuccessfulExecution {
            get { return BackingStore?.Get<SynchronizationTaskExecution?>("lastSuccessfulExecution"); }
            set { BackingStore?.Set("lastSuccessfulExecution", value); }
        }
#nullable restore
#else
        public SynchronizationTaskExecution LastSuccessfulExecution {
            get { return BackingStore?.Get<SynchronizationTaskExecution>("lastSuccessfulExecution"); }
            set { BackingStore?.Set("lastSuccessfulExecution", value); }
        }
#endif
        /// <summary>The lastSuccessfulExecutionWithExports property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationTaskExecution? LastSuccessfulExecutionWithExports {
            get { return BackingStore?.Get<SynchronizationTaskExecution?>("lastSuccessfulExecutionWithExports"); }
            set { BackingStore?.Set("lastSuccessfulExecutionWithExports", value); }
        }
#nullable restore
#else
        public SynchronizationTaskExecution LastSuccessfulExecutionWithExports {
            get { return BackingStore?.Get<SynchronizationTaskExecution>("lastSuccessfulExecutionWithExports"); }
            set { BackingStore?.Set("lastSuccessfulExecutionWithExports", value); }
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
        /// <summary>The progress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationProgress>? Progress {
            get { return BackingStore?.Get<List<SynchronizationProgress>?>("progress"); }
            set { BackingStore?.Set("progress", value); }
        }
#nullable restore
#else
        public List<SynchronizationProgress> Progress {
            get { return BackingStore?.Get<List<SynchronizationProgress>>("progress"); }
            set { BackingStore?.Set("progress", value); }
        }
#endif
        /// <summary>The quarantine property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationQuarantine? Quarantine {
            get { return BackingStore?.Get<SynchronizationQuarantine?>("quarantine"); }
            set { BackingStore?.Set("quarantine", value); }
        }
#nullable restore
#else
        public SynchronizationQuarantine Quarantine {
            get { return BackingStore?.Get<SynchronizationQuarantine>("quarantine"); }
            set { BackingStore?.Set("quarantine", value); }
        }
#endif
        /// <summary>The steadyStateFirstAchievedTime property</summary>
        public DateTimeOffset? SteadyStateFirstAchievedTime {
            get { return BackingStore?.Get<DateTimeOffset?>("steadyStateFirstAchievedTime"); }
            set { BackingStore?.Set("steadyStateFirstAchievedTime", value); }
        }
        /// <summary>The steadyStateLastAchievedTime property</summary>
        public DateTimeOffset? SteadyStateLastAchievedTime {
            get { return BackingStore?.Get<DateTimeOffset?>("steadyStateLastAchievedTime"); }
            set { BackingStore?.Set("steadyStateLastAchievedTime", value); }
        }
        /// <summary>The synchronizedEntryCountByType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<StringKeyLongValuePair>? SynchronizedEntryCountByType {
            get { return BackingStore?.Get<List<StringKeyLongValuePair>?>("synchronizedEntryCountByType"); }
            set { BackingStore?.Set("synchronizedEntryCountByType", value); }
        }
#nullable restore
#else
        public List<StringKeyLongValuePair> SynchronizedEntryCountByType {
            get { return BackingStore?.Get<List<StringKeyLongValuePair>>("synchronizedEntryCountByType"); }
            set { BackingStore?.Set("synchronizedEntryCountByType", value); }
        }
#endif
        /// <summary>The troubleshootingUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TroubleshootingUrl {
            get { return BackingStore?.Get<string?>("troubleshootingUrl"); }
            set { BackingStore?.Set("troubleshootingUrl", value); }
        }
#nullable restore
#else
        public string TroubleshootingUrl {
            get { return BackingStore?.Get<string>("troubleshootingUrl"); }
            set { BackingStore?.Set("troubleshootingUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new synchronizationStatus and sets the default values.
        /// </summary>
        public SynchronizationStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code", n => { Code = n.GetEnumValue<SynchronizationStatusCode>(); } },
                {"countSuccessiveCompleteFailures", n => { CountSuccessiveCompleteFailures = n.GetLongValue(); } },
                {"escrowsPruned", n => { EscrowsPruned = n.GetBoolValue(); } },
                {"lastExecution", n => { LastExecution = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"lastSuccessfulExecution", n => { LastSuccessfulExecution = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"lastSuccessfulExecutionWithExports", n => { LastSuccessfulExecutionWithExports = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"progress", n => { Progress = n.GetCollectionOfObjectValues<SynchronizationProgress>(SynchronizationProgress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"quarantine", n => { Quarantine = n.GetObjectValue<SynchronizationQuarantine>(SynchronizationQuarantine.CreateFromDiscriminatorValue); } },
                {"steadyStateFirstAchievedTime", n => { SteadyStateFirstAchievedTime = n.GetDateTimeOffsetValue(); } },
                {"steadyStateLastAchievedTime", n => { SteadyStateLastAchievedTime = n.GetDateTimeOffsetValue(); } },
                {"synchronizedEntryCountByType", n => { SynchronizedEntryCountByType = n.GetCollectionOfObjectValues<StringKeyLongValuePair>(StringKeyLongValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"troubleshootingUrl", n => { TroubleshootingUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SynchronizationStatusCode>("code", Code);
            writer.WriteLongValue("countSuccessiveCompleteFailures", CountSuccessiveCompleteFailures);
            writer.WriteBoolValue("escrowsPruned", EscrowsPruned);
            writer.WriteObjectValue<SynchronizationTaskExecution>("lastExecution", LastExecution);
            writer.WriteObjectValue<SynchronizationTaskExecution>("lastSuccessfulExecution", LastSuccessfulExecution);
            writer.WriteObjectValue<SynchronizationTaskExecution>("lastSuccessfulExecutionWithExports", LastSuccessfulExecutionWithExports);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<SynchronizationProgress>("progress", Progress);
            writer.WriteObjectValue<SynchronizationQuarantine>("quarantine", Quarantine);
            writer.WriteDateTimeOffsetValue("steadyStateFirstAchievedTime", SteadyStateFirstAchievedTime);
            writer.WriteDateTimeOffsetValue("steadyStateLastAchievedTime", SteadyStateLastAchievedTime);
            writer.WriteCollectionOfObjectValues<StringKeyLongValuePair>("synchronizedEntryCountByType", SynchronizedEntryCountByType);
            writer.WriteStringValue("troubleshootingUrl", TroubleshootingUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

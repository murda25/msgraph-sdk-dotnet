using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SynchronizationTaskExecution : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The activityIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityIdentifier {
            get { return BackingStore?.Get<string?>("activityIdentifier"); }
            set { BackingStore?.Set("activityIdentifier", value); }
        }
#nullable restore
#else
        public string ActivityIdentifier {
            get { return BackingStore?.Get<string>("activityIdentifier"); }
            set { BackingStore?.Set("activityIdentifier", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The countEntitled property</summary>
        public long? CountEntitled {
            get { return BackingStore?.Get<long?>("countEntitled"); }
            set { BackingStore?.Set("countEntitled", value); }
        }
        /// <summary>The countEntitledForProvisioning property</summary>
        public long? CountEntitledForProvisioning {
            get { return BackingStore?.Get<long?>("countEntitledForProvisioning"); }
            set { BackingStore?.Set("countEntitledForProvisioning", value); }
        }
        /// <summary>The countEscrowed property</summary>
        public long? CountEscrowed {
            get { return BackingStore?.Get<long?>("countEscrowed"); }
            set { BackingStore?.Set("countEscrowed", value); }
        }
        /// <summary>The countEscrowedRaw property</summary>
        public long? CountEscrowedRaw {
            get { return BackingStore?.Get<long?>("countEscrowedRaw"); }
            set { BackingStore?.Set("countEscrowedRaw", value); }
        }
        /// <summary>The countExported property</summary>
        public long? CountExported {
            get { return BackingStore?.Get<long?>("countExported"); }
            set { BackingStore?.Set("countExported", value); }
        }
        /// <summary>The countExports property</summary>
        public long? CountExports {
            get { return BackingStore?.Get<long?>("countExports"); }
            set { BackingStore?.Set("countExports", value); }
        }
        /// <summary>The countImported property</summary>
        public long? CountImported {
            get { return BackingStore?.Get<long?>("countImported"); }
            set { BackingStore?.Set("countImported", value); }
        }
        /// <summary>The countImportedDeltas property</summary>
        public long? CountImportedDeltas {
            get { return BackingStore?.Get<long?>("countImportedDeltas"); }
            set { BackingStore?.Set("countImportedDeltas", value); }
        }
        /// <summary>The countImportedReferenceDeltas property</summary>
        public long? CountImportedReferenceDeltas {
            get { return BackingStore?.Get<long?>("countImportedReferenceDeltas"); }
            set { BackingStore?.Set("countImportedReferenceDeltas", value); }
        }
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationError? Error {
            get { return BackingStore?.Get<SynchronizationError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public SynchronizationError Error {
            get { return BackingStore?.Get<SynchronizationError>("error"); }
            set { BackingStore?.Set("error", value); }
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
        /// <summary>The state property</summary>
        public SynchronizationTaskExecutionResult? State {
            get { return BackingStore?.Get<SynchronizationTaskExecutionResult?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The timeBegan property</summary>
        public DateTimeOffset? TimeBegan {
            get { return BackingStore?.Get<DateTimeOffset?>("timeBegan"); }
            set { BackingStore?.Set("timeBegan", value); }
        }
        /// <summary>The timeEnded property</summary>
        public DateTimeOffset? TimeEnded {
            get { return BackingStore?.Get<DateTimeOffset?>("timeEnded"); }
            set { BackingStore?.Set("timeEnded", value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationTaskExecution and sets the default values.
        /// </summary>
        public SynchronizationTaskExecution() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationTaskExecution CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationTaskExecution();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityIdentifier", n => { ActivityIdentifier = n.GetStringValue(); } },
                {"countEntitled", n => { CountEntitled = n.GetLongValue(); } },
                {"countEntitledForProvisioning", n => { CountEntitledForProvisioning = n.GetLongValue(); } },
                {"countEscrowed", n => { CountEscrowed = n.GetLongValue(); } },
                {"countEscrowedRaw", n => { CountEscrowedRaw = n.GetLongValue(); } },
                {"countExported", n => { CountExported = n.GetLongValue(); } },
                {"countExports", n => { CountExports = n.GetLongValue(); } },
                {"countImported", n => { CountImported = n.GetLongValue(); } },
                {"countImportedDeltas", n => { CountImportedDeltas = n.GetLongValue(); } },
                {"countImportedReferenceDeltas", n => { CountImportedReferenceDeltas = n.GetLongValue(); } },
                {"error", n => { Error = n.GetObjectValue<SynchronizationError>(SynchronizationError.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<SynchronizationTaskExecutionResult>(); } },
                {"timeBegan", n => { TimeBegan = n.GetDateTimeOffsetValue(); } },
                {"timeEnded", n => { TimeEnded = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityIdentifier", ActivityIdentifier);
            writer.WriteLongValue("countEntitled", CountEntitled);
            writer.WriteLongValue("countEntitledForProvisioning", CountEntitledForProvisioning);
            writer.WriteLongValue("countEscrowed", CountEscrowed);
            writer.WriteLongValue("countEscrowedRaw", CountEscrowedRaw);
            writer.WriteLongValue("countExported", CountExported);
            writer.WriteLongValue("countExports", CountExports);
            writer.WriteLongValue("countImported", CountImported);
            writer.WriteLongValue("countImportedDeltas", CountImportedDeltas);
            writer.WriteLongValue("countImportedReferenceDeltas", CountImportedReferenceDeltas);
            writer.WriteObjectValue<SynchronizationError>("error", Error);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<SynchronizationTaskExecutionResult>("state", State);
            writer.WriteDateTimeOffsetValue("timeBegan", TimeBegan);
            writer.WriteDateTimeOffsetValue("timeEnded", TimeEnded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

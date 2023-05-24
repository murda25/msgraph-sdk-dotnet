using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SynchronizationQuarantine : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The currentBegan property</summary>
        public DateTimeOffset? CurrentBegan {
            get { return BackingStore?.Get<DateTimeOffset?>("currentBegan"); }
            set { BackingStore?.Set("currentBegan", value); }
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
        /// <summary>The nextAttempt property</summary>
        public DateTimeOffset? NextAttempt {
            get { return BackingStore?.Get<DateTimeOffset?>("nextAttempt"); }
            set { BackingStore?.Set("nextAttempt", value); }
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
        /// <summary>The reason property</summary>
        public QuarantineReason? Reason {
            get { return BackingStore?.Get<QuarantineReason?>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
        /// <summary>The seriesBegan property</summary>
        public DateTimeOffset? SeriesBegan {
            get { return BackingStore?.Get<DateTimeOffset?>("seriesBegan"); }
            set { BackingStore?.Set("seriesBegan", value); }
        }
        /// <summary>The seriesCount property</summary>
        public long? SeriesCount {
            get { return BackingStore?.Get<long?>("seriesCount"); }
            set { BackingStore?.Set("seriesCount", value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationQuarantine and sets the default values.
        /// </summary>
        public SynchronizationQuarantine() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationQuarantine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationQuarantine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"currentBegan", n => { CurrentBegan = n.GetDateTimeOffsetValue(); } },
                {"error", n => { Error = n.GetObjectValue<SynchronizationError>(SynchronizationError.CreateFromDiscriminatorValue); } },
                {"nextAttempt", n => { NextAttempt = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetEnumValue<QuarantineReason>(); } },
                {"seriesBegan", n => { SeriesBegan = n.GetDateTimeOffsetValue(); } },
                {"seriesCount", n => { SeriesCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("currentBegan", CurrentBegan);
            writer.WriteObjectValue<SynchronizationError>("error", Error);
            writer.WriteDateTimeOffsetValue("nextAttempt", NextAttempt);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<QuarantineReason>("reason", Reason);
            writer.WriteDateTimeOffsetValue("seriesBegan", SeriesBegan);
            writer.WriteLongValue("seriesCount", SeriesCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

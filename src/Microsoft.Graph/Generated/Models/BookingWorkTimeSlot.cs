using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class BookingWorkTimeSlot : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The time of the day when work stops. For example, 17:00:00.0000000.</summary>
        public Time? EndTime {
            get { return BackingStore?.Get<Time?>(nameof(EndTime)); }
            set { BackingStore?.Set(nameof(EndTime), value); }
        }
        /// <summary>The time of the day when work starts. For example, 08:00:00.0000000.</summary>
        public Time? StartTime {
            get { return BackingStore?.Get<Time?>(nameof(StartTime)); }
            set { BackingStore?.Set(nameof(StartTime), value); }
        }
        /// <summary>
        /// Instantiates a new bookingWorkTimeSlot and sets the default values.
        /// </summary>
        public BookingWorkTimeSlot() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BookingWorkTimeSlot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingWorkTimeSlot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endTime", n => { EndTime = n.GetTimeValue(); } },
                {"startTime", n => { StartTime = n.GetTimeValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeValue("endTime", EndTime);
            writer.WriteTimeValue("startTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
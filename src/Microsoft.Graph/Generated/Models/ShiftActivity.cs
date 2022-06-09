using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ShiftActivity : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Customer defined code for the shiftActivity. Required.</summary>
        public string Code {
            get { return BackingStore?.Get<string>(nameof(Code)); }
            set { BackingStore?.Set(nameof(Code), value); }
        }
        /// <summary>The name of the shiftActivity. Required.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The end date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EndDateTime)); }
            set { BackingStore?.Set(nameof(EndDateTime), value); }
        }
        /// <summary>Indicates whether the microsoft.graph.user should be paid for the activity during their shift. Required.</summary>
        public bool? IsPaid {
            get { return BackingStore?.Get<bool?>(nameof(IsPaid)); }
            set { BackingStore?.Set(nameof(IsPaid), value); }
        }
        /// <summary>The start date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>The theme property</summary>
        public ScheduleEntityTheme? Theme {
            get { return BackingStore?.Get<ScheduleEntityTheme?>(nameof(Theme)); }
            set { BackingStore?.Set(nameof(Theme), value); }
        }
        /// <summary>
        /// Instantiates a new shiftActivity and sets the default values.
        /// </summary>
        public ShiftActivity() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ShiftActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ShiftActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code", n => { Code = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"isPaid", n => { IsPaid = n.GetBoolValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"theme", n => { Theme = n.GetEnumValue<ScheduleEntityTheme>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteBoolValue("isPaid", IsPaid);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<ScheduleEntityTheme>("theme", Theme);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class TeamworkOnlineMeetingInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The identifier of the calendar event associated with the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CalendarEventId {
            get { return BackingStore?.Get<string?>("calendarEventId"); }
            set { BackingStore?.Set("calendarEventId", value); }
        }
#nullable restore
#else
        public string CalendarEventId {
            get { return BackingStore?.Get<string>("calendarEventId"); }
            set { BackingStore?.Set("calendarEventId", value); }
        }
#endif
        /// <summary>The URL that users click to join or uniquely identify the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl {
            get { return BackingStore?.Get<string?>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#nullable restore
#else
        public string JoinWebUrl {
            get { return BackingStore?.Get<string>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
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
        /// <summary>The organizer of the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkUserIdentity? Organizer {
            get { return BackingStore?.Get<TeamworkUserIdentity?>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#nullable restore
#else
        public TeamworkUserIdentity Organizer {
            get { return BackingStore?.Get<TeamworkUserIdentity>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new teamworkOnlineMeetingInfo and sets the default values.
        /// </summary>
        public TeamworkOnlineMeetingInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkOnlineMeetingInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkOnlineMeetingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"calendarEventId", n => { CalendarEventId = n.GetStringValue(); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organizer", n => { Organizer = n.GetObjectValue<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("calendarEventId", CalendarEventId);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TeamworkUserIdentity>("organizer", Organizer);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

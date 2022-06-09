using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class MeetingTimeSuggestionsResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A reason for not returning any meeting suggestions. Possible values are: attendeesUnavailable, attendeesUnavailableOrUnknown, locationsUnavailable, organizerUnavailable, or unknown. This property is an empty string if the meetingTimeSuggestions property does include any meeting suggestions.</summary>
        public string EmptySuggestionsReason {
            get { return BackingStore?.Get<string>(nameof(EmptySuggestionsReason)); }
            set { BackingStore?.Set(nameof(EmptySuggestionsReason), value); }
        }
        /// <summary>An array of meeting suggestions.</summary>
        public List<MeetingTimeSuggestion> MeetingTimeSuggestions {
            get { return BackingStore?.Get<List<MeetingTimeSuggestion>>(nameof(MeetingTimeSuggestions)); }
            set { BackingStore?.Set(nameof(MeetingTimeSuggestions), value); }
        }
        /// <summary>
        /// Instantiates a new MeetingTimeSuggestionsResult and sets the default values.
        /// </summary>
        public MeetingTimeSuggestionsResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MeetingTimeSuggestionsResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingTimeSuggestionsResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"emptySuggestionsReason", n => { EmptySuggestionsReason = n.GetStringValue(); } },
                {"meetingTimeSuggestions", n => { MeetingTimeSuggestions = n.GetCollectionOfObjectValues<MeetingTimeSuggestion>(MeetingTimeSuggestion.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("emptySuggestionsReason", EmptySuggestionsReason);
            writer.WriteCollectionOfObjectValues<MeetingTimeSuggestion>("meetingTimeSuggestions", MeetingTimeSuggestions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
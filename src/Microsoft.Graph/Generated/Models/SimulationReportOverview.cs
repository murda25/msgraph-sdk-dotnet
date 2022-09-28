using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class SimulationReportOverview : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The recommendedActions property</summary>
        public List<RecommendedAction> RecommendedActions {
            get { return BackingStore?.Get<List<RecommendedAction>>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
        /// <summary>The resolvedTargetsCount property</summary>
        public int? ResolvedTargetsCount {
            get { return BackingStore?.Get<int?>("resolvedTargetsCount"); }
            set { BackingStore?.Set("resolvedTargetsCount", value); }
        }
        /// <summary>The simulationEventsContent property</summary>
        public Microsoft.Graph.Models.SimulationEventsContent SimulationEventsContent {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SimulationEventsContent>("simulationEventsContent"); }
            set { BackingStore?.Set("simulationEventsContent", value); }
        }
        /// <summary>The trainingEventsContent property</summary>
        public Microsoft.Graph.Models.TrainingEventsContent TrainingEventsContent {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TrainingEventsContent>("trainingEventsContent"); }
            set { BackingStore?.Set("trainingEventsContent", value); }
        }
        /// <summary>
        /// Instantiates a new simulationReportOverview and sets the default values.
        /// </summary>
        public SimulationReportOverview() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.simulationReportOverview";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SimulationReportOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimulationReportOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recommendedActions", n => { RecommendedActions = n.GetCollectionOfObjectValues<RecommendedAction>(RecommendedAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resolvedTargetsCount", n => { ResolvedTargetsCount = n.GetIntValue(); } },
                {"simulationEventsContent", n => { SimulationEventsContent = n.GetObjectValue<Microsoft.Graph.Models.SimulationEventsContent>(Microsoft.Graph.Models.SimulationEventsContent.CreateFromDiscriminatorValue); } },
                {"trainingEventsContent", n => { TrainingEventsContent = n.GetObjectValue<Microsoft.Graph.Models.TrainingEventsContent>(Microsoft.Graph.Models.TrainingEventsContent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<RecommendedAction>("recommendedActions", RecommendedActions);
            writer.WriteIntValue("resolvedTargetsCount", ResolvedTargetsCount);
            writer.WriteObjectValue<Microsoft.Graph.Models.SimulationEventsContent>("simulationEventsContent", SimulationEventsContent);
            writer.WriteObjectValue<Microsoft.Graph.Models.TrainingEventsContent>("trainingEventsContent", TrainingEventsContent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

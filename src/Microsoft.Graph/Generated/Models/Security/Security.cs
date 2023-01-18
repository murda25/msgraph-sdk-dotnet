using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.Security {
    public class Security : Entity, IParsable {
        /// <summary>The alerts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Microsoft.Graph.Models.Alert>? Alerts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Alert>?>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#else
        public List<Microsoft.Graph.Models.Alert> Alerts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Alert>>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#endif
        /// <summary>A collection of alerts in Microsoft 365 Defender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Alert>? Alerts_v2 {
            get { return BackingStore?.Get<List<Alert>?>("alerts_v2"); }
            set { BackingStore?.Set("alerts_v2", value); }
        }
#else
        public List<Alert> Alerts_v2 {
            get { return BackingStore?.Get<List<Alert>>("alerts_v2"); }
            set { BackingStore?.Set("alerts_v2", value); }
        }
#endif
        /// <summary>The attackSimulation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Models.AttackSimulationRoot? AttackSimulation {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AttackSimulationRoot?>("attackSimulation"); }
            set { BackingStore?.Set("attackSimulation", value); }
        }
#else
        public Microsoft.Graph.Models.AttackSimulationRoot AttackSimulation {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AttackSimulationRoot>("attackSimulation"); }
            set { BackingStore?.Set("attackSimulation", value); }
        }
#endif
        /// <summary>The cases property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public CasesRoot? Cases {
            get { return BackingStore?.Get<CasesRoot?>("cases"); }
            set { BackingStore?.Set("cases", value); }
        }
#else
        public CasesRoot Cases {
            get { return BackingStore?.Get<CasesRoot>("cases"); }
            set { BackingStore?.Set("cases", value); }
        }
#endif
        /// <summary>A collection of incidents in Microsoft 365 Defender, each of which is a set of correlated alerts and associated metadata that reflects the story of an attack.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Incident>? Incidents {
            get { return BackingStore?.Get<List<Incident>?>("incidents"); }
            set { BackingStore?.Set("incidents", value); }
        }
#else
        public List<Incident> Incidents {
            get { return BackingStore?.Get<List<Incident>>("incidents"); }
            set { BackingStore?.Set("incidents", value); }
        }
#endif
        /// <summary>The secureScoreControlProfiles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Microsoft.Graph.Models.SecureScoreControlProfile>? SecureScoreControlProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SecureScoreControlProfile>?>("secureScoreControlProfiles"); }
            set { BackingStore?.Set("secureScoreControlProfiles", value); }
        }
#else
        public List<Microsoft.Graph.Models.SecureScoreControlProfile> SecureScoreControlProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SecureScoreControlProfile>>("secureScoreControlProfiles"); }
            set { BackingStore?.Set("secureScoreControlProfiles", value); }
        }
#endif
        /// <summary>The secureScores property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Microsoft.Graph.Models.SecureScore>? SecureScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SecureScore>?>("secureScores"); }
            set { BackingStore?.Set("secureScores", value); }
        }
#else
        public List<Microsoft.Graph.Models.SecureScore> SecureScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SecureScore>>("secureScores"); }
            set { BackingStore?.Set("secureScores", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Security CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Security();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alerts", n => { Alerts = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Alert>(Microsoft.Graph.Models.Alert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alerts_v2", n => { Alerts_v2 = n.GetCollectionOfObjectValues<Alert>(Alert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attackSimulation", n => { AttackSimulation = n.GetObjectValue<Microsoft.Graph.Models.AttackSimulationRoot>(Microsoft.Graph.Models.AttackSimulationRoot.CreateFromDiscriminatorValue); } },
                {"cases", n => { Cases = n.GetObjectValue<CasesRoot>(CasesRoot.CreateFromDiscriminatorValue); } },
                {"incidents", n => { Incidents = n.GetCollectionOfObjectValues<Incident>(Incident.CreateFromDiscriminatorValue)?.ToList(); } },
                {"secureScoreControlProfiles", n => { SecureScoreControlProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.SecureScoreControlProfile>(Microsoft.Graph.Models.SecureScoreControlProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"secureScores", n => { SecureScores = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.SecureScore>(Microsoft.Graph.Models.SecureScore.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Alert>("alerts", Alerts);
            writer.WriteCollectionOfObjectValues<Alert>("alerts_v2", Alerts_v2);
            writer.WriteObjectValue<Microsoft.Graph.Models.AttackSimulationRoot>("attackSimulation", AttackSimulation);
            writer.WriteObjectValue<CasesRoot>("cases", Cases);
            writer.WriteCollectionOfObjectValues<Incident>("incidents", Incidents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.SecureScoreControlProfile>("secureScoreControlProfiles", SecureScoreControlProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.SecureScore>("secureScores", SecureScores);
        }
    }
}

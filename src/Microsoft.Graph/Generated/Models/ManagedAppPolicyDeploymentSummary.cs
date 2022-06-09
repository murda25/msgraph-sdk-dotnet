using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>The ManagedAppEntity is the base entity type for all other entity types under app management workflow.</summary>
    public class ManagedAppPolicyDeploymentSummary : Entity, IParsable {
        /// <summary>Not yet documented</summary>
        public int? ConfigurationDeployedUserCount {
            get { return BackingStore?.Get<int?>(nameof(ConfigurationDeployedUserCount)); }
            set { BackingStore?.Set(nameof(ConfigurationDeployedUserCount), value); }
        }
        /// <summary>Not yet documented</summary>
        public List<ManagedAppPolicyDeploymentSummaryPerApp> ConfigurationDeploymentSummaryPerApp {
            get { return BackingStore?.Get<List<ManagedAppPolicyDeploymentSummaryPerApp>>(nameof(ConfigurationDeploymentSummaryPerApp)); }
            set { BackingStore?.Set(nameof(ConfigurationDeploymentSummaryPerApp), value); }
        }
        /// <summary>Not yet documented</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Not yet documented</summary>
        public DateTimeOffset? LastRefreshTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastRefreshTime)); }
            set { BackingStore?.Set(nameof(LastRefreshTime), value); }
        }
        /// <summary>Version of the entity.</summary>
        public string Version {
            get { return BackingStore?.Get<string>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedAppPolicyDeploymentSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppPolicyDeploymentSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationDeployedUserCount", n => { ConfigurationDeployedUserCount = n.GetIntValue(); } },
                {"configurationDeploymentSummaryPerApp", n => { ConfigurationDeploymentSummaryPerApp = n.GetCollectionOfObjectValues<ManagedAppPolicyDeploymentSummaryPerApp>(ManagedAppPolicyDeploymentSummaryPerApp.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastRefreshTime", n => { LastRefreshTime = n.GetDateTimeOffsetValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("configurationDeployedUserCount", ConfigurationDeployedUserCount);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicyDeploymentSummaryPerApp>("configurationDeploymentSummaryPerApp", ConfigurationDeploymentSummaryPerApp);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastRefreshTime", LastRefreshTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
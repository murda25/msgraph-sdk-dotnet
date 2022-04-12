using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class TeamsAppInstallation : Entity, IParsable {
        /// <summary>The app that is installed.</summary>
        public Microsoft.Graph.Models.TeamsApp TeamsApp { get; set; }
        /// <summary>The details of this version of the app.</summary>
        public Microsoft.Graph.Models.TeamsAppDefinition TeamsAppDefinition { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsAppInstallation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAppInstallation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"teamsApp", n => { TeamsApp = n.GetObjectValue<Microsoft.Graph.Models.TeamsApp>(Microsoft.Graph.Models.TeamsApp.CreateFromDiscriminatorValue); } },
                {"teamsAppDefinition", n => { TeamsAppDefinition = n.GetObjectValue<Microsoft.Graph.Models.TeamsAppDefinition>(Microsoft.Graph.Models.TeamsAppDefinition.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteObjectValue<Microsoft.Graph.Models.TeamsAppDefinition>("teamsAppDefinition", TeamsAppDefinition);
        }
    }
}

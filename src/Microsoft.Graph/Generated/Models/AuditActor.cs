using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// A class containing the properties for Audit Actor.
    /// </summary>
    public class AuditActor : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Name of the Application.</summary>
        public string ApplicationDisplayName {
            get { return BackingStore?.Get<string>("applicationDisplayName"); }
            set { BackingStore?.Set("applicationDisplayName", value); }
        }
        /// <summary>AAD Application Id.</summary>
        public string ApplicationId {
            get { return BackingStore?.Get<string>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
        /// <summary>Actor Type.</summary>
        public string AuditActorType {
            get { return BackingStore?.Get<string>("auditActorType"); }
            set { BackingStore?.Set("auditActorType", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>IPAddress.</summary>
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Service Principal Name (SPN).</summary>
        public string ServicePrincipalName {
            get { return BackingStore?.Get<string>("servicePrincipalName"); }
            set { BackingStore?.Set("servicePrincipalName", value); }
        }
        /// <summary>User Id.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
        /// <summary>List of user permissions when the audit was performed.</summary>
        public List<string> UserPermissions {
            get { return BackingStore?.Get<List<string>>("userPermissions"); }
            set { BackingStore?.Set("userPermissions", value); }
        }
        /// <summary>User Principal Name (UPN).</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Instantiates a new auditActor and sets the default values.
        /// </summary>
        public AuditActor() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuditActor CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditActor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationDisplayName", n => { ApplicationDisplayName = n.GetStringValue(); } },
                {"applicationId", n => { ApplicationId = n.GetStringValue(); } },
                {"auditActorType", n => { AuditActorType = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"servicePrincipalName", n => { ServicePrincipalName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPermissions", n => { UserPermissions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationDisplayName", ApplicationDisplayName);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteStringValue("auditActorType", AuditActorType);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("servicePrincipalName", ServicePrincipalName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteCollectionOfPrimitiveValues<string>("userPermissions", UserPermissions);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

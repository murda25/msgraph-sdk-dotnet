using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ConditionalAccessConditionSet : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Applications and user actions included in and excluded from the policy. Required.</summary>
        public ConditionalAccessApplications Applications {
            get { return BackingStore?.Get<ConditionalAccessApplications>(nameof(Applications)); }
            set { BackingStore?.Set(nameof(Applications), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Client applications (service principals and workload identities) included in and excluded from the policy. Either users or clientApplications is required.</summary>
        public ConditionalAccessClientApplications ClientApplications {
            get { return BackingStore?.Get<ConditionalAccessClientApplications>(nameof(ClientApplications)); }
            set { BackingStore?.Set(nameof(ClientApplications), value); }
        }
        /// <summary>Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other. Required.</summary>
        public List<string> ClientAppTypes {
            get { return BackingStore?.Get<List<string>>(nameof(ClientAppTypes)); }
            set { BackingStore?.Set(nameof(ClientAppTypes), value); }
        }
        /// <summary>Devices in the policy.</summary>
        public ConditionalAccessDevices Devices {
            get { return BackingStore?.Get<ConditionalAccessDevices>(nameof(Devices)); }
            set { BackingStore?.Set(nameof(Devices), value); }
        }
        /// <summary>Locations included in and excluded from the policy.</summary>
        public ConditionalAccessLocations Locations {
            get { return BackingStore?.Get<ConditionalAccessLocations>(nameof(Locations)); }
            set { BackingStore?.Set(nameof(Locations), value); }
        }
        /// <summary>Platforms included in and excluded from the policy.</summary>
        public ConditionalAccessPlatforms Platforms {
            get { return BackingStore?.Get<ConditionalAccessPlatforms>(nameof(Platforms)); }
            set { BackingStore?.Set(nameof(Platforms), value); }
        }
        /// <summary>Sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
        public List<string> SignInRiskLevels {
            get { return BackingStore?.Get<List<string>>(nameof(SignInRiskLevels)); }
            set { BackingStore?.Set(nameof(SignInRiskLevels), value); }
        }
        /// <summary>User risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
        public List<string> UserRiskLevels {
            get { return BackingStore?.Get<List<string>>(nameof(UserRiskLevels)); }
            set { BackingStore?.Set(nameof(UserRiskLevels), value); }
        }
        /// <summary>Users, groups, and roles included in and excluded from the policy. Either users or clientApplications is required.</summary>
        public ConditionalAccessUsers Users {
            get { return BackingStore?.Get<ConditionalAccessUsers>(nameof(Users)); }
            set { BackingStore?.Set(nameof(Users), value); }
        }
        /// <summary>
        /// Instantiates a new conditionalAccessConditionSet and sets the default values.
        /// </summary>
        public ConditionalAccessConditionSet() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConditionalAccessConditionSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessConditionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applications", n => { Applications = n.GetObjectValue<ConditionalAccessApplications>(ConditionalAccessApplications.CreateFromDiscriminatorValue); } },
                {"clientApplications", n => { ClientApplications = n.GetObjectValue<ConditionalAccessClientApplications>(ConditionalAccessClientApplications.CreateFromDiscriminatorValue); } },
                {"clientAppTypes", n => { ClientAppTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"devices", n => { Devices = n.GetObjectValue<ConditionalAccessDevices>(ConditionalAccessDevices.CreateFromDiscriminatorValue); } },
                {"locations", n => { Locations = n.GetObjectValue<ConditionalAccessLocations>(ConditionalAccessLocations.CreateFromDiscriminatorValue); } },
                {"platforms", n => { Platforms = n.GetObjectValue<ConditionalAccessPlatforms>(ConditionalAccessPlatforms.CreateFromDiscriminatorValue); } },
                {"signInRiskLevels", n => { SignInRiskLevels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userRiskLevels", n => { UserRiskLevels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"users", n => { Users = n.GetObjectValue<ConditionalAccessUsers>(ConditionalAccessUsers.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConditionalAccessApplications>("applications", Applications);
            writer.WriteObjectValue<ConditionalAccessClientApplications>("clientApplications", ClientApplications);
            writer.WriteCollectionOfPrimitiveValues<string>("clientAppTypes", ClientAppTypes);
            writer.WriteObjectValue<ConditionalAccessDevices>("devices", Devices);
            writer.WriteObjectValue<ConditionalAccessLocations>("locations", Locations);
            writer.WriteObjectValue<ConditionalAccessPlatforms>("platforms", Platforms);
            writer.WriteCollectionOfPrimitiveValues<string>("signInRiskLevels", SignInRiskLevels);
            writer.WriteCollectionOfPrimitiveValues<string>("userRiskLevels", UserRiskLevels);
            writer.WriteObjectValue<ConditionalAccessUsers>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
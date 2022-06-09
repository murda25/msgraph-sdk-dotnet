using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Device Configuration Setting State for a given device.</summary>
    public class DeviceConfigurationSettingState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Current value of setting on device</summary>
        public string CurrentValue {
            get { return BackingStore?.Get<string>(nameof(CurrentValue)); }
            set { BackingStore?.Set(nameof(CurrentValue), value); }
        }
        /// <summary>Error code for the setting</summary>
        public long? ErrorCode {
            get { return BackingStore?.Get<long?>(nameof(ErrorCode)); }
            set { BackingStore?.Set(nameof(ErrorCode), value); }
        }
        /// <summary>Error description</summary>
        public string ErrorDescription {
            get { return BackingStore?.Get<string>(nameof(ErrorDescription)); }
            set { BackingStore?.Set(nameof(ErrorDescription), value); }
        }
        /// <summary>Name of setting instance that is being reported.</summary>
        public string InstanceDisplayName {
            get { return BackingStore?.Get<string>(nameof(InstanceDisplayName)); }
            set { BackingStore?.Set(nameof(InstanceDisplayName), value); }
        }
        /// <summary>The setting that is being reported</summary>
        public string Setting {
            get { return BackingStore?.Get<string>(nameof(Setting)); }
            set { BackingStore?.Set(nameof(Setting), value); }
        }
        /// <summary>Localized/user friendly setting name that is being reported</summary>
        public string SettingName {
            get { return BackingStore?.Get<string>(nameof(SettingName)); }
            set { BackingStore?.Set(nameof(SettingName), value); }
        }
        /// <summary>Contributing policies</summary>
        public List<SettingSource> Sources {
            get { return BackingStore?.Get<List<SettingSource>>(nameof(Sources)); }
            set { BackingStore?.Set(nameof(Sources), value); }
        }
        /// <summary>The compliance state of the setting. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? State {
            get { return BackingStore?.Get<ComplianceStatus?>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>UserEmail</summary>
        public string UserEmail {
            get { return BackingStore?.Get<string>(nameof(UserEmail)); }
            set { BackingStore?.Set(nameof(UserEmail), value); }
        }
        /// <summary>UserId</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>UserName</summary>
        public string UserName {
            get { return BackingStore?.Get<string>(nameof(UserName)); }
            set { BackingStore?.Set(nameof(UserName), value); }
        }
        /// <summary>UserPrincipalName.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Instantiates a new deviceConfigurationSettingState and sets the default values.
        /// </summary>
        public DeviceConfigurationSettingState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceConfigurationSettingState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfigurationSettingState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"currentValue", n => { CurrentValue = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetLongValue(); } },
                {"errorDescription", n => { ErrorDescription = n.GetStringValue(); } },
                {"instanceDisplayName", n => { InstanceDisplayName = n.GetStringValue(); } },
                {"setting", n => { Setting = n.GetStringValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
                {"sources", n => { Sources = n.GetCollectionOfObjectValues<SettingSource>(SettingSource.CreateFromDiscriminatorValue).ToList(); } },
                {"state", n => { State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userEmail", n => { UserEmail = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currentValue", CurrentValue);
            writer.WriteLongValue("errorCode", ErrorCode);
            writer.WriteStringValue("errorDescription", ErrorDescription);
            writer.WriteStringValue("instanceDisplayName", InstanceDisplayName);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteCollectionOfObjectValues<SettingSource>("sources", Sources);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UserSecurityState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>AAD User object identifier (GUID) - represents the physical/multi-account user entity.</summary>
        public string AadUserId {
            get { return BackingStore?.Get<string>(nameof(AadUserId)); }
            set { BackingStore?.Set(nameof(AadUserId), value); }
        }
        /// <summary>Account name of user account (without Active Directory domain or DNS domain) - (also called mailNickName).</summary>
        public string AccountName {
            get { return BackingStore?.Get<string>(nameof(AccountName)); }
            set { BackingStore?.Set(nameof(AccountName), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>NetBIOS/Active Directory domain of user account (that is, domain/account format).</summary>
        public string DomainName {
            get { return BackingStore?.Get<string>(nameof(DomainName)); }
            set { BackingStore?.Set(nameof(DomainName), value); }
        }
        /// <summary>For email-related alerts - user account&apos;s email &apos;role&apos;. Possible values are: unknown, sender, recipient.</summary>
        public Microsoft.Graph.Models.EmailRole? EmailRole {
            get { return BackingStore?.Get<Microsoft.Graph.Models.EmailRole?>(nameof(EmailRole)); }
            set { BackingStore?.Set(nameof(EmailRole), value); }
        }
        /// <summary>Indicates whether the user logged on through a VPN.</summary>
        public bool? IsVpn {
            get { return BackingStore?.Get<bool?>(nameof(IsVpn)); }
            set { BackingStore?.Set(nameof(IsVpn), value); }
        }
        /// <summary>Time at which the sign-in occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LogonDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LogonDateTime)); }
            set { BackingStore?.Set(nameof(LogonDateTime), value); }
        }
        /// <summary>User sign-in ID.</summary>
        public string LogonId {
            get { return BackingStore?.Get<string>(nameof(LogonId)); }
            set { BackingStore?.Set(nameof(LogonId), value); }
        }
        /// <summary>IP Address the sign-in request originated from.</summary>
        public string LogonIp {
            get { return BackingStore?.Get<string>(nameof(LogonIp)); }
            set { BackingStore?.Set(nameof(LogonIp), value); }
        }
        /// <summary>Location (by IP address mapping) associated with a user sign-in event by this user.</summary>
        public string LogonLocation {
            get { return BackingStore?.Get<string>(nameof(LogonLocation)); }
            set { BackingStore?.Set(nameof(LogonLocation), value); }
        }
        /// <summary>Method of user sign in. Possible values are: unknown, interactive, remoteInteractive, network, batch, service.</summary>
        public Microsoft.Graph.Models.LogonType? LogonType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.LogonType?>(nameof(LogonType)); }
            set { BackingStore?.Set(nameof(LogonType), value); }
        }
        /// <summary>Active Directory (on-premises) Security Identifier (SID) of the user.</summary>
        public string OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string>(nameof(OnPremisesSecurityIdentifier)); }
            set { BackingStore?.Set(nameof(OnPremisesSecurityIdentifier), value); }
        }
        /// <summary>Provider-generated/calculated risk score of the user account. Recommended value range of 0-1, which equates to a percentage.</summary>
        public string RiskScore {
            get { return BackingStore?.Get<string>(nameof(RiskScore)); }
            set { BackingStore?.Set(nameof(RiskScore), value); }
        }
        /// <summary>User account type (group membership), per Windows definition. Possible values are: unknown, standard, power, administrator.</summary>
        public UserAccountSecurityType? UserAccountType {
            get { return BackingStore?.Get<UserAccountSecurityType?>(nameof(UserAccountType)); }
            set { BackingStore?.Set(nameof(UserAccountType), value); }
        }
        /// <summary>User sign-in name - internet format: (user account name)@(user account DNS domain name).</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Instantiates a new userSecurityState and sets the default values.
        /// </summary>
        public UserSecurityState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserSecurityState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSecurityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aadUserId", n => { AadUserId = n.GetStringValue(); } },
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"emailRole", n => { EmailRole = n.GetEnumValue<EmailRole>(); } },
                {"isVpn", n => { IsVpn = n.GetBoolValue(); } },
                {"logonDateTime", n => { LogonDateTime = n.GetDateTimeOffsetValue(); } },
                {"logonId", n => { LogonId = n.GetStringValue(); } },
                {"logonIp", n => { LogonIp = n.GetStringValue(); } },
                {"logonLocation", n => { LogonLocation = n.GetStringValue(); } },
                {"logonType", n => { LogonType = n.GetEnumValue<LogonType>(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"userAccountType", n => { UserAccountType = n.GetEnumValue<UserAccountSecurityType>(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("aadUserId", AadUserId);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteEnumValue<EmailRole>("emailRole", EmailRole);
            writer.WriteBoolValue("isVpn", IsVpn);
            writer.WriteDateTimeOffsetValue("logonDateTime", LogonDateTime);
            writer.WriteStringValue("logonId", LogonId);
            writer.WriteStringValue("logonIp", LogonIp);
            writer.WriteStringValue("logonLocation", LogonLocation);
            writer.WriteEnumValue<LogonType>("logonType", LogonType);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteEnumValue<UserAccountSecurityType>("userAccountType", UserAccountType);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
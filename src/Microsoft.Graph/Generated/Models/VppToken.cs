using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>You purchase multiple licenses for iOS apps through the Apple Volume Purchase Program for Business or Education. This involves setting up an Apple VPP account from the Apple website and uploading the Apple VPP Business or Education token to Intune. You can then synchronize your volume purchase information with Intune and track your volume-purchased app use. You can upload multiple Apple VPP Business or Education tokens.</summary>
    public class VppToken : Entity, IParsable {
        /// <summary>The apple Id associated with the given Apple Volume Purchase Program Token.</summary>
        public string AppleId {
            get { return BackingStore?.Get<string>("appleId"); }
            set { BackingStore?.Set("appleId", value); }
        }
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
        public bool? AutomaticallyUpdateApps {
            get { return BackingStore?.Get<bool?>("automaticallyUpdateApps"); }
            set { BackingStore?.Set("automaticallyUpdateApps", value); }
        }
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
        public string CountryOrRegion {
            get { return BackingStore?.Get<string>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
        /// <summary>The expiration date time of the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Last modification date time associated with the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>Possible sync statuses associated with an Apple Volume Purchase Program token.</summary>
        public VppTokenSyncStatus? LastSyncStatus {
            get { return BackingStore?.Get<VppTokenSyncStatus?>("lastSyncStatus"); }
            set { BackingStore?.Set("lastSyncStatus", value); }
        }
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
        public string OrganizationName {
            get { return BackingStore?.Get<string>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
        /// <summary>Possible states associated with an Apple Volume Purchase Program token.</summary>
        public VppTokenState? State {
            get { return BackingStore?.Get<VppTokenState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</summary>
        public string Token {
            get { return BackingStore?.Get<string>("token"); }
            set { BackingStore?.Set("token", value); }
        }
        /// <summary>Possible types of an Apple Volume Purchase Program token.</summary>
        public Microsoft.Graph.Models.VppTokenAccountType? VppTokenAccountType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.VppTokenAccountType?>("vppTokenAccountType"); }
            set { BackingStore?.Set("vppTokenAccountType", value); }
        }
        /// <summary>
        /// Instantiates a new vppToken and sets the default values.
        /// </summary>
        public VppToken() : base() {
            OdataType = "#microsoft.graph.vppToken";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new VppToken CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VppToken();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleId", n => { AppleId = n.GetStringValue(); } },
                {"automaticallyUpdateApps", n => { AutomaticallyUpdateApps = n.GetBoolValue(); } },
                {"countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncStatus", n => { LastSyncStatus = n.GetEnumValue<VppTokenSyncStatus>(); } },
                {"organizationName", n => { OrganizationName = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<VppTokenState>(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"vppTokenAccountType", n => { VppTokenAccountType = n.GetEnumValue<VppTokenAccountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteBoolValue("automaticallyUpdateApps", AutomaticallyUpdateApps);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<VppTokenSyncStatus>("lastSyncStatus", LastSyncStatus);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteEnumValue<VppTokenState>("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
        }
    }
}
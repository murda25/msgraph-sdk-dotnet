using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.CallRecords {
    public class DirectRoutingLogRow : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of the user or bot who received the call. E.164 format, but may include additional data.</summary>
        public string CalleeNumber {
            get { return BackingStore?.Get<string>(nameof(CalleeNumber)); }
            set { BackingStore?.Set(nameof(CalleeNumber), value); }
        }
        /// <summary>In addition to the SIP codes, Microsoft has own subcodes that indicate the specific issue.</summary>
        public int? CallEndSubReason {
            get { return BackingStore?.Get<int?>(nameof(CallEndSubReason)); }
            set { BackingStore?.Set(nameof(CallEndSubReason), value); }
        }
        /// <summary>Number of the user or bot who made the call. E.164 format, but may include additional data.</summary>
        public string CallerNumber {
            get { return BackingStore?.Get<string>(nameof(CallerNumber)); }
            set { BackingStore?.Set(nameof(CallerNumber), value); }
        }
        /// <summary>Call type and direction.</summary>
        public string CallType {
            get { return BackingStore?.Get<string>(nameof(CallType)); }
            set { BackingStore?.Set(nameof(CallType), value); }
        }
        /// <summary>Identifier for the call that you can use when calling Microsoft Support. GUID.</summary>
        public string CorrelationId {
            get { return BackingStore?.Get<string>(nameof(CorrelationId)); }
            set { BackingStore?.Set(nameof(CorrelationId), value); }
        }
        /// <summary>Duration of the call in seconds.</summary>
        public int? Duration {
            get { return BackingStore?.Get<int?>(nameof(Duration)); }
            set { BackingStore?.Set(nameof(Duration), value); }
        }
        /// <summary>Only exists for successful (fully established) calls. Time when call ended.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EndDateTime)); }
            set { BackingStore?.Set(nameof(EndDateTime), value); }
        }
        /// <summary>Only exists for failed (not fully established) calls.</summary>
        public DateTimeOffset? FailureDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(FailureDateTime)); }
            set { BackingStore?.Set(nameof(FailureDateTime), value); }
        }
        /// <summary>The code with which the call ended, RFC 3261.</summary>
        public int? FinalSipCode {
            get { return BackingStore?.Get<int?>(nameof(FinalSipCode)); }
            set { BackingStore?.Set(nameof(FinalSipCode), value); }
        }
        /// <summary>Description of the SIP code and Microsoft subcode.</summary>
        public string FinalSipCodePhrase {
            get { return BackingStore?.Get<string>(nameof(FinalSipCodePhrase)); }
            set { BackingStore?.Set(nameof(FinalSipCodePhrase), value); }
        }
        /// <summary>Unique call identifier. GUID.</summary>
        public string Id {
            get { return BackingStore?.Get<string>(nameof(Id)); }
            set { BackingStore?.Set(nameof(Id), value); }
        }
        /// <summary>When the initial invite was sent.</summary>
        public DateTimeOffset? InviteDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(InviteDateTime)); }
            set { BackingStore?.Set(nameof(InviteDateTime), value); }
        }
        /// <summary>Indicates if the trunk was enabled for media bypass or not.</summary>
        public bool? MediaBypassEnabled {
            get { return BackingStore?.Get<bool?>(nameof(MediaBypassEnabled)); }
            set { BackingStore?.Set(nameof(MediaBypassEnabled), value); }
        }
        /// <summary>The datacenter used for media path in non-bypass call.</summary>
        public string MediaPathLocation {
            get { return BackingStore?.Get<string>(nameof(MediaPathLocation)); }
            set { BackingStore?.Set(nameof(MediaPathLocation), value); }
        }
        /// <summary>The datacenter used for signaling for both bypass and non-bypass calls.</summary>
        public string SignalingLocation {
            get { return BackingStore?.Get<string>(nameof(SignalingLocation)); }
            set { BackingStore?.Set(nameof(SignalingLocation), value); }
        }
        /// <summary>Call start time.For failed and unanswered calls, this can be equal to invite or failure time.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>Success or attempt.</summary>
        public bool? SuccessfulCall {
            get { return BackingStore?.Get<bool?>(nameof(SuccessfulCall)); }
            set { BackingStore?.Set(nameof(SuccessfulCall), value); }
        }
        /// <summary>Fully qualified domain name of the session border controller.</summary>
        public string TrunkFullyQualifiedDomainName {
            get { return BackingStore?.Get<string>(nameof(TrunkFullyQualifiedDomainName)); }
            set { BackingStore?.Set(nameof(TrunkFullyQualifiedDomainName), value); }
        }
        /// <summary>Display name of the user.</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>(nameof(UserDisplayName)); }
            set { BackingStore?.Set(nameof(UserDisplayName), value); }
        }
        /// <summary>Calling user&apos;s ID in Graph. This and other user info will be null/empty for bot call types. GUID.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>UserPrincipalName (sign-in name) in Azure Active Directory. This is usually the same as user&apos;s SIP Address, and can be same as user&apos;s e-mail address.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Instantiates a new directRoutingLogRow and sets the default values.
        /// </summary>
        public DirectRoutingLogRow() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DirectRoutingLogRow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectRoutingLogRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"calleeNumber", n => { CalleeNumber = n.GetStringValue(); } },
                {"callEndSubReason", n => { CallEndSubReason = n.GetIntValue(); } },
                {"callerNumber", n => { CallerNumber = n.GetStringValue(); } },
                {"callType", n => { CallType = n.GetStringValue(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetIntValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"failureDateTime", n => { FailureDateTime = n.GetDateTimeOffsetValue(); } },
                {"finalSipCode", n => { FinalSipCode = n.GetIntValue(); } },
                {"finalSipCodePhrase", n => { FinalSipCodePhrase = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"inviteDateTime", n => { InviteDateTime = n.GetDateTimeOffsetValue(); } },
                {"mediaBypassEnabled", n => { MediaBypassEnabled = n.GetBoolValue(); } },
                {"mediaPathLocation", n => { MediaPathLocation = n.GetStringValue(); } },
                {"signalingLocation", n => { SignalingLocation = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"successfulCall", n => { SuccessfulCall = n.GetBoolValue(); } },
                {"trunkFullyQualifiedDomainName", n => { TrunkFullyQualifiedDomainName = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("calleeNumber", CalleeNumber);
            writer.WriteIntValue("callEndSubReason", CallEndSubReason);
            writer.WriteStringValue("callerNumber", CallerNumber);
            writer.WriteStringValue("callType", CallType);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteIntValue("duration", Duration);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("failureDateTime", FailureDateTime);
            writer.WriteIntValue("finalSipCode", FinalSipCode);
            writer.WriteStringValue("finalSipCodePhrase", FinalSipCodePhrase);
            writer.WriteStringValue("id", Id);
            writer.WriteDateTimeOffsetValue("inviteDateTime", InviteDateTime);
            writer.WriteBoolValue("mediaBypassEnabled", MediaBypassEnabled);
            writer.WriteStringValue("mediaPathLocation", MediaPathLocation);
            writer.WriteStringValue("signalingLocation", SignalingLocation);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteBoolValue("successfulCall", SuccessfulCall);
            writer.WriteStringValue("trunkFullyQualifiedDomainName", TrunkFullyQualifiedDomainName);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
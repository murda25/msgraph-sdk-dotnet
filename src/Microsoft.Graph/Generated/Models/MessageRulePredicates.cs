using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class MessageRulePredicates : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents the strings that should appear in the body of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> BodyContains {
            get { return BackingStore?.Get<List<string>>(nameof(BodyContains)); }
            set { BackingStore?.Set(nameof(BodyContains), value); }
        }
        /// <summary>Represents the strings that should appear in the body or subject of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> BodyOrSubjectContains {
            get { return BackingStore?.Get<List<string>>(nameof(BodyOrSubjectContains)); }
            set { BackingStore?.Set(nameof(BodyOrSubjectContains), value); }
        }
        /// <summary>Represents the categories that an incoming message should be labeled with in order for the condition or exception to apply.</summary>
        public List<string> Categories {
            get { return BackingStore?.Get<List<string>>(nameof(Categories)); }
            set { BackingStore?.Set(nameof(Categories), value); }
        }
        /// <summary>Represents the specific sender email addresses of an incoming message in order for the condition or exception to apply.</summary>
        public List<Recipient> FromAddresses {
            get { return BackingStore?.Get<List<Recipient>>(nameof(FromAddresses)); }
            set { BackingStore?.Set(nameof(FromAddresses), value); }
        }
        /// <summary>Indicates whether an incoming message must have attachments in order for the condition or exception to apply.</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>(nameof(HasAttachments)); }
            set { BackingStore?.Set(nameof(HasAttachments), value); }
        }
        /// <summary>Represents the strings that appear in the headers of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> HeaderContains {
            get { return BackingStore?.Get<List<string>>(nameof(HeaderContains)); }
            set { BackingStore?.Set(nameof(HeaderContains), value); }
        }
        /// <summary>The importance that is stamped on an incoming message in order for the condition or exception to apply: low, normal, high.</summary>
        public Microsoft.Graph.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Importance?>(nameof(Importance)); }
            set { BackingStore?.Set(nameof(Importance), value); }
        }
        /// <summary>Indicates whether an incoming message must be an approval request in order for the condition or exception to apply.</summary>
        public bool? IsApprovalRequest {
            get { return BackingStore?.Get<bool?>(nameof(IsApprovalRequest)); }
            set { BackingStore?.Set(nameof(IsApprovalRequest), value); }
        }
        /// <summary>Indicates whether an incoming message must be automatically forwarded in order for the condition or exception to apply.</summary>
        public bool? IsAutomaticForward {
            get { return BackingStore?.Get<bool?>(nameof(IsAutomaticForward)); }
            set { BackingStore?.Set(nameof(IsAutomaticForward), value); }
        }
        /// <summary>Indicates whether an incoming message must be an auto reply in order for the condition or exception to apply.</summary>
        public bool? IsAutomaticReply {
            get { return BackingStore?.Get<bool?>(nameof(IsAutomaticReply)); }
            set { BackingStore?.Set(nameof(IsAutomaticReply), value); }
        }
        /// <summary>Indicates whether an incoming message must be encrypted in order for the condition or exception to apply.</summary>
        public bool? IsEncrypted {
            get { return BackingStore?.Get<bool?>(nameof(IsEncrypted)); }
            set { BackingStore?.Set(nameof(IsEncrypted), value); }
        }
        /// <summary>Indicates whether an incoming message must be a meeting request in order for the condition or exception to apply.</summary>
        public bool? IsMeetingRequest {
            get { return BackingStore?.Get<bool?>(nameof(IsMeetingRequest)); }
            set { BackingStore?.Set(nameof(IsMeetingRequest), value); }
        }
        /// <summary>Indicates whether an incoming message must be a meeting response in order for the condition or exception to apply.</summary>
        public bool? IsMeetingResponse {
            get { return BackingStore?.Get<bool?>(nameof(IsMeetingResponse)); }
            set { BackingStore?.Set(nameof(IsMeetingResponse), value); }
        }
        /// <summary>Indicates whether an incoming message must be a non-delivery report in order for the condition or exception to apply.</summary>
        public bool? IsNonDeliveryReport {
            get { return BackingStore?.Get<bool?>(nameof(IsNonDeliveryReport)); }
            set { BackingStore?.Set(nameof(IsNonDeliveryReport), value); }
        }
        /// <summary>Indicates whether an incoming message must be permission controlled (RMS-protected) in order for the condition or exception to apply.</summary>
        public bool? IsPermissionControlled {
            get { return BackingStore?.Get<bool?>(nameof(IsPermissionControlled)); }
            set { BackingStore?.Set(nameof(IsPermissionControlled), value); }
        }
        /// <summary>Indicates whether an incoming message must be a read receipt in order for the condition or exception to apply.</summary>
        public bool? IsReadReceipt {
            get { return BackingStore?.Get<bool?>(nameof(IsReadReceipt)); }
            set { BackingStore?.Set(nameof(IsReadReceipt), value); }
        }
        /// <summary>Indicates whether an incoming message must be S/MIME-signed in order for the condition or exception to apply.</summary>
        public bool? IsSigned {
            get { return BackingStore?.Get<bool?>(nameof(IsSigned)); }
            set { BackingStore?.Set(nameof(IsSigned), value); }
        }
        /// <summary>Indicates whether an incoming message must be a voice mail in order for the condition or exception to apply.</summary>
        public bool? IsVoicemail {
            get { return BackingStore?.Get<bool?>(nameof(IsVoicemail)); }
            set { BackingStore?.Set(nameof(IsVoicemail), value); }
        }
        /// <summary>Represents the flag-for-action value that appears on an incoming message in order for the condition or exception to apply. The possible values are: any, call, doNotForward, followUp, fyi, forward, noResponseNecessary, read, reply, replyToAll, review.</summary>
        public Microsoft.Graph.Models.MessageActionFlag? MessageActionFlag {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MessageActionFlag?>(nameof(MessageActionFlag)); }
            set { BackingStore?.Set(nameof(MessageActionFlag), value); }
        }
        /// <summary>Indicates whether the owner of the mailbox must not be a recipient of an incoming message in order for the condition or exception to apply.</summary>
        public bool? NotSentToMe {
            get { return BackingStore?.Get<bool?>(nameof(NotSentToMe)); }
            set { BackingStore?.Set(nameof(NotSentToMe), value); }
        }
        /// <summary>Represents the strings that appear in either the toRecipients or ccRecipients properties of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> RecipientContains {
            get { return BackingStore?.Get<List<string>>(nameof(RecipientContains)); }
            set { BackingStore?.Set(nameof(RecipientContains), value); }
        }
        /// <summary>Represents the strings that appear in the from property of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> SenderContains {
            get { return BackingStore?.Get<List<string>>(nameof(SenderContains)); }
            set { BackingStore?.Set(nameof(SenderContains), value); }
        }
        /// <summary>Represents the sensitivity level that must be stamped on an incoming message in order for the condition or exception to apply. The possible values are: normal, personal, private, confidential.</summary>
        public Microsoft.Graph.Models.Sensitivity? Sensitivity {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Sensitivity?>(nameof(Sensitivity)); }
            set { BackingStore?.Set(nameof(Sensitivity), value); }
        }
        /// <summary>Indicates whether the owner of the mailbox must be in the ccRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentCcMe {
            get { return BackingStore?.Get<bool?>(nameof(SentCcMe)); }
            set { BackingStore?.Set(nameof(SentCcMe), value); }
        }
        /// <summary>Indicates whether the owner of the mailbox must be the only recipient in an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentOnlyToMe {
            get { return BackingStore?.Get<bool?>(nameof(SentOnlyToMe)); }
            set { BackingStore?.Set(nameof(SentOnlyToMe), value); }
        }
        /// <summary>Represents the email addresses that an incoming message must have been sent to in order for the condition or exception to apply.</summary>
        public List<Recipient> SentToAddresses {
            get { return BackingStore?.Get<List<Recipient>>(nameof(SentToAddresses)); }
            set { BackingStore?.Set(nameof(SentToAddresses), value); }
        }
        /// <summary>Indicates whether the owner of the mailbox must be in the toRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentToMe {
            get { return BackingStore?.Get<bool?>(nameof(SentToMe)); }
            set { BackingStore?.Set(nameof(SentToMe), value); }
        }
        /// <summary>Indicates whether the owner of the mailbox must be in either a toRecipients or ccRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentToOrCcMe {
            get { return BackingStore?.Get<bool?>(nameof(SentToOrCcMe)); }
            set { BackingStore?.Set(nameof(SentToOrCcMe), value); }
        }
        /// <summary>Represents the strings that appear in the subject of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> SubjectContains {
            get { return BackingStore?.Get<List<string>>(nameof(SubjectContains)); }
            set { BackingStore?.Set(nameof(SubjectContains), value); }
        }
        /// <summary>Represents the minimum and maximum sizes (in kilobytes) that an incoming message must fall in between in order for the condition or exception to apply.</summary>
        public SizeRange WithinSizeRange {
            get { return BackingStore?.Get<SizeRange>(nameof(WithinSizeRange)); }
            set { BackingStore?.Set(nameof(WithinSizeRange), value); }
        }
        /// <summary>
        /// Instantiates a new messageRulePredicates and sets the default values.
        /// </summary>
        public MessageRulePredicates() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MessageRulePredicates CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageRulePredicates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bodyContains", n => { BodyContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"bodyOrSubjectContains", n => { BodyOrSubjectContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fromAddresses", n => { FromAddresses = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"headerContains", n => { HeaderContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"isApprovalRequest", n => { IsApprovalRequest = n.GetBoolValue(); } },
                {"isAutomaticForward", n => { IsAutomaticForward = n.GetBoolValue(); } },
                {"isAutomaticReply", n => { IsAutomaticReply = n.GetBoolValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"isMeetingRequest", n => { IsMeetingRequest = n.GetBoolValue(); } },
                {"isMeetingResponse", n => { IsMeetingResponse = n.GetBoolValue(); } },
                {"isNonDeliveryReport", n => { IsNonDeliveryReport = n.GetBoolValue(); } },
                {"isPermissionControlled", n => { IsPermissionControlled = n.GetBoolValue(); } },
                {"isReadReceipt", n => { IsReadReceipt = n.GetBoolValue(); } },
                {"isSigned", n => { IsSigned = n.GetBoolValue(); } },
                {"isVoicemail", n => { IsVoicemail = n.GetBoolValue(); } },
                {"messageActionFlag", n => { MessageActionFlag = n.GetEnumValue<MessageActionFlag>(); } },
                {"notSentToMe", n => { NotSentToMe = n.GetBoolValue(); } },
                {"recipientContains", n => { RecipientContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"senderContains", n => { SenderContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sensitivity", n => { Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"sentCcMe", n => { SentCcMe = n.GetBoolValue(); } },
                {"sentOnlyToMe", n => { SentOnlyToMe = n.GetBoolValue(); } },
                {"sentToAddresses", n => { SentToAddresses = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"sentToMe", n => { SentToMe = n.GetBoolValue(); } },
                {"sentToOrCcMe", n => { SentToOrCcMe = n.GetBoolValue(); } },
                {"subjectContains", n => { SubjectContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"withinSizeRange", n => { WithinSizeRange = n.GetObjectValue<SizeRange>(SizeRange.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("bodyContains", BodyContains);
            writer.WriteCollectionOfPrimitiveValues<string>("bodyOrSubjectContains", BodyOrSubjectContains);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfObjectValues<Recipient>("fromAddresses", FromAddresses);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteCollectionOfPrimitiveValues<string>("headerContains", HeaderContains);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteBoolValue("isApprovalRequest", IsApprovalRequest);
            writer.WriteBoolValue("isAutomaticForward", IsAutomaticForward);
            writer.WriteBoolValue("isAutomaticReply", IsAutomaticReply);
            writer.WriteBoolValue("isEncrypted", IsEncrypted);
            writer.WriteBoolValue("isMeetingRequest", IsMeetingRequest);
            writer.WriteBoolValue("isMeetingResponse", IsMeetingResponse);
            writer.WriteBoolValue("isNonDeliveryReport", IsNonDeliveryReport);
            writer.WriteBoolValue("isPermissionControlled", IsPermissionControlled);
            writer.WriteBoolValue("isReadReceipt", IsReadReceipt);
            writer.WriteBoolValue("isSigned", IsSigned);
            writer.WriteBoolValue("isVoicemail", IsVoicemail);
            writer.WriteEnumValue<MessageActionFlag>("messageActionFlag", MessageActionFlag);
            writer.WriteBoolValue("notSentToMe", NotSentToMe);
            writer.WriteCollectionOfPrimitiveValues<string>("recipientContains", RecipientContains);
            writer.WriteCollectionOfPrimitiveValues<string>("senderContains", SenderContains);
            writer.WriteEnumValue<Sensitivity>("sensitivity", Sensitivity);
            writer.WriteBoolValue("sentCcMe", SentCcMe);
            writer.WriteBoolValue("sentOnlyToMe", SentOnlyToMe);
            writer.WriteCollectionOfObjectValues<Recipient>("sentToAddresses", SentToAddresses);
            writer.WriteBoolValue("sentToMe", SentToMe);
            writer.WriteBoolValue("sentToOrCcMe", SentToOrCcMe);
            writer.WriteCollectionOfPrimitiveValues<string>("subjectContains", SubjectContains);
            writer.WriteObjectValue<SizeRange>("withinSizeRange", WithinSizeRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the collection of invitation entities.</summary>
    public class Invitation : Entity, IParsable {
        /// <summary>The user created as part of the invitation creation. Read-Only</summary>
        public User InvitedUser {
            get { return BackingStore?.Get<User>(nameof(InvitedUser)); }
            set { BackingStore?.Set(nameof(InvitedUser), value); }
        }
        /// <summary>The display name of the user being invited.</summary>
        public string InvitedUserDisplayName {
            get { return BackingStore?.Get<string>(nameof(InvitedUserDisplayName)); }
            set { BackingStore?.Set(nameof(InvitedUserDisplayName), value); }
        }
        /// <summary>The email address of the user being invited. Required. The following special characters are not permitted in the email address:Tilde (~)Exclamation point (!)At sign (@)Number sign (#)Dollar sign ($)Percent (%)Circumflex (^)Ampersand (&amp;)Asterisk (*)Parentheses (( ))Hyphen (-)Plus sign (+)Equal sign (=)Brackets ([ ])Braces ({ })Backslash (/)Slash mark (/)Pipe (`</summary>
        public string InvitedUserEmailAddress {
            get { return BackingStore?.Get<string>(nameof(InvitedUserEmailAddress)); }
            set { BackingStore?.Set(nameof(InvitedUserEmailAddress), value); }
        }
        /// <summary>Additional configuration for the message being sent to the invited user, including customizing message text, language and cc recipient list.</summary>
        public Microsoft.Graph.Models.InvitedUserMessageInfo InvitedUserMessageInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.InvitedUserMessageInfo>(nameof(InvitedUserMessageInfo)); }
            set { BackingStore?.Set(nameof(InvitedUserMessageInfo), value); }
        }
        /// <summary>The userType of the user being invited. By default, this is Guest. You can invite as Member if you&apos;re are company administrator. The default is false.</summary>
        public string InvitedUserType {
            get { return BackingStore?.Get<string>(nameof(InvitedUserType)); }
            set { BackingStore?.Set(nameof(InvitedUserType), value); }
        }
        /// <summary>The URL the user can use to redeem their invitation. Read-only.</summary>
        public string InviteRedeemUrl {
            get { return BackingStore?.Get<string>(nameof(InviteRedeemUrl)); }
            set { BackingStore?.Set(nameof(InviteRedeemUrl), value); }
        }
        /// <summary>The URL user should be redirected to once the invitation is redeemed. Required.</summary>
        public string InviteRedirectUrl {
            get { return BackingStore?.Get<string>(nameof(InviteRedirectUrl)); }
            set { BackingStore?.Set(nameof(InviteRedirectUrl), value); }
        }
        /// <summary>Indicates whether an email should be sent to the user being invited. The default is false.</summary>
        public bool? SendInvitationMessage {
            get { return BackingStore?.Get<bool?>(nameof(SendInvitationMessage)); }
            set { BackingStore?.Set(nameof(SendInvitationMessage), value); }
        }
        /// <summary>The status of the invitation. Possible values: PendingAcceptance, Completed, InProgress, and Error</summary>
        public string Status {
            get { return BackingStore?.Get<string>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Invitation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Invitation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"invitedUser", n => { InvitedUser = n.GetObjectValue<User>(User.CreateFromDiscriminatorValue); } },
                {"invitedUserDisplayName", n => { InvitedUserDisplayName = n.GetStringValue(); } },
                {"invitedUserEmailAddress", n => { InvitedUserEmailAddress = n.GetStringValue(); } },
                {"invitedUserMessageInfo", n => { InvitedUserMessageInfo = n.GetObjectValue<Microsoft.Graph.Models.InvitedUserMessageInfo>(Microsoft.Graph.Models.InvitedUserMessageInfo.CreateFromDiscriminatorValue); } },
                {"invitedUserType", n => { InvitedUserType = n.GetStringValue(); } },
                {"inviteRedeemUrl", n => { InviteRedeemUrl = n.GetStringValue(); } },
                {"inviteRedirectUrl", n => { InviteRedirectUrl = n.GetStringValue(); } },
                {"sendInvitationMessage", n => { SendInvitationMessage = n.GetBoolValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<User>("invitedUser", InvitedUser);
            writer.WriteStringValue("invitedUserDisplayName", InvitedUserDisplayName);
            writer.WriteStringValue("invitedUserEmailAddress", InvitedUserEmailAddress);
            writer.WriteObjectValue<Microsoft.Graph.Models.InvitedUserMessageInfo>("invitedUserMessageInfo", InvitedUserMessageInfo);
            writer.WriteStringValue("invitedUserType", InvitedUserType);
            writer.WriteStringValue("inviteRedeemUrl", InviteRedeemUrl);
            writer.WriteStringValue("inviteRedirectUrl", InviteRedirectUrl);
            writer.WriteBoolValue("sendInvitationMessage", SendInvitationMessage);
            writer.WriteStringValue("status", Status);
        }
    }
}
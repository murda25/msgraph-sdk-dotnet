using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AuthorizationPolicy : PolicyBase, IParsable {
        /// <summary>Indicates whether users can sign up for email based subscriptions.</summary>
        public bool? AllowedToSignUpEmailBasedSubscriptions {
            get { return BackingStore?.Get<bool?>(nameof(AllowedToSignUpEmailBasedSubscriptions)); }
            set { BackingStore?.Set(nameof(AllowedToSignUpEmailBasedSubscriptions), value); }
        }
        /// <summary>Indicates whether the Self-Serve Password Reset feature can be used by users on the tenant.</summary>
        public bool? AllowedToUseSSPR {
            get { return BackingStore?.Get<bool?>(nameof(AllowedToUseSSPR)); }
            set { BackingStore?.Set(nameof(AllowedToUseSSPR), value); }
        }
        /// <summary>Indicates whether a user can join the tenant by email validation.</summary>
        public bool? AllowEmailVerifiedUsersToJoinOrganization {
            get { return BackingStore?.Get<bool?>(nameof(AllowEmailVerifiedUsersToJoinOrganization)); }
            set { BackingStore?.Set(nameof(AllowEmailVerifiedUsersToJoinOrganization), value); }
        }
        /// <summary>Indicates who can invite external users to the organization. Possible values are: none, adminsAndGuestInviters, adminsGuestInvitersAndAllMembers, everyone.  everyone is the default setting for all cloud environments except US Government. See more in the table below.</summary>
        public Microsoft.Graph.Models.AllowInvitesFrom? AllowInvitesFrom {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AllowInvitesFrom?>(nameof(AllowInvitesFrom)); }
            set { BackingStore?.Set(nameof(AllowInvitesFrom), value); }
        }
        /// <summary>To disable the use of MSOL PowerShell set this property to true. This will also disable user-based access to the legacy service endpoint used by MSOL PowerShell. This does not affect Azure AD Connect or Microsoft Graph.</summary>
        public bool? BlockMsolPowerShell {
            get { return BackingStore?.Get<bool?>(nameof(BlockMsolPowerShell)); }
            set { BackingStore?.Set(nameof(BlockMsolPowerShell), value); }
        }
        /// <summary>The defaultUserRolePermissions property</summary>
        public Microsoft.Graph.Models.DefaultUserRolePermissions DefaultUserRolePermissions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DefaultUserRolePermissions>(nameof(DefaultUserRolePermissions)); }
            set { BackingStore?.Set(nameof(DefaultUserRolePermissions), value); }
        }
        /// <summary>Represents role templateId for the role that should be granted to guest user. Refer to List unifiedRoleDefinitions to find the list of available role templates. Currently following roles are supported:  User (a0b1b346-4d3e-4e8b-98f8-753987be4970), Guest User (10dae51f-b6af-4016-8d66-8c2a99b929b3), and Restricted Guest User (2af84b1e-32c8-42b7-82bc-daa82404023b).</summary>
        public string GuestUserRoleId {
            get { return BackingStore?.Get<string>(nameof(GuestUserRoleId)); }
            set { BackingStore?.Set(nameof(GuestUserRoleId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuthorizationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthorizationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedToSignUpEmailBasedSubscriptions", n => { AllowedToSignUpEmailBasedSubscriptions = n.GetBoolValue(); } },
                {"allowedToUseSSPR", n => { AllowedToUseSSPR = n.GetBoolValue(); } },
                {"allowEmailVerifiedUsersToJoinOrganization", n => { AllowEmailVerifiedUsersToJoinOrganization = n.GetBoolValue(); } },
                {"allowInvitesFrom", n => { AllowInvitesFrom = n.GetEnumValue<AllowInvitesFrom>(); } },
                {"blockMsolPowerShell", n => { BlockMsolPowerShell = n.GetBoolValue(); } },
                {"defaultUserRolePermissions", n => { DefaultUserRolePermissions = n.GetObjectValue<Microsoft.Graph.Models.DefaultUserRolePermissions>(Microsoft.Graph.Models.DefaultUserRolePermissions.CreateFromDiscriminatorValue); } },
                {"guestUserRoleId", n => { GuestUserRoleId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowedToSignUpEmailBasedSubscriptions", AllowedToSignUpEmailBasedSubscriptions);
            writer.WriteBoolValue("allowedToUseSSPR", AllowedToUseSSPR);
            writer.WriteBoolValue("allowEmailVerifiedUsersToJoinOrganization", AllowEmailVerifiedUsersToJoinOrganization);
            writer.WriteEnumValue<AllowInvitesFrom>("allowInvitesFrom", AllowInvitesFrom);
            writer.WriteBoolValue("blockMsolPowerShell", BlockMsolPowerShell);
            writer.WriteObjectValue<Microsoft.Graph.Models.DefaultUserRolePermissions>("defaultUserRolePermissions", DefaultUserRolePermissions);
            writer.WriteStringValue("guestUserRoleId", GuestUserRoleId);
        }
    }
}

using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UserRegistrationDetails : Entity, IParsable {
        /// <summary>The isAdmin property</summary>
        public bool? IsAdmin {
            get { return BackingStore?.Get<bool?>("isAdmin"); }
            set { BackingStore?.Set("isAdmin", value); }
        }
        /// <summary>The isMfaCapable property</summary>
        public bool? IsMfaCapable {
            get { return BackingStore?.Get<bool?>("isMfaCapable"); }
            set { BackingStore?.Set("isMfaCapable", value); }
        }
        /// <summary>The isMfaRegistered property</summary>
        public bool? IsMfaRegistered {
            get { return BackingStore?.Get<bool?>("isMfaRegistered"); }
            set { BackingStore?.Set("isMfaRegistered", value); }
        }
        /// <summary>The isPasswordlessCapable property</summary>
        public bool? IsPasswordlessCapable {
            get { return BackingStore?.Get<bool?>("isPasswordlessCapable"); }
            set { BackingStore?.Set("isPasswordlessCapable", value); }
        }
        /// <summary>The isSsprCapable property</summary>
        public bool? IsSsprCapable {
            get { return BackingStore?.Get<bool?>("isSsprCapable"); }
            set { BackingStore?.Set("isSsprCapable", value); }
        }
        /// <summary>The isSsprEnabled property</summary>
        public bool? IsSsprEnabled {
            get { return BackingStore?.Get<bool?>("isSsprEnabled"); }
            set { BackingStore?.Set("isSsprEnabled", value); }
        }
        /// <summary>The isSsprRegistered property</summary>
        public bool? IsSsprRegistered {
            get { return BackingStore?.Get<bool?>("isSsprRegistered"); }
            set { BackingStore?.Set("isSsprRegistered", value); }
        }
        /// <summary>The isSystemPreferredAuthenticationMethodEnabled property</summary>
        public bool? IsSystemPreferredAuthenticationMethodEnabled {
            get { return BackingStore?.Get<bool?>("isSystemPreferredAuthenticationMethodEnabled"); }
            set { BackingStore?.Set("isSystemPreferredAuthenticationMethodEnabled", value); }
        }
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The methodsRegistered property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MethodsRegistered {
            get { return BackingStore?.Get<List<string>?>("methodsRegistered"); }
            set { BackingStore?.Set("methodsRegistered", value); }
        }
#nullable restore
#else
        public List<string> MethodsRegistered {
            get { return BackingStore?.Get<List<string>>("methodsRegistered"); }
            set { BackingStore?.Set("methodsRegistered", value); }
        }
#endif
        /// <summary>The systemPreferredAuthenticationMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemPreferredAuthenticationMethods {
            get { return BackingStore?.Get<List<string>?>("systemPreferredAuthenticationMethods"); }
            set { BackingStore?.Set("systemPreferredAuthenticationMethods", value); }
        }
#nullable restore
#else
        public List<string> SystemPreferredAuthenticationMethods {
            get { return BackingStore?.Get<List<string>>("systemPreferredAuthenticationMethods"); }
            set { BackingStore?.Set("systemPreferredAuthenticationMethods", value); }
        }
#endif
        /// <summary>The userDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>The userPreferredMethodForSecondaryAuthentication property</summary>
        public UserDefaultAuthenticationMethod? UserPreferredMethodForSecondaryAuthentication {
            get { return BackingStore?.Get<UserDefaultAuthenticationMethod?>("userPreferredMethodForSecondaryAuthentication"); }
            set { BackingStore?.Set("userPreferredMethodForSecondaryAuthentication", value); }
        }
        /// <summary>The userPrincipalName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>The userType property</summary>
        public SignInUserType? UserType {
            get { return BackingStore?.Get<SignInUserType?>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserRegistrationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isAdmin", n => { IsAdmin = n.GetBoolValue(); } },
                {"isMfaCapable", n => { IsMfaCapable = n.GetBoolValue(); } },
                {"isMfaRegistered", n => { IsMfaRegistered = n.GetBoolValue(); } },
                {"isPasswordlessCapable", n => { IsPasswordlessCapable = n.GetBoolValue(); } },
                {"isSsprCapable", n => { IsSsprCapable = n.GetBoolValue(); } },
                {"isSsprEnabled", n => { IsSsprEnabled = n.GetBoolValue(); } },
                {"isSsprRegistered", n => { IsSsprRegistered = n.GetBoolValue(); } },
                {"isSystemPreferredAuthenticationMethodEnabled", n => { IsSystemPreferredAuthenticationMethodEnabled = n.GetBoolValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"methodsRegistered", n => { MethodsRegistered = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"systemPreferredAuthenticationMethods", n => { SystemPreferredAuthenticationMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userPreferredMethodForSecondaryAuthentication", n => { UserPreferredMethodForSecondaryAuthentication = n.GetEnumValue<UserDefaultAuthenticationMethod>(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<SignInUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isAdmin", IsAdmin);
            writer.WriteBoolValue("isMfaCapable", IsMfaCapable);
            writer.WriteBoolValue("isMfaRegistered", IsMfaRegistered);
            writer.WriteBoolValue("isPasswordlessCapable", IsPasswordlessCapable);
            writer.WriteBoolValue("isSsprCapable", IsSsprCapable);
            writer.WriteBoolValue("isSsprEnabled", IsSsprEnabled);
            writer.WriteBoolValue("isSsprRegistered", IsSsprRegistered);
            writer.WriteBoolValue("isSystemPreferredAuthenticationMethodEnabled", IsSystemPreferredAuthenticationMethodEnabled);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("methodsRegistered", MethodsRegistered);
            writer.WriteCollectionOfPrimitiveValues<string>("systemPreferredAuthenticationMethods", SystemPreferredAuthenticationMethods);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteEnumValue<UserDefaultAuthenticationMethod>("userPreferredMethodForSecondaryAuthentication", UserPreferredMethodForSecondaryAuthentication);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<SignInUserType>("userType", UserType);
        }
    }
}

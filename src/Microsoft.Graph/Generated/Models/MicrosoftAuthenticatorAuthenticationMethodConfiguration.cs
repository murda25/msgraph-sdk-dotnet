// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class MicrosoftAuthenticatorAuthenticationMethodConfiguration : AuthenticationMethodConfiguration, IParsable 
    {
        /// <summary>A collection of Microsoft Authenticator settings such as application context and location context, and whether they are enabled for all users or specific users only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MicrosoftAuthenticatorFeatureSettings? FeatureSettings {
            get { return BackingStore?.Get<MicrosoftAuthenticatorFeatureSettings?>("featureSettings"); }
            set { BackingStore?.Set("featureSettings", value); }
        }
#nullable restore
#else
        public MicrosoftAuthenticatorFeatureSettings FeatureSettings {
            get { return BackingStore?.Get<MicrosoftAuthenticatorFeatureSettings>("featureSettings"); }
            set { BackingStore?.Set("featureSettings", value); }
        }
#endif
        /// <summary>A collection of groups that are enabled to use the authentication method. Expanded by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MicrosoftAuthenticatorAuthenticationMethodTarget>? IncludeTargets {
            get { return BackingStore?.Get<List<MicrosoftAuthenticatorAuthenticationMethodTarget>?>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#nullable restore
#else
        public List<MicrosoftAuthenticatorAuthenticationMethodTarget> IncludeTargets {
            get { return BackingStore?.Get<List<MicrosoftAuthenticatorAuthenticationMethodTarget>>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#endif
        /// <summary>The isSoftwareOathEnabled property</summary>
        public bool? IsSoftwareOathEnabled {
            get { return BackingStore?.Get<bool?>("isSoftwareOathEnabled"); }
            set { BackingStore?.Set("isSoftwareOathEnabled", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MicrosoftAuthenticatorAuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftAuthenticatorAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftAuthenticatorAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"featureSettings", n => { FeatureSettings = n.GetObjectValue<MicrosoftAuthenticatorFeatureSettings>(MicrosoftAuthenticatorFeatureSettings.CreateFromDiscriminatorValue); } },
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethodTarget>(MicrosoftAuthenticatorAuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isSoftwareOathEnabled", n => { IsSoftwareOathEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftAuthenticatorFeatureSettings>("featureSettings", FeatureSettings);
            writer.WriteCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethodTarget>("includeTargets", IncludeTargets);
            writer.WriteBoolValue("isSoftwareOathEnabled", IsSoftwareOathEnabled);
        }
    }
}

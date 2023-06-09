using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class LoginPageTextVisibilitySettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The hideAccountResetCredentials property</summary>
        public bool? HideAccountResetCredentials {
            get { return BackingStore?.Get<bool?>("hideAccountResetCredentials"); }
            set { BackingStore?.Set("hideAccountResetCredentials", value); }
        }
        /// <summary>The hideCannotAccessYourAccount property</summary>
        public bool? HideCannotAccessYourAccount {
            get { return BackingStore?.Get<bool?>("hideCannotAccessYourAccount"); }
            set { BackingStore?.Set("hideCannotAccessYourAccount", value); }
        }
        /// <summary>The hideForgotMyPassword property</summary>
        public bool? HideForgotMyPassword {
            get { return BackingStore?.Get<bool?>("hideForgotMyPassword"); }
            set { BackingStore?.Set("hideForgotMyPassword", value); }
        }
        /// <summary>The hidePrivacyAndCookies property</summary>
        public bool? HidePrivacyAndCookies {
            get { return BackingStore?.Get<bool?>("hidePrivacyAndCookies"); }
            set { BackingStore?.Set("hidePrivacyAndCookies", value); }
        }
        /// <summary>The hideResetItNow property</summary>
        public bool? HideResetItNow {
            get { return BackingStore?.Get<bool?>("hideResetItNow"); }
            set { BackingStore?.Set("hideResetItNow", value); }
        }
        /// <summary>The hideTermsOfUse property</summary>
        public bool? HideTermsOfUse {
            get { return BackingStore?.Get<bool?>("hideTermsOfUse"); }
            set { BackingStore?.Set("hideTermsOfUse", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new loginPageTextVisibilitySettings and sets the default values.
        /// </summary>
        public LoginPageTextVisibilitySettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LoginPageTextVisibilitySettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LoginPageTextVisibilitySettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hideAccountResetCredentials", n => { HideAccountResetCredentials = n.GetBoolValue(); } },
                {"hideCannotAccessYourAccount", n => { HideCannotAccessYourAccount = n.GetBoolValue(); } },
                {"hideForgotMyPassword", n => { HideForgotMyPassword = n.GetBoolValue(); } },
                {"hidePrivacyAndCookies", n => { HidePrivacyAndCookies = n.GetBoolValue(); } },
                {"hideResetItNow", n => { HideResetItNow = n.GetBoolValue(); } },
                {"hideTermsOfUse", n => { HideTermsOfUse = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hideAccountResetCredentials", HideAccountResetCredentials);
            writer.WriteBoolValue("hideCannotAccessYourAccount", HideCannotAccessYourAccount);
            writer.WriteBoolValue("hideForgotMyPassword", HideForgotMyPassword);
            writer.WriteBoolValue("hidePrivacyAndCookies", HidePrivacyAndCookies);
            writer.WriteBoolValue("hideResetItNow", HideResetItNow);
            writer.WriteBoolValue("hideTermsOfUse", HideTermsOfUse);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

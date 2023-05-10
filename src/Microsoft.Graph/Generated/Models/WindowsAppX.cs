using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class WindowsAppX : MobileLobApp, IParsable {
        /// <summary>Contains properties for Windows architecture.</summary>
        public WindowsArchitecture? ApplicableArchitectures {
            get { return BackingStore?.Get<WindowsArchitecture?>("applicableArchitectures"); }
            set { BackingStore?.Set("applicableArchitectures", value); }
        }
        /// <summary>The identity name of the uploaded app package. For example: &apos;Contoso.DemoApp&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityName {
            get { return BackingStore?.Get<string?>("identityName"); }
            set { BackingStore?.Set("identityName", value); }
        }
#nullable restore
#else
        public string IdentityName {
            get { return BackingStore?.Get<string>("identityName"); }
            set { BackingStore?.Set("identityName", value); }
        }
#endif
        /// <summary>The identity publisher hash of the uploaded app package. This is the hash of the publisher from the manifest. For example: &apos;AB82CD0XYZ&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityPublisherHash {
            get { return BackingStore?.Get<string?>("identityPublisherHash"); }
            set { BackingStore?.Set("identityPublisherHash", value); }
        }
#nullable restore
#else
        public string IdentityPublisherHash {
            get { return BackingStore?.Get<string>("identityPublisherHash"); }
            set { BackingStore?.Set("identityPublisherHash", value); }
        }
#endif
        /// <summary>The identity resource identifier of the uploaded app package. For example: &apos;TestResourceId&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityResourceIdentifier {
            get { return BackingStore?.Get<string?>("identityResourceIdentifier"); }
            set { BackingStore?.Set("identityResourceIdentifier", value); }
        }
#nullable restore
#else
        public string IdentityResourceIdentifier {
            get { return BackingStore?.Get<string>("identityResourceIdentifier"); }
            set { BackingStore?.Set("identityResourceIdentifier", value); }
        }
#endif
        /// <summary>The identity version of the uploaded app package. For example: &apos;1.0.0.0&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityVersion {
            get { return BackingStore?.Get<string?>("identityVersion"); }
            set { BackingStore?.Set("identityVersion", value); }
        }
#nullable restore
#else
        public string IdentityVersion {
            get { return BackingStore?.Get<string>("identityVersion"); }
            set { BackingStore?.Set("identityVersion", value); }
        }
#endif
        /// <summary>When TRUE, indicates that the app is a bundle. When FALSE, indicates that the app is not a bundle. By default, property is set to FALSE.</summary>
        public bool? IsBundle {
            get { return BackingStore?.Get<bool?>("isBundle"); }
            set { BackingStore?.Set("isBundle", value); }
        }
        /// <summary>The minimum operating system required for a Windows mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsMinimumOperatingSystem? MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem?>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#nullable restore
#else
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new WindowsAppX and sets the default values.
        /// </summary>
        public WindowsAppX() : base() {
            OdataType = "#microsoft.graph.windowsAppX";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsAppX CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAppX();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableArchitectures", n => { ApplicableArchitectures = n.GetEnumValue<WindowsArchitecture>(); } },
                {"identityName", n => { IdentityName = n.GetStringValue(); } },
                {"identityPublisherHash", n => { IdentityPublisherHash = n.GetStringValue(); } },
                {"identityResourceIdentifier", n => { IdentityResourceIdentifier = n.GetStringValue(); } },
                {"identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                {"isBundle", n => { IsBundle = n.GetBoolValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<WindowsMinimumOperatingSystem>(WindowsMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WindowsArchitecture>("applicableArchitectures", ApplicableArchitectures);
            writer.WriteStringValue("identityName", IdentityName);
            writer.WriteStringValue("identityPublisherHash", IdentityPublisherHash);
            writer.WriteStringValue("identityResourceIdentifier", IdentityResourceIdentifier);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteBoolValue("isBundle", IsBundle);
            writer.WriteObjectValue<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
        }
    }
}
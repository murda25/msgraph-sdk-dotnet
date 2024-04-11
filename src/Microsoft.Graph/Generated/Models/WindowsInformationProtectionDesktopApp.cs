// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Desktop App for Windows information protection
    /// </summary>
    public class WindowsInformationProtectionDesktopApp : WindowsInformationProtectionApp, IParsable 
    {
        /// <summary>The binary name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BinaryName {
            get { return BackingStore?.Get<string?>("binaryName"); }
            set { BackingStore?.Set("binaryName", value); }
        }
#nullable restore
#else
        public string BinaryName {
            get { return BackingStore?.Get<string>("binaryName"); }
            set { BackingStore?.Set("binaryName", value); }
        }
#endif
        /// <summary>The high binary version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BinaryVersionHigh {
            get { return BackingStore?.Get<string?>("binaryVersionHigh"); }
            set { BackingStore?.Set("binaryVersionHigh", value); }
        }
#nullable restore
#else
        public string BinaryVersionHigh {
            get { return BackingStore?.Get<string>("binaryVersionHigh"); }
            set { BackingStore?.Set("binaryVersionHigh", value); }
        }
#endif
        /// <summary>The lower binary version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BinaryVersionLow {
            get { return BackingStore?.Get<string?>("binaryVersionLow"); }
            set { BackingStore?.Set("binaryVersionLow", value); }
        }
#nullable restore
#else
        public string BinaryVersionLow {
            get { return BackingStore?.Get<string>("binaryVersionLow"); }
            set { BackingStore?.Set("binaryVersionLow", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsInformationProtectionDesktopApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsInformationProtectionDesktopApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionDesktopApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"binaryName", n => { BinaryName = n.GetStringValue(); } },
                {"binaryVersionHigh", n => { BinaryVersionHigh = n.GetStringValue(); } },
                {"binaryVersionLow", n => { BinaryVersionLow = n.GetStringValue(); } },
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
            writer.WriteStringValue("binaryName", BinaryName);
            writer.WriteStringValue("binaryVersionHigh", BinaryVersionHigh);
            writer.WriteStringValue("binaryVersionLow", BinaryVersionLow);
        }
    }
}

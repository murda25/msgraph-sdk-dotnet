// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class PassiveDnsRecord : Artifact, IParsable 
    {
        /// <summary>The artifact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.Artifact? Artifact {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.Artifact?>("artifact"); }
            set { BackingStore?.Set("artifact", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.Artifact Artifact {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.Artifact>("artifact"); }
            set { BackingStore?.Set("artifact", value); }
        }
#endif
        /// <summary>The date and time that this passiveDnsRecord entry was collected by Microsoft. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CollectedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("collectedDateTime"); }
            set { BackingStore?.Set("collectedDateTime", value); }
        }
        /// <summary>The date and time when this passiveDnsRecord entry was first seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The date and time when this passiveDnsRecord entry was most recently seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The parentHost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Host? ParentHost {
            get { return BackingStore?.Get<Host?>("parentHost"); }
            set { BackingStore?.Set("parentHost", value); }
        }
#nullable restore
#else
        public Host ParentHost {
            get { return BackingStore?.Get<Host>("parentHost"); }
            set { BackingStore?.Set("parentHost", value); }
        }
#endif
        /// <summary>The DNS record type for this passiveDnsRecord entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType {
            get { return BackingStore?.Get<string?>("recordType"); }
            set { BackingStore?.Set("recordType", value); }
        }
#nullable restore
#else
        public string RecordType {
            get { return BackingStore?.Get<string>("recordType"); }
            set { BackingStore?.Set("recordType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PassiveDnsRecord"/> and sets the default values.
        /// </summary>
        public PassiveDnsRecord() : base()
        {
            OdataType = "#microsoft.graph.security.passiveDnsRecord";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PassiveDnsRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PassiveDnsRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PassiveDnsRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"artifact", n => { Artifact = n.GetObjectValue<Microsoft.Graph.Models.Security.Artifact>(Microsoft.Graph.Models.Security.Artifact.CreateFromDiscriminatorValue); } },
                {"collectedDateTime", n => { CollectedDateTime = n.GetDateTimeOffsetValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"parentHost", n => { ParentHost = n.GetObjectValue<Host>(Host.CreateFromDiscriminatorValue); } },
                {"recordType", n => { RecordType = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.Artifact>("artifact", Artifact);
            writer.WriteDateTimeOffsetValue("collectedDateTime", CollectedDateTime);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteObjectValue<Host>("parentHost", ParentHost);
            writer.WriteStringValue("recordType", RecordType);
        }
    }
}

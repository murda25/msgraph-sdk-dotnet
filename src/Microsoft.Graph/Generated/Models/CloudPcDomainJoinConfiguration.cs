// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CloudPcDomainJoinConfiguration : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The domainJoinType property</summary>
        public CloudPcDomainJoinType? DomainJoinType {
            get { return BackingStore?.Get<CloudPcDomainJoinType?>("domainJoinType"); }
            set { BackingStore?.Set("domainJoinType", value); }
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
        /// <summary>The onPremisesConnectionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesConnectionId {
            get { return BackingStore?.Get<string?>("onPremisesConnectionId"); }
            set { BackingStore?.Set("onPremisesConnectionId", value); }
        }
#nullable restore
#else
        public string OnPremisesConnectionId {
            get { return BackingStore?.Get<string>("onPremisesConnectionId"); }
            set { BackingStore?.Set("onPremisesConnectionId", value); }
        }
#endif
        /// <summary>The regionGroup property</summary>
        public CloudPcRegionGroup? RegionGroup {
            get { return BackingStore?.Get<CloudPcRegionGroup?>("regionGroup"); }
            set { BackingStore?.Set("regionGroup", value); }
        }
        /// <summary>The regionName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegionName {
            get { return BackingStore?.Get<string?>("regionName"); }
            set { BackingStore?.Set("regionName", value); }
        }
#nullable restore
#else
        public string RegionName {
            get { return BackingStore?.Get<string>("regionName"); }
            set { BackingStore?.Set("regionName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CloudPcDomainJoinConfiguration"/> and sets the default values.
        /// </summary>
        public CloudPcDomainJoinConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcDomainJoinConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CloudPcDomainJoinConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcDomainJoinConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"domainJoinType", n => { DomainJoinType = n.GetEnumValue<CloudPcDomainJoinType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onPremisesConnectionId", n => { OnPremisesConnectionId = n.GetStringValue(); } },
                {"regionGroup", n => { RegionGroup = n.GetEnumValue<CloudPcRegionGroup>(); } },
                {"regionName", n => { RegionName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CloudPcDomainJoinType>("domainJoinType", DomainJoinType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("onPremisesConnectionId", OnPremisesConnectionId);
            writer.WriteEnumValue<CloudPcRegionGroup>("regionGroup", RegionGroup);
            writer.WriteStringValue("regionName", RegionName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

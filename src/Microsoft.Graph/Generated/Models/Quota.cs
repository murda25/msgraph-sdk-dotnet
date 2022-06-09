using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Quota : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Total space consumed by files in the recycle bin, in bytes. Read-only.</summary>
        public long? Deleted {
            get { return BackingStore?.Get<long?>(nameof(Deleted)); }
            set { BackingStore?.Set(nameof(Deleted), value); }
        }
        /// <summary>Total space remaining before reaching the quota limit, in bytes. Read-only.</summary>
        public long? Remaining {
            get { return BackingStore?.Get<long?>(nameof(Remaining)); }
            set { BackingStore?.Set(nameof(Remaining), value); }
        }
        /// <summary>Enumeration value that indicates the state of the storage space. Read-only.</summary>
        public string State {
            get { return BackingStore?.Get<string>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>Information about the drive&apos;s storage quota plans. Only in Personal OneDrive.</summary>
        public Microsoft.Graph.Models.StoragePlanInformation StoragePlanInformation {
            get { return BackingStore?.Get<Microsoft.Graph.Models.StoragePlanInformation>(nameof(StoragePlanInformation)); }
            set { BackingStore?.Set(nameof(StoragePlanInformation), value); }
        }
        /// <summary>Total allowed storage space, in bytes. Read-only.</summary>
        public long? Total {
            get { return BackingStore?.Get<long?>(nameof(Total)); }
            set { BackingStore?.Set(nameof(Total), value); }
        }
        /// <summary>Total space used, in bytes. Read-only.</summary>
        public long? Used {
            get { return BackingStore?.Get<long?>(nameof(Used)); }
            set { BackingStore?.Set(nameof(Used), value); }
        }
        /// <summary>
        /// Instantiates a new quota and sets the default values.
        /// </summary>
        public Quota() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Quota CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Quota();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deleted", n => { Deleted = n.GetLongValue(); } },
                {"remaining", n => { Remaining = n.GetLongValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"storagePlanInformation", n => { StoragePlanInformation = n.GetObjectValue<Microsoft.Graph.Models.StoragePlanInformation>(Microsoft.Graph.Models.StoragePlanInformation.CreateFromDiscriminatorValue); } },
                {"total", n => { Total = n.GetLongValue(); } },
                {"used", n => { Used = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("deleted", Deleted);
            writer.WriteLongValue("remaining", Remaining);
            writer.WriteStringValue("state", State);
            writer.WriteObjectValue<Microsoft.Graph.Models.StoragePlanInformation>("storagePlanInformation", StoragePlanInformation);
            writer.WriteLongValue("total", Total);
            writer.WriteLongValue("used", Used);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
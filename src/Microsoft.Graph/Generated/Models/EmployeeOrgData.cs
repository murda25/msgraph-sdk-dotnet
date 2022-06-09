using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class EmployeeOrgData : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cost center associated with the user. Returned only on $select. Supports $filter.</summary>
        public string CostCenter {
            get { return BackingStore?.Get<string>(nameof(CostCenter)); }
            set { BackingStore?.Set(nameof(CostCenter), value); }
        }
        /// <summary>The name of the division in which the user works. Returned only on $select. Supports $filter.</summary>
        public string Division {
            get { return BackingStore?.Get<string>(nameof(Division)); }
            set { BackingStore?.Set(nameof(Division), value); }
        }
        /// <summary>
        /// Instantiates a new employeeOrgData and sets the default values.
        /// </summary>
        public EmployeeOrgData() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EmployeeOrgData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmployeeOrgData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"costCenter", n => { CostCenter = n.GetStringValue(); } },
                {"division", n => { Division = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("costCenter", CostCenter);
            writer.WriteStringValue("division", Division);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
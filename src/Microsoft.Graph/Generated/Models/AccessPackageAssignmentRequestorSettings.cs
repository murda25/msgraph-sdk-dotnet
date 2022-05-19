using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AccessPackageAssignmentRequestorSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>If false, the requestor is not permitted to include a schedule in their request.</summary>
        public bool? AllowCustomAssignmentSchedule {
            get { return BackingStore?.Get<bool?>(nameof(AllowCustomAssignmentSchedule)); }
            set { BackingStore?.Set(nameof(AllowCustomAssignmentSchedule), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>If true, allows on-behalf-of requestors to create a request to add access for another principal.</summary>
        public bool? EnableOnBehalfRequestorsToAddAccess {
            get { return BackingStore?.Get<bool?>(nameof(EnableOnBehalfRequestorsToAddAccess)); }
            set { BackingStore?.Set(nameof(EnableOnBehalfRequestorsToAddAccess), value); }
        }
        /// <summary>If true, allows on-behalf-of requestors to create a request to remove access for another principal.</summary>
        public bool? EnableOnBehalfRequestorsToRemoveAccess {
            get { return BackingStore?.Get<bool?>(nameof(EnableOnBehalfRequestorsToRemoveAccess)); }
            set { BackingStore?.Set(nameof(EnableOnBehalfRequestorsToRemoveAccess), value); }
        }
        /// <summary>If true, allows on-behalf-of requestors to create a request to update access for another principal.</summary>
        public bool? EnableOnBehalfRequestorsToUpdateAccess {
            get { return BackingStore?.Get<bool?>(nameof(EnableOnBehalfRequestorsToUpdateAccess)); }
            set { BackingStore?.Set(nameof(EnableOnBehalfRequestorsToUpdateAccess), value); }
        }
        /// <summary>If true, allows requestors to create a request to add access for themselves.</summary>
        public bool? EnableTargetsToSelfAddAccess {
            get { return BackingStore?.Get<bool?>(nameof(EnableTargetsToSelfAddAccess)); }
            set { BackingStore?.Set(nameof(EnableTargetsToSelfAddAccess), value); }
        }
        /// <summary>If true, allows requestors to create a request to remove their access.</summary>
        public bool? EnableTargetsToSelfRemoveAccess {
            get { return BackingStore?.Get<bool?>(nameof(EnableTargetsToSelfRemoveAccess)); }
            set { BackingStore?.Set(nameof(EnableTargetsToSelfRemoveAccess), value); }
        }
        /// <summary>If true, allows requestors to create a request to update their access.</summary>
        public bool? EnableTargetsToSelfUpdateAccess {
            get { return BackingStore?.Get<bool?>(nameof(EnableTargetsToSelfUpdateAccess)); }
            set { BackingStore?.Set(nameof(EnableTargetsToSelfUpdateAccess), value); }
        }
        /// <summary>The principals who can request on-behalf-of others.</summary>
        public List<SubjectSet> OnBehalfRequestors {
            get { return BackingStore?.Get<List<SubjectSet>>(nameof(OnBehalfRequestors)); }
            set { BackingStore?.Set(nameof(OnBehalfRequestors), value); }
        }
        /// <summary>
        /// Instantiates a new accessPackageAssignmentRequestorSettings and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestorSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageAssignmentRequestorSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequestorSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowCustomAssignmentSchedule", n => { AllowCustomAssignmentSchedule = n.GetBoolValue(); } },
                {"enableOnBehalfRequestorsToAddAccess", n => { EnableOnBehalfRequestorsToAddAccess = n.GetBoolValue(); } },
                {"enableOnBehalfRequestorsToRemoveAccess", n => { EnableOnBehalfRequestorsToRemoveAccess = n.GetBoolValue(); } },
                {"enableOnBehalfRequestorsToUpdateAccess", n => { EnableOnBehalfRequestorsToUpdateAccess = n.GetBoolValue(); } },
                {"enableTargetsToSelfAddAccess", n => { EnableTargetsToSelfAddAccess = n.GetBoolValue(); } },
                {"enableTargetsToSelfRemoveAccess", n => { EnableTargetsToSelfRemoveAccess = n.GetBoolValue(); } },
                {"enableTargetsToSelfUpdateAccess", n => { EnableTargetsToSelfUpdateAccess = n.GetBoolValue(); } },
                {"onBehalfRequestors", n => { OnBehalfRequestors = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowCustomAssignmentSchedule", AllowCustomAssignmentSchedule);
            writer.WriteBoolValue("enableOnBehalfRequestorsToAddAccess", EnableOnBehalfRequestorsToAddAccess);
            writer.WriteBoolValue("enableOnBehalfRequestorsToRemoveAccess", EnableOnBehalfRequestorsToRemoveAccess);
            writer.WriteBoolValue("enableOnBehalfRequestorsToUpdateAccess", EnableOnBehalfRequestorsToUpdateAccess);
            writer.WriteBoolValue("enableTargetsToSelfAddAccess", EnableTargetsToSelfAddAccess);
            writer.WriteBoolValue("enableTargetsToSelfRemoveAccess", EnableTargetsToSelfRemoveAccess);
            writer.WriteBoolValue("enableTargetsToSelfUpdateAccess", EnableTargetsToSelfUpdateAccess);
            writer.WriteCollectionOfObjectValues<SubjectSet>("onBehalfRequestors", OnBehalfRequestors);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

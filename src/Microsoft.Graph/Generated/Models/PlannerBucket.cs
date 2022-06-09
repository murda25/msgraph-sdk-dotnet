using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class PlannerBucket : Entity, IParsable {
        /// <summary>Name of the bucket.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
        public string OrderHint {
            get { return BackingStore?.Get<string>(nameof(OrderHint)); }
            set { BackingStore?.Set(nameof(OrderHint), value); }
        }
        /// <summary>Plan ID to which the bucket belongs.</summary>
        public string PlanId {
            get { return BackingStore?.Get<string>(nameof(PlanId)); }
            set { BackingStore?.Set(nameof(PlanId), value); }
        }
        /// <summary>Read-only. Nullable. The collection of tasks in the bucket.</summary>
        public List<PlannerTask> Tasks {
            get { return BackingStore?.Get<List<PlannerTask>>(nameof(Tasks)); }
            set { BackingStore?.Set(nameof(Tasks), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PlannerBucket CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerBucket();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"name", n => { Name = n.GetStringValue(); } },
                {"orderHint", n => { OrderHint = n.GetStringValue(); } },
                {"planId", n => { PlanId = n.GetStringValue(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<PlannerTask>(PlannerTask.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("orderHint", OrderHint);
            writer.WriteStringValue("planId", PlanId);
            writer.WriteCollectionOfObjectValues<PlannerTask>("tasks", Tasks);
        }
    }
}
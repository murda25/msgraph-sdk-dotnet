using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class SharedDriveItem : BaseItem, IParsable {
        /// <summary>Used to access the underlying driveItem</summary>
        public Microsoft.Graph.Models.DriveItem DriveItem { get; set; }
        /// <summary>All driveItems contained in the sharing root. This collection cannot be enumerated.</summary>
        public List<Microsoft.Graph.Models.DriveItem> Items { get; set; }
        /// <summary>Used to access the underlying list</summary>
        public Microsoft.Graph.Models.List List { get; set; }
        /// <summary>Used to access the underlying listItem</summary>
        public Microsoft.Graph.Models.ListItem ListItem { get; set; }
        /// <summary>Information about the owner of the shared item being referenced.</summary>
        public IdentitySet Owner { get; set; }
        /// <summary>Used to access the permission representing the underlying sharing link</summary>
        public Microsoft.Graph.Models.Permission Permission { get; set; }
        /// <summary>Used to access the underlying driveItem. Deprecated -- use driveItem instead.</summary>
        public Microsoft.Graph.Models.DriveItem Root { get; set; }
        /// <summary>Used to access the underlying site</summary>
        public Microsoft.Graph.Models.Site Site { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SharedDriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedDriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"driveItem", (o,n) => { (o as SharedDriveItem).DriveItem = n.GetObjectValue<Microsoft.Graph.Models.DriveItem>(Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"items", (o,n) => { (o as SharedDriveItem).Items = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.DriveItem>(Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"list", (o,n) => { (o as SharedDriveItem).List = n.GetObjectValue<Microsoft.Graph.Models.List>(Microsoft.Graph.Models.List.CreateFromDiscriminatorValue); } },
                {"listItem", (o,n) => { (o as SharedDriveItem).ListItem = n.GetObjectValue<Microsoft.Graph.Models.ListItem>(Microsoft.Graph.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"owner", (o,n) => { (o as SharedDriveItem).Owner = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"permission", (o,n) => { (o as SharedDriveItem).Permission = n.GetObjectValue<Microsoft.Graph.Models.Permission>(Microsoft.Graph.Models.Permission.CreateFromDiscriminatorValue); } },
                {"root", (o,n) => { (o as SharedDriveItem).Root = n.GetObjectValue<Microsoft.Graph.Models.DriveItem>(Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"site", (o,n) => { (o as SharedDriveItem).Site = n.GetObjectValue<Microsoft.Graph.Models.Site>(Microsoft.Graph.Models.Site.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.DriveItem>("items", Items);
            writer.WriteObjectValue<Microsoft.Graph.Models.List>("list", List);
            writer.WriteObjectValue<Microsoft.Graph.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteObjectValue<Microsoft.Graph.Models.Permission>("permission", Permission);
            writer.WriteObjectValue<Microsoft.Graph.Models.DriveItem>("root", Root);
            writer.WriteObjectValue<Microsoft.Graph.Models.Site>("site", Site);
        }
    }
}
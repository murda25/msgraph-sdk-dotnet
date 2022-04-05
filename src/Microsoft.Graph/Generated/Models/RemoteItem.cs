using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class RemoteItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identity of the user, device, and application which created the item. Read-only.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>Date and time of item creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Indicates that the remote item is a file. Read-only.</summary>
        public Microsoft.Graph.Models.File File { get; set; }
        /// <summary>Information about the remote item from the local file system. Read-only.</summary>
        public Microsoft.Graph.Models.FileSystemInfo FileSystemInfo { get; set; }
        /// <summary>Indicates that the remote item is a folder. Read-only.</summary>
        public Microsoft.Graph.Models.Folder Folder { get; set; }
        /// <summary>Unique identifier for the remote item in its drive. Read-only.</summary>
        public string Id { get; set; }
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
        public Microsoft.Graph.Models.Image Image { get; set; }
        /// <summary>Identity of the user, device, and application which last modified the item. Read-only.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>Date and time the item was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Optional. Filename of the remote item. Read-only.</summary>
        public string Name { get; set; }
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
        public Microsoft.Graph.Models.Package Package { get; set; }
        /// <summary>Properties of the parent of the remote item. Read-only.</summary>
        public ItemReference ParentReference { get; set; }
        /// <summary>Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.</summary>
        public Microsoft.Graph.Models.Shared Shared { get; set; }
        /// <summary>Provides interop between items in OneDrive for Business and SharePoint with the full set of item identifiers. Read-only.</summary>
        public Microsoft.Graph.Models.SharepointIds SharepointIds { get; set; }
        /// <summary>Size of the remote item. Read-only.</summary>
        public long? Size { get; set; }
        /// <summary>If the current item is also available as a special folder, this facet is returned. Read-only.</summary>
        public Microsoft.Graph.Models.SpecialFolder SpecialFolder { get; set; }
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
        public Microsoft.Graph.Models.Video Video { get; set; }
        /// <summary>DAV compatible URL for the item.</summary>
        public string WebDavUrl { get; set; }
        /// <summary>URL that displays the resource in the browser. Read-only.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new remoteItem and sets the default values.
        /// </summary>
        public RemoteItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RemoteItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"createdBy", (o,n) => { (o as RemoteItem).CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as RemoteItem).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"file", (o,n) => { (o as RemoteItem).File = n.GetObjectValue<Microsoft.Graph.Models.File>(Microsoft.Graph.Models.File.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", (o,n) => { (o as RemoteItem).FileSystemInfo = n.GetObjectValue<Microsoft.Graph.Models.FileSystemInfo>(Microsoft.Graph.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", (o,n) => { (o as RemoteItem).Folder = n.GetObjectValue<Microsoft.Graph.Models.Folder>(Microsoft.Graph.Models.Folder.CreateFromDiscriminatorValue); } },
                {"id", (o,n) => { (o as RemoteItem).Id = n.GetStringValue(); } },
                {"image", (o,n) => { (o as RemoteItem).Image = n.GetObjectValue<Microsoft.Graph.Models.Image>(Microsoft.Graph.Models.Image.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", (o,n) => { (o as RemoteItem).LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as RemoteItem).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as RemoteItem).Name = n.GetStringValue(); } },
                {"package", (o,n) => { (o as RemoteItem).Package = n.GetObjectValue<Microsoft.Graph.Models.Package>(Microsoft.Graph.Models.Package.CreateFromDiscriminatorValue); } },
                {"parentReference", (o,n) => { (o as RemoteItem).ParentReference = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
                {"shared", (o,n) => { (o as RemoteItem).Shared = n.GetObjectValue<Microsoft.Graph.Models.Shared>(Microsoft.Graph.Models.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", (o,n) => { (o as RemoteItem).SharepointIds = n.GetObjectValue<Microsoft.Graph.Models.SharepointIds>(Microsoft.Graph.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", (o,n) => { (o as RemoteItem).Size = n.GetLongValue(); } },
                {"specialFolder", (o,n) => { (o as RemoteItem).SpecialFolder = n.GetObjectValue<Microsoft.Graph.Models.SpecialFolder>(Microsoft.Graph.Models.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"video", (o,n) => { (o as RemoteItem).Video = n.GetObjectValue<Microsoft.Graph.Models.Video>(Microsoft.Graph.Models.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", (o,n) => { (o as RemoteItem).WebDavUrl = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as RemoteItem).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Models.File>("file", File);
            writer.WriteObjectValue<Microsoft.Graph.Models.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<Microsoft.Graph.Models.Folder>("folder", Folder);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<Microsoft.Graph.Models.Image>("image", Image);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Microsoft.Graph.Models.Package>("package", Package);
            writer.WriteObjectValue<ItemReference>("parentReference", ParentReference);
            writer.WriteObjectValue<Microsoft.Graph.Models.Shared>("shared", Shared);
            writer.WriteObjectValue<Microsoft.Graph.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteLongValue("size", Size);
            writer.WriteObjectValue<Microsoft.Graph.Models.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteObjectValue<Microsoft.Graph.Models.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Groups.Item.GroupLifecyclePolicies.Item.RemoveGroup {
    [Obsolete("This class is obsolete. Use RemoveGroupPostResponse instead.")]
    public class RemoveGroupResponse : RemoveGroupPostResponse, IParsable 
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RemoveGroupResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RemoveGroupResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoveGroupResponse();
        }
    }
}

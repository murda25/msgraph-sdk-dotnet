// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Room List.
    /// </summary>
    public partial class RoomList : Place
    {
    
        ///<summary>
        /// The RoomList constructor
        ///</summary>
        public RoomList()
        {
            this.ODataType = "microsoft.graph.roomList";
        }

        /// <summary>
        /// Gets or sets email address.
        /// The email address of the room list.
        /// </summary>
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets rooms.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("rooms")]
        public IRoomListRoomsCollectionPage Rooms { get; set; }

        /// <summary>
        /// Gets or sets roomsNextLink.
        /// </summary>
        [JsonPropertyName("rooms@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoomsNextLink { get; set; }
    
    }
}


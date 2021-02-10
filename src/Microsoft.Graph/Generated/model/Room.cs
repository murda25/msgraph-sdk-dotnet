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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Room.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Room : Place
    {
    
		///<summary>
		/// The Room constructor
		///</summary>
        public Room()
        {
            this.ODataType = "microsoft.graph.room";
        }
	
        /// <summary>
        /// Gets or sets audio device name.
        /// Specifies the name of the audio device in the room.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audioDeviceName", Required = Newtonsoft.Json.Required.Default)]
        public string AudioDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets booking type.
        /// Type of room. Possible values are standard, and reserved.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bookingType", Required = Newtonsoft.Json.Required.Default)]
        public BookingType? BookingType { get; set; }
    
        /// <summary>
        /// Gets or sets building.
        /// Specifies the building name or building number that the room is in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "building", Required = Newtonsoft.Json.Required.Default)]
        public string Building { get; set; }
    
        /// <summary>
        /// Gets or sets capacity.
        /// Specifies the capacity of the room.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "capacity", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Capacity { get; set; }
    
        /// <summary>
        /// Gets or sets display device name.
        /// Specifies the name of the display device in the room.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayDeviceName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets email address.
        /// Email address of the room.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailAddress", Required = Newtonsoft.Json.Required.Default)]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets floor label.
        /// Specifies a descriptive label for the floor, for example, P.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "floorLabel", Required = Newtonsoft.Json.Required.Default)]
        public string FloorLabel { get; set; }
    
        /// <summary>
        /// Gets or sets floor number.
        /// Specifies the floor number that the room is on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "floorNumber", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FloorNumber { get; set; }
    
        /// <summary>
        /// Gets or sets is wheel chair accessible.
        /// Specifies whether the room is wheelchair accessible.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isWheelChairAccessible", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsWheelChairAccessible { get; set; }
    
        /// <summary>
        /// Gets or sets label.
        /// Specifies a descriptive label for the room, for example, a number or name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "label", Required = Newtonsoft.Json.Required.Default)]
        public string Label { get; set; }
    
        /// <summary>
        /// Gets or sets nickname.
        /// Specifies a nickname for the room, for example, 'conf room'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nickname", Required = Newtonsoft.Json.Required.Default)]
        public string Nickname { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// Specifies additional features of the room, for example, details like the type of view or furniture type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets video device name.
        /// Specifies the name of the video device in the room.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "videoDeviceName", Required = Newtonsoft.Json.Required.Default)]
        public string VideoDeviceName { get; set; }
    
    }
}


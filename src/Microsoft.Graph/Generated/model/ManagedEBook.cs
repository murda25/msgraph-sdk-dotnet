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
    /// The type Managed EBook.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ManagedEBook>))]
    public partial class ManagedEBook : Entity
    {
    
        ///<summary>
        /// The internal ManagedEBook constructor
        ///</summary>
        protected internal ManagedEBook()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time when the eBook file was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the eBook.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets information url.
        /// The more information Url.
        /// </summary>
        [JsonPropertyName("informationUrl")]
        public string InformationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets large cover.
        /// Book cover.
        /// </summary>
        [JsonPropertyName("largeCover")]
        public MimeContent LargeCover { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time when the eBook was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets privacy information url.
        /// The privacy statement Url.
        /// </summary>
        [JsonPropertyName("privacyInformationUrl")]
        public string PrivacyInformationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets published date time.
        /// The date and time when the eBook was published.
        /// </summary>
        [JsonPropertyName("publishedDateTime")]
        public DateTimeOffset? PublishedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// Publisher.
        /// </summary>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of assignments for this eBook.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IManagedEBookAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device states.
        /// The list of installation states for this eBook.
        /// </summary>
        [JsonPropertyName("deviceStates")]
        public IManagedEBookDeviceStatesCollectionPage DeviceStates { get; set; }

        /// <summary>
        /// Gets or sets deviceStatesNextLink.
        /// </summary>
        [JsonPropertyName("deviceStates@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceStatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets install summary.
        /// Mobile App Install Summary.
        /// </summary>
        [JsonPropertyName("installSummary")]
        public EBookInstallSummary InstallSummary { get; set; }
    
        /// <summary>
        /// Gets or sets user state summary.
        /// The list of installation states for this eBook.
        /// </summary>
        [JsonPropertyName("userStateSummary")]
        public IManagedEBookUserStateSummaryCollectionPage UserStateSummary { get; set; }

        /// <summary>
        /// Gets or sets userStateSummaryNextLink.
        /// </summary>
        [JsonPropertyName("userStateSummary@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UserStateSummaryNextLink { get; set; }
    
    }
}


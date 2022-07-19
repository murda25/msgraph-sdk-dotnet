// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserOauth2PermissionGrantsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class UserOauth2PermissionGrantsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IUserOauth2PermissionGrantsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserOauth2PermissionGrantsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserOauth2PermissionGrantsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserOauth2PermissionGrantsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserOauth2PermissionGrantsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new UserOauth2PermissionGrantsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IOAuth2PermissionGrantWithReferenceRequestBuilder"/> for the specified UserOAuth2PermissionGrant.
        /// </summary>
        /// <param name="id">The ID for the UserOAuth2PermissionGrant.</param>
        /// <returns>The <see cref="IOAuth2PermissionGrantWithReferenceRequestBuilder"/>.</returns>
        public IOAuth2PermissionGrantWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new OAuth2PermissionGrantWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IUserOauth2PermissionGrantsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IUserOauth2PermissionGrantsCollectionReferencesRequestBuilder"/>.</returns>
        public IUserOauth2PermissionGrantsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new UserOauth2PermissionGrantsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
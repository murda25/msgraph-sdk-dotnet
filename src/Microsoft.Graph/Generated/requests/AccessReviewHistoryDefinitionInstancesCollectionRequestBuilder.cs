// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AccessReviewHistoryDefinitionInstancesCollectionRequestBuilder.
    /// </summary>
    public partial class AccessReviewHistoryDefinitionInstancesCollectionRequestBuilder : BaseRequestBuilder, IAccessReviewHistoryDefinitionInstancesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AccessReviewHistoryDefinitionInstancesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessReviewHistoryDefinitionInstancesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAccessReviewHistoryDefinitionInstancesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAccessReviewHistoryDefinitionInstancesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AccessReviewHistoryDefinitionInstancesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessReviewHistoryInstanceRequestBuilder"/> for the specified AccessReviewHistoryDefinitionAccessReviewHistoryInstance.
        /// </summary>
        /// <param name="id">The ID for the AccessReviewHistoryDefinitionAccessReviewHistoryInstance.</param>
        /// <returns>The <see cref="IAccessReviewHistoryInstanceRequestBuilder"/>.</returns>
        public IAccessReviewHistoryInstanceRequestBuilder this[string id]
        {
            get
            {
                return new AccessReviewHistoryInstanceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
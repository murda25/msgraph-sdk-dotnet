// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EdiscoveryCaseTagsCollectionRequestBuilder.
    /// </summary>
    public partial class EdiscoveryCaseTagsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IEdiscoveryCaseTagsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EdiscoveryCaseTagsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public EdiscoveryCaseTagsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEdiscoveryCaseTagsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEdiscoveryCaseTagsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new EdiscoveryCaseTagsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEdiscoveryReviewTagRequestBuilder"/> for the specified EdiscoveryCaseEdiscoveryReviewTag.
        /// </summary>
        /// <param name="id">The ID for the EdiscoveryCaseEdiscoveryReviewTag.</param>
        /// <returns>The <see cref="IEdiscoveryReviewTagRequestBuilder"/>.</returns>
        public IEdiscoveryReviewTagRequestBuilder this[string id]
        {
            get
            {
                return new EdiscoveryReviewTagRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for EdiscoveryReviewTagAsHierarchy.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryReviewTagAsHierarchyRequestBuilder"/>.</returns>
        public IEdiscoveryReviewTagAsHierarchyRequestBuilder AsHierarchy()
        {
            return new EdiscoveryReviewTagAsHierarchyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.security.asHierarchy"),
                this.Client);
        }
    }
}
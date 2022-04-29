// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AccessReviewSetRequest.
    /// </summary>
    public partial class AccessReviewSetRequest : BaseRequest, IAccessReviewSetRequest
    {
        /// <summary>
        /// Constructs a new AccessReviewSetRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessReviewSetRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AccessReviewSet using POST.
        /// </summary>
        /// <param name="accessReviewSetToCreate">The AccessReviewSet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReviewSet.</returns>
        public async System.Threading.Tasks.Task<AccessReviewSet> CreateAsync(AccessReviewSet accessReviewSetToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AccessReviewSet>(accessReviewSetToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AccessReviewSet using POST and returns a <see cref="GraphResponse{AccessReviewSet}"/> object.
        /// </summary>
        /// <param name="accessReviewSetToCreate">The AccessReviewSet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewSet}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReviewSet>> CreateResponseAsync(AccessReviewSet accessReviewSetToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AccessReviewSet>(accessReviewSetToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AccessReviewSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AccessReviewSet>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AccessReviewSet and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AccessReviewSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessReviewSet.</returns>
        public async System.Threading.Tasks.Task<AccessReviewSet> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AccessReviewSet>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AccessReviewSet and returns a <see cref="GraphResponse{AccessReviewSet}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewSet}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReviewSet>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AccessReviewSet>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessReviewSet using PATCH.
        /// </summary>
        /// <param name="accessReviewSetToUpdate">The AccessReviewSet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessReviewSet.</returns>
        public async System.Threading.Tasks.Task<AccessReviewSet> UpdateAsync(AccessReviewSet accessReviewSetToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AccessReviewSet>(accessReviewSetToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessReviewSet using PATCH and returns a <see cref="GraphResponse{AccessReviewSet}"/> object.
        /// </summary>
        /// <param name="accessReviewSetToUpdate">The AccessReviewSet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessReviewSet}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReviewSet>> UpdateResponseAsync(AccessReviewSet accessReviewSetToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AccessReviewSet>(accessReviewSetToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessReviewSet using PUT.
        /// </summary>
        /// <param name="accessReviewSetToUpdate">The AccessReviewSet object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AccessReviewSet> PutAsync(AccessReviewSet accessReviewSetToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AccessReviewSet>(accessReviewSetToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessReviewSet using PUT and returns a <see cref="GraphResponse{AccessReviewSet}"/> object.
        /// </summary>
        /// <param name="accessReviewSetToUpdate">The AccessReviewSet object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AccessReviewSet}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReviewSet>> PutResponseAsync(AccessReviewSet accessReviewSetToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AccessReviewSet>(accessReviewSetToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewSetRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewSetRequest Expand(Expression<Func<AccessReviewSet, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewSetRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewSetRequest Select(Expression<Func<AccessReviewSet, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="accessReviewSetToInitialize">The <see cref="AccessReviewSet"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AccessReviewSet accessReviewSetToInitialize)
        {

            if (accessReviewSetToInitialize != null)
            {
                if (accessReviewSetToInitialize.Definitions != null && accessReviewSetToInitialize.Definitions.CurrentPage != null)
                {
                    accessReviewSetToInitialize.Definitions.InitializeNextPageRequest(this.Client, accessReviewSetToInitialize.DefinitionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessReviewSetToInitialize.Definitions.AdditionalData = accessReviewSetToInitialize.AdditionalData;
                }
                if (accessReviewSetToInitialize.HistoryDefinitions != null && accessReviewSetToInitialize.HistoryDefinitions.CurrentPage != null)
                {
                    accessReviewSetToInitialize.HistoryDefinitions.InitializeNextPageRequest(this.Client, accessReviewSetToInitialize.HistoryDefinitionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessReviewSetToInitialize.HistoryDefinitions.AdditionalData = accessReviewSetToInitialize.AdditionalData;
                }

            }


        }
    }
}
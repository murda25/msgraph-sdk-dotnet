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
    /// The type BookingCustomQuestionRequest.
    /// </summary>
    public partial class BookingCustomQuestionRequest : BaseRequest, IBookingCustomQuestionRequest
    {
        /// <summary>
        /// Constructs a new BookingCustomQuestionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public BookingCustomQuestionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified BookingCustomQuestion using POST.
        /// </summary>
        /// <param name="bookingCustomQuestionToCreate">The BookingCustomQuestion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingCustomQuestion.</returns>
        public async System.Threading.Tasks.Task<BookingCustomQuestion> CreateAsync(BookingCustomQuestion bookingCustomQuestionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<BookingCustomQuestion>(bookingCustomQuestionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified BookingCustomQuestion using POST and returns a <see cref="GraphResponse{BookingCustomQuestion}"/> object.
        /// </summary>
        /// <param name="bookingCustomQuestionToCreate">The BookingCustomQuestion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingCustomQuestion}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BookingCustomQuestion>> CreateResponseAsync(BookingCustomQuestion bookingCustomQuestionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<BookingCustomQuestion>(bookingCustomQuestionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified BookingCustomQuestion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<BookingCustomQuestion>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified BookingCustomQuestion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified BookingCustomQuestion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BookingCustomQuestion.</returns>
        public async System.Threading.Tasks.Task<BookingCustomQuestion> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<BookingCustomQuestion>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified BookingCustomQuestion and returns a <see cref="GraphResponse{BookingCustomQuestion}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingCustomQuestion}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BookingCustomQuestion>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<BookingCustomQuestion>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified BookingCustomQuestion using PATCH.
        /// </summary>
        /// <param name="bookingCustomQuestionToUpdate">The BookingCustomQuestion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BookingCustomQuestion.</returns>
        public async System.Threading.Tasks.Task<BookingCustomQuestion> UpdateAsync(BookingCustomQuestion bookingCustomQuestionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<BookingCustomQuestion>(bookingCustomQuestionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified BookingCustomQuestion using PATCH and returns a <see cref="GraphResponse{BookingCustomQuestion}"/> object.
        /// </summary>
        /// <param name="bookingCustomQuestionToUpdate">The BookingCustomQuestion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BookingCustomQuestion}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BookingCustomQuestion>> UpdateResponseAsync(BookingCustomQuestion bookingCustomQuestionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<BookingCustomQuestion>(bookingCustomQuestionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified BookingCustomQuestion using PUT.
        /// </summary>
        /// <param name="bookingCustomQuestionToUpdate">The BookingCustomQuestion object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<BookingCustomQuestion> PutAsync(BookingCustomQuestion bookingCustomQuestionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<BookingCustomQuestion>(bookingCustomQuestionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified BookingCustomQuestion using PUT and returns a <see cref="GraphResponse{BookingCustomQuestion}"/> object.
        /// </summary>
        /// <param name="bookingCustomQuestionToUpdate">The BookingCustomQuestion object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{BookingCustomQuestion}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BookingCustomQuestion>> PutResponseAsync(BookingCustomQuestion bookingCustomQuestionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<BookingCustomQuestion>(bookingCustomQuestionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBookingCustomQuestionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBookingCustomQuestionRequest Expand(Expression<Func<BookingCustomQuestion, object>> expandExpression)
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
        public IBookingCustomQuestionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IBookingCustomQuestionRequest Select(Expression<Func<BookingCustomQuestion, object>> selectExpression)
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
        /// <param name="bookingCustomQuestionToInitialize">The <see cref="BookingCustomQuestion"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(BookingCustomQuestion bookingCustomQuestionToInitialize)
        {

        }
    }
}
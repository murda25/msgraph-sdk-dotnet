// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISubjectRightsRequestRequest.
    /// </summary>
    public partial interface ISubjectRightsRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SubjectRightsRequestObject using POST.
        /// </summary>
        /// <param name="subjectRightsRequestObjectToCreate">The SubjectRightsRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SubjectRightsRequestObject.</returns>
        System.Threading.Tasks.Task<SubjectRightsRequestObject> CreateAsync(SubjectRightsRequestObject subjectRightsRequestObjectToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SubjectRightsRequestObject using POST and returns a <see cref="GraphResponse{SubjectRightsRequestObject}"/> object.
        /// </summary>
        /// <param name="subjectRightsRequestObjectToCreate">The SubjectRightsRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SubjectRightsRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SubjectRightsRequestObject>> CreateResponseAsync(SubjectRightsRequestObject subjectRightsRequestObjectToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SubjectRightsRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SubjectRightsRequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SubjectRightsRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SubjectRightsRequestObject.</returns>
        System.Threading.Tasks.Task<SubjectRightsRequestObject> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SubjectRightsRequestObject and returns a <see cref="GraphResponse{SubjectRightsRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SubjectRightsRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SubjectRightsRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SubjectRightsRequestObject using PATCH.
        /// </summary>
        /// <param name="subjectRightsRequestObjectToUpdate">The SubjectRightsRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SubjectRightsRequestObject.</returns>
        System.Threading.Tasks.Task<SubjectRightsRequestObject> UpdateAsync(SubjectRightsRequestObject subjectRightsRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SubjectRightsRequestObject using PATCH and returns a <see cref="GraphResponse{SubjectRightsRequestObject}"/> object.
        /// </summary>
        /// <param name="subjectRightsRequestObjectToUpdate">The SubjectRightsRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SubjectRightsRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SubjectRightsRequestObject>> UpdateResponseAsync(SubjectRightsRequestObject subjectRightsRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SubjectRightsRequestObject using PUT.
        /// </summary>
        /// <param name="subjectRightsRequestObjectToUpdate">The SubjectRightsRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SubjectRightsRequestObject> PutAsync(SubjectRightsRequestObject subjectRightsRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SubjectRightsRequestObject using PUT and returns a <see cref="GraphResponse{SubjectRightsRequestObject}"/> object.
        /// </summary>
        /// <param name="subjectRightsRequestObjectToUpdate">The SubjectRightsRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SubjectRightsRequestObject}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SubjectRightsRequestObject>> PutResponseAsync(SubjectRightsRequestObject subjectRightsRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubjectRightsRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubjectRightsRequestRequest Expand(Expression<Func<SubjectRightsRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISubjectRightsRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISubjectRightsRequestRequest Select(Expression<Func<SubjectRightsRequestObject, object>> selectExpression);

    }
}
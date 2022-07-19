// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IEdiscoveryHoldOperationRequest.
    /// </summary>
    public partial interface IEdiscoveryHoldOperationRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified EdiscoveryHoldOperation using POST.
        /// </summary>
        /// <param name="ediscoveryHoldOperationToCreate">The EdiscoveryHoldOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EdiscoveryHoldOperation.</returns>
        System.Threading.Tasks.Task<EdiscoveryHoldOperation> CreateAsync(EdiscoveryHoldOperation ediscoveryHoldOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EdiscoveryHoldOperation using POST and returns a <see cref="GraphResponse{EdiscoveryHoldOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryHoldOperationToCreate">The EdiscoveryHoldOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryHoldOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EdiscoveryHoldOperation>> CreateResponseAsync(EdiscoveryHoldOperation ediscoveryHoldOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EdiscoveryHoldOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EdiscoveryHoldOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EdiscoveryHoldOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EdiscoveryHoldOperation.</returns>
        System.Threading.Tasks.Task<EdiscoveryHoldOperation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EdiscoveryHoldOperation and returns a <see cref="GraphResponse{EdiscoveryHoldOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryHoldOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EdiscoveryHoldOperation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EdiscoveryHoldOperation using PATCH.
        /// </summary>
        /// <param name="ediscoveryHoldOperationToUpdate">The EdiscoveryHoldOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EdiscoveryHoldOperation.</returns>
        System.Threading.Tasks.Task<EdiscoveryHoldOperation> UpdateAsync(EdiscoveryHoldOperation ediscoveryHoldOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EdiscoveryHoldOperation using PATCH and returns a <see cref="GraphResponse{EdiscoveryHoldOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryHoldOperationToUpdate">The EdiscoveryHoldOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EdiscoveryHoldOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EdiscoveryHoldOperation>> UpdateResponseAsync(EdiscoveryHoldOperation ediscoveryHoldOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EdiscoveryHoldOperation using PUT.
        /// </summary>
        /// <param name="ediscoveryHoldOperationToUpdate">The EdiscoveryHoldOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EdiscoveryHoldOperation> PutAsync(EdiscoveryHoldOperation ediscoveryHoldOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EdiscoveryHoldOperation using PUT and returns a <see cref="GraphResponse{EdiscoveryHoldOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryHoldOperationToUpdate">The EdiscoveryHoldOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EdiscoveryHoldOperation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EdiscoveryHoldOperation>> PutResponseAsync(EdiscoveryHoldOperation ediscoveryHoldOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEdiscoveryHoldOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEdiscoveryHoldOperationRequest Expand(Expression<Func<EdiscoveryHoldOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEdiscoveryHoldOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEdiscoveryHoldOperationRequest Select(Expression<Func<EdiscoveryHoldOperation, object>> selectExpression);

    }
}
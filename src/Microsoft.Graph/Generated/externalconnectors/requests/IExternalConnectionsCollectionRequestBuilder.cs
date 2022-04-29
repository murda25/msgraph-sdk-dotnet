// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IExternalConnectionsCollectionRequestBuilder.
    /// </summary>
    public partial interface IExternalConnectionsCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IExternalConnectionsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IExternalConnectionsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IExternalConnectionRequestBuilder"/> for the specified ExternalConnection.
        /// </summary>
        /// <param name="id">The ID for the ExternalConnection.</param>
        /// <returns>The <see cref="IExternalConnectionRequestBuilder"/>.</returns>
        IExternalConnectionRequestBuilder this[string id] { get; }

        
    }
}
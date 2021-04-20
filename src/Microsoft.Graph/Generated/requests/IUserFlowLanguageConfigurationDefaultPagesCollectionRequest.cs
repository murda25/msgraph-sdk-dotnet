// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IUserFlowLanguageConfigurationDefaultPagesCollectionRequest.
    /// </summary>
    public partial interface IUserFlowLanguageConfigurationDefaultPagesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified UserFlowLanguagePage to the collection via POST.
        /// </summary>
        /// <param name="userFlowLanguagePage">The UserFlowLanguagePage to add.</param>
        /// <returns>The created UserFlowLanguagePage.</returns>
        System.Threading.Tasks.Task<UserFlowLanguagePage> AddAsync(UserFlowLanguagePage userFlowLanguagePage);

        /// <summary>
        /// Adds the specified UserFlowLanguagePage to the collection via POST.
        /// </summary>
        /// <param name="userFlowLanguagePage">The UserFlowLanguagePage to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserFlowLanguagePage.</returns>
        System.Threading.Tasks.Task<UserFlowLanguagePage> AddAsync(UserFlowLanguagePage userFlowLanguagePage, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserFlowLanguageConfigurationDefaultPagesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserFlowLanguageConfigurationDefaultPagesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserFlowLanguageConfigurationDefaultPagesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserFlowLanguageConfigurationDefaultPagesCollectionRequest Expand(Expression<Func<UserFlowLanguagePage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserFlowLanguageConfigurationDefaultPagesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserFlowLanguageConfigurationDefaultPagesCollectionRequest Select(Expression<Func<UserFlowLanguagePage, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IUserFlowLanguageConfigurationDefaultPagesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IUserFlowLanguageConfigurationDefaultPagesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IUserFlowLanguageConfigurationDefaultPagesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IUserFlowLanguageConfigurationDefaultPagesCollectionRequest OrderBy(string value);
    }
}
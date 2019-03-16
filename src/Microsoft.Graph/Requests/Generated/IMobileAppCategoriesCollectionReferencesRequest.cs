// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IMobileAppCategoriesCollectionReferencesRequest.
    /// </summary>
    public partial interface IMobileAppCategoriesCollectionReferencesRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified MobileAppCategory to the collection via POST.
        /// </summary>
        /// <param name="mobileAppCategory">The MobileAppCategory to add.</param>
        System.Threading.Tasks.Task AddAsync(MobileAppCategory mobileAppCategory);

        /// <summary>
        /// Adds the specified MobileAppCategory to the collection via POST.
        /// </summary>
        /// <param name="mobileAppCategory">The MobileAppCategory to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(MobileAppCategory mobileAppCategory, CancellationToken cancellationToken);
    }
}
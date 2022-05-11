// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IRbacApplicationRoleAssignmentSchedulesCollectionRequestBuilder.
    /// </summary>
    public partial interface IRbacApplicationRoleAssignmentSchedulesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleAssignmentSchedulesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleAssignmentSchedulesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUnifiedRoleAssignmentScheduleRequestBuilder"/> for the specified UnifiedRoleAssignmentSchedule.
        /// </summary>
        /// <param name="id">The ID for the UnifiedRoleAssignmentSchedule.</param>
        /// <returns>The <see cref="IUnifiedRoleAssignmentScheduleRequestBuilder"/>.</returns>
        IUnifiedRoleAssignmentScheduleRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for UnifiedRoleAssignmentScheduleFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IUnifiedRoleAssignmentScheduleFilterByCurrentUserRequestBuilder"/>.</returns>
        IUnifiedRoleAssignmentScheduleFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            RoleAssignmentScheduleFilterByCurrentUserOptions on);
    }
}
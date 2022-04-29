// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type CalendarAllowedCalendarSharingRolesCollectionPage.
    /// </summary>
    public partial class CalendarAllowedCalendarSharingRolesCollectionPage : CollectionPage<CalendarRoleType>, ICalendarAllowedCalendarSharingRolesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="ICalendarAllowedCalendarSharingRolesRequest"/> instance.
        /// </summary>
        public ICalendarAllowedCalendarSharingRolesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new CalendarAllowedCalendarSharingRolesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
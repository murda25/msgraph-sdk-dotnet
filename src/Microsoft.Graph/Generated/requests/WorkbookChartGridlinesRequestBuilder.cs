// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartGridlinesRequestBuilder.
    /// </summary>
    public partial class WorkbookChartGridlinesRequestBuilder : EntityRequestBuilder, IWorkbookChartGridlinesRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookChartGridlinesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookChartGridlinesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookChartGridlinesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookChartGridlinesRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookChartGridlinesRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Format.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartGridlinesFormatRequestBuilder"/>.</returns>
        public IWorkbookChartGridlinesFormatRequestBuilder Format
        {
            get
            {
                return new WorkbookChartGridlinesFormatRequestBuilder(this.AppendSegmentToRequestUrl("format"), this.Client);
            }
        }
    
    }
}
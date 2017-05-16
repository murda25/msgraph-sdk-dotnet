// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WorkbookWorksheetRequest.
    /// </summary>
    public partial class WorkbookWorksheetRequest : BaseRequest, IWorkbookWorksheetRequest
    {
        /// <summary>
        /// Constructs a new WorkbookWorksheetRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookWorksheetRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookWorksheet using POST.
        /// </summary>
        /// <param name="workbookWorksheetToCreate">The WorkbookWorksheet to create.</param>
        /// <returns>The created WorkbookWorksheet.</returns>
        public System.Threading.Tasks.Task<WorkbookWorksheet> CreateAsync(WorkbookWorksheet workbookWorksheetToCreate)
        {
            return this.CreateAsync(workbookWorksheetToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookWorksheet using POST.
        /// </summary>
        /// <param name="workbookWorksheetToCreate">The WorkbookWorksheet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookWorksheet.</returns>
        public async System.Threading.Tasks.Task<WorkbookWorksheet> CreateAsync(WorkbookWorksheet workbookWorksheetToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookWorksheet>(workbookWorksheetToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookWorksheet.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookWorksheet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookWorksheet>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookWorksheet.
        /// </summary>
        /// <returns>The WorkbookWorksheet.</returns>
        public System.Threading.Tasks.Task<WorkbookWorksheet> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookWorksheet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookWorksheet.</returns>
        public async System.Threading.Tasks.Task<WorkbookWorksheet> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookWorksheet>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookWorksheet using PATCH.
        /// </summary>
        /// <param name="workbookWorksheetToUpdate">The WorkbookWorksheet to update.</param>
        /// <returns>The updated WorkbookWorksheet.</returns>
        public System.Threading.Tasks.Task<WorkbookWorksheet> UpdateAsync(WorkbookWorksheet workbookWorksheetToUpdate)
        {
            return this.UpdateAsync(workbookWorksheetToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookWorksheet using PATCH.
        /// </summary>
        /// <param name="workbookWorksheetToUpdate">The WorkbookWorksheet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookWorksheet.</returns>
        public async System.Threading.Tasks.Task<WorkbookWorksheet> UpdateAsync(WorkbookWorksheet workbookWorksheetToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookWorksheet>(workbookWorksheetToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookWorksheetRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookWorksheetRequest Expand(Expression<Func<WorkbookWorksheet, object>> expandExpression)
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
        public IWorkbookWorksheetRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookWorksheetRequest Select(Expression<Func<WorkbookWorksheet, object>> selectExpression)
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
        /// <param name="workbookWorksheetToInitialize">The <see cref="WorkbookWorksheet"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookWorksheet workbookWorksheetToInitialize)
        {

            if (workbookWorksheetToInitialize != null && workbookWorksheetToInitialize.AdditionalData != null)
            {

                if (workbookWorksheetToInitialize.Charts != null && workbookWorksheetToInitialize.Charts.CurrentPage != null)
                {
                    workbookWorksheetToInitialize.Charts.AdditionalData = workbookWorksheetToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookWorksheetToInitialize.AdditionalData.TryGetValue("charts@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookWorksheetToInitialize.Charts.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookWorksheetToInitialize.Names != null && workbookWorksheetToInitialize.Names.CurrentPage != null)
                {
                    workbookWorksheetToInitialize.Names.AdditionalData = workbookWorksheetToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookWorksheetToInitialize.AdditionalData.TryGetValue("names@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookWorksheetToInitialize.Names.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookWorksheetToInitialize.PivotTables != null && workbookWorksheetToInitialize.PivotTables.CurrentPage != null)
                {
                    workbookWorksheetToInitialize.PivotTables.AdditionalData = workbookWorksheetToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookWorksheetToInitialize.AdditionalData.TryGetValue("pivotTables@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookWorksheetToInitialize.PivotTables.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookWorksheetToInitialize.Tables != null && workbookWorksheetToInitialize.Tables.CurrentPage != null)
                {
                    workbookWorksheetToInitialize.Tables.AdditionalData = workbookWorksheetToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookWorksheetToInitialize.AdditionalData.TryGetValue("tables@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookWorksheetToInitialize.Tables.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
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
    /// The type EducationAssignmentRequestBuilder.
    /// </summary>
    public partial class EducationAssignmentRequestBuilder : EntityRequestBuilder, IEducationAssignmentRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationAssignmentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationAssignmentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IEducationAssignmentRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IEducationAssignmentRequest Request(IEnumerable<Option> options)
        {
            return new EducationAssignmentRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Categories.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentCategoriesCollectionRequestBuilder"/>.</returns>
        public IEducationAssignmentCategoriesCollectionRequestBuilder Categories
        {
            get
            {
                return new EducationAssignmentCategoriesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("categories"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Resources.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentResourcesCollectionRequestBuilder"/>.</returns>
        public IEducationAssignmentResourcesCollectionRequestBuilder Resources
        {
            get
            {
                return new EducationAssignmentResourcesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("resources"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Rubric.
        /// </summary>
        /// <returns>The <see cref="IEducationRubricRequestBuilder"/>.</returns>
        public IEducationRubricRequestBuilder Rubric
        {
            get
            {
                return new EducationRubricRequestBuilder(this.AppendSegmentToRequestUrl("rubric"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Submissions.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentSubmissionsCollectionRequestBuilder"/>.</returns>
        public IEducationAssignmentSubmissionsCollectionRequestBuilder Submissions
        {
            get
            {
                return new EducationAssignmentSubmissionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("submissions"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for EducationAssignmentPublish.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentPublishRequestBuilder"/>.</returns>
        public IEducationAssignmentPublishRequestBuilder Publish()
        {
            return new EducationAssignmentPublishRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.publish"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for EducationAssignmentSetUpFeedbackResourcesFolder.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentSetUpFeedbackResourcesFolderRequestBuilder"/>.</returns>
        public IEducationAssignmentSetUpFeedbackResourcesFolderRequestBuilder SetUpFeedbackResourcesFolder()
        {
            return new EducationAssignmentSetUpFeedbackResourcesFolderRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setUpFeedbackResourcesFolder"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for EducationAssignmentSetUpResourcesFolder.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentSetUpResourcesFolderRequestBuilder"/>.</returns>
        public IEducationAssignmentSetUpResourcesFolderRequestBuilder SetUpResourcesFolder()
        {
            return new EducationAssignmentSetUpResourcesFolderRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setUpResourcesFolder"),
                this.Client);
        }
    
    }
}

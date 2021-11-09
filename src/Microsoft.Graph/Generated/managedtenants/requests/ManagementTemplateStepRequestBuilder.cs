// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagementTemplateStepRequestBuilder.
    /// </summary>
    public partial class ManagementTemplateStepRequestBuilder : Microsoft.Graph.EntityRequestBuilder, IManagementTemplateStepRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagementTemplateStepRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagementTemplateStepRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IManagementTemplateStepRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IManagementTemplateStepRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagementTemplateStepRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ManagementTemplate.
        /// </summary>
        /// <returns>The <see cref="IManagementTemplateWithReferenceRequestBuilder"/>.</returns>
        public IManagementTemplateWithReferenceRequestBuilder ManagementTemplate
        {
            get
            {
                return new ManagementTemplateWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("managementTemplate"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for StepVersions.
        /// </summary>
        /// <returns>The <see cref="IManagementTemplateStepStepVersionsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IManagementTemplateStepStepVersionsCollectionWithReferencesRequestBuilder StepVersions
        {
            get
            {
                return new ManagementTemplateStepStepVersionsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("stepVersions"), this.Client);
            }
        }
    
    }
}

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedTenantManagementTemplateStepVersionsCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedTenantManagementTemplateStepVersionsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantManagementTemplateStepVersionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedTenantManagementTemplateStepVersionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantManagementTemplateStepVersionsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantManagementTemplateStepVersionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantManagementTemplateStepVersionsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantManagementTemplateStepVersionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagementTemplateStepVersionRequestBuilder"/> for the specified ManagedTenantManagementTemplateStepVersion.
        /// </summary>
        /// <param name="id">The ID for the ManagedTenantManagementTemplateStepVersion.</param>
        /// <returns>The <see cref="IManagementTemplateStepVersionRequestBuilder"/>.</returns>
        public IManagementTemplateStepVersionRequestBuilder this[string id]
        {
            get
            {
                return new ManagementTemplateStepVersionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

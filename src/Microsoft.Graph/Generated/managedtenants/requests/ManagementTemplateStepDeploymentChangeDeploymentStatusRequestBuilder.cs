// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagementTemplateStepDeploymentChangeDeploymentStatusRequestBuilder.
    /// </summary>
    public partial class ManagementTemplateStepDeploymentChangeDeploymentStatusRequestBuilder : Microsoft.Graph.BaseActionMethodRequestBuilder<IManagementTemplateStepDeploymentChangeDeploymentStatusRequest>, IManagementTemplateStepDeploymentChangeDeploymentStatusRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ManagementTemplateStepDeploymentChangeDeploymentStatusRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="tenantId">A tenantId parameter for the OData method call.</param>
        /// <param name="managementTemplateStepId">A managementTemplateStepId parameter for the OData method call.</param>
        /// <param name="status">A status parameter for the OData method call.</param>
        public ManagementTemplateStepDeploymentChangeDeploymentStatusRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            string tenantId,
            string managementTemplateStepId,
            string status)
            : base(requestUrl, client)
        {
            this.SetParameter("tenantId", tenantId, true);
            this.SetParameter("managementTemplateStepId", managementTemplateStepId, true);
            this.SetParameter("status", status, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IManagementTemplateStepDeploymentChangeDeploymentStatusRequest CreateRequest(string functionUrl, IEnumerable<Microsoft.Graph.Option> options)
        {
            var request = new ManagementTemplateStepDeploymentChangeDeploymentStatusRequest(functionUrl, this.Client, options);

            if (this.HasParameter("tenantId"))
            {
                request.RequestBody.TenantId = this.GetParameter<string>("tenantId");
            }

            if (this.HasParameter("managementTemplateStepId"))
            {
                request.RequestBody.ManagementTemplateStepId = this.GetParameter<string>("managementTemplateStepId");
            }

            if (this.HasParameter("status"))
            {
                request.RequestBody.Status = this.GetParameter<string>("status");
            }

            return request;
        }
    }
}

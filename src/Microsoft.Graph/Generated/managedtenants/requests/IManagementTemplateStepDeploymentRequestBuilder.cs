// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IManagementTemplateStepDeploymentRequestBuilder.
    /// </summary>
    public partial interface IManagementTemplateStepDeploymentRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IManagementTemplateStepDeploymentRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IManagementTemplateStepDeploymentRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for TemplateStepVersion.
        /// </summary>
        /// <returns>The <see cref="IManagementTemplateStepVersionWithReferenceRequestBuilder"/>.</returns>
        IManagementTemplateStepVersionWithReferenceRequestBuilder TemplateStepVersion { get; }
    
        /// <summary>
        /// Gets the request builder for ManagementTemplateStepDeploymentChangeDeploymentStatus.
        /// </summary>
        /// <returns>The <see cref="IManagementTemplateStepDeploymentChangeDeploymentStatusRequestBuilder"/>.</returns>
        IManagementTemplateStepDeploymentChangeDeploymentStatusRequestBuilder ChangeDeploymentStatus(
            string tenantId = null,
            string managementTemplateStepId = null,
            string status = null);
    
    }
}

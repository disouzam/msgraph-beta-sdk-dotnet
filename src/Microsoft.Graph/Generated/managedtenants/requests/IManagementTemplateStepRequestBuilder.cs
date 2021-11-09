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
    /// The interface IManagementTemplateStepRequestBuilder.
    /// </summary>
    public partial interface IManagementTemplateStepRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IManagementTemplateStepRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IManagementTemplateStepRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for ManagementTemplate.
        /// </summary>
        /// <returns>The <see cref="IManagementTemplateWithReferenceRequestBuilder"/>.</returns>
        IManagementTemplateWithReferenceRequestBuilder ManagementTemplate { get; }

        /// <summary>
        /// Gets the request builder for StepVersions.
        /// </summary>
        /// <returns>The <see cref="IManagementTemplateStepStepVersionsCollectionWithReferencesRequestBuilder"/>.</returns>
        IManagementTemplateStepStepVersionsCollectionWithReferencesRequestBuilder StepVersions { get; }
    
    }
}

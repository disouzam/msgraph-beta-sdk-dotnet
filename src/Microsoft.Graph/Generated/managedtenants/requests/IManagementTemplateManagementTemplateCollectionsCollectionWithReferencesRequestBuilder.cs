// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagementTemplateManagementTemplateCollectionsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IManagementTemplateManagementTemplateCollectionsCollectionWithReferencesRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagementTemplateManagementTemplateCollectionsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagementTemplateManagementTemplateCollectionsCollectionWithReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IManagementTemplateCollectionWithReferenceRequestBuilder"/> for the specified ManagementTemplateCollection.
        /// </summary>
        /// <param name="id">The ID for the ManagementTemplateCollection.</param>
        /// <returns>The <see cref="IManagementTemplateCollectionWithReferenceRequestBuilder"/>.</returns>
        IManagementTemplateCollectionWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IManagementTemplateManagementTemplateCollectionsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IManagementTemplateManagementTemplateCollectionsCollectionReferencesRequestBuilder"/>.</returns>
        IManagementTemplateManagementTemplateCollectionsCollectionReferencesRequestBuilder References { get; }

    }
}

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<UnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesPage>))]
    public interface IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesPage : ICollectionPage<DirectoryObject>
    {
        /// <summary>
        /// Gets the next page <see cref="IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest"/> instance.
        /// </summary>
        IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}

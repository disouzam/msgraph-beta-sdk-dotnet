// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IRoleScopeTagGetRoleScopeTagsByIdCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<RoleScopeTagGetRoleScopeTagsByIdCollectionPage>))]
    public interface IRoleScopeTagGetRoleScopeTagsByIdCollectionPage : ICollectionPage<RoleScopeTag>
    {
        /// <summary>
        /// Gets the next page <see cref="IRoleScopeTagGetRoleScopeTagsByIdRequest"/> instance.
        /// </summary>
        IRoleScopeTagGetRoleScopeTagsByIdRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}

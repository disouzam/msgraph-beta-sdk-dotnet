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
    /// The interface IUserGetManagedDevicesWithFailedOrPendingAppsCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<UserGetManagedDevicesWithFailedOrPendingAppsCollectionPage>))]
    public interface IUserGetManagedDevicesWithFailedOrPendingAppsCollectionPage : ICollectionPage<ManagedDeviceSummarizedAppState>
    {
        /// <summary>
        /// Gets the next page <see cref="IUserGetManagedDevicesWithFailedOrPendingAppsRequest"/> instance.
        /// </summary>
        IUserGetManagedDevicesWithFailedOrPendingAppsRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}

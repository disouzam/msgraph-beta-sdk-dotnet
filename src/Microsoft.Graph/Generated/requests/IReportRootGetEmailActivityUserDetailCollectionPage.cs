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
    /// The interface IReportRootGetEmailActivityUserDetailCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<ReportRootGetEmailActivityUserDetailCollectionPage>))]
    public interface IReportRootGetEmailActivityUserDetailCollectionPage : ICollectionPage<EmailActivityUserDetail>
    {
        /// <summary>
        /// Gets the next page <see cref="IReportRootGetEmailActivityUserDetailRequest"/> instance.
        /// </summary>
        IReportRootGetEmailActivityUserDetailRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ReportRootGetTeamsDeviceUsageTotalUserCountsCollectionPage.
    /// </summary>
    public partial class ReportRootGetTeamsDeviceUsageTotalUserCountsCollectionPage : CollectionPage<TeamsDeviceUsageUserCounts>, IReportRootGetTeamsDeviceUsageTotalUserCountsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IReportRootGetTeamsDeviceUsageTotalUserCountsRequest"/> instance.
        /// </summary>
        public IReportRootGetTeamsDeviceUsageTotalUserCountsRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ReportRootGetTeamsDeviceUsageTotalUserCountsRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}

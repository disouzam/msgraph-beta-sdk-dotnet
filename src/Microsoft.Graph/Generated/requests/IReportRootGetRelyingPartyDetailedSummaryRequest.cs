// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IReportRootGetRelyingPartyDetailedSummaryRequest.
    /// </summary>
    public partial interface IReportRootGetRelyingPartyDetailedSummaryRequest : IBaseRequest
    {

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetRelyingPartyDetailedSummaryCollectionPage> GetAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRootGetRelyingPartyDetailedSummaryCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="relyingpartydetailedsummary">The RelyingPartyDetailedSummary object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetRelyingPartyDetailedSummaryCollectionPage> PatchAsync(RelyingPartyDetailedSummary relyingpartydetailedsummary,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="relyingpartydetailedsummary">The RelyingPartyDetailedSummary object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRootGetRelyingPartyDetailedSummaryCollectionResponse>> PatchResponseAsync(RelyingPartyDetailedSummary relyingpartydetailedsummary, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="relyingpartydetailedsummary">The RelyingPartyDetailedSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetRelyingPartyDetailedSummaryCollectionPage> PutAsync(RelyingPartyDetailedSummary relyingpartydetailedsummary,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="relyingpartydetailedsummary">The RelyingPartyDetailedSummary object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRootGetRelyingPartyDetailedSummaryCollectionResponse>> PutResponseAsync(RelyingPartyDetailedSummary relyingpartydetailedsummary, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetRelyingPartyDetailedSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetRelyingPartyDetailedSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetRelyingPartyDetailedSummaryRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetRelyingPartyDetailedSummaryRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetRelyingPartyDetailedSummaryRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetRelyingPartyDetailedSummaryRequest OrderBy(string value);
    }
}

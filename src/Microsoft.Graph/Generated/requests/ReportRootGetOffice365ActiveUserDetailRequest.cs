// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ReportRootGetOffice365ActiveUserDetailRequest.
    /// </summary>
    public partial class ReportRootGetOffice365ActiveUserDetailRequest : BaseRequest, IReportRootGetOffice365ActiveUserDetailRequest
    {
        /// <summary>
        /// Constructs a new ReportRootGetOffice365ActiveUserDetailRequest.
        /// </summary>
        public ReportRootGetOffice365ActiveUserDetailRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetOffice365ActiveUserDetailCollectionPage> GetAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var response = await this.SendAsync<ReportRootGetOffice365ActiveUserDetailCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response?.Value?.CurrentPage != null)
            {
                response.Value.InitializeNextPageRequest(this.Client, response.NextLink);
                // Copy the additional data collection to the page itself so that information is not lost
                response.Value.AdditionalData = response.AdditionalData;
                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRootGetOffice365ActiveUserDetailCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ReportRootGetOffice365ActiveUserDetailCollectionResponse>(null, cancellationToken);
        }


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="office365activeuserdetail">The Office365ActiveUserDetail object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetOffice365ActiveUserDetailCollectionPage> PatchAsync(Office365ActiveUserDetail office365activeuserdetail,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.PATCH;
            var response = await this.SendAsync<ReportRootGetOffice365ActiveUserDetailCollectionResponse>(office365activeuserdetail, cancellationToken).ConfigureAwait(false);
            if (response?.Value?.CurrentPage != null)
            {
                response.Value.InitializeNextPageRequest(this.Client, response.NextLink);
                // Copy the additional data collection to the page itself so that information is not lost
                response.Value.AdditionalData = response.AdditionalData;
                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="office365activeuserdetail">The Office365ActiveUserDetail object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRootGetOffice365ActiveUserDetailCollectionResponse>> PatchResponseAsync(Office365ActiveUserDetail office365activeuserdetail, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ReportRootGetOffice365ActiveUserDetailCollectionResponse>(office365activeuserdetail, cancellationToken);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="office365activeuserdetail">The Office365ActiveUserDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetOffice365ActiveUserDetailCollectionPage> PutAsync(Office365ActiveUserDetail office365activeuserdetail,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.PUT;
            var response = await this.SendAsync<ReportRootGetOffice365ActiveUserDetailCollectionResponse>(office365activeuserdetail, cancellationToken).ConfigureAwait(false);
            if (response?.Value?.CurrentPage != null)
            {
                response.Value.InitializeNextPageRequest(this.Client, response.NextLink);
                // Copy the additional data collection to the page itself so that information is not lost
                response.Value.AdditionalData = response.AdditionalData;
                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="office365activeuserdetail">The Office365ActiveUserDetail object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRootGetOffice365ActiveUserDetailCollectionResponse>> PutResponseAsync(Office365ActiveUserDetail office365activeuserdetail, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ReportRootGetOffice365ActiveUserDetailCollectionResponse>(office365activeuserdetail, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserDetailRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserDetailRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserDetailRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserDetailRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserDetailRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserDetailRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}

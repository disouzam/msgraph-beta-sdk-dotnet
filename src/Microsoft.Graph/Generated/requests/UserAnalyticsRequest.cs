// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type UserAnalyticsRequest.
    /// </summary>
    public partial class UserAnalyticsRequest : BaseRequest, IUserAnalyticsRequest
    {
        /// <summary>
        /// Constructs a new UserAnalyticsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserAnalyticsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserAnalytics using POST.
        /// </summary>
        /// <param name="userAnalyticsToCreate">The UserAnalytics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserAnalytics.</returns>
        public async System.Threading.Tasks.Task<UserAnalytics> CreateAsync(UserAnalytics userAnalyticsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UserAnalytics>(userAnalyticsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UserAnalytics using POST and returns a <see cref="GraphResponse{UserAnalytics}"/> object.
        /// </summary>
        /// <param name="userAnalyticsToCreate">The UserAnalytics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserAnalytics}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserAnalytics>> CreateResponseAsync(UserAnalytics userAnalyticsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UserAnalytics>(userAnalyticsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UserAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UserAnalytics>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UserAnalytics and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UserAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserAnalytics.</returns>
        public async System.Threading.Tasks.Task<UserAnalytics> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UserAnalytics>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UserAnalytics and returns a <see cref="GraphResponse{UserAnalytics}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserAnalytics}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserAnalytics>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UserAnalytics>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserAnalytics using PATCH.
        /// </summary>
        /// <param name="userAnalyticsToUpdate">The UserAnalytics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserAnalytics.</returns>
        public async System.Threading.Tasks.Task<UserAnalytics> UpdateAsync(UserAnalytics userAnalyticsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UserAnalytics>(userAnalyticsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserAnalytics using PATCH and returns a <see cref="GraphResponse{UserAnalytics}"/> object.
        /// </summary>
        /// <param name="userAnalyticsToUpdate">The UserAnalytics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserAnalytics}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserAnalytics>> UpdateResponseAsync(UserAnalytics userAnalyticsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UserAnalytics>(userAnalyticsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserAnalytics using PUT.
        /// </summary>
        /// <param name="userAnalyticsToUpdate">The UserAnalytics object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UserAnalytics> PutAsync(UserAnalytics userAnalyticsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UserAnalytics>(userAnalyticsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserAnalytics using PUT and returns a <see cref="GraphResponse{UserAnalytics}"/> object.
        /// </summary>
        /// <param name="userAnalyticsToUpdate">The UserAnalytics object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UserAnalytics}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserAnalytics>> PutResponseAsync(UserAnalytics userAnalyticsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UserAnalytics>(userAnalyticsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserAnalyticsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserAnalyticsRequest Expand(Expression<Func<UserAnalytics, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserAnalyticsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserAnalyticsRequest Select(Expression<Func<UserAnalytics, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="userAnalyticsToInitialize">The <see cref="UserAnalytics"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserAnalytics userAnalyticsToInitialize)
        {

            if (userAnalyticsToInitialize != null)
            {
                if (userAnalyticsToInitialize.ActivityStatistics != null && userAnalyticsToInitialize.ActivityStatistics.CurrentPage != null)
                {
                    userAnalyticsToInitialize.ActivityStatistics.InitializeNextPageRequest(this.Client, userAnalyticsToInitialize.ActivityStatisticsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userAnalyticsToInitialize.ActivityStatistics.AdditionalData = userAnalyticsToInitialize.AdditionalData;
                }

            }


        }
    }
}

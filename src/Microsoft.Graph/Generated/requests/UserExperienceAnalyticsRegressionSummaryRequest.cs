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
    /// The type UserExperienceAnalyticsRegressionSummaryRequest.
    /// </summary>
    public partial class UserExperienceAnalyticsRegressionSummaryRequest : BaseRequest, IUserExperienceAnalyticsRegressionSummaryRequest
    {
        /// <summary>
        /// Constructs a new UserExperienceAnalyticsRegressionSummaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserExperienceAnalyticsRegressionSummaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsRegressionSummary using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsRegressionSummaryToCreate">The UserExperienceAnalyticsRegressionSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsRegressionSummary.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> CreateAsync(UserExperienceAnalyticsRegressionSummary userExperienceAnalyticsRegressionSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UserExperienceAnalyticsRegressionSummary>(userExperienceAnalyticsRegressionSummaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsRegressionSummary using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsRegressionSummary}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsRegressionSummaryToCreate">The UserExperienceAnalyticsRegressionSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsRegressionSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsRegressionSummary>> CreateResponseAsync(UserExperienceAnalyticsRegressionSummary userExperienceAnalyticsRegressionSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsRegressionSummary>(userExperienceAnalyticsRegressionSummaryToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsRegressionSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UserExperienceAnalyticsRegressionSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsRegressionSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsRegressionSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsRegressionSummary.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UserExperienceAnalyticsRegressionSummary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsRegressionSummary and returns a <see cref="GraphResponse{UserExperienceAnalyticsRegressionSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsRegressionSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsRegressionSummary>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsRegressionSummary>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsRegressionSummary using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsRegressionSummaryToUpdate">The UserExperienceAnalyticsRegressionSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsRegressionSummary.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> UpdateAsync(UserExperienceAnalyticsRegressionSummary userExperienceAnalyticsRegressionSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UserExperienceAnalyticsRegressionSummary>(userExperienceAnalyticsRegressionSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsRegressionSummary using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsRegressionSummary}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsRegressionSummaryToUpdate">The UserExperienceAnalyticsRegressionSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsRegressionSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsRegressionSummary>> UpdateResponseAsync(UserExperienceAnalyticsRegressionSummary userExperienceAnalyticsRegressionSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsRegressionSummary>(userExperienceAnalyticsRegressionSummaryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsRegressionSummary using PUT.
        /// </summary>
        /// <param name="userExperienceAnalyticsRegressionSummaryToUpdate">The UserExperienceAnalyticsRegressionSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> PutAsync(UserExperienceAnalyticsRegressionSummary userExperienceAnalyticsRegressionSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UserExperienceAnalyticsRegressionSummary>(userExperienceAnalyticsRegressionSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsRegressionSummary using PUT and returns a <see cref="GraphResponse{UserExperienceAnalyticsRegressionSummary}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsRegressionSummaryToUpdate">The UserExperienceAnalyticsRegressionSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UserExperienceAnalyticsRegressionSummary}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsRegressionSummary>> PutResponseAsync(UserExperienceAnalyticsRegressionSummary userExperienceAnalyticsRegressionSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsRegressionSummary>(userExperienceAnalyticsRegressionSummaryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsRegressionSummaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsRegressionSummaryRequest Expand(Expression<Func<UserExperienceAnalyticsRegressionSummary, object>> expandExpression)
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
        public IUserExperienceAnalyticsRegressionSummaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsRegressionSummaryRequest Select(Expression<Func<UserExperienceAnalyticsRegressionSummary, object>> selectExpression)
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
        /// <param name="userExperienceAnalyticsRegressionSummaryToInitialize">The <see cref="UserExperienceAnalyticsRegressionSummary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserExperienceAnalyticsRegressionSummary userExperienceAnalyticsRegressionSummaryToInitialize)
        {

            if (userExperienceAnalyticsRegressionSummaryToInitialize != null && userExperienceAnalyticsRegressionSummaryToInitialize.AdditionalData != null)
            {

                if (userExperienceAnalyticsRegressionSummaryToInitialize.ManufacturerRegression != null && userExperienceAnalyticsRegressionSummaryToInitialize.ManufacturerRegression.CurrentPage != null)
                {
                    userExperienceAnalyticsRegressionSummaryToInitialize.ManufacturerRegression.AdditionalData = userExperienceAnalyticsRegressionSummaryToInitialize.AdditionalData;

                    object nextPageLink;
                    userExperienceAnalyticsRegressionSummaryToInitialize.AdditionalData.TryGetValue("manufacturerRegression@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userExperienceAnalyticsRegressionSummaryToInitialize.ManufacturerRegression.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userExperienceAnalyticsRegressionSummaryToInitialize.ModelRegression != null && userExperienceAnalyticsRegressionSummaryToInitialize.ModelRegression.CurrentPage != null)
                {
                    userExperienceAnalyticsRegressionSummaryToInitialize.ModelRegression.AdditionalData = userExperienceAnalyticsRegressionSummaryToInitialize.AdditionalData;

                    object nextPageLink;
                    userExperienceAnalyticsRegressionSummaryToInitialize.AdditionalData.TryGetValue("modelRegression@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userExperienceAnalyticsRegressionSummaryToInitialize.ModelRegression.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userExperienceAnalyticsRegressionSummaryToInitialize.OperatingSystemRegression != null && userExperienceAnalyticsRegressionSummaryToInitialize.OperatingSystemRegression.CurrentPage != null)
                {
                    userExperienceAnalyticsRegressionSummaryToInitialize.OperatingSystemRegression.AdditionalData = userExperienceAnalyticsRegressionSummaryToInitialize.AdditionalData;

                    object nextPageLink;
                    userExperienceAnalyticsRegressionSummaryToInitialize.AdditionalData.TryGetValue("operatingSystemRegression@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userExperienceAnalyticsRegressionSummaryToInitialize.OperatingSystemRegression.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}

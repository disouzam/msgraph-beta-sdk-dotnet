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
    /// The type GroupPolicyCategoryRequest.
    /// </summary>
    public partial class GroupPolicyCategoryRequest : BaseRequest, IGroupPolicyCategoryRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyCategoryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyCategoryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyCategory using POST.
        /// </summary>
        /// <param name="groupPolicyCategoryToCreate">The GroupPolicyCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyCategory.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyCategory> CreateAsync(GroupPolicyCategory groupPolicyCategoryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupPolicyCategory>(groupPolicyCategoryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupPolicyCategory using POST and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <param name="groupPolicyCategoryToCreate">The GroupPolicyCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> CreateResponseAsync(GroupPolicyCategory groupPolicyCategoryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupPolicyCategory>(groupPolicyCategoryToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupPolicyCategory>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GroupPolicyCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyCategory.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyCategory> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupPolicyCategory>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyCategory and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupPolicyCategory>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyCategory using PATCH.
        /// </summary>
        /// <param name="groupPolicyCategoryToUpdate">The GroupPolicyCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyCategory.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyCategory> UpdateAsync(GroupPolicyCategory groupPolicyCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupPolicyCategory>(groupPolicyCategoryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyCategory using PATCH and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <param name="groupPolicyCategoryToUpdate">The GroupPolicyCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyCategory}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> UpdateResponseAsync(GroupPolicyCategory groupPolicyCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupPolicyCategory>(groupPolicyCategoryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyCategory using PUT.
        /// </summary>
        /// <param name="groupPolicyCategoryToUpdate">The GroupPolicyCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyCategory> PutAsync(GroupPolicyCategory groupPolicyCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<GroupPolicyCategory>(groupPolicyCategoryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyCategory using PUT and returns a <see cref="GraphResponse{GroupPolicyCategory}"/> object.
        /// </summary>
        /// <param name="groupPolicyCategoryToUpdate">The GroupPolicyCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{GroupPolicyCategory}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyCategory>> PutResponseAsync(GroupPolicyCategory groupPolicyCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<GroupPolicyCategory>(groupPolicyCategoryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyCategoryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyCategoryRequest Expand(Expression<Func<GroupPolicyCategory, object>> expandExpression)
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
        public IGroupPolicyCategoryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyCategoryRequest Select(Expression<Func<GroupPolicyCategory, object>> selectExpression)
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
        /// <param name="groupPolicyCategoryToInitialize">The <see cref="GroupPolicyCategory"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyCategory groupPolicyCategoryToInitialize)
        {

            if (groupPolicyCategoryToInitialize != null && groupPolicyCategoryToInitialize.AdditionalData != null)
            {

                if (groupPolicyCategoryToInitialize.Children != null && groupPolicyCategoryToInitialize.Children.CurrentPage != null)
                {
                    groupPolicyCategoryToInitialize.Children.AdditionalData = groupPolicyCategoryToInitialize.AdditionalData;

                    object nextPageLink;
                    groupPolicyCategoryToInitialize.AdditionalData.TryGetValue("children@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupPolicyCategoryToInitialize.Children.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupPolicyCategoryToInitialize.Definitions != null && groupPolicyCategoryToInitialize.Definitions.CurrentPage != null)
                {
                    groupPolicyCategoryToInitialize.Definitions.AdditionalData = groupPolicyCategoryToInitialize.AdditionalData;

                    object nextPageLink;
                    groupPolicyCategoryToInitialize.AdditionalData.TryGetValue("definitions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupPolicyCategoryToInitialize.Definitions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}

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
    /// The type B2cIdentityUserFlowRequest.
    /// </summary>
    public partial class B2cIdentityUserFlowRequest : BaseRequest, IB2cIdentityUserFlowRequest
    {
        /// <summary>
        /// Constructs a new B2cIdentityUserFlowRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public B2cIdentityUserFlowRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified B2cIdentityUserFlow using POST.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToCreate">The B2cIdentityUserFlow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created B2cIdentityUserFlow.</returns>
        public async System.Threading.Tasks.Task<B2cIdentityUserFlow> CreateAsync(B2cIdentityUserFlow b2cIdentityUserFlowToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<B2cIdentityUserFlow>(b2cIdentityUserFlowToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified B2cIdentityUserFlow using POST and returns a <see cref="GraphResponse{B2cIdentityUserFlow}"/> object.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToCreate">The B2cIdentityUserFlow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{B2cIdentityUserFlow}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2cIdentityUserFlow>> CreateResponseAsync(B2cIdentityUserFlow b2cIdentityUserFlowToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<B2cIdentityUserFlow>(b2cIdentityUserFlowToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified B2cIdentityUserFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<B2cIdentityUserFlow>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified B2cIdentityUserFlow and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified B2cIdentityUserFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The B2cIdentityUserFlow.</returns>
        public async System.Threading.Tasks.Task<B2cIdentityUserFlow> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<B2cIdentityUserFlow>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified B2cIdentityUserFlow and returns a <see cref="GraphResponse{B2cIdentityUserFlow}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{B2cIdentityUserFlow}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2cIdentityUserFlow>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<B2cIdentityUserFlow>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified B2cIdentityUserFlow using PATCH.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToUpdate">The B2cIdentityUserFlow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated B2cIdentityUserFlow.</returns>
        public async System.Threading.Tasks.Task<B2cIdentityUserFlow> UpdateAsync(B2cIdentityUserFlow b2cIdentityUserFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<B2cIdentityUserFlow>(b2cIdentityUserFlowToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified B2cIdentityUserFlow using PATCH and returns a <see cref="GraphResponse{B2cIdentityUserFlow}"/> object.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToUpdate">The B2cIdentityUserFlow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{B2cIdentityUserFlow}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2cIdentityUserFlow>> UpdateResponseAsync(B2cIdentityUserFlow b2cIdentityUserFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<B2cIdentityUserFlow>(b2cIdentityUserFlowToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified B2cIdentityUserFlow using PUT.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToUpdate">The B2cIdentityUserFlow object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<B2cIdentityUserFlow> PutAsync(B2cIdentityUserFlow b2cIdentityUserFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<B2cIdentityUserFlow>(b2cIdentityUserFlowToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified B2cIdentityUserFlow using PUT and returns a <see cref="GraphResponse{B2cIdentityUserFlow}"/> object.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToUpdate">The B2cIdentityUserFlow object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{B2cIdentityUserFlow}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2cIdentityUserFlow>> PutResponseAsync(B2cIdentityUserFlow b2cIdentityUserFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<B2cIdentityUserFlow>(b2cIdentityUserFlowToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IB2cIdentityUserFlowRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IB2cIdentityUserFlowRequest Expand(Expression<Func<B2cIdentityUserFlow, object>> expandExpression)
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
        public IB2cIdentityUserFlowRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IB2cIdentityUserFlowRequest Select(Expression<Func<B2cIdentityUserFlow, object>> selectExpression)
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
        /// <param name="b2cIdentityUserFlowToInitialize">The <see cref="B2cIdentityUserFlow"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(B2cIdentityUserFlow b2cIdentityUserFlowToInitialize)
        {

            if (b2cIdentityUserFlowToInitialize != null && b2cIdentityUserFlowToInitialize.AdditionalData != null)
            {

                if (b2cIdentityUserFlowToInitialize.IdentityProviders != null && b2cIdentityUserFlowToInitialize.IdentityProviders.CurrentPage != null)
                {
                    b2cIdentityUserFlowToInitialize.IdentityProviders.AdditionalData = b2cIdentityUserFlowToInitialize.AdditionalData;

                    object nextPageLink;
                    b2cIdentityUserFlowToInitialize.AdditionalData.TryGetValue("identityProviders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        b2cIdentityUserFlowToInitialize.IdentityProviders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (b2cIdentityUserFlowToInitialize.Languages != null && b2cIdentityUserFlowToInitialize.Languages.CurrentPage != null)
                {
                    b2cIdentityUserFlowToInitialize.Languages.AdditionalData = b2cIdentityUserFlowToInitialize.AdditionalData;

                    object nextPageLink;
                    b2cIdentityUserFlowToInitialize.AdditionalData.TryGetValue("languages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        b2cIdentityUserFlowToInitialize.Languages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (b2cIdentityUserFlowToInitialize.UserAttributeAssignments != null && b2cIdentityUserFlowToInitialize.UserAttributeAssignments.CurrentPage != null)
                {
                    b2cIdentityUserFlowToInitialize.UserAttributeAssignments.AdditionalData = b2cIdentityUserFlowToInitialize.AdditionalData;

                    object nextPageLink;
                    b2cIdentityUserFlowToInitialize.AdditionalData.TryGetValue("userAttributeAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        b2cIdentityUserFlowToInitialize.UserAttributeAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}

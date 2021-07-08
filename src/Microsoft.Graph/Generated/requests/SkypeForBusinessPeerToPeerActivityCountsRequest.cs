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
    /// The type SkypeForBusinessPeerToPeerActivityCountsRequest.
    /// </summary>
    public partial class SkypeForBusinessPeerToPeerActivityCountsRequest : BaseRequest, ISkypeForBusinessPeerToPeerActivityCountsRequest
    {
        /// <summary>
        /// Constructs a new SkypeForBusinessPeerToPeerActivityCountsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SkypeForBusinessPeerToPeerActivityCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SkypeForBusinessPeerToPeerActivityCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToCreate">The SkypeForBusinessPeerToPeerActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessPeerToPeerActivityCounts.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessPeerToPeerActivityCounts> CreateAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<SkypeForBusinessPeerToPeerActivityCounts>(skypeForBusinessPeerToPeerActivityCountsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SkypeForBusinessPeerToPeerActivityCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToCreate">The SkypeForBusinessPeerToPeerActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessPeerToPeerActivityCounts>> CreateResponseAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<SkypeForBusinessPeerToPeerActivityCounts>(skypeForBusinessPeerToPeerActivityCountsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SkypeForBusinessPeerToPeerActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<SkypeForBusinessPeerToPeerActivityCounts>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SkypeForBusinessPeerToPeerActivityCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SkypeForBusinessPeerToPeerActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessPeerToPeerActivityCounts.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessPeerToPeerActivityCounts> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<SkypeForBusinessPeerToPeerActivityCounts>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SkypeForBusinessPeerToPeerActivityCounts and returns a <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessPeerToPeerActivityCounts>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<SkypeForBusinessPeerToPeerActivityCounts>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessPeerToPeerActivityCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToUpdate">The SkypeForBusinessPeerToPeerActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessPeerToPeerActivityCounts.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessPeerToPeerActivityCounts> UpdateAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<SkypeForBusinessPeerToPeerActivityCounts>(skypeForBusinessPeerToPeerActivityCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessPeerToPeerActivityCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToUpdate">The SkypeForBusinessPeerToPeerActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessPeerToPeerActivityCounts>> UpdateResponseAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<SkypeForBusinessPeerToPeerActivityCounts>(skypeForBusinessPeerToPeerActivityCountsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessPeerToPeerActivityCounts using PUT.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToUpdate">The SkypeForBusinessPeerToPeerActivityCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<SkypeForBusinessPeerToPeerActivityCounts> PutAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<SkypeForBusinessPeerToPeerActivityCounts>(skypeForBusinessPeerToPeerActivityCountsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SkypeForBusinessPeerToPeerActivityCounts using PUT and returns a <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToUpdate">The SkypeForBusinessPeerToPeerActivityCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessPeerToPeerActivityCounts>> PutResponseAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<SkypeForBusinessPeerToPeerActivityCounts>(skypeForBusinessPeerToPeerActivityCountsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeForBusinessPeerToPeerActivityCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeForBusinessPeerToPeerActivityCountsRequest Expand(Expression<Func<SkypeForBusinessPeerToPeerActivityCounts, object>> expandExpression)
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
        public ISkypeForBusinessPeerToPeerActivityCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeForBusinessPeerToPeerActivityCountsRequest Select(Expression<Func<SkypeForBusinessPeerToPeerActivityCounts, object>> selectExpression)
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
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToInitialize">The <see cref="SkypeForBusinessPeerToPeerActivityCounts"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToInitialize)
        {

        }
    }
}

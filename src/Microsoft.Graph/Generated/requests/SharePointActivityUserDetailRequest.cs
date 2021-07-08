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
    /// The type SharePointActivityUserDetailRequest.
    /// </summary>
    public partial class SharePointActivityUserDetailRequest : BaseRequest, ISharePointActivityUserDetailRequest
    {
        /// <summary>
        /// Constructs a new SharePointActivityUserDetailRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SharePointActivityUserDetailRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SharePointActivityUserDetail using POST.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToCreate">The SharePointActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharePointActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<SharePointActivityUserDetail> CreateAsync(SharePointActivityUserDetail sharePointActivityUserDetailToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<SharePointActivityUserDetail>(sharePointActivityUserDetailToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SharePointActivityUserDetail using POST and returns a <see cref="GraphResponse{SharePointActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToCreate">The SharePointActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharePointActivityUserDetail}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharePointActivityUserDetail>> CreateResponseAsync(SharePointActivityUserDetail sharePointActivityUserDetailToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<SharePointActivityUserDetail>(sharePointActivityUserDetailToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SharePointActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<SharePointActivityUserDetail>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SharePointActivityUserDetail and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SharePointActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharePointActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<SharePointActivityUserDetail> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<SharePointActivityUserDetail>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SharePointActivityUserDetail and returns a <see cref="GraphResponse{SharePointActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharePointActivityUserDetail}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharePointActivityUserDetail>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<SharePointActivityUserDetail>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SharePointActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToUpdate">The SharePointActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharePointActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<SharePointActivityUserDetail> UpdateAsync(SharePointActivityUserDetail sharePointActivityUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<SharePointActivityUserDetail>(sharePointActivityUserDetailToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SharePointActivityUserDetail using PATCH and returns a <see cref="GraphResponse{SharePointActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToUpdate">The SharePointActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SharePointActivityUserDetail}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharePointActivityUserDetail>> UpdateResponseAsync(SharePointActivityUserDetail sharePointActivityUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<SharePointActivityUserDetail>(sharePointActivityUserDetailToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SharePointActivityUserDetail using PUT.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToUpdate">The SharePointActivityUserDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<SharePointActivityUserDetail> PutAsync(SharePointActivityUserDetail sharePointActivityUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<SharePointActivityUserDetail>(sharePointActivityUserDetailToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SharePointActivityUserDetail using PUT and returns a <see cref="GraphResponse{SharePointActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToUpdate">The SharePointActivityUserDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{SharePointActivityUserDetail}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharePointActivityUserDetail>> PutResponseAsync(SharePointActivityUserDetail sharePointActivityUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<SharePointActivityUserDetail>(sharePointActivityUserDetailToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISharePointActivityUserDetailRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISharePointActivityUserDetailRequest Expand(Expression<Func<SharePointActivityUserDetail, object>> expandExpression)
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
        public ISharePointActivityUserDetailRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISharePointActivityUserDetailRequest Select(Expression<Func<SharePointActivityUserDetail, object>> selectExpression)
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
        /// <param name="sharePointActivityUserDetailToInitialize">The <see cref="SharePointActivityUserDetail"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SharePointActivityUserDetail sharePointActivityUserDetailToInitialize)
        {

        }
    }
}

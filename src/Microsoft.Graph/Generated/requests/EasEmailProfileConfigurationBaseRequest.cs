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
    /// The type EasEmailProfileConfigurationBaseRequest.
    /// </summary>
    public partial class EasEmailProfileConfigurationBaseRequest : BaseRequest, IEasEmailProfileConfigurationBaseRequest
    {
        /// <summary>
        /// Constructs a new EasEmailProfileConfigurationBaseRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EasEmailProfileConfigurationBaseRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EasEmailProfileConfigurationBase using POST.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToCreate">The EasEmailProfileConfigurationBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EasEmailProfileConfigurationBase.</returns>
        public async System.Threading.Tasks.Task<EasEmailProfileConfigurationBase> CreateAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EasEmailProfileConfigurationBase>(easEmailProfileConfigurationBaseToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EasEmailProfileConfigurationBase using POST and returns a <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToCreate">The EasEmailProfileConfigurationBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EasEmailProfileConfigurationBase>> CreateResponseAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EasEmailProfileConfigurationBase>(easEmailProfileConfigurationBaseToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EasEmailProfileConfigurationBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EasEmailProfileConfigurationBase>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EasEmailProfileConfigurationBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EasEmailProfileConfigurationBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EasEmailProfileConfigurationBase.</returns>
        public async System.Threading.Tasks.Task<EasEmailProfileConfigurationBase> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EasEmailProfileConfigurationBase>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EasEmailProfileConfigurationBase and returns a <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EasEmailProfileConfigurationBase>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EasEmailProfileConfigurationBase>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EasEmailProfileConfigurationBase using PATCH.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToUpdate">The EasEmailProfileConfigurationBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EasEmailProfileConfigurationBase.</returns>
        public async System.Threading.Tasks.Task<EasEmailProfileConfigurationBase> UpdateAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EasEmailProfileConfigurationBase>(easEmailProfileConfigurationBaseToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EasEmailProfileConfigurationBase using PATCH and returns a <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToUpdate">The EasEmailProfileConfigurationBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EasEmailProfileConfigurationBase>> UpdateResponseAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EasEmailProfileConfigurationBase>(easEmailProfileConfigurationBaseToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EasEmailProfileConfigurationBase using PUT.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToUpdate">The EasEmailProfileConfigurationBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EasEmailProfileConfigurationBase> PutAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EasEmailProfileConfigurationBase>(easEmailProfileConfigurationBaseToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EasEmailProfileConfigurationBase using PUT and returns a <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToUpdate">The EasEmailProfileConfigurationBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EasEmailProfileConfigurationBase>> PutResponseAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EasEmailProfileConfigurationBase>(easEmailProfileConfigurationBaseToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEasEmailProfileConfigurationBaseRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEasEmailProfileConfigurationBaseRequest Expand(Expression<Func<EasEmailProfileConfigurationBase, object>> expandExpression)
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
        public IEasEmailProfileConfigurationBaseRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEasEmailProfileConfigurationBaseRequest Select(Expression<Func<EasEmailProfileConfigurationBase, object>> selectExpression)
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
        /// <param name="easEmailProfileConfigurationBaseToInitialize">The <see cref="EasEmailProfileConfigurationBase"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToInitialize)
        {

        }
    }
}

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
    /// The type ItemInsightsSettingsRequest.
    /// </summary>
    public partial class ItemInsightsSettingsRequest : BaseRequest, IItemInsightsSettingsRequest
    {
        /// <summary>
        /// Constructs a new ItemInsightsSettingsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ItemInsightsSettingsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ItemInsightsSettings using POST.
        /// </summary>
        /// <param name="itemInsightsSettingsToCreate">The ItemInsightsSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemInsightsSettings.</returns>
        public async System.Threading.Tasks.Task<ItemInsightsSettings> CreateAsync(ItemInsightsSettings itemInsightsSettingsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ItemInsightsSettings>(itemInsightsSettingsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ItemInsightsSettings using POST and returns a <see cref="GraphResponse{ItemInsightsSettings}"/> object.
        /// </summary>
        /// <param name="itemInsightsSettingsToCreate">The ItemInsightsSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemInsightsSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ItemInsightsSettings>> CreateResponseAsync(ItemInsightsSettings itemInsightsSettingsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ItemInsightsSettings>(itemInsightsSettingsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ItemInsightsSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ItemInsightsSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ItemInsightsSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ItemInsightsSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemInsightsSettings.</returns>
        public async System.Threading.Tasks.Task<ItemInsightsSettings> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ItemInsightsSettings>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ItemInsightsSettings and returns a <see cref="GraphResponse{ItemInsightsSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemInsightsSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ItemInsightsSettings>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ItemInsightsSettings>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ItemInsightsSettings using PATCH.
        /// </summary>
        /// <param name="itemInsightsSettingsToUpdate">The ItemInsightsSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemInsightsSettings.</returns>
        public async System.Threading.Tasks.Task<ItemInsightsSettings> UpdateAsync(ItemInsightsSettings itemInsightsSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ItemInsightsSettings>(itemInsightsSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ItemInsightsSettings using PATCH and returns a <see cref="GraphResponse{ItemInsightsSettings}"/> object.
        /// </summary>
        /// <param name="itemInsightsSettingsToUpdate">The ItemInsightsSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ItemInsightsSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ItemInsightsSettings>> UpdateResponseAsync(ItemInsightsSettings itemInsightsSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ItemInsightsSettings>(itemInsightsSettingsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ItemInsightsSettings using PUT.
        /// </summary>
        /// <param name="itemInsightsSettingsToUpdate">The ItemInsightsSettings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ItemInsightsSettings> PutAsync(ItemInsightsSettings itemInsightsSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ItemInsightsSettings>(itemInsightsSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ItemInsightsSettings using PUT and returns a <see cref="GraphResponse{ItemInsightsSettings}"/> object.
        /// </summary>
        /// <param name="itemInsightsSettingsToUpdate">The ItemInsightsSettings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ItemInsightsSettings}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ItemInsightsSettings>> PutResponseAsync(ItemInsightsSettings itemInsightsSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ItemInsightsSettings>(itemInsightsSettingsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemInsightsSettingsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemInsightsSettingsRequest Expand(Expression<Func<ItemInsightsSettings, object>> expandExpression)
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
        public IItemInsightsSettingsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IItemInsightsSettingsRequest Select(Expression<Func<ItemInsightsSettings, object>> selectExpression)
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
        /// <param name="itemInsightsSettingsToInitialize">The <see cref="ItemInsightsSettings"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ItemInsightsSettings itemInsightsSettingsToInitialize)
        {

        }
    }
}

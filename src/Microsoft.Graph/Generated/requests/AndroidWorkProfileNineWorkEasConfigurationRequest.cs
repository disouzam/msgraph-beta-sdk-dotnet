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
    /// The type AndroidWorkProfileNineWorkEasConfigurationRequest.
    /// </summary>
    public partial class AndroidWorkProfileNineWorkEasConfigurationRequest : BaseRequest, IAndroidWorkProfileNineWorkEasConfigurationRequest
    {
        /// <summary>
        /// Constructs a new AndroidWorkProfileNineWorkEasConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidWorkProfileNineWorkEasConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidWorkProfileNineWorkEasConfiguration using POST.
        /// </summary>
        /// <param name="androidWorkProfileNineWorkEasConfigurationToCreate">The AndroidWorkProfileNineWorkEasConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfileNineWorkEasConfiguration.</returns>
        public async System.Threading.Tasks.Task<AndroidWorkProfileNineWorkEasConfiguration> CreateAsync(AndroidWorkProfileNineWorkEasConfiguration androidWorkProfileNineWorkEasConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AndroidWorkProfileNineWorkEasConfiguration>(androidWorkProfileNineWorkEasConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AndroidWorkProfileNineWorkEasConfiguration using POST and returns a <see cref="GraphResponse{AndroidWorkProfileNineWorkEasConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileNineWorkEasConfigurationToCreate">The AndroidWorkProfileNineWorkEasConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileNineWorkEasConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileNineWorkEasConfiguration>> CreateResponseAsync(AndroidWorkProfileNineWorkEasConfiguration androidWorkProfileNineWorkEasConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AndroidWorkProfileNineWorkEasConfiguration>(androidWorkProfileNineWorkEasConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AndroidWorkProfileNineWorkEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AndroidWorkProfileNineWorkEasConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidWorkProfileNineWorkEasConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AndroidWorkProfileNineWorkEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfileNineWorkEasConfiguration.</returns>
        public async System.Threading.Tasks.Task<AndroidWorkProfileNineWorkEasConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AndroidWorkProfileNineWorkEasConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AndroidWorkProfileNineWorkEasConfiguration and returns a <see cref="GraphResponse{AndroidWorkProfileNineWorkEasConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileNineWorkEasConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileNineWorkEasConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AndroidWorkProfileNineWorkEasConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AndroidWorkProfileNineWorkEasConfiguration using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileNineWorkEasConfigurationToUpdate">The AndroidWorkProfileNineWorkEasConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidWorkProfileNineWorkEasConfiguration.</returns>
        public async System.Threading.Tasks.Task<AndroidWorkProfileNineWorkEasConfiguration> UpdateAsync(AndroidWorkProfileNineWorkEasConfiguration androidWorkProfileNineWorkEasConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AndroidWorkProfileNineWorkEasConfiguration>(androidWorkProfileNineWorkEasConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidWorkProfileNineWorkEasConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidWorkProfileNineWorkEasConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileNineWorkEasConfigurationToUpdate">The AndroidWorkProfileNineWorkEasConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileNineWorkEasConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileNineWorkEasConfiguration>> UpdateResponseAsync(AndroidWorkProfileNineWorkEasConfiguration androidWorkProfileNineWorkEasConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AndroidWorkProfileNineWorkEasConfiguration>(androidWorkProfileNineWorkEasConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AndroidWorkProfileNineWorkEasConfiguration using PUT.
        /// </summary>
        /// <param name="androidWorkProfileNineWorkEasConfigurationToUpdate">The AndroidWorkProfileNineWorkEasConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AndroidWorkProfileNineWorkEasConfiguration> PutAsync(AndroidWorkProfileNineWorkEasConfiguration androidWorkProfileNineWorkEasConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AndroidWorkProfileNineWorkEasConfiguration>(androidWorkProfileNineWorkEasConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidWorkProfileNineWorkEasConfiguration using PUT and returns a <see cref="GraphResponse{AndroidWorkProfileNineWorkEasConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileNineWorkEasConfigurationToUpdate">The AndroidWorkProfileNineWorkEasConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AndroidWorkProfileNineWorkEasConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileNineWorkEasConfiguration>> PutResponseAsync(AndroidWorkProfileNineWorkEasConfiguration androidWorkProfileNineWorkEasConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AndroidWorkProfileNineWorkEasConfiguration>(androidWorkProfileNineWorkEasConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidWorkProfileNineWorkEasConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidWorkProfileNineWorkEasConfigurationRequest Expand(Expression<Func<AndroidWorkProfileNineWorkEasConfiguration, object>> expandExpression)
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
        public IAndroidWorkProfileNineWorkEasConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidWorkProfileNineWorkEasConfigurationRequest Select(Expression<Func<AndroidWorkProfileNineWorkEasConfiguration, object>> selectExpression)
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
        /// <param name="androidWorkProfileNineWorkEasConfigurationToInitialize">The <see cref="AndroidWorkProfileNineWorkEasConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidWorkProfileNineWorkEasConfiguration androidWorkProfileNineWorkEasConfigurationToInitialize)
        {

        }
    }
}

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
    /// The type ManagementConditionRequest.
    /// </summary>
    public partial class ManagementConditionRequest : BaseRequest, IManagementConditionRequest
    {
        /// <summary>
        /// Constructs a new ManagementConditionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagementConditionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ManagementCondition using POST.
        /// </summary>
        /// <param name="managementConditionToCreate">The ManagementCondition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagementCondition.</returns>
        public async System.Threading.Tasks.Task<ManagementCondition> CreateAsync(ManagementCondition managementConditionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ManagementCondition>(managementConditionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ManagementCondition using POST and returns a <see cref="GraphResponse{ManagementCondition}"/> object.
        /// </summary>
        /// <param name="managementConditionToCreate">The ManagementCondition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementCondition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagementCondition>> CreateResponseAsync(ManagementCondition managementConditionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ManagementCondition>(managementConditionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ManagementCondition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagementCondition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagementCondition.</returns>
        public async System.Threading.Tasks.Task<ManagementCondition> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ManagementCondition>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ManagementCondition and returns a <see cref="GraphResponse{ManagementCondition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementCondition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagementCondition>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ManagementCondition>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagementCondition using PATCH.
        /// </summary>
        /// <param name="managementConditionToUpdate">The ManagementCondition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagementCondition.</returns>
        public async System.Threading.Tasks.Task<ManagementCondition> UpdateAsync(ManagementCondition managementConditionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ManagementCondition>(managementConditionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagementCondition using PATCH and returns a <see cref="GraphResponse{ManagementCondition}"/> object.
        /// </summary>
        /// <param name="managementConditionToUpdate">The ManagementCondition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagementCondition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagementCondition>> UpdateResponseAsync(ManagementCondition managementConditionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ManagementCondition>(managementConditionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagementCondition using PUT.
        /// </summary>
        /// <param name="managementConditionToUpdate">The ManagementCondition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ManagementCondition> PutAsync(ManagementCondition managementConditionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ManagementCondition>(managementConditionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagementCondition using PUT and returns a <see cref="GraphResponse{ManagementCondition}"/> object.
        /// </summary>
        /// <param name="managementConditionToUpdate">The ManagementCondition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ManagementCondition}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagementCondition>> PutResponseAsync(ManagementCondition managementConditionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ManagementCondition>(managementConditionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagementConditionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagementConditionRequest Expand(Expression<Func<ManagementCondition, object>> expandExpression)
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
        public IManagementConditionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagementConditionRequest Select(Expression<Func<ManagementCondition, object>> selectExpression)
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
        /// <param name="managementConditionToInitialize">The <see cref="ManagementCondition"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ManagementCondition managementConditionToInitialize)
        {

            if (managementConditionToInitialize != null)
            {
                if (managementConditionToInitialize.ManagementConditionStatements != null && managementConditionToInitialize.ManagementConditionStatements.CurrentPage != null)
                {
                    managementConditionToInitialize.ManagementConditionStatements.InitializeNextPageRequest(this.Client, managementConditionToInitialize.ManagementConditionStatementsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managementConditionToInitialize.ManagementConditionStatements.AdditionalData = managementConditionToInitialize.AdditionalData;
                }

            }


        }
    }
}

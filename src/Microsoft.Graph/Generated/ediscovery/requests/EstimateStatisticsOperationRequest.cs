// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EstimateStatisticsOperationRequest.
    /// </summary>
    public partial class EstimateStatisticsOperationRequest : Microsoft.Graph.BaseRequest, IEstimateStatisticsOperationRequest
    {
        /// <summary>
        /// Constructs a new EstimateStatisticsOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EstimateStatisticsOperationRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EstimateStatisticsOperation using POST.
        /// </summary>
        /// <param name="estimateStatisticsOperationToCreate">The EstimateStatisticsOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EstimateStatisticsOperation.</returns>
        public async System.Threading.Tasks.Task<EstimateStatisticsOperation> CreateAsync(EstimateStatisticsOperation estimateStatisticsOperationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EstimateStatisticsOperation>(estimateStatisticsOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EstimateStatisticsOperation using POST and returns a <see cref="GraphResponse{EstimateStatisticsOperation}"/> object.
        /// </summary>
        /// <param name="estimateStatisticsOperationToCreate">The EstimateStatisticsOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EstimateStatisticsOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EstimateStatisticsOperation>> CreateResponseAsync(EstimateStatisticsOperation estimateStatisticsOperationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EstimateStatisticsOperation>(estimateStatisticsOperationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EstimateStatisticsOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EstimateStatisticsOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EstimateStatisticsOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EstimateStatisticsOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EstimateStatisticsOperation.</returns>
        public async System.Threading.Tasks.Task<EstimateStatisticsOperation> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EstimateStatisticsOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EstimateStatisticsOperation and returns a <see cref="GraphResponse{EstimateStatisticsOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EstimateStatisticsOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EstimateStatisticsOperation>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EstimateStatisticsOperation>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EstimateStatisticsOperation using PATCH.
        /// </summary>
        /// <param name="estimateStatisticsOperationToUpdate">The EstimateStatisticsOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EstimateStatisticsOperation.</returns>
        public async System.Threading.Tasks.Task<EstimateStatisticsOperation> UpdateAsync(EstimateStatisticsOperation estimateStatisticsOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EstimateStatisticsOperation>(estimateStatisticsOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EstimateStatisticsOperation using PATCH and returns a <see cref="GraphResponse{EstimateStatisticsOperation}"/> object.
        /// </summary>
        /// <param name="estimateStatisticsOperationToUpdate">The EstimateStatisticsOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EstimateStatisticsOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EstimateStatisticsOperation>> UpdateResponseAsync(EstimateStatisticsOperation estimateStatisticsOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EstimateStatisticsOperation>(estimateStatisticsOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EstimateStatisticsOperation using PUT.
        /// </summary>
        /// <param name="estimateStatisticsOperationToUpdate">The EstimateStatisticsOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EstimateStatisticsOperation> PutAsync(EstimateStatisticsOperation estimateStatisticsOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EstimateStatisticsOperation>(estimateStatisticsOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EstimateStatisticsOperation using PUT and returns a <see cref="GraphResponse{EstimateStatisticsOperation}"/> object.
        /// </summary>
        /// <param name="estimateStatisticsOperationToUpdate">The EstimateStatisticsOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EstimateStatisticsOperation}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EstimateStatisticsOperation>> PutResponseAsync(EstimateStatisticsOperation estimateStatisticsOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EstimateStatisticsOperation>(estimateStatisticsOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEstimateStatisticsOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEstimateStatisticsOperationRequest Expand(Expression<Func<EstimateStatisticsOperation, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEstimateStatisticsOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEstimateStatisticsOperationRequest Select(Expression<Func<EstimateStatisticsOperation, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="estimateStatisticsOperationToInitialize">The <see cref="EstimateStatisticsOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EstimateStatisticsOperation estimateStatisticsOperationToInitialize)
        {

        }
    }
}

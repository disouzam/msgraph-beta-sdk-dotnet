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
    /// The type UnmanagedDeviceDiscoveryTaskRequest.
    /// </summary>
    public partial class UnmanagedDeviceDiscoveryTaskRequest : BaseRequest, IUnmanagedDeviceDiscoveryTaskRequest
    {
        /// <summary>
        /// Constructs a new UnmanagedDeviceDiscoveryTaskRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnmanagedDeviceDiscoveryTaskRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnmanagedDeviceDiscoveryTask using POST.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToCreate">The UnmanagedDeviceDiscoveryTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnmanagedDeviceDiscoveryTask.</returns>
        public async System.Threading.Tasks.Task<UnmanagedDeviceDiscoveryTask> CreateAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UnmanagedDeviceDiscoveryTask>(unmanagedDeviceDiscoveryTaskToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UnmanagedDeviceDiscoveryTask using POST and returns a <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToCreate">The UnmanagedDeviceDiscoveryTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnmanagedDeviceDiscoveryTask>> CreateResponseAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UnmanagedDeviceDiscoveryTask>(unmanagedDeviceDiscoveryTaskToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UnmanagedDeviceDiscoveryTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UnmanagedDeviceDiscoveryTask>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UnmanagedDeviceDiscoveryTask and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UnmanagedDeviceDiscoveryTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnmanagedDeviceDiscoveryTask.</returns>
        public async System.Threading.Tasks.Task<UnmanagedDeviceDiscoveryTask> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UnmanagedDeviceDiscoveryTask>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UnmanagedDeviceDiscoveryTask and returns a <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnmanagedDeviceDiscoveryTask>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UnmanagedDeviceDiscoveryTask>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnmanagedDeviceDiscoveryTask using PATCH.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToUpdate">The UnmanagedDeviceDiscoveryTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnmanagedDeviceDiscoveryTask.</returns>
        public async System.Threading.Tasks.Task<UnmanagedDeviceDiscoveryTask> UpdateAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UnmanagedDeviceDiscoveryTask>(unmanagedDeviceDiscoveryTaskToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnmanagedDeviceDiscoveryTask using PATCH and returns a <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToUpdate">The UnmanagedDeviceDiscoveryTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnmanagedDeviceDiscoveryTask>> UpdateResponseAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UnmanagedDeviceDiscoveryTask>(unmanagedDeviceDiscoveryTaskToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnmanagedDeviceDiscoveryTask using PUT.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToUpdate">The UnmanagedDeviceDiscoveryTask object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UnmanagedDeviceDiscoveryTask> PutAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UnmanagedDeviceDiscoveryTask>(unmanagedDeviceDiscoveryTaskToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnmanagedDeviceDiscoveryTask using PUT and returns a <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/> object.
        /// </summary>
        /// <param name="unmanagedDeviceDiscoveryTaskToUpdate">The UnmanagedDeviceDiscoveryTask object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UnmanagedDeviceDiscoveryTask}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnmanagedDeviceDiscoveryTask>> PutResponseAsync(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UnmanagedDeviceDiscoveryTask>(unmanagedDeviceDiscoveryTaskToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnmanagedDeviceDiscoveryTaskRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnmanagedDeviceDiscoveryTaskRequest Expand(Expression<Func<UnmanagedDeviceDiscoveryTask, object>> expandExpression)
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
        public IUnmanagedDeviceDiscoveryTaskRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnmanagedDeviceDiscoveryTaskRequest Select(Expression<Func<UnmanagedDeviceDiscoveryTask, object>> selectExpression)
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
        /// <param name="unmanagedDeviceDiscoveryTaskToInitialize">The <see cref="UnmanagedDeviceDiscoveryTask"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnmanagedDeviceDiscoveryTask unmanagedDeviceDiscoveryTaskToInitialize)
        {

        }
    }
}

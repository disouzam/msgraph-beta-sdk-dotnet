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
    /// The type WindowsPhone81StoreAppRequest.
    /// </summary>
    public partial class WindowsPhone81StoreAppRequest : BaseRequest, IWindowsPhone81StoreAppRequest
    {
        /// <summary>
        /// Constructs a new WindowsPhone81StoreAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsPhone81StoreAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsPhone81StoreApp using POST.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToCreate">The WindowsPhone81StoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81StoreApp.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81StoreApp> CreateAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<WindowsPhone81StoreApp>(windowsPhone81StoreAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WindowsPhone81StoreApp using POST and returns a <see cref="GraphResponse{WindowsPhone81StoreApp}"/> object.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToCreate">The WindowsPhone81StoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81StoreApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsPhone81StoreApp>> CreateResponseAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<WindowsPhone81StoreApp>(windowsPhone81StoreAppToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified WindowsPhone81StoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<WindowsPhone81StoreApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsPhone81StoreApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified WindowsPhone81StoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81StoreApp.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81StoreApp> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<WindowsPhone81StoreApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsPhone81StoreApp and returns a <see cref="GraphResponse{WindowsPhone81StoreApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81StoreApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsPhone81StoreApp>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<WindowsPhone81StoreApp>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WindowsPhone81StoreApp using PATCH.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToUpdate">The WindowsPhone81StoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsPhone81StoreApp.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81StoreApp> UpdateAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<WindowsPhone81StoreApp>(windowsPhone81StoreAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsPhone81StoreApp using PATCH and returns a <see cref="GraphResponse{WindowsPhone81StoreApp}"/> object.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToUpdate">The WindowsPhone81StoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81StoreApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsPhone81StoreApp>> UpdateResponseAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<WindowsPhone81StoreApp>(windowsPhone81StoreAppToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WindowsPhone81StoreApp using PUT.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToUpdate">The WindowsPhone81StoreApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81StoreApp> PutAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<WindowsPhone81StoreApp>(windowsPhone81StoreAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsPhone81StoreApp using PUT and returns a <see cref="GraphResponse{WindowsPhone81StoreApp}"/> object.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToUpdate">The WindowsPhone81StoreApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{WindowsPhone81StoreApp}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsPhone81StoreApp>> PutResponseAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<WindowsPhone81StoreApp>(windowsPhone81StoreAppToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81StoreAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81StoreAppRequest Expand(Expression<Func<WindowsPhone81StoreApp, object>> expandExpression)
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
        public IWindowsPhone81StoreAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81StoreAppRequest Select(Expression<Func<WindowsPhone81StoreApp, object>> selectExpression)
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
        /// <param name="windowsPhone81StoreAppToInitialize">The <see cref="WindowsPhone81StoreApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsPhone81StoreApp windowsPhone81StoreAppToInitialize)
        {

        }
    }
}

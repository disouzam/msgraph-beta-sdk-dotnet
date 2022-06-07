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
    /// The type FileAttachment_v2Request.
    /// </summary>
    public partial class FileAttachment_v2Request : BaseRequest, IFileAttachment_v2Request
    {
        /// <summary>
        /// Constructs a new FileAttachment_v2Request.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public FileAttachment_v2Request(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified FileAttachment_v2 using POST.
        /// </summary>
        /// <param name="fileAttachment_v2ToCreate">The FileAttachment_v2 to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FileAttachment_v2.</returns>
        public async System.Threading.Tasks.Task<FileAttachment_v2> CreateAsync(FileAttachment_v2 fileAttachment_v2ToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<FileAttachment_v2>(fileAttachment_v2ToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified FileAttachment_v2 using POST and returns a <see cref="GraphResponse{FileAttachment_v2}"/> object.
        /// </summary>
        /// <param name="fileAttachment_v2ToCreate">The FileAttachment_v2 to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileAttachment_v2}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FileAttachment_v2>> CreateResponseAsync(FileAttachment_v2 fileAttachment_v2ToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<FileAttachment_v2>(fileAttachment_v2ToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified FileAttachment_v2.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<FileAttachment_v2>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified FileAttachment_v2 and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified FileAttachment_v2.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FileAttachment_v2.</returns>
        public async System.Threading.Tasks.Task<FileAttachment_v2> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<FileAttachment_v2>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified FileAttachment_v2 and returns a <see cref="GraphResponse{FileAttachment_v2}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileAttachment_v2}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FileAttachment_v2>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<FileAttachment_v2>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified FileAttachment_v2 using PATCH.
        /// </summary>
        /// <param name="fileAttachment_v2ToUpdate">The FileAttachment_v2 to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated FileAttachment_v2.</returns>
        public async System.Threading.Tasks.Task<FileAttachment_v2> UpdateAsync(FileAttachment_v2 fileAttachment_v2ToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<FileAttachment_v2>(fileAttachment_v2ToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified FileAttachment_v2 using PATCH and returns a <see cref="GraphResponse{FileAttachment_v2}"/> object.
        /// </summary>
        /// <param name="fileAttachment_v2ToUpdate">The FileAttachment_v2 to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{FileAttachment_v2}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FileAttachment_v2>> UpdateResponseAsync(FileAttachment_v2 fileAttachment_v2ToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<FileAttachment_v2>(fileAttachment_v2ToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified FileAttachment_v2 using PUT.
        /// </summary>
        /// <param name="fileAttachment_v2ToUpdate">The FileAttachment_v2 object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<FileAttachment_v2> PutAsync(FileAttachment_v2 fileAttachment_v2ToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<FileAttachment_v2>(fileAttachment_v2ToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified FileAttachment_v2 using PUT and returns a <see cref="GraphResponse{FileAttachment_v2}"/> object.
        /// </summary>
        /// <param name="fileAttachment_v2ToUpdate">The FileAttachment_v2 object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{FileAttachment_v2}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FileAttachment_v2>> PutResponseAsync(FileAttachment_v2 fileAttachment_v2ToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<FileAttachment_v2>(fileAttachment_v2ToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IFileAttachment_v2Request Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IFileAttachment_v2Request Expand(Expression<Func<FileAttachment_v2, object>> expandExpression)
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
        public IFileAttachment_v2Request Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IFileAttachment_v2Request Select(Expression<Func<FileAttachment_v2, object>> selectExpression)
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
        /// <param name="fileAttachment_v2ToInitialize">The <see cref="FileAttachment_v2"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(FileAttachment_v2 fileAttachment_v2ToInitialize)
        {

        }
    }
}

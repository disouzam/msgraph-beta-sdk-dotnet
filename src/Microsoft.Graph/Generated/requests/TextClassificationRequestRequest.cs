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
    /// The type TextClassificationRequestRequest.
    /// </summary>
    public partial class TextClassificationRequestRequest : BaseRequest, ITextClassificationRequestRequest
    {
        /// <summary>
        /// Constructs a new TextClassificationRequestRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TextClassificationRequestRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TextClassificationRequestObject using POST.
        /// </summary>
        /// <param name="textClassificationRequestObjectToCreate">The TextClassificationRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TextClassificationRequestObject.</returns>
        public async System.Threading.Tasks.Task<TextClassificationRequestObject> CreateAsync(TextClassificationRequestObject textClassificationRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<TextClassificationRequestObject>(textClassificationRequestObjectToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TextClassificationRequestObject using POST and returns a <see cref="GraphResponse{TextClassificationRequestObject}"/> object.
        /// </summary>
        /// <param name="textClassificationRequestObjectToCreate">The TextClassificationRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TextClassificationRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TextClassificationRequestObject>> CreateResponseAsync(TextClassificationRequestObject textClassificationRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<TextClassificationRequestObject>(textClassificationRequestObjectToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified TextClassificationRequest.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<TextClassificationRequestObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TextClassificationRequest and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified TextClassificationRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TextClassificationRequestObject.</returns>
        public async System.Threading.Tasks.Task<TextClassificationRequestObject> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<TextClassificationRequestObject>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TextClassificationRequestObject and returns a <see cref="GraphResponse{TextClassificationRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TextClassificationRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TextClassificationRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<TextClassificationRequestObject>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TextClassificationRequestObject using PATCH.
        /// </summary>
        /// <param name="textClassificationRequestObjectToUpdate">The TextClassificationRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TextClassificationRequestObject.</returns>
        public async System.Threading.Tasks.Task<TextClassificationRequestObject> UpdateAsync(TextClassificationRequestObject textClassificationRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<TextClassificationRequestObject>(textClassificationRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TextClassificationRequestObject using PATCH and returns a <see cref="GraphResponse{TextClassificationRequestObject}"/> object.
        /// </summary>
        /// <param name="textClassificationRequestObjectToUpdate">The TextClassificationRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TextClassificationRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TextClassificationRequestObject>> UpdateResponseAsync(TextClassificationRequestObject textClassificationRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<TextClassificationRequestObject>(textClassificationRequestObjectToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified TextClassificationRequestObject using PUT.
        /// </summary>
        /// <param name="textClassificationRequestObjectToUpdate">The TextClassificationRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<TextClassificationRequestObject> PutAsync(TextClassificationRequestObject textClassificationRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<TextClassificationRequestObject>(textClassificationRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TextClassificationRequestObject using PUT and returns a <see cref="GraphResponse{TextClassificationRequestObject}"/> object.
        /// </summary>
        /// <param name="textClassificationRequestObjectToUpdate">The TextClassificationRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{TextClassificationRequestObject}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TextClassificationRequestObject>> PutResponseAsync(TextClassificationRequestObject textClassificationRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<TextClassificationRequestObject>(textClassificationRequestObjectToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITextClassificationRequestRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITextClassificationRequestRequest Expand(Expression<Func<TextClassificationRequestObject, object>> expandExpression)
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
        public ITextClassificationRequestRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITextClassificationRequestRequest Select(Expression<Func<TextClassificationRequestObject, object>> selectExpression)
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
        /// <param name="textClassificationRequestObjectToInitialize">The <see cref="TextClassificationRequestObject"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TextClassificationRequestObject textClassificationRequestObjectToInitialize)
        {

        }
    }
}

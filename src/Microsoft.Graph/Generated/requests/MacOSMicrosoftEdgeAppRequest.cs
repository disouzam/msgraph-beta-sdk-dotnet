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
    /// The type MacOSMicrosoftEdgeAppRequest.
    /// </summary>
    public partial class MacOSMicrosoftEdgeAppRequest : BaseRequest, IMacOSMicrosoftEdgeAppRequest
    {
        /// <summary>
        /// Constructs a new MacOSMicrosoftEdgeAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSMicrosoftEdgeAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSMicrosoftEdgeApp using POST.
        /// </summary>
        /// <param name="macOSMicrosoftEdgeAppToCreate">The MacOSMicrosoftEdgeApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSMicrosoftEdgeApp.</returns>
        public async System.Threading.Tasks.Task<MacOSMicrosoftEdgeApp> CreateAsync(MacOSMicrosoftEdgeApp macOSMicrosoftEdgeAppToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<MacOSMicrosoftEdgeApp>(macOSMicrosoftEdgeAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSMicrosoftEdgeApp using POST and returns a <see cref="GraphResponse{MacOSMicrosoftEdgeApp}"/> object.
        /// </summary>
        /// <param name="macOSMicrosoftEdgeAppToCreate">The MacOSMicrosoftEdgeApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSMicrosoftEdgeApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSMicrosoftEdgeApp>> CreateResponseAsync(MacOSMicrosoftEdgeApp macOSMicrosoftEdgeAppToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<MacOSMicrosoftEdgeApp>(macOSMicrosoftEdgeAppToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MacOSMicrosoftEdgeApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<MacOSMicrosoftEdgeApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSMicrosoftEdgeApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MacOSMicrosoftEdgeApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSMicrosoftEdgeApp.</returns>
        public async System.Threading.Tasks.Task<MacOSMicrosoftEdgeApp> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<MacOSMicrosoftEdgeApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSMicrosoftEdgeApp and returns a <see cref="GraphResponse{MacOSMicrosoftEdgeApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSMicrosoftEdgeApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSMicrosoftEdgeApp>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<MacOSMicrosoftEdgeApp>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MacOSMicrosoftEdgeApp using PATCH.
        /// </summary>
        /// <param name="macOSMicrosoftEdgeAppToUpdate">The MacOSMicrosoftEdgeApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSMicrosoftEdgeApp.</returns>
        public async System.Threading.Tasks.Task<MacOSMicrosoftEdgeApp> UpdateAsync(MacOSMicrosoftEdgeApp macOSMicrosoftEdgeAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<MacOSMicrosoftEdgeApp>(macOSMicrosoftEdgeAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSMicrosoftEdgeApp using PATCH and returns a <see cref="GraphResponse{MacOSMicrosoftEdgeApp}"/> object.
        /// </summary>
        /// <param name="macOSMicrosoftEdgeAppToUpdate">The MacOSMicrosoftEdgeApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSMicrosoftEdgeApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSMicrosoftEdgeApp>> UpdateResponseAsync(MacOSMicrosoftEdgeApp macOSMicrosoftEdgeAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<MacOSMicrosoftEdgeApp>(macOSMicrosoftEdgeAppToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MacOSMicrosoftEdgeApp using PUT.
        /// </summary>
        /// <param name="macOSMicrosoftEdgeAppToUpdate">The MacOSMicrosoftEdgeApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<MacOSMicrosoftEdgeApp> PutAsync(MacOSMicrosoftEdgeApp macOSMicrosoftEdgeAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<MacOSMicrosoftEdgeApp>(macOSMicrosoftEdgeAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSMicrosoftEdgeApp using PUT and returns a <see cref="GraphResponse{MacOSMicrosoftEdgeApp}"/> object.
        /// </summary>
        /// <param name="macOSMicrosoftEdgeAppToUpdate">The MacOSMicrosoftEdgeApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{MacOSMicrosoftEdgeApp}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSMicrosoftEdgeApp>> PutResponseAsync(MacOSMicrosoftEdgeApp macOSMicrosoftEdgeAppToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<MacOSMicrosoftEdgeApp>(macOSMicrosoftEdgeAppToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSMicrosoftEdgeAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSMicrosoftEdgeAppRequest Expand(Expression<Func<MacOSMicrosoftEdgeApp, object>> expandExpression)
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
        public IMacOSMicrosoftEdgeAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSMicrosoftEdgeAppRequest Select(Expression<Func<MacOSMicrosoftEdgeApp, object>> selectExpression)
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
        /// <param name="macOSMicrosoftEdgeAppToInitialize">The <see cref="MacOSMicrosoftEdgeApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSMicrosoftEdgeApp macOSMicrosoftEdgeAppToInitialize)
        {

        }
    }
}

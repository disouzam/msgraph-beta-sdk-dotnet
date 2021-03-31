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
    /// The type MicrosoftTunnelServerRequest.
    /// </summary>
    public partial class MicrosoftTunnelServerRequest : BaseRequest, IMicrosoftTunnelServerRequest
    {
        /// <summary>
        /// Constructs a new MicrosoftTunnelServerRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MicrosoftTunnelServerRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MicrosoftTunnelServer using POST.
        /// </summary>
        /// <param name="microsoftTunnelServerToCreate">The MicrosoftTunnelServer to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftTunnelServer.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelServer> CreateAsync(MicrosoftTunnelServer microsoftTunnelServerToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<MicrosoftTunnelServer>(microsoftTunnelServerToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MicrosoftTunnelServer using POST and returns a <see cref="GraphResponse{MicrosoftTunnelServer}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelServerToCreate">The MicrosoftTunnelServer to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelServer}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServer>> CreateResponseAsync(MicrosoftTunnelServer microsoftTunnelServerToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<MicrosoftTunnelServer>(microsoftTunnelServerToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MicrosoftTunnelServer.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<MicrosoftTunnelServer>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MicrosoftTunnelServer and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MicrosoftTunnelServer.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftTunnelServer.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelServer> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<MicrosoftTunnelServer>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MicrosoftTunnelServer and returns a <see cref="GraphResponse{MicrosoftTunnelServer}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelServer}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServer>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<MicrosoftTunnelServer>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelServer using PATCH.
        /// </summary>
        /// <param name="microsoftTunnelServerToUpdate">The MicrosoftTunnelServer to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftTunnelServer.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelServer> UpdateAsync(MicrosoftTunnelServer microsoftTunnelServerToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<MicrosoftTunnelServer>(microsoftTunnelServerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelServer using PATCH and returns a <see cref="GraphResponse{MicrosoftTunnelServer}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelServerToUpdate">The MicrosoftTunnelServer to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelServer}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServer>> UpdateResponseAsync(MicrosoftTunnelServer microsoftTunnelServerToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<MicrosoftTunnelServer>(microsoftTunnelServerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelServer using PUT.
        /// </summary>
        /// <param name="microsoftTunnelServerToUpdate">The MicrosoftTunnelServer object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelServer> PutAsync(MicrosoftTunnelServer microsoftTunnelServerToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<MicrosoftTunnelServer>(microsoftTunnelServerToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelServer using PUT and returns a <see cref="GraphResponse{MicrosoftTunnelServer}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelServerToUpdate">The MicrosoftTunnelServer object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{MicrosoftTunnelServer}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelServer>> PutResponseAsync(MicrosoftTunnelServer microsoftTunnelServerToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<MicrosoftTunnelServer>(microsoftTunnelServerToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftTunnelServerRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftTunnelServerRequest Expand(Expression<Func<MicrosoftTunnelServer, object>> expandExpression)
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
        public IMicrosoftTunnelServerRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftTunnelServerRequest Select(Expression<Func<MicrosoftTunnelServer, object>> selectExpression)
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
        /// <param name="microsoftTunnelServerToInitialize">The <see cref="MicrosoftTunnelServer"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MicrosoftTunnelServer microsoftTunnelServerToInitialize)
        {

        }
    }
}

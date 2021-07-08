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
    /// The type IdentityCustomUserFlowAttributeRequest.
    /// </summary>
    public partial class IdentityCustomUserFlowAttributeRequest : BaseRequest, IIdentityCustomUserFlowAttributeRequest
    {
        /// <summary>
        /// Constructs a new IdentityCustomUserFlowAttributeRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IdentityCustomUserFlowAttributeRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IdentityCustomUserFlowAttribute using POST.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToCreate">The IdentityCustomUserFlowAttribute to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityCustomUserFlowAttribute.</returns>
        public async System.Threading.Tasks.Task<IdentityCustomUserFlowAttribute> CreateAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<IdentityCustomUserFlowAttribute>(identityCustomUserFlowAttributeToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IdentityCustomUserFlowAttribute using POST and returns a <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToCreate">The IdentityCustomUserFlowAttribute to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityCustomUserFlowAttribute>> CreateResponseAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<IdentityCustomUserFlowAttribute>(identityCustomUserFlowAttributeToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IdentityCustomUserFlowAttribute.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<IdentityCustomUserFlowAttribute>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IdentityCustomUserFlowAttribute and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IdentityCustomUserFlowAttribute.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityCustomUserFlowAttribute.</returns>
        public async System.Threading.Tasks.Task<IdentityCustomUserFlowAttribute> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<IdentityCustomUserFlowAttribute>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IdentityCustomUserFlowAttribute and returns a <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityCustomUserFlowAttribute>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IdentityCustomUserFlowAttribute>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IdentityCustomUserFlowAttribute using PATCH.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToUpdate">The IdentityCustomUserFlowAttribute to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityCustomUserFlowAttribute.</returns>
        public async System.Threading.Tasks.Task<IdentityCustomUserFlowAttribute> UpdateAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<IdentityCustomUserFlowAttribute>(identityCustomUserFlowAttributeToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IdentityCustomUserFlowAttribute using PATCH and returns a <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToUpdate">The IdentityCustomUserFlowAttribute to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityCustomUserFlowAttribute>> UpdateResponseAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<IdentityCustomUserFlowAttribute>(identityCustomUserFlowAttributeToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IdentityCustomUserFlowAttribute using PUT.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToUpdate">The IdentityCustomUserFlowAttribute object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<IdentityCustomUserFlowAttribute> PutAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<IdentityCustomUserFlowAttribute>(identityCustomUserFlowAttributeToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IdentityCustomUserFlowAttribute using PUT and returns a <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToUpdate">The IdentityCustomUserFlowAttribute object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityCustomUserFlowAttribute>> PutResponseAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<IdentityCustomUserFlowAttribute>(identityCustomUserFlowAttributeToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityCustomUserFlowAttributeRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityCustomUserFlowAttributeRequest Expand(Expression<Func<IdentityCustomUserFlowAttribute, object>> expandExpression)
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
        public IIdentityCustomUserFlowAttributeRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityCustomUserFlowAttributeRequest Select(Expression<Func<IdentityCustomUserFlowAttribute, object>> selectExpression)
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
        /// <param name="identityCustomUserFlowAttributeToInitialize">The <see cref="IdentityCustomUserFlowAttribute"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToInitialize)
        {

        }
    }
}

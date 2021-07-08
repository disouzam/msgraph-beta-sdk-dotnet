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
    /// The type AccessPackageResourceRequest.
    /// </summary>
    public partial class AccessPackageResourceRequest : BaseRequest, IAccessPackageResourceRequest
    {
        /// <summary>
        /// Constructs a new AccessPackageResourceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessPackageResourceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AccessPackageResource using POST.
        /// </summary>
        /// <param name="accessPackageResourceToCreate">The AccessPackageResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageResource.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResource> CreateAsync(AccessPackageResource accessPackageResourceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AccessPackageResource>(accessPackageResourceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AccessPackageResource using POST and returns a <see cref="GraphResponse{AccessPackageResource}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceToCreate">The AccessPackageResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResource}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResource>> CreateResponseAsync(AccessPackageResource accessPackageResourceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AccessPackageResource>(accessPackageResourceToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AccessPackageResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AccessPackageResource>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AccessPackageResource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AccessPackageResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageResource.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResource> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AccessPackageResource>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AccessPackageResource and returns a <see cref="GraphResponse{AccessPackageResource}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResource}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResource>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AccessPackageResource>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessPackageResource using PATCH.
        /// </summary>
        /// <param name="accessPackageResourceToUpdate">The AccessPackageResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageResource.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResource> UpdateAsync(AccessPackageResource accessPackageResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AccessPackageResource>(accessPackageResourceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessPackageResource using PATCH and returns a <see cref="GraphResponse{AccessPackageResource}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceToUpdate">The AccessPackageResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageResource}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResource>> UpdateResponseAsync(AccessPackageResource accessPackageResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AccessPackageResource>(accessPackageResourceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessPackageResource using PUT.
        /// </summary>
        /// <param name="accessPackageResourceToUpdate">The AccessPackageResource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResource> PutAsync(AccessPackageResource accessPackageResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AccessPackageResource>(accessPackageResourceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessPackageResource using PUT and returns a <see cref="GraphResponse{AccessPackageResource}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceToUpdate">The AccessPackageResource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AccessPackageResource}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResource>> PutResponseAsync(AccessPackageResource accessPackageResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AccessPackageResource>(accessPackageResourceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageResourceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageResourceRequest Expand(Expression<Func<AccessPackageResource, object>> expandExpression)
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
        public IAccessPackageResourceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageResourceRequest Select(Expression<Func<AccessPackageResource, object>> selectExpression)
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
        /// <param name="accessPackageResourceToInitialize">The <see cref="AccessPackageResource"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AccessPackageResource accessPackageResourceToInitialize)
        {

            if (accessPackageResourceToInitialize != null)
            {
                if (accessPackageResourceToInitialize.AccessPackageResourceRoles != null && accessPackageResourceToInitialize.AccessPackageResourceRoles.CurrentPage != null)
                {
                    accessPackageResourceToInitialize.AccessPackageResourceRoles.InitializeNextPageRequest(this.Client, accessPackageResourceToInitialize.AccessPackageResourceRolesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessPackageResourceToInitialize.AccessPackageResourceRoles.AdditionalData = accessPackageResourceToInitialize.AdditionalData;
                }
                if (accessPackageResourceToInitialize.AccessPackageResourceScopes != null && accessPackageResourceToInitialize.AccessPackageResourceScopes.CurrentPage != null)
                {
                    accessPackageResourceToInitialize.AccessPackageResourceScopes.InitializeNextPageRequest(this.Client, accessPackageResourceToInitialize.AccessPackageResourceScopesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessPackageResourceToInitialize.AccessPackageResourceScopes.AdditionalData = accessPackageResourceToInitialize.AdditionalData;
                }

            }


        }
    }
}

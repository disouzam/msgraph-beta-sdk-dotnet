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
    /// The type DepIOSEnrollmentProfileRequest.
    /// </summary>
    public partial class DepIOSEnrollmentProfileRequest : BaseRequest, IDepIOSEnrollmentProfileRequest
    {
        /// <summary>
        /// Constructs a new DepIOSEnrollmentProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DepIOSEnrollmentProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DepIOSEnrollmentProfile using POST.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToCreate">The DepIOSEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DepIOSEnrollmentProfile.</returns>
        public async System.Threading.Tasks.Task<DepIOSEnrollmentProfile> CreateAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DepIOSEnrollmentProfile>(depIOSEnrollmentProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DepIOSEnrollmentProfile using POST and returns a <see cref="GraphResponse{DepIOSEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToCreate">The DepIOSEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DepIOSEnrollmentProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DepIOSEnrollmentProfile>> CreateResponseAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DepIOSEnrollmentProfile>(depIOSEnrollmentProfileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DepIOSEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DepIOSEnrollmentProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DepIOSEnrollmentProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DepIOSEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DepIOSEnrollmentProfile.</returns>
        public async System.Threading.Tasks.Task<DepIOSEnrollmentProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DepIOSEnrollmentProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DepIOSEnrollmentProfile and returns a <see cref="GraphResponse{DepIOSEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DepIOSEnrollmentProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DepIOSEnrollmentProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DepIOSEnrollmentProfile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DepIOSEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToUpdate">The DepIOSEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DepIOSEnrollmentProfile.</returns>
        public async System.Threading.Tasks.Task<DepIOSEnrollmentProfile> UpdateAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DepIOSEnrollmentProfile>(depIOSEnrollmentProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DepIOSEnrollmentProfile using PATCH and returns a <see cref="GraphResponse{DepIOSEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToUpdate">The DepIOSEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DepIOSEnrollmentProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DepIOSEnrollmentProfile>> UpdateResponseAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DepIOSEnrollmentProfile>(depIOSEnrollmentProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DepIOSEnrollmentProfile using PUT.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToUpdate">The DepIOSEnrollmentProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DepIOSEnrollmentProfile> PutAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DepIOSEnrollmentProfile>(depIOSEnrollmentProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DepIOSEnrollmentProfile using PUT and returns a <see cref="GraphResponse{DepIOSEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToUpdate">The DepIOSEnrollmentProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DepIOSEnrollmentProfile}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DepIOSEnrollmentProfile>> PutResponseAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DepIOSEnrollmentProfile>(depIOSEnrollmentProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDepIOSEnrollmentProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDepIOSEnrollmentProfileRequest Expand(Expression<Func<DepIOSEnrollmentProfile, object>> expandExpression)
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
        public IDepIOSEnrollmentProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDepIOSEnrollmentProfileRequest Select(Expression<Func<DepIOSEnrollmentProfile, object>> selectExpression)
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
        /// <param name="depIOSEnrollmentProfileToInitialize">The <see cref="DepIOSEnrollmentProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DepIOSEnrollmentProfile depIOSEnrollmentProfileToInitialize)
        {

        }
    }
}

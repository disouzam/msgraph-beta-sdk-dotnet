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
    /// The type AospDeviceOwnerCompliancePolicyRequest.
    /// </summary>
    public partial class AospDeviceOwnerCompliancePolicyRequest : BaseRequest, IAospDeviceOwnerCompliancePolicyRequest
    {
        /// <summary>
        /// Constructs a new AospDeviceOwnerCompliancePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AospDeviceOwnerCompliancePolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AospDeviceOwnerCompliancePolicy using POST.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToCreate">The AospDeviceOwnerCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AospDeviceOwnerCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<AospDeviceOwnerCompliancePolicy> CreateAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AospDeviceOwnerCompliancePolicy>(aospDeviceOwnerCompliancePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AospDeviceOwnerCompliancePolicy using POST and returns a <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToCreate">The AospDeviceOwnerCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerCompliancePolicy>> CreateResponseAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AospDeviceOwnerCompliancePolicy>(aospDeviceOwnerCompliancePolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AospDeviceOwnerCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AospDeviceOwnerCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AospDeviceOwnerCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AospDeviceOwnerCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AospDeviceOwnerCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<AospDeviceOwnerCompliancePolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AospDeviceOwnerCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AospDeviceOwnerCompliancePolicy and returns a <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerCompliancePolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AospDeviceOwnerCompliancePolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AospDeviceOwnerCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToUpdate">The AospDeviceOwnerCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AospDeviceOwnerCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<AospDeviceOwnerCompliancePolicy> UpdateAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AospDeviceOwnerCompliancePolicy>(aospDeviceOwnerCompliancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AospDeviceOwnerCompliancePolicy using PATCH and returns a <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToUpdate">The AospDeviceOwnerCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerCompliancePolicy>> UpdateResponseAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AospDeviceOwnerCompliancePolicy>(aospDeviceOwnerCompliancePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AospDeviceOwnerCompliancePolicy using PUT.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToUpdate">The AospDeviceOwnerCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AospDeviceOwnerCompliancePolicy> PutAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AospDeviceOwnerCompliancePolicy>(aospDeviceOwnerCompliancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AospDeviceOwnerCompliancePolicy using PUT and returns a <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToUpdate">The AospDeviceOwnerCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerCompliancePolicy>> PutResponseAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AospDeviceOwnerCompliancePolicy>(aospDeviceOwnerCompliancePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAospDeviceOwnerCompliancePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAospDeviceOwnerCompliancePolicyRequest Expand(Expression<Func<AospDeviceOwnerCompliancePolicy, object>> expandExpression)
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
        public IAospDeviceOwnerCompliancePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAospDeviceOwnerCompliancePolicyRequest Select(Expression<Func<AospDeviceOwnerCompliancePolicy, object>> selectExpression)
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
        /// <param name="aospDeviceOwnerCompliancePolicyToInitialize">The <see cref="AospDeviceOwnerCompliancePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToInitialize)
        {

        }
    }
}

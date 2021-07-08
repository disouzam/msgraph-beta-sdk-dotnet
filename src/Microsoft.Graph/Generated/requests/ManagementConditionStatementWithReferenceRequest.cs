// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ManagementConditionStatementWithReferenceRequest.
    /// </summary>
    public partial class ManagementConditionStatementWithReferenceRequest : BaseRequest, IManagementConditionStatementWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new ManagementConditionStatementWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagementConditionStatementWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified ManagementConditionStatement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagementConditionStatement.</returns>
        public async System.Threading.Tasks.Task<ManagementConditionStatement> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ManagementConditionStatement>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ManagementConditionStatement and returns a <see cref="GraphResponse{ManagementConditionStatement}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementConditionStatement}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagementConditionStatement>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ManagementConditionStatement>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified ManagementConditionStatement using POST.
        /// </summary>
        /// <param name="managementConditionStatementToCreate">The ManagementConditionStatement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagementConditionStatement.</returns>
        public async System.Threading.Tasks.Task<ManagementConditionStatement> CreateAsync(ManagementConditionStatement managementConditionStatementToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ManagementConditionStatement>(managementConditionStatementToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified ManagementConditionStatement using POST and returns a <see cref="GraphResponse{ManagementConditionStatement}"/> object.
        /// </summary>
        /// <param name="managementConditionStatementToCreate">The ManagementConditionStatement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementConditionStatement}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagementConditionStatement>> CreateResponseAsync(ManagementConditionStatement managementConditionStatementToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ManagementConditionStatement>(managementConditionStatementToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified ManagementConditionStatement using PATCH.
        /// </summary>
        /// <param name="managementConditionStatementToUpdate">The ManagementConditionStatement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagementConditionStatement.</returns>
        public async System.Threading.Tasks.Task<ManagementConditionStatement> UpdateAsync(ManagementConditionStatement managementConditionStatementToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ManagementConditionStatement>(managementConditionStatementToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified ManagementConditionStatement using PATCH and returns a <see cref="GraphResponse{ManagementConditionStatement}"/> object.
        /// </summary>
        /// <param name="managementConditionStatementToUpdate">The ManagementConditionStatement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagementConditionStatement}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagementConditionStatement>> UpdateResponseAsync(ManagementConditionStatement managementConditionStatementToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ManagementConditionStatement>(managementConditionStatementToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified ManagementConditionStatement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ManagementConditionStatement>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified ManagementConditionStatement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagementConditionStatementWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagementConditionStatementWithReferenceRequest Expand(Expression<Func<ManagementConditionStatement, object>> expandExpression)
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
        public IManagementConditionStatementWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagementConditionStatementWithReferenceRequest Select(Expression<Func<ManagementConditionStatement, object>> selectExpression)
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

    }
}

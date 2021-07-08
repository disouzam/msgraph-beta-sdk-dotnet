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
    /// The type UnifiedRoleManagementPolicyRuleRequest.
    /// </summary>
    public partial class UnifiedRoleManagementPolicyRuleRequest : BaseRequest, IUnifiedRoleManagementPolicyRuleRequest
    {
        /// <summary>
        /// Constructs a new UnifiedRoleManagementPolicyRuleRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnifiedRoleManagementPolicyRuleRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnifiedRoleManagementPolicyRule using POST.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyRuleToCreate">The UnifiedRoleManagementPolicyRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleManagementPolicyRule.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleManagementPolicyRule> CreateAsync(UnifiedRoleManagementPolicyRule unifiedRoleManagementPolicyRuleToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UnifiedRoleManagementPolicyRule>(unifiedRoleManagementPolicyRuleToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UnifiedRoleManagementPolicyRule using POST and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyRule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyRuleToCreate">The UnifiedRoleManagementPolicyRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyRule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyRule>> CreateResponseAsync(UnifiedRoleManagementPolicyRule unifiedRoleManagementPolicyRuleToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UnifiedRoleManagementPolicyRule>(unifiedRoleManagementPolicyRuleToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicyRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UnifiedRoleManagementPolicyRule>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicyRule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleManagementPolicyRule.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleManagementPolicyRule> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UnifiedRoleManagementPolicyRule>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyRule and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyRule}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyRule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyRule>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UnifiedRoleManagementPolicyRule>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyRule using PATCH.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyRuleToUpdate">The UnifiedRoleManagementPolicyRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleManagementPolicyRule.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleManagementPolicyRule> UpdateAsync(UnifiedRoleManagementPolicyRule unifiedRoleManagementPolicyRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UnifiedRoleManagementPolicyRule>(unifiedRoleManagementPolicyRuleToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyRule using PATCH and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyRule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyRuleToUpdate">The UnifiedRoleManagementPolicyRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyRule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyRule>> UpdateResponseAsync(UnifiedRoleManagementPolicyRule unifiedRoleManagementPolicyRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UnifiedRoleManagementPolicyRule>(unifiedRoleManagementPolicyRuleToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyRule using PUT.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyRuleToUpdate">The UnifiedRoleManagementPolicyRule object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UnifiedRoleManagementPolicyRule> PutAsync(UnifiedRoleManagementPolicyRule unifiedRoleManagementPolicyRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UnifiedRoleManagementPolicyRule>(unifiedRoleManagementPolicyRuleToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyRule using PUT and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyRule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyRuleToUpdate">The UnifiedRoleManagementPolicyRule object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UnifiedRoleManagementPolicyRule}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyRule>> PutResponseAsync(UnifiedRoleManagementPolicyRule unifiedRoleManagementPolicyRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UnifiedRoleManagementPolicyRule>(unifiedRoleManagementPolicyRuleToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleManagementPolicyRuleRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleManagementPolicyRuleRequest Expand(Expression<Func<UnifiedRoleManagementPolicyRule, object>> expandExpression)
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
        public IUnifiedRoleManagementPolicyRuleRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRoleManagementPolicyRuleRequest Select(Expression<Func<UnifiedRoleManagementPolicyRule, object>> selectExpression)
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
        /// <param name="unifiedRoleManagementPolicyRuleToInitialize">The <see cref="UnifiedRoleManagementPolicyRule"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnifiedRoleManagementPolicyRule unifiedRoleManagementPolicyRuleToInitialize)
        {

        }
    }
}

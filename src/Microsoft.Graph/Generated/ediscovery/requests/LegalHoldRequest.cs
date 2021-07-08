// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type LegalHoldRequest.
    /// </summary>
    public partial class LegalHoldRequest : Microsoft.Graph.BaseRequest, ILegalHoldRequest
    {
        /// <summary>
        /// Constructs a new LegalHoldRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public LegalHoldRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified LegalHold using POST.
        /// </summary>
        /// <param name="legalHoldToCreate">The LegalHold to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LegalHold.</returns>
        public async System.Threading.Tasks.Task<LegalHold> CreateAsync(LegalHold legalHoldToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<LegalHold>(legalHoldToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified LegalHold using POST and returns a <see cref="GraphResponse{LegalHold}"/> object.
        /// </summary>
        /// <param name="legalHoldToCreate">The LegalHold to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LegalHold}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LegalHold>> CreateResponseAsync(LegalHold legalHoldToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<LegalHold>(legalHoldToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified LegalHold.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<LegalHold>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified LegalHold and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified LegalHold.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The LegalHold.</returns>
        public async System.Threading.Tasks.Task<LegalHold> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<LegalHold>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified LegalHold and returns a <see cref="GraphResponse{LegalHold}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LegalHold}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LegalHold>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<LegalHold>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified LegalHold using PATCH.
        /// </summary>
        /// <param name="legalHoldToUpdate">The LegalHold to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated LegalHold.</returns>
        public async System.Threading.Tasks.Task<LegalHold> UpdateAsync(LegalHold legalHoldToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<LegalHold>(legalHoldToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified LegalHold using PATCH and returns a <see cref="GraphResponse{LegalHold}"/> object.
        /// </summary>
        /// <param name="legalHoldToUpdate">The LegalHold to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{LegalHold}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LegalHold>> UpdateResponseAsync(LegalHold legalHoldToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<LegalHold>(legalHoldToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified LegalHold using PUT.
        /// </summary>
        /// <param name="legalHoldToUpdate">The LegalHold object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<LegalHold> PutAsync(LegalHold legalHoldToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<LegalHold>(legalHoldToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified LegalHold using PUT and returns a <see cref="GraphResponse{LegalHold}"/> object.
        /// </summary>
        /// <param name="legalHoldToUpdate">The LegalHold object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{LegalHold}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LegalHold>> PutResponseAsync(LegalHold legalHoldToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<LegalHold>(legalHoldToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILegalHoldRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILegalHoldRequest Expand(Expression<Func<LegalHold, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ILegalHoldRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ILegalHoldRequest Select(Expression<Func<LegalHold, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="legalHoldToInitialize">The <see cref="LegalHold"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(LegalHold legalHoldToInitialize)
        {

            if (legalHoldToInitialize != null)
            {
                if (legalHoldToInitialize.SiteSources != null && legalHoldToInitialize.SiteSources.CurrentPage != null)
                {
                    legalHoldToInitialize.SiteSources.InitializeNextPageRequest(this.Client, legalHoldToInitialize.SiteSourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    legalHoldToInitialize.SiteSources.AdditionalData = legalHoldToInitialize.AdditionalData;
                }
                if (legalHoldToInitialize.UnifiedGroupSources != null && legalHoldToInitialize.UnifiedGroupSources.CurrentPage != null)
                {
                    legalHoldToInitialize.UnifiedGroupSources.InitializeNextPageRequest(this.Client, legalHoldToInitialize.UnifiedGroupSourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    legalHoldToInitialize.UnifiedGroupSources.AdditionalData = legalHoldToInitialize.AdditionalData;
                }
                if (legalHoldToInitialize.UserSources != null && legalHoldToInitialize.UserSources.CurrentPage != null)
                {
                    legalHoldToInitialize.UserSources.InitializeNextPageRequest(this.Client, legalHoldToInitialize.UserSourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    legalHoldToInitialize.UserSources.AdditionalData = legalHoldToInitialize.AdditionalData;
                }

            }


        }
    }
}

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
    /// The type Windows81SCEPCertificateProfileRequest.
    /// </summary>
    public partial class Windows81SCEPCertificateProfileRequest : BaseRequest, IWindows81SCEPCertificateProfileRequest
    {
        /// <summary>
        /// Constructs a new Windows81SCEPCertificateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Windows81SCEPCertificateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Windows81SCEPCertificateProfile using POST.
        /// </summary>
        /// <param name="windows81SCEPCertificateProfileToCreate">The Windows81SCEPCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows81SCEPCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<Windows81SCEPCertificateProfile> CreateAsync(Windows81SCEPCertificateProfile windows81SCEPCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Windows81SCEPCertificateProfile>(windows81SCEPCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Windows81SCEPCertificateProfile using POST and returns a <see cref="GraphResponse{Windows81SCEPCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows81SCEPCertificateProfileToCreate">The Windows81SCEPCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows81SCEPCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows81SCEPCertificateProfile>> CreateResponseAsync(Windows81SCEPCertificateProfile windows81SCEPCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Windows81SCEPCertificateProfile>(windows81SCEPCertificateProfileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Windows81SCEPCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Windows81SCEPCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Windows81SCEPCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Windows81SCEPCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows81SCEPCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<Windows81SCEPCertificateProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Windows81SCEPCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Windows81SCEPCertificateProfile and returns a <see cref="GraphResponse{Windows81SCEPCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows81SCEPCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows81SCEPCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Windows81SCEPCertificateProfile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Windows81SCEPCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windows81SCEPCertificateProfileToUpdate">The Windows81SCEPCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows81SCEPCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<Windows81SCEPCertificateProfile> UpdateAsync(Windows81SCEPCertificateProfile windows81SCEPCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Windows81SCEPCertificateProfile>(windows81SCEPCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Windows81SCEPCertificateProfile using PATCH and returns a <see cref="GraphResponse{Windows81SCEPCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows81SCEPCertificateProfileToUpdate">The Windows81SCEPCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows81SCEPCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows81SCEPCertificateProfile>> UpdateResponseAsync(Windows81SCEPCertificateProfile windows81SCEPCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Windows81SCEPCertificateProfile>(windows81SCEPCertificateProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Windows81SCEPCertificateProfile using PUT.
        /// </summary>
        /// <param name="windows81SCEPCertificateProfileToUpdate">The Windows81SCEPCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Windows81SCEPCertificateProfile> PutAsync(Windows81SCEPCertificateProfile windows81SCEPCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Windows81SCEPCertificateProfile>(windows81SCEPCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Windows81SCEPCertificateProfile using PUT and returns a <see cref="GraphResponse{Windows81SCEPCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows81SCEPCertificateProfileToUpdate">The Windows81SCEPCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Windows81SCEPCertificateProfile}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows81SCEPCertificateProfile>> PutResponseAsync(Windows81SCEPCertificateProfile windows81SCEPCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Windows81SCEPCertificateProfile>(windows81SCEPCertificateProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows81SCEPCertificateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows81SCEPCertificateProfileRequest Expand(Expression<Func<Windows81SCEPCertificateProfile, object>> expandExpression)
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
        public IWindows81SCEPCertificateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows81SCEPCertificateProfileRequest Select(Expression<Func<Windows81SCEPCertificateProfile, object>> selectExpression)
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
        /// <param name="windows81SCEPCertificateProfileToInitialize">The <see cref="Windows81SCEPCertificateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Windows81SCEPCertificateProfile windows81SCEPCertificateProfileToInitialize)
        {

            if (windows81SCEPCertificateProfileToInitialize != null)
            {
                if (windows81SCEPCertificateProfileToInitialize.ManagedDeviceCertificateStates != null && windows81SCEPCertificateProfileToInitialize.ManagedDeviceCertificateStates.CurrentPage != null)
                {
                    windows81SCEPCertificateProfileToInitialize.ManagedDeviceCertificateStates.InitializeNextPageRequest(this.Client, windows81SCEPCertificateProfileToInitialize.ManagedDeviceCertificateStatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    windows81SCEPCertificateProfileToInitialize.ManagedDeviceCertificateStates.AdditionalData = windows81SCEPCertificateProfileToInitialize.AdditionalData;
                }

            }


        }
    }
}

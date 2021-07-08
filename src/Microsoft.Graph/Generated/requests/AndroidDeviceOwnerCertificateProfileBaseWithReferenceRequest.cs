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
    /// The type AndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest.
    /// </summary>
    public partial class AndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest : BaseRequest, IAndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new AndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceOwnerCertificateProfileBase.</returns>
        public async System.Threading.Tasks.Task<AndroidDeviceOwnerCertificateProfileBase> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AndroidDeviceOwnerCertificateProfileBase>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerCertificateProfileBase and returns a <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerCertificateProfileBase>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AndroidDeviceOwnerCertificateProfileBase>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified AndroidDeviceOwnerCertificateProfileBase using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerCertificateProfileBaseToCreate">The AndroidDeviceOwnerCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceOwnerCertificateProfileBase.</returns>
        public async System.Threading.Tasks.Task<AndroidDeviceOwnerCertificateProfileBase> CreateAsync(AndroidDeviceOwnerCertificateProfileBase androidDeviceOwnerCertificateProfileBaseToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AndroidDeviceOwnerCertificateProfileBase>(androidDeviceOwnerCertificateProfileBaseToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified AndroidDeviceOwnerCertificateProfileBase using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerCertificateProfileBaseToCreate">The AndroidDeviceOwnerCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerCertificateProfileBase>> CreateResponseAsync(AndroidDeviceOwnerCertificateProfileBase androidDeviceOwnerCertificateProfileBaseToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AndroidDeviceOwnerCertificateProfileBase>(androidDeviceOwnerCertificateProfileBaseToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified AndroidDeviceOwnerCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerCertificateProfileBaseToUpdate">The AndroidDeviceOwnerCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceOwnerCertificateProfileBase.</returns>
        public async System.Threading.Tasks.Task<AndroidDeviceOwnerCertificateProfileBase> UpdateAsync(AndroidDeviceOwnerCertificateProfileBase androidDeviceOwnerCertificateProfileBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AndroidDeviceOwnerCertificateProfileBase>(androidDeviceOwnerCertificateProfileBaseToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified AndroidDeviceOwnerCertificateProfileBase using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerCertificateProfileBaseToUpdate">The AndroidDeviceOwnerCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerCertificateProfileBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerCertificateProfileBase>> UpdateResponseAsync(AndroidDeviceOwnerCertificateProfileBase androidDeviceOwnerCertificateProfileBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AndroidDeviceOwnerCertificateProfileBase>(androidDeviceOwnerCertificateProfileBaseToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified AndroidDeviceOwnerCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AndroidDeviceOwnerCertificateProfileBase>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified AndroidDeviceOwnerCertificateProfileBase and returns a <see cref="GraphResponse"/> object.
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
        public IAndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest Expand(Expression<Func<AndroidDeviceOwnerCertificateProfileBase, object>> expandExpression)
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
        public IAndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest Select(Expression<Func<AndroidDeviceOwnerCertificateProfileBase, object>> selectExpression)
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

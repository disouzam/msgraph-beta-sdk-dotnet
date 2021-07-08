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
    /// The type WindowsInformationProtectionDeviceRegistrationRequest.
    /// </summary>
    public partial class WindowsInformationProtectionDeviceRegistrationRequest : BaseRequest, IWindowsInformationProtectionDeviceRegistrationRequest
    {
        /// <summary>
        /// Constructs a new WindowsInformationProtectionDeviceRegistrationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsInformationProtectionDeviceRegistrationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtectionDeviceRegistration using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToCreate">The WindowsInformationProtectionDeviceRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtectionDeviceRegistration.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> CreateAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<WindowsInformationProtectionDeviceRegistration>(windowsInformationProtectionDeviceRegistrationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtectionDeviceRegistration using POST and returns a <see cref="GraphResponse{WindowsInformationProtectionDeviceRegistration}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToCreate">The WindowsInformationProtectionDeviceRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionDeviceRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionDeviceRegistration>> CreateResponseAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<WindowsInformationProtectionDeviceRegistration>(windowsInformationProtectionDeviceRegistrationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionDeviceRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<WindowsInformationProtectionDeviceRegistration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionDeviceRegistration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionDeviceRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtectionDeviceRegistration.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<WindowsInformationProtectionDeviceRegistration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionDeviceRegistration and returns a <see cref="GraphResponse{WindowsInformationProtectionDeviceRegistration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionDeviceRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionDeviceRegistration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<WindowsInformationProtectionDeviceRegistration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtectionDeviceRegistration using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToUpdate">The WindowsInformationProtectionDeviceRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsInformationProtectionDeviceRegistration.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> UpdateAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<WindowsInformationProtectionDeviceRegistration>(windowsInformationProtectionDeviceRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtectionDeviceRegistration using PATCH and returns a <see cref="GraphResponse{WindowsInformationProtectionDeviceRegistration}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToUpdate">The WindowsInformationProtectionDeviceRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtectionDeviceRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionDeviceRegistration>> UpdateResponseAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<WindowsInformationProtectionDeviceRegistration>(windowsInformationProtectionDeviceRegistrationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtectionDeviceRegistration using PUT.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToUpdate">The WindowsInformationProtectionDeviceRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> PutAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<WindowsInformationProtectionDeviceRegistration>(windowsInformationProtectionDeviceRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtectionDeviceRegistration using PUT and returns a <see cref="GraphResponse{WindowsInformationProtectionDeviceRegistration}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToUpdate">The WindowsInformationProtectionDeviceRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{WindowsInformationProtectionDeviceRegistration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtectionDeviceRegistration>> PutResponseAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<WindowsInformationProtectionDeviceRegistration>(windowsInformationProtectionDeviceRegistrationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionDeviceRegistrationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionDeviceRegistrationRequest Expand(Expression<Func<WindowsInformationProtectionDeviceRegistration, object>> expandExpression)
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
        public IWindowsInformationProtectionDeviceRegistrationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionDeviceRegistrationRequest Select(Expression<Func<WindowsInformationProtectionDeviceRegistration, object>> selectExpression)
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
        /// <param name="windowsInformationProtectionDeviceRegistrationToInitialize">The <see cref="WindowsInformationProtectionDeviceRegistration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToInitialize)
        {

        }
    }
}

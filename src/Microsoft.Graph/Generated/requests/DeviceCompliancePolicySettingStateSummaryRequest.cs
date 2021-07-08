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
    /// The type DeviceCompliancePolicySettingStateSummaryRequest.
    /// </summary>
    public partial class DeviceCompliancePolicySettingStateSummaryRequest : BaseRequest, IDeviceCompliancePolicySettingStateSummaryRequest
    {
        /// <summary>
        /// Constructs a new DeviceCompliancePolicySettingStateSummaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceCompliancePolicySettingStateSummaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceCompliancePolicySettingStateSummary using POST.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToCreate">The DeviceCompliancePolicySettingStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicySettingStateSummary.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicySettingStateSummary> CreateAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceCompliancePolicySettingStateSummary>(deviceCompliancePolicySettingStateSummaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceCompliancePolicySettingStateSummary using POST and returns a <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToCreate">The DeviceCompliancePolicySettingStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicySettingStateSummary>> CreateResponseAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceCompliancePolicySettingStateSummary>(deviceCompliancePolicySettingStateSummaryToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicySettingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceCompliancePolicySettingStateSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicySettingStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceCompliancePolicySettingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCompliancePolicySettingStateSummary.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicySettingStateSummary> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceCompliancePolicySettingStateSummary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceCompliancePolicySettingStateSummary and returns a <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicySettingStateSummary>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceCompliancePolicySettingStateSummary>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicySettingStateSummary using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToUpdate">The DeviceCompliancePolicySettingStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceCompliancePolicySettingStateSummary.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicySettingStateSummary> UpdateAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceCompliancePolicySettingStateSummary>(deviceCompliancePolicySettingStateSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicySettingStateSummary using PATCH and returns a <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToUpdate">The DeviceCompliancePolicySettingStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicySettingStateSummary>> UpdateResponseAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceCompliancePolicySettingStateSummary>(deviceCompliancePolicySettingStateSummaryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicySettingStateSummary using PUT.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToUpdate">The DeviceCompliancePolicySettingStateSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicySettingStateSummary> PutAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceCompliancePolicySettingStateSummary>(deviceCompliancePolicySettingStateSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicySettingStateSummary using PUT and returns a <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummaryToUpdate">The DeviceCompliancePolicySettingStateSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicySettingStateSummary>> PutResponseAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceCompliancePolicySettingStateSummary>(deviceCompliancePolicySettingStateSummaryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicySettingStateSummaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicySettingStateSummaryRequest Expand(Expression<Func<DeviceCompliancePolicySettingStateSummary, object>> expandExpression)
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
        public IDeviceCompliancePolicySettingStateSummaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicySettingStateSummaryRequest Select(Expression<Func<DeviceCompliancePolicySettingStateSummary, object>> selectExpression)
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
        /// <param name="deviceCompliancePolicySettingStateSummaryToInitialize">The <see cref="DeviceCompliancePolicySettingStateSummary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummaryToInitialize)
        {

            if (deviceCompliancePolicySettingStateSummaryToInitialize != null)
            {
                if (deviceCompliancePolicySettingStateSummaryToInitialize.DeviceComplianceSettingStates != null && deviceCompliancePolicySettingStateSummaryToInitialize.DeviceComplianceSettingStates.CurrentPage != null)
                {
                    deviceCompliancePolicySettingStateSummaryToInitialize.DeviceComplianceSettingStates.InitializeNextPageRequest(this.Client, deviceCompliancePolicySettingStateSummaryToInitialize.DeviceComplianceSettingStatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    deviceCompliancePolicySettingStateSummaryToInitialize.DeviceComplianceSettingStates.AdditionalData = deviceCompliancePolicySettingStateSummaryToInitialize.AdditionalData;
                }

            }


        }
    }
}

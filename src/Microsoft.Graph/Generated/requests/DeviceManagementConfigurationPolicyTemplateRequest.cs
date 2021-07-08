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
    /// The type DeviceManagementConfigurationPolicyTemplateRequest.
    /// </summary>
    public partial class DeviceManagementConfigurationPolicyTemplateRequest : BaseRequest, IDeviceManagementConfigurationPolicyTemplateRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementConfigurationPolicyTemplateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementConfigurationPolicyTemplateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyTemplate using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyTemplateToCreate">The DeviceManagementConfigurationPolicyTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationPolicyTemplate.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyTemplate> CreateAsync(DeviceManagementConfigurationPolicyTemplate deviceManagementConfigurationPolicyTemplateToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceManagementConfigurationPolicyTemplate>(deviceManagementConfigurationPolicyTemplateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicyTemplate using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyTemplate}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyTemplateToCreate">The DeviceManagementConfigurationPolicyTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyTemplate>> CreateResponseAsync(DeviceManagementConfigurationPolicyTemplate deviceManagementConfigurationPolicyTemplateToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicyTemplate>(deviceManagementConfigurationPolicyTemplateToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceManagementConfigurationPolicyTemplate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicyTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationPolicyTemplate.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyTemplate> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceManagementConfigurationPolicyTemplate>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicyTemplate and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyTemplate>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicyTemplate>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyTemplate using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyTemplateToUpdate">The DeviceManagementConfigurationPolicyTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationPolicyTemplate.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyTemplate> UpdateAsync(DeviceManagementConfigurationPolicyTemplate deviceManagementConfigurationPolicyTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceManagementConfigurationPolicyTemplate>(deviceManagementConfigurationPolicyTemplateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyTemplate using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyTemplate}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyTemplateToUpdate">The DeviceManagementConfigurationPolicyTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicyTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyTemplate>> UpdateResponseAsync(DeviceManagementConfigurationPolicyTemplate deviceManagementConfigurationPolicyTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicyTemplate>(deviceManagementConfigurationPolicyTemplateToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyTemplate using PUT.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyTemplateToUpdate">The DeviceManagementConfigurationPolicyTemplate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicyTemplate> PutAsync(DeviceManagementConfigurationPolicyTemplate deviceManagementConfigurationPolicyTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceManagementConfigurationPolicyTemplate>(deviceManagementConfigurationPolicyTemplateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicyTemplate using PUT and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicyTemplate}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyTemplateToUpdate">The DeviceManagementConfigurationPolicyTemplate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceManagementConfigurationPolicyTemplate}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicyTemplate>> PutResponseAsync(DeviceManagementConfigurationPolicyTemplate deviceManagementConfigurationPolicyTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicyTemplate>(deviceManagementConfigurationPolicyTemplateToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationPolicyTemplateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationPolicyTemplateRequest Expand(Expression<Func<DeviceManagementConfigurationPolicyTemplate, object>> expandExpression)
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
        public IDeviceManagementConfigurationPolicyTemplateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationPolicyTemplateRequest Select(Expression<Func<DeviceManagementConfigurationPolicyTemplate, object>> selectExpression)
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
        /// <param name="deviceManagementConfigurationPolicyTemplateToInitialize">The <see cref="DeviceManagementConfigurationPolicyTemplate"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementConfigurationPolicyTemplate deviceManagementConfigurationPolicyTemplateToInitialize)
        {

            if (deviceManagementConfigurationPolicyTemplateToInitialize != null)
            {
                if (deviceManagementConfigurationPolicyTemplateToInitialize.SettingTemplates != null && deviceManagementConfigurationPolicyTemplateToInitialize.SettingTemplates.CurrentPage != null)
                {
                    deviceManagementConfigurationPolicyTemplateToInitialize.SettingTemplates.InitializeNextPageRequest(this.Client, deviceManagementConfigurationPolicyTemplateToInitialize.SettingTemplatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    deviceManagementConfigurationPolicyTemplateToInitialize.SettingTemplates.AdditionalData = deviceManagementConfigurationPolicyTemplateToInitialize.AdditionalData;
                }

            }


        }
    }
}

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserDeviceEnrollmentConfigurationsCollectionRequestBuilder.
    /// </summary>
    public partial class UserDeviceEnrollmentConfigurationsCollectionRequestBuilder : BaseRequestBuilder, IUserDeviceEnrollmentConfigurationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserDeviceEnrollmentConfigurationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserDeviceEnrollmentConfigurationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserDeviceEnrollmentConfigurationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserDeviceEnrollmentConfigurationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserDeviceEnrollmentConfigurationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceEnrollmentConfigurationRequestBuilder"/> for the specified UserDeviceEnrollmentConfiguration.
        /// </summary>
        /// <param name="id">The ID for the UserDeviceEnrollmentConfiguration.</param>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationRequestBuilder"/>.</returns>
        public IDeviceEnrollmentConfigurationRequestBuilder this[string id]
        {
            get
            {
                return new DeviceEnrollmentConfigurationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurationHasPayloadLinks.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationHasPayloadLinksRequestBuilder"/>.</returns>
        public IDeviceEnrollmentConfigurationHasPayloadLinksRequestBuilder HasPayloadLinks(
            IEnumerable<string> payloadIds = null)
        {
            return new DeviceEnrollmentConfigurationHasPayloadLinksRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.hasPayloadLinks"),
                this.Client,
                payloadIds);
        }

        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurationCreateEnrollmentNotificationConfiguration.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationCreateEnrollmentNotificationConfigurationRequestBuilder"/>.</returns>
        public IDeviceEnrollmentConfigurationCreateEnrollmentNotificationConfigurationRequestBuilder CreateEnrollmentNotificationConfiguration(
            IEnumerable<DeviceEnrollmentConfiguration> deviceEnrollmentNotificationConfigurations = null)
        {
            return new DeviceEnrollmentConfigurationCreateEnrollmentNotificationConfigurationRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createEnrollmentNotificationConfiguration"),
                this.Client,
                deviceEnrollmentNotificationConfigurations);
        }
    }
}

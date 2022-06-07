// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceManagementDeviceEnrollmentConfigurationsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementDeviceEnrollmentConfigurationsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementDeviceEnrollmentConfigurationsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementDeviceEnrollmentConfigurationsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceEnrollmentConfigurationRequestBuilder"/> for the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <param name="id">The ID for the DeviceEnrollmentConfiguration.</param>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationRequestBuilder"/>.</returns>
        IDeviceEnrollmentConfigurationRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurationHasPayloadLinks.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationHasPayloadLinksRequestBuilder"/>.</returns>
        IDeviceEnrollmentConfigurationHasPayloadLinksRequestBuilder HasPayloadLinks(
            IEnumerable<string> payloadIds = null);

        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurationCreateEnrollmentNotificationConfiguration.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationCreateEnrollmentNotificationConfigurationRequestBuilder"/>.</returns>
        IDeviceEnrollmentConfigurationCreateEnrollmentNotificationConfigurationRequestBuilder CreateEnrollmentNotificationConfiguration(
            IEnumerable<DeviceEnrollmentConfiguration> deviceEnrollmentNotificationConfigurations = null);
    }
}

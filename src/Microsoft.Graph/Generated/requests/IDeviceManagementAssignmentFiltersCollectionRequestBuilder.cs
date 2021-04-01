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
    /// The interface IDeviceManagementAssignmentFiltersCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementAssignmentFiltersCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementAssignmentFiltersCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementAssignmentFiltersCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceAndAppManagementAssignmentFilterRequestBuilder"/> for the specified DeviceAndAppManagementAssignmentFilter.
        /// </summary>
        /// <param name="id">The ID for the DeviceAndAppManagementAssignmentFilter.</param>
        /// <returns>The <see cref="IDeviceAndAppManagementAssignmentFilterRequestBuilder"/>.</returns>
        IDeviceAndAppManagementAssignmentFilterRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for DeviceAndAppManagementAssignmentFilterEnable.
        /// </summary>
        /// <returns>The <see cref="IDeviceAndAppManagementAssignmentFilterEnableRequestBuilder"/>.</returns>
        IDeviceAndAppManagementAssignmentFilterEnableRequestBuilder Enable(
            bool enable);

        /// <summary>
        /// Gets the request builder for DeviceAndAppManagementAssignmentFilterValidateFilter.
        /// </summary>
        /// <returns>The <see cref="IDeviceAndAppManagementAssignmentFilterValidateFilterRequestBuilder"/>.</returns>
        IDeviceAndAppManagementAssignmentFilterValidateFilterRequestBuilder ValidateFilter(
            DeviceAndAppManagementAssignmentFilter deviceAndAppManagementAssignmentFilter = null);

        /// <summary>
        /// Gets the request builder for DeviceAndAppManagementAssignmentFilterGetState.
        /// </summary>
        /// <returns>The <see cref="IDeviceAndAppManagementAssignmentFilterGetStateRequestBuilder"/>.</returns>
        IDeviceAndAppManagementAssignmentFilterGetStateRequestBuilder GetState();
    }
}

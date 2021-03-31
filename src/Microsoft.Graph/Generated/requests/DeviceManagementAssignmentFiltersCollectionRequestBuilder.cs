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
    /// The type DeviceManagementAssignmentFiltersCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementAssignmentFiltersCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementAssignmentFiltersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementAssignmentFiltersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementAssignmentFiltersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementAssignmentFiltersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementAssignmentFiltersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementAssignmentFiltersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceAndAppManagementAssignmentFilterRequestBuilder"/> for the specified DeviceManagementDeviceAndAppManagementAssignmentFilter.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceAndAppManagementAssignmentFilter.</param>
        /// <returns>The <see cref="IDeviceAndAppManagementAssignmentFilterRequestBuilder"/>.</returns>
        public IDeviceAndAppManagementAssignmentFilterRequestBuilder this[string id]
        {
            get
            {
                return new DeviceAndAppManagementAssignmentFilterRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceAndAppManagementAssignmentFilterEnable.
        /// </summary>
        /// <returns>The <see cref="IDeviceAndAppManagementAssignmentFilterEnableRequestBuilder"/>.</returns>
        public IDeviceAndAppManagementAssignmentFilterEnableRequestBuilder Enable(
            bool enable)
        {
            return new DeviceAndAppManagementAssignmentFilterEnableRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.enable"),
                this.Client,
                enable);
        }

        /// <summary>
        /// Gets the request builder for DeviceAndAppManagementAssignmentFilterValidateFilter.
        /// </summary>
        /// <returns>The <see cref="IDeviceAndAppManagementAssignmentFilterValidateFilterRequestBuilder"/>.</returns>
        public IDeviceAndAppManagementAssignmentFilterValidateFilterRequestBuilder ValidateFilter(
            DeviceAndAppManagementAssignmentFilter deviceAndAppManagementAssignmentFilter = null)
        {
            return new DeviceAndAppManagementAssignmentFilterValidateFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.validateFilter"),
                this.Client,
                deviceAndAppManagementAssignmentFilter);
        }

        /// <summary>
        /// Gets the request builder for DeviceAndAppManagementAssignmentFilterGetState.
        /// </summary>
        /// <returns>The <see cref="IDeviceAndAppManagementAssignmentFilterGetStateRequestBuilder"/>.</returns>
        public IDeviceAndAppManagementAssignmentFilterGetStateRequestBuilder GetState()
        {
            return new DeviceAndAppManagementAssignmentFilterGetStateRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getState"),
                this.Client);
        }
    }
}

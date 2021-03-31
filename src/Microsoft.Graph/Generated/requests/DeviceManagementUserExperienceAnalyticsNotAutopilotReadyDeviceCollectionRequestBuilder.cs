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
    /// The type DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder"/> for the specified DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDevice.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDevice.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

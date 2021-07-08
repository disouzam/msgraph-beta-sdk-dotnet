// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementDomainJoinConnectorRequest.
    /// </summary>
    public partial interface IDeviceManagementDomainJoinConnectorRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementDomainJoinConnector using POST.
        /// </summary>
        /// <param name="deviceManagementDomainJoinConnectorToCreate">The DeviceManagementDomainJoinConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementDomainJoinConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementDomainJoinConnector> CreateAsync(DeviceManagementDomainJoinConnector deviceManagementDomainJoinConnectorToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceManagementDomainJoinConnector using POST and returns a <see cref="GraphResponse{DeviceManagementDomainJoinConnector}"/> object.
        /// </summary>
        /// <param name="deviceManagementDomainJoinConnectorToCreate">The DeviceManagementDomainJoinConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementDomainJoinConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDomainJoinConnector>> CreateResponseAsync(DeviceManagementDomainJoinConnector deviceManagementDomainJoinConnectorToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementDomainJoinConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementDomainJoinConnector and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementDomainJoinConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementDomainJoinConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementDomainJoinConnector> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementDomainJoinConnector and returns a <see cref="GraphResponse{DeviceManagementDomainJoinConnector}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementDomainJoinConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDomainJoinConnector>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementDomainJoinConnector using PATCH.
        /// </summary>
        /// <param name="deviceManagementDomainJoinConnectorToUpdate">The DeviceManagementDomainJoinConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementDomainJoinConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementDomainJoinConnector> UpdateAsync(DeviceManagementDomainJoinConnector deviceManagementDomainJoinConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementDomainJoinConnector using PATCH and returns a <see cref="GraphResponse{DeviceManagementDomainJoinConnector}"/> object.
        /// </summary>
        /// <param name="deviceManagementDomainJoinConnectorToUpdate">The DeviceManagementDomainJoinConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementDomainJoinConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDomainJoinConnector>> UpdateResponseAsync(DeviceManagementDomainJoinConnector deviceManagementDomainJoinConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementDomainJoinConnector using PUT.
        /// </summary>
        /// <param name="deviceManagementDomainJoinConnectorToUpdate">The DeviceManagementDomainJoinConnector object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagementDomainJoinConnector> PutAsync(DeviceManagementDomainJoinConnector deviceManagementDomainJoinConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementDomainJoinConnector using PUT and returns a <see cref="GraphResponse{DeviceManagementDomainJoinConnector}"/> object.
        /// </summary>
        /// <param name="deviceManagementDomainJoinConnectorToUpdate">The DeviceManagementDomainJoinConnector object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagementDomainJoinConnector}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementDomainJoinConnector>> PutResponseAsync(DeviceManagementDomainJoinConnector deviceManagementDomainJoinConnectorToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorRequest Expand(Expression<Func<DeviceManagementDomainJoinConnector, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorRequest Select(Expression<Func<DeviceManagementDomainJoinConnector, object>> selectExpression);

    }
}

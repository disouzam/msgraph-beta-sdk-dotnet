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
    /// The interface IDeviceManagementResourceAccessProfileAssignmentRequest.
    /// </summary>
    public partial interface IDeviceManagementResourceAccessProfileAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementResourceAccessProfileAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToCreate">The DeviceManagementResourceAccessProfileAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementResourceAccessProfileAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> CreateAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceManagementResourceAccessProfileAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToCreate">The DeviceManagementResourceAccessProfileAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> CreateResponseAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementResourceAccessProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementResourceAccessProfileAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementResourceAccessProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementResourceAccessProfileAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementResourceAccessProfileAssignment and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementResourceAccessProfileAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToUpdate">The DeviceManagementResourceAccessProfileAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementResourceAccessProfileAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> UpdateAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementResourceAccessProfileAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToUpdate">The DeviceManagementResourceAccessProfileAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> UpdateResponseAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementResourceAccessProfileAssignment using PUT.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToUpdate">The DeviceManagementResourceAccessProfileAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagementResourceAccessProfileAssignment> PutAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementResourceAccessProfileAssignment using PUT and returns a <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementResourceAccessProfileAssignmentToUpdate">The DeviceManagementResourceAccessProfileAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagementResourceAccessProfileAssignment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementResourceAccessProfileAssignment>> PutResponseAsync(DeviceManagementResourceAccessProfileAssignment deviceManagementResourceAccessProfileAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementResourceAccessProfileAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementResourceAccessProfileAssignmentRequest Expand(Expression<Func<DeviceManagementResourceAccessProfileAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementResourceAccessProfileAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementResourceAccessProfileAssignmentRequest Select(Expression<Func<DeviceManagementResourceAccessProfileAssignment, object>> selectExpression);

    }
}

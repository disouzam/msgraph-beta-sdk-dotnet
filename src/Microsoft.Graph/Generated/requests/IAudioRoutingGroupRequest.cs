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
    /// The interface IAudioRoutingGroupRequest.
    /// </summary>
    public partial interface IAudioRoutingGroupRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AudioRoutingGroup using POST.
        /// </summary>
        /// <param name="audioRoutingGroupToCreate">The AudioRoutingGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AudioRoutingGroup.</returns>
        System.Threading.Tasks.Task<AudioRoutingGroup> CreateAsync(AudioRoutingGroup audioRoutingGroupToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AudioRoutingGroup using POST and returns a <see cref="GraphResponse{AudioRoutingGroup}"/> object.
        /// </summary>
        /// <param name="audioRoutingGroupToCreate">The AudioRoutingGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AudioRoutingGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AudioRoutingGroup>> CreateResponseAsync(AudioRoutingGroup audioRoutingGroupToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AudioRoutingGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AudioRoutingGroup and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AudioRoutingGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AudioRoutingGroup.</returns>
        System.Threading.Tasks.Task<AudioRoutingGroup> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AudioRoutingGroup and returns a <see cref="GraphResponse{AudioRoutingGroup}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AudioRoutingGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AudioRoutingGroup>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AudioRoutingGroup using PATCH.
        /// </summary>
        /// <param name="audioRoutingGroupToUpdate">The AudioRoutingGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AudioRoutingGroup.</returns>
        System.Threading.Tasks.Task<AudioRoutingGroup> UpdateAsync(AudioRoutingGroup audioRoutingGroupToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AudioRoutingGroup using PATCH and returns a <see cref="GraphResponse{AudioRoutingGroup}"/> object.
        /// </summary>
        /// <param name="audioRoutingGroupToUpdate">The AudioRoutingGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AudioRoutingGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AudioRoutingGroup>> UpdateResponseAsync(AudioRoutingGroup audioRoutingGroupToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AudioRoutingGroup using PUT.
        /// </summary>
        /// <param name="audioRoutingGroupToUpdate">The AudioRoutingGroup object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AudioRoutingGroup> PutAsync(AudioRoutingGroup audioRoutingGroupToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AudioRoutingGroup using PUT and returns a <see cref="GraphResponse{AudioRoutingGroup}"/> object.
        /// </summary>
        /// <param name="audioRoutingGroupToUpdate">The AudioRoutingGroup object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AudioRoutingGroup}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AudioRoutingGroup>> PutResponseAsync(AudioRoutingGroup audioRoutingGroupToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAudioRoutingGroupRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAudioRoutingGroupRequest Expand(Expression<Func<AudioRoutingGroup, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAudioRoutingGroupRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAudioRoutingGroupRequest Select(Expression<Func<AudioRoutingGroup, object>> selectExpression);

    }
}

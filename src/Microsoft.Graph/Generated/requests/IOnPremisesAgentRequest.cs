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
    /// The interface IOnPremisesAgentRequest.
    /// </summary>
    public partial interface IOnPremisesAgentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnPremisesAgent using POST.
        /// </summary>
        /// <param name="onPremisesAgentToCreate">The OnPremisesAgent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnPremisesAgent.</returns>
        System.Threading.Tasks.Task<OnPremisesAgent> CreateAsync(OnPremisesAgent onPremisesAgentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified OnPremisesAgent using POST and returns a <see cref="GraphResponse{OnPremisesAgent}"/> object.
        /// </summary>
        /// <param name="onPremisesAgentToCreate">The OnPremisesAgent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnPremisesAgent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnPremisesAgent>> CreateResponseAsync(OnPremisesAgent onPremisesAgentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OnPremisesAgent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OnPremisesAgent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OnPremisesAgent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnPremisesAgent.</returns>
        System.Threading.Tasks.Task<OnPremisesAgent> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OnPremisesAgent and returns a <see cref="GraphResponse{OnPremisesAgent}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnPremisesAgent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnPremisesAgent>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OnPremisesAgent using PATCH.
        /// </summary>
        /// <param name="onPremisesAgentToUpdate">The OnPremisesAgent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnPremisesAgent.</returns>
        System.Threading.Tasks.Task<OnPremisesAgent> UpdateAsync(OnPremisesAgent onPremisesAgentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OnPremisesAgent using PATCH and returns a <see cref="GraphResponse{OnPremisesAgent}"/> object.
        /// </summary>
        /// <param name="onPremisesAgentToUpdate">The OnPremisesAgent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OnPremisesAgent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnPremisesAgent>> UpdateResponseAsync(OnPremisesAgent onPremisesAgentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OnPremisesAgent using PUT.
        /// </summary>
        /// <param name="onPremisesAgentToUpdate">The OnPremisesAgent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<OnPremisesAgent> PutAsync(OnPremisesAgent onPremisesAgentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OnPremisesAgent using PUT and returns a <see cref="GraphResponse{OnPremisesAgent}"/> object.
        /// </summary>
        /// <param name="onPremisesAgentToUpdate">The OnPremisesAgent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{OnPremisesAgent}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnPremisesAgent>> PutResponseAsync(OnPremisesAgent onPremisesAgentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesAgentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesAgentRequest Expand(Expression<Func<OnPremisesAgent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesAgentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesAgentRequest Select(Expression<Func<OnPremisesAgent, object>> selectExpression);

    }
}

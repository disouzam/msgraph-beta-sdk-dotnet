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
    /// The interface ISecurityBaselineDeviceStateRequest.
    /// </summary>
    public partial interface ISecurityBaselineDeviceStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecurityBaselineDeviceState using POST.
        /// </summary>
        /// <param name="securityBaselineDeviceStateToCreate">The SecurityBaselineDeviceState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecurityBaselineDeviceState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineDeviceState> CreateAsync(SecurityBaselineDeviceState securityBaselineDeviceStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SecurityBaselineDeviceState using POST and returns a <see cref="GraphResponse{SecurityBaselineDeviceState}"/> object.
        /// </summary>
        /// <param name="securityBaselineDeviceStateToCreate">The SecurityBaselineDeviceState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineDeviceState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineDeviceState>> CreateResponseAsync(SecurityBaselineDeviceState securityBaselineDeviceStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SecurityBaselineDeviceState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SecurityBaselineDeviceState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SecurityBaselineDeviceState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecurityBaselineDeviceState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineDeviceState> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SecurityBaselineDeviceState and returns a <see cref="GraphResponse{SecurityBaselineDeviceState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineDeviceState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineDeviceState>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SecurityBaselineDeviceState using PATCH.
        /// </summary>
        /// <param name="securityBaselineDeviceStateToUpdate">The SecurityBaselineDeviceState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecurityBaselineDeviceState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineDeviceState> UpdateAsync(SecurityBaselineDeviceState securityBaselineDeviceStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SecurityBaselineDeviceState using PATCH and returns a <see cref="GraphResponse{SecurityBaselineDeviceState}"/> object.
        /// </summary>
        /// <param name="securityBaselineDeviceStateToUpdate">The SecurityBaselineDeviceState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineDeviceState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineDeviceState>> UpdateResponseAsync(SecurityBaselineDeviceState securityBaselineDeviceStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SecurityBaselineDeviceState using PUT.
        /// </summary>
        /// <param name="securityBaselineDeviceStateToUpdate">The SecurityBaselineDeviceState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SecurityBaselineDeviceState> PutAsync(SecurityBaselineDeviceState securityBaselineDeviceStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SecurityBaselineDeviceState using PUT and returns a <see cref="GraphResponse{SecurityBaselineDeviceState}"/> object.
        /// </summary>
        /// <param name="securityBaselineDeviceStateToUpdate">The SecurityBaselineDeviceState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SecurityBaselineDeviceState}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineDeviceState>> PutResponseAsync(SecurityBaselineDeviceState securityBaselineDeviceStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineDeviceStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineDeviceStateRequest Expand(Expression<Func<SecurityBaselineDeviceState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineDeviceStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineDeviceStateRequest Select(Expression<Func<SecurityBaselineDeviceState, object>> selectExpression);

    }
}

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
    /// The interface IIosVpnConfigurationRequest.
    /// </summary>
    public partial interface IIosVpnConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosVpnConfiguration using POST.
        /// </summary>
        /// <param name="iosVpnConfigurationToCreate">The IosVpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosVpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> CreateAsync(IosVpnConfiguration iosVpnConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified IosVpnConfiguration using POST and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosVpnConfigurationToCreate">The IosVpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> CreateResponseAsync(IosVpnConfiguration iosVpnConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosVpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosVpnConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosVpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosVpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosVpnConfiguration and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosVpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PATCH.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosVpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> UpdateAsync(IosVpnConfiguration iosVpnConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PATCH and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosVpnConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> UpdateResponseAsync(IosVpnConfiguration iosVpnConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PUT.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> PutAsync(IosVpnConfiguration iosVpnConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PUT and returns a <see cref="GraphResponse{IosVpnConfiguration}"/> object.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IosVpnConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosVpnConfiguration>> PutResponseAsync(IosVpnConfiguration iosVpnConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVpnConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVpnConfigurationRequest Expand(Expression<Func<IosVpnConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVpnConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVpnConfigurationRequest Select(Expression<Func<IosVpnConfiguration, object>> selectExpression);

    }
}

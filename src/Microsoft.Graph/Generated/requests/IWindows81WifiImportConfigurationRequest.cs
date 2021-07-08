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
    /// The interface IWindows81WifiImportConfigurationRequest.
    /// </summary>
    public partial interface IWindows81WifiImportConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows81WifiImportConfiguration using POST.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToCreate">The Windows81WifiImportConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows81WifiImportConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> CreateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified Windows81WifiImportConfiguration using POST and returns a <see cref="GraphResponse{Windows81WifiImportConfiguration}"/> object.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToCreate">The Windows81WifiImportConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows81WifiImportConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81WifiImportConfiguration>> CreateResponseAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Windows81WifiImportConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows81WifiImportConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified Windows81WifiImportConfiguration and returns a <see cref="GraphResponse{Windows81WifiImportConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows81WifiImportConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81WifiImportConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Windows81WifiImportConfiguration using PATCH.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToUpdate">The Windows81WifiImportConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows81WifiImportConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> UpdateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Windows81WifiImportConfiguration using PATCH and returns a <see cref="GraphResponse{Windows81WifiImportConfiguration}"/> object.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToUpdate">The Windows81WifiImportConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows81WifiImportConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81WifiImportConfiguration>> UpdateResponseAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Windows81WifiImportConfiguration using PUT.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToUpdate">The Windows81WifiImportConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> PutAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Windows81WifiImportConfiguration using PUT and returns a <see cref="GraphResponse{Windows81WifiImportConfiguration}"/> object.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToUpdate">The Windows81WifiImportConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Windows81WifiImportConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81WifiImportConfiguration>> PutResponseAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81WifiImportConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81WifiImportConfigurationRequest Expand(Expression<Func<Windows81WifiImportConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81WifiImportConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81WifiImportConfigurationRequest Select(Expression<Func<Windows81WifiImportConfiguration, object>> selectExpression);

    }
}

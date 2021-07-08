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
    /// The interface IMacOSExtensionsConfigurationRequest.
    /// </summary>
    public partial interface IMacOSExtensionsConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSExtensionsConfiguration using POST.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToCreate">The MacOSExtensionsConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSExtensionsConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSExtensionsConfiguration> CreateAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified MacOSExtensionsConfiguration using POST and returns a <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToCreate">The MacOSExtensionsConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSExtensionsConfiguration>> CreateResponseAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MacOSExtensionsConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MacOSExtensionsConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified MacOSExtensionsConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSExtensionsConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSExtensionsConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified MacOSExtensionsConfiguration and returns a <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSExtensionsConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MacOSExtensionsConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToUpdate">The MacOSExtensionsConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSExtensionsConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSExtensionsConfiguration> UpdateAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MacOSExtensionsConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToUpdate">The MacOSExtensionsConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSExtensionsConfiguration>> UpdateResponseAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MacOSExtensionsConfiguration using PUT.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToUpdate">The MacOSExtensionsConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MacOSExtensionsConfiguration> PutAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MacOSExtensionsConfiguration using PUT and returns a <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSExtensionsConfigurationToUpdate">The MacOSExtensionsConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MacOSExtensionsConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSExtensionsConfiguration>> PutResponseAsync(MacOSExtensionsConfiguration macOSExtensionsConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSExtensionsConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSExtensionsConfigurationRequest Expand(Expression<Func<MacOSExtensionsConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSExtensionsConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSExtensionsConfigurationRequest Select(Expression<Func<MacOSExtensionsConfiguration, object>> selectExpression);

    }
}

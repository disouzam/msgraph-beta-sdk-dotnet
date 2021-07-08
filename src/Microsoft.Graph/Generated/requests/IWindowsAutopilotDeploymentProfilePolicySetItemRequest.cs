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
    /// The interface IWindowsAutopilotDeploymentProfilePolicySetItemRequest.
    /// </summary>
    public partial interface IWindowsAutopilotDeploymentProfilePolicySetItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfilePolicySetItem using POST.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToCreate">The WindowsAutopilotDeploymentProfilePolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> CreateAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfilePolicySetItem using POST and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToCreate">The WindowsAutopilotDeploymentProfilePolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>> CreateResponseAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfilePolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfilePolicySetItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfilePolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfilePolicySetItem and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfilePolicySetItem using PATCH.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToUpdate">The WindowsAutopilotDeploymentProfilePolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> UpdateAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfilePolicySetItem using PATCH and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToUpdate">The WindowsAutopilotDeploymentProfilePolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>> UpdateResponseAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfilePolicySetItem using PUT.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToUpdate">The WindowsAutopilotDeploymentProfilePolicySetItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> PutAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfilePolicySetItem using PUT and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToUpdate">The WindowsAutopilotDeploymentProfilePolicySetItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>> PutResponseAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfilePolicySetItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfilePolicySetItemRequest Expand(Expression<Func<WindowsAutopilotDeploymentProfilePolicySetItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfilePolicySetItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfilePolicySetItemRequest Select(Expression<Func<WindowsAutopilotDeploymentProfilePolicySetItem, object>> selectExpression);

    }
}

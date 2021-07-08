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
    /// The interface IWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusRequest.
    /// </summary>
    public partial interface IWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus using POST.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToCreate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus> CreateAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus using POST and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToCreate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>> CreateResponseAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus using PATCH.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToUpdate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus> UpdateAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus using PATCH and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToUpdate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>> UpdateResponseAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus using PUT.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToUpdate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus> PutAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus using PUT and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> object.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToUpdate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>> PutResponseAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus windowsDefenderApplicationControlSupplementalPolicyDeploymentStatusToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusRequest Expand(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusRequest Select(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus, object>> selectExpression);

    }
}

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
    /// The interface IDefaultDeviceCompliancePolicyRequest.
    /// </summary>
    public partial interface IDefaultDeviceCompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DefaultDeviceCompliancePolicy using POST.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToCreate">The DefaultDeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DefaultDeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> CreateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DefaultDeviceCompliancePolicy using POST and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToCreate">The DefaultDeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> CreateResponseAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DefaultDeviceCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DefaultDeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DefaultDeviceCompliancePolicy and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DefaultDeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> UpdateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PATCH and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> UpdateResponseAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PUT.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> PutAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PUT and returns a <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DefaultDeviceCompliancePolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DefaultDeviceCompliancePolicy>> PutResponseAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDefaultDeviceCompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDefaultDeviceCompliancePolicyRequest Expand(Expression<Func<DefaultDeviceCompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDefaultDeviceCompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDefaultDeviceCompliancePolicyRequest Select(Expression<Func<DefaultDeviceCompliancePolicy, object>> selectExpression);

    }
}

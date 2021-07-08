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
    /// The interface IAospDeviceOwnerCompliancePolicyRequest.
    /// </summary>
    public partial interface IAospDeviceOwnerCompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AospDeviceOwnerCompliancePolicy using POST.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToCreate">The AospDeviceOwnerCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AospDeviceOwnerCompliancePolicy.</returns>
        System.Threading.Tasks.Task<AospDeviceOwnerCompliancePolicy> CreateAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AospDeviceOwnerCompliancePolicy using POST and returns a <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToCreate">The AospDeviceOwnerCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerCompliancePolicy>> CreateResponseAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AospDeviceOwnerCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AospDeviceOwnerCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AospDeviceOwnerCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AospDeviceOwnerCompliancePolicy.</returns>
        System.Threading.Tasks.Task<AospDeviceOwnerCompliancePolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AospDeviceOwnerCompliancePolicy and returns a <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerCompliancePolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AospDeviceOwnerCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToUpdate">The AospDeviceOwnerCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AospDeviceOwnerCompliancePolicy.</returns>
        System.Threading.Tasks.Task<AospDeviceOwnerCompliancePolicy> UpdateAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AospDeviceOwnerCompliancePolicy using PATCH and returns a <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToUpdate">The AospDeviceOwnerCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerCompliancePolicy>> UpdateResponseAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AospDeviceOwnerCompliancePolicy using PUT.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToUpdate">The AospDeviceOwnerCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AospDeviceOwnerCompliancePolicy> PutAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AospDeviceOwnerCompliancePolicy using PUT and returns a <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerCompliancePolicyToUpdate">The AospDeviceOwnerCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AospDeviceOwnerCompliancePolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerCompliancePolicy>> PutResponseAsync(AospDeviceOwnerCompliancePolicy aospDeviceOwnerCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAospDeviceOwnerCompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAospDeviceOwnerCompliancePolicyRequest Expand(Expression<Func<AospDeviceOwnerCompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAospDeviceOwnerCompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAospDeviceOwnerCompliancePolicyRequest Select(Expression<Func<AospDeviceOwnerCompliancePolicy, object>> selectExpression);

    }
}

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
    /// The interface IDataLossPreventionPolicyRequest.
    /// </summary>
    public partial interface IDataLossPreventionPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DataLossPreventionPolicy using POST.
        /// </summary>
        /// <param name="dataLossPreventionPolicyToCreate">The DataLossPreventionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DataLossPreventionPolicy.</returns>
        System.Threading.Tasks.Task<DataLossPreventionPolicy> CreateAsync(DataLossPreventionPolicy dataLossPreventionPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DataLossPreventionPolicy using POST and returns a <see cref="GraphResponse{DataLossPreventionPolicy}"/> object.
        /// </summary>
        /// <param name="dataLossPreventionPolicyToCreate">The DataLossPreventionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DataLossPreventionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataLossPreventionPolicy>> CreateResponseAsync(DataLossPreventionPolicy dataLossPreventionPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DataLossPreventionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DataLossPreventionPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DataLossPreventionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DataLossPreventionPolicy.</returns>
        System.Threading.Tasks.Task<DataLossPreventionPolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DataLossPreventionPolicy and returns a <see cref="GraphResponse{DataLossPreventionPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DataLossPreventionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataLossPreventionPolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DataLossPreventionPolicy using PATCH.
        /// </summary>
        /// <param name="dataLossPreventionPolicyToUpdate">The DataLossPreventionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DataLossPreventionPolicy.</returns>
        System.Threading.Tasks.Task<DataLossPreventionPolicy> UpdateAsync(DataLossPreventionPolicy dataLossPreventionPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DataLossPreventionPolicy using PATCH and returns a <see cref="GraphResponse{DataLossPreventionPolicy}"/> object.
        /// </summary>
        /// <param name="dataLossPreventionPolicyToUpdate">The DataLossPreventionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DataLossPreventionPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataLossPreventionPolicy>> UpdateResponseAsync(DataLossPreventionPolicy dataLossPreventionPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DataLossPreventionPolicy using PUT.
        /// </summary>
        /// <param name="dataLossPreventionPolicyToUpdate">The DataLossPreventionPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DataLossPreventionPolicy> PutAsync(DataLossPreventionPolicy dataLossPreventionPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DataLossPreventionPolicy using PUT and returns a <see cref="GraphResponse{DataLossPreventionPolicy}"/> object.
        /// </summary>
        /// <param name="dataLossPreventionPolicyToUpdate">The DataLossPreventionPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DataLossPreventionPolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataLossPreventionPolicy>> PutResponseAsync(DataLossPreventionPolicy dataLossPreventionPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDataLossPreventionPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDataLossPreventionPolicyRequest Expand(Expression<Func<DataLossPreventionPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDataLossPreventionPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDataLossPreventionPolicyRequest Select(Expression<Func<DataLossPreventionPolicy, object>> selectExpression);

    }
}

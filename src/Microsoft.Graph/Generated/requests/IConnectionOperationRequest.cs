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
    /// The interface IConnectionOperationRequest.
    /// </summary>
    public partial interface IConnectionOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ConnectionOperation using POST.
        /// </summary>
        /// <param name="connectionOperationToCreate">The ConnectionOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConnectionOperation.</returns>
        System.Threading.Tasks.Task<ConnectionOperation> CreateAsync(ConnectionOperation connectionOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ConnectionOperation using POST and returns a <see cref="GraphResponse{ConnectionOperation}"/> object.
        /// </summary>
        /// <param name="connectionOperationToCreate">The ConnectionOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectionOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectionOperation>> CreateResponseAsync(ConnectionOperation connectionOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ConnectionOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ConnectionOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ConnectionOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConnectionOperation.</returns>
        System.Threading.Tasks.Task<ConnectionOperation> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ConnectionOperation and returns a <see cref="GraphResponse{ConnectionOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectionOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectionOperation>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ConnectionOperation using PATCH.
        /// </summary>
        /// <param name="connectionOperationToUpdate">The ConnectionOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConnectionOperation.</returns>
        System.Threading.Tasks.Task<ConnectionOperation> UpdateAsync(ConnectionOperation connectionOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ConnectionOperation using PATCH and returns a <see cref="GraphResponse{ConnectionOperation}"/> object.
        /// </summary>
        /// <param name="connectionOperationToUpdate">The ConnectionOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConnectionOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectionOperation>> UpdateResponseAsync(ConnectionOperation connectionOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ConnectionOperation using PUT.
        /// </summary>
        /// <param name="connectionOperationToUpdate">The ConnectionOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ConnectionOperation> PutAsync(ConnectionOperation connectionOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ConnectionOperation using PUT and returns a <see cref="GraphResponse{ConnectionOperation}"/> object.
        /// </summary>
        /// <param name="connectionOperationToUpdate">The ConnectionOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ConnectionOperation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectionOperation>> PutResponseAsync(ConnectionOperation connectionOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConnectionOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IConnectionOperationRequest Expand(Expression<Func<ConnectionOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConnectionOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IConnectionOperationRequest Select(Expression<Func<ConnectionOperation, object>> selectExpression);

    }
}

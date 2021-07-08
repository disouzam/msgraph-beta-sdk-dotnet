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
    /// The interface IBusinessFlowRequest.
    /// </summary>
    public partial interface IBusinessFlowRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BusinessFlow using POST.
        /// </summary>
        /// <param name="businessFlowToCreate">The BusinessFlow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BusinessFlow.</returns>
        System.Threading.Tasks.Task<BusinessFlow> CreateAsync(BusinessFlow businessFlowToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified BusinessFlow using POST and returns a <see cref="GraphResponse{BusinessFlow}"/> object.
        /// </summary>
        /// <param name="businessFlowToCreate">The BusinessFlow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BusinessFlow}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BusinessFlow>> CreateResponseAsync(BusinessFlow businessFlowToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified BusinessFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified BusinessFlow and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified BusinessFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BusinessFlow.</returns>
        System.Threading.Tasks.Task<BusinessFlow> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified BusinessFlow and returns a <see cref="GraphResponse{BusinessFlow}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BusinessFlow}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BusinessFlow>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified BusinessFlow using PATCH.
        /// </summary>
        /// <param name="businessFlowToUpdate">The BusinessFlow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BusinessFlow.</returns>
        System.Threading.Tasks.Task<BusinessFlow> UpdateAsync(BusinessFlow businessFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified BusinessFlow using PATCH and returns a <see cref="GraphResponse{BusinessFlow}"/> object.
        /// </summary>
        /// <param name="businessFlowToUpdate">The BusinessFlow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BusinessFlow}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BusinessFlow>> UpdateResponseAsync(BusinessFlow businessFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified BusinessFlow using PUT.
        /// </summary>
        /// <param name="businessFlowToUpdate">The BusinessFlow object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<BusinessFlow> PutAsync(BusinessFlow businessFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified BusinessFlow using PUT and returns a <see cref="GraphResponse{BusinessFlow}"/> object.
        /// </summary>
        /// <param name="businessFlowToUpdate">The BusinessFlow object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{BusinessFlow}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<BusinessFlow>> PutResponseAsync(BusinessFlow businessFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBusinessFlowRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBusinessFlowRequest Expand(Expression<Func<BusinessFlow, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBusinessFlowRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBusinessFlowRequest Select(Expression<Func<BusinessFlow, object>> selectExpression);

    }
}

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
    /// The interface IAgedAccountsPayableRequest.
    /// </summary>
    public partial interface IAgedAccountsPayableRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AgedAccountsPayable using POST.
        /// </summary>
        /// <param name="agedAccountsPayableToCreate">The AgedAccountsPayable to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AgedAccountsPayable.</returns>
        System.Threading.Tasks.Task<AgedAccountsPayable> CreateAsync(AgedAccountsPayable agedAccountsPayableToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AgedAccountsPayable using POST and returns a <see cref="GraphResponse{AgedAccountsPayable}"/> object.
        /// </summary>
        /// <param name="agedAccountsPayableToCreate">The AgedAccountsPayable to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgedAccountsPayable}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgedAccountsPayable>> CreateResponseAsync(AgedAccountsPayable agedAccountsPayableToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AgedAccountsPayable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AgedAccountsPayable and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AgedAccountsPayable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AgedAccountsPayable.</returns>
        System.Threading.Tasks.Task<AgedAccountsPayable> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AgedAccountsPayable and returns a <see cref="GraphResponse{AgedAccountsPayable}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgedAccountsPayable}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgedAccountsPayable>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AgedAccountsPayable using PATCH.
        /// </summary>
        /// <param name="agedAccountsPayableToUpdate">The AgedAccountsPayable to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AgedAccountsPayable.</returns>
        System.Threading.Tasks.Task<AgedAccountsPayable> UpdateAsync(AgedAccountsPayable agedAccountsPayableToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AgedAccountsPayable using PATCH and returns a <see cref="GraphResponse{AgedAccountsPayable}"/> object.
        /// </summary>
        /// <param name="agedAccountsPayableToUpdate">The AgedAccountsPayable to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AgedAccountsPayable}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgedAccountsPayable>> UpdateResponseAsync(AgedAccountsPayable agedAccountsPayableToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AgedAccountsPayable using PUT.
        /// </summary>
        /// <param name="agedAccountsPayableToUpdate">The AgedAccountsPayable object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AgedAccountsPayable> PutAsync(AgedAccountsPayable agedAccountsPayableToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AgedAccountsPayable using PUT and returns a <see cref="GraphResponse{AgedAccountsPayable}"/> object.
        /// </summary>
        /// <param name="agedAccountsPayableToUpdate">The AgedAccountsPayable object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AgedAccountsPayable}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgedAccountsPayable>> PutResponseAsync(AgedAccountsPayable agedAccountsPayableToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAgedAccountsPayableRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAgedAccountsPayableRequest Expand(Expression<Func<AgedAccountsPayable, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAgedAccountsPayableRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAgedAccountsPayableRequest Select(Expression<Func<AgedAccountsPayable, object>> selectExpression);

    }
}

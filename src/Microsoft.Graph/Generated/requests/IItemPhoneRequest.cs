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
    /// The interface IItemPhoneRequest.
    /// </summary>
    public partial interface IItemPhoneRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ItemPhone using POST.
        /// </summary>
        /// <param name="itemPhoneToCreate">The ItemPhone to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemPhone.</returns>
        System.Threading.Tasks.Task<ItemPhone> CreateAsync(ItemPhone itemPhoneToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ItemPhone using POST and returns a <see cref="GraphResponse{ItemPhone}"/> object.
        /// </summary>
        /// <param name="itemPhoneToCreate">The ItemPhone to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemPhone}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemPhone>> CreateResponseAsync(ItemPhone itemPhoneToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ItemPhone.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ItemPhone and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ItemPhone.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemPhone.</returns>
        System.Threading.Tasks.Task<ItemPhone> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ItemPhone and returns a <see cref="GraphResponse{ItemPhone}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemPhone}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemPhone>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ItemPhone using PATCH.
        /// </summary>
        /// <param name="itemPhoneToUpdate">The ItemPhone to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemPhone.</returns>
        System.Threading.Tasks.Task<ItemPhone> UpdateAsync(ItemPhone itemPhoneToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ItemPhone using PATCH and returns a <see cref="GraphResponse{ItemPhone}"/> object.
        /// </summary>
        /// <param name="itemPhoneToUpdate">The ItemPhone to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ItemPhone}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemPhone>> UpdateResponseAsync(ItemPhone itemPhoneToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ItemPhone using PUT.
        /// </summary>
        /// <param name="itemPhoneToUpdate">The ItemPhone object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ItemPhone> PutAsync(ItemPhone itemPhoneToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ItemPhone using PUT and returns a <see cref="GraphResponse{ItemPhone}"/> object.
        /// </summary>
        /// <param name="itemPhoneToUpdate">The ItemPhone object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ItemPhone}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemPhone>> PutResponseAsync(ItemPhone itemPhoneToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemPhoneRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemPhoneRequest Expand(Expression<Func<ItemPhone, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemPhoneRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IItemPhoneRequest Select(Expression<Func<ItemPhone, object>> selectExpression);

    }
}

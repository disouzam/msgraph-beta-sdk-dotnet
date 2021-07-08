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
    /// The interface IUsageRightRequest.
    /// </summary>
    public partial interface IUsageRightRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UsageRight using POST.
        /// </summary>
        /// <param name="usageRightToCreate">The UsageRight to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UsageRight.</returns>
        System.Threading.Tasks.Task<UsageRight> CreateAsync(UsageRight usageRightToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UsageRight using POST and returns a <see cref="GraphResponse{UsageRight}"/> object.
        /// </summary>
        /// <param name="usageRightToCreate">The UsageRight to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UsageRight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UsageRight>> CreateResponseAsync(UsageRight usageRightToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UsageRight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UsageRight and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UsageRight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UsageRight.</returns>
        System.Threading.Tasks.Task<UsageRight> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UsageRight and returns a <see cref="GraphResponse{UsageRight}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UsageRight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UsageRight>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UsageRight using PATCH.
        /// </summary>
        /// <param name="usageRightToUpdate">The UsageRight to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UsageRight.</returns>
        System.Threading.Tasks.Task<UsageRight> UpdateAsync(UsageRight usageRightToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UsageRight using PATCH and returns a <see cref="GraphResponse{UsageRight}"/> object.
        /// </summary>
        /// <param name="usageRightToUpdate">The UsageRight to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UsageRight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UsageRight>> UpdateResponseAsync(UsageRight usageRightToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UsageRight using PUT.
        /// </summary>
        /// <param name="usageRightToUpdate">The UsageRight object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UsageRight> PutAsync(UsageRight usageRightToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UsageRight using PUT and returns a <see cref="GraphResponse{UsageRight}"/> object.
        /// </summary>
        /// <param name="usageRightToUpdate">The UsageRight object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UsageRight}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UsageRight>> PutResponseAsync(UsageRight usageRightToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUsageRightRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUsageRightRequest Expand(Expression<Func<UsageRight, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUsageRightRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUsageRightRequest Select(Expression<Func<UsageRight, object>> selectExpression);

    }
}

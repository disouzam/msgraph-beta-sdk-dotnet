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
    /// The interface IUnifiedRbacResourceScopeRequest.
    /// </summary>
    public partial interface IUnifiedRbacResourceScopeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRbacResourceScope using POST.
        /// </summary>
        /// <param name="unifiedRbacResourceScopeToCreate">The UnifiedRbacResourceScope to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRbacResourceScope.</returns>
        System.Threading.Tasks.Task<UnifiedRbacResourceScope> CreateAsync(UnifiedRbacResourceScope unifiedRbacResourceScopeToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnifiedRbacResourceScope using POST and returns a <see cref="GraphResponse{UnifiedRbacResourceScope}"/> object.
        /// </summary>
        /// <param name="unifiedRbacResourceScopeToCreate">The UnifiedRbacResourceScope to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRbacResourceScope}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceScope>> CreateResponseAsync(UnifiedRbacResourceScope unifiedRbacResourceScopeToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRbacResourceScope.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRbacResourceScope and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRbacResourceScope.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRbacResourceScope.</returns>
        System.Threading.Tasks.Task<UnifiedRbacResourceScope> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRbacResourceScope and returns a <see cref="GraphResponse{UnifiedRbacResourceScope}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRbacResourceScope}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceScope>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRbacResourceScope using PATCH.
        /// </summary>
        /// <param name="unifiedRbacResourceScopeToUpdate">The UnifiedRbacResourceScope to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRbacResourceScope.</returns>
        System.Threading.Tasks.Task<UnifiedRbacResourceScope> UpdateAsync(UnifiedRbacResourceScope unifiedRbacResourceScopeToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRbacResourceScope using PATCH and returns a <see cref="GraphResponse{UnifiedRbacResourceScope}"/> object.
        /// </summary>
        /// <param name="unifiedRbacResourceScopeToUpdate">The UnifiedRbacResourceScope to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRbacResourceScope}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceScope>> UpdateResponseAsync(UnifiedRbacResourceScope unifiedRbacResourceScopeToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRbacResourceScope using PUT.
        /// </summary>
        /// <param name="unifiedRbacResourceScopeToUpdate">The UnifiedRbacResourceScope object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UnifiedRbacResourceScope> PutAsync(UnifiedRbacResourceScope unifiedRbacResourceScopeToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRbacResourceScope using PUT and returns a <see cref="GraphResponse{UnifiedRbacResourceScope}"/> object.
        /// </summary>
        /// <param name="unifiedRbacResourceScopeToUpdate">The UnifiedRbacResourceScope object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UnifiedRbacResourceScope}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceScope>> PutResponseAsync(UnifiedRbacResourceScope unifiedRbacResourceScopeToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRbacResourceScopeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRbacResourceScopeRequest Expand(Expression<Func<UnifiedRbacResourceScope, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRbacResourceScopeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRbacResourceScopeRequest Select(Expression<Func<UnifiedRbacResourceScope, object>> selectExpression);

    }
}

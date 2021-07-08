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
    /// The interface IAccessPackageResourceRequest.
    /// </summary>
    public partial interface IAccessPackageResourceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessPackageResource using POST.
        /// </summary>
        /// <param name="accessPackageResourceToCreate">The AccessPackageResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageResource.</returns>
        System.Threading.Tasks.Task<AccessPackageResource> CreateAsync(AccessPackageResource accessPackageResourceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AccessPackageResource using POST and returns a <see cref="GraphResponse{AccessPackageResource}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceToCreate">The AccessPackageResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResource>> CreateResponseAsync(AccessPackageResource accessPackageResourceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AccessPackageResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AccessPackageResource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AccessPackageResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageResource.</returns>
        System.Threading.Tasks.Task<AccessPackageResource> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AccessPackageResource and returns a <see cref="GraphResponse{AccessPackageResource}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResource>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessPackageResource using PATCH.
        /// </summary>
        /// <param name="accessPackageResourceToUpdate">The AccessPackageResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageResource.</returns>
        System.Threading.Tasks.Task<AccessPackageResource> UpdateAsync(AccessPackageResource accessPackageResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessPackageResource using PATCH and returns a <see cref="GraphResponse{AccessPackageResource}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceToUpdate">The AccessPackageResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResource>> UpdateResponseAsync(AccessPackageResource accessPackageResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessPackageResource using PUT.
        /// </summary>
        /// <param name="accessPackageResourceToUpdate">The AccessPackageResource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AccessPackageResource> PutAsync(AccessPackageResource accessPackageResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessPackageResource using PUT and returns a <see cref="GraphResponse{AccessPackageResource}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceToUpdate">The AccessPackageResource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AccessPackageResource}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResource>> PutResponseAsync(AccessPackageResource accessPackageResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceRequest Expand(Expression<Func<AccessPackageResource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceRequest Select(Expression<Func<AccessPackageResource, object>> selectExpression);

    }
}

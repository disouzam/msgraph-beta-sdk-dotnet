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
    /// The interface IAccessPackageSubjectRequest.
    /// </summary>
    public partial interface IAccessPackageSubjectRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessPackageSubject using POST.
        /// </summary>
        /// <param name="accessPackageSubjectToCreate">The AccessPackageSubject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageSubject.</returns>
        System.Threading.Tasks.Task<AccessPackageSubject> CreateAsync(AccessPackageSubject accessPackageSubjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AccessPackageSubject using POST and returns a <see cref="GraphResponse{AccessPackageSubject}"/> object.
        /// </summary>
        /// <param name="accessPackageSubjectToCreate">The AccessPackageSubject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageSubject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageSubject>> CreateResponseAsync(AccessPackageSubject accessPackageSubjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AccessPackageSubject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AccessPackageSubject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AccessPackageSubject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageSubject.</returns>
        System.Threading.Tasks.Task<AccessPackageSubject> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AccessPackageSubject and returns a <see cref="GraphResponse{AccessPackageSubject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageSubject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageSubject>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessPackageSubject using PATCH.
        /// </summary>
        /// <param name="accessPackageSubjectToUpdate">The AccessPackageSubject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageSubject.</returns>
        System.Threading.Tasks.Task<AccessPackageSubject> UpdateAsync(AccessPackageSubject accessPackageSubjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessPackageSubject using PATCH and returns a <see cref="GraphResponse{AccessPackageSubject}"/> object.
        /// </summary>
        /// <param name="accessPackageSubjectToUpdate">The AccessPackageSubject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageSubject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageSubject>> UpdateResponseAsync(AccessPackageSubject accessPackageSubjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessPackageSubject using PUT.
        /// </summary>
        /// <param name="accessPackageSubjectToUpdate">The AccessPackageSubject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AccessPackageSubject> PutAsync(AccessPackageSubject accessPackageSubjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessPackageSubject using PUT and returns a <see cref="GraphResponse{AccessPackageSubject}"/> object.
        /// </summary>
        /// <param name="accessPackageSubjectToUpdate">The AccessPackageSubject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AccessPackageSubject}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageSubject>> PutResponseAsync(AccessPackageSubject accessPackageSubjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageSubjectRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageSubjectRequest Expand(Expression<Func<AccessPackageSubject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageSubjectRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageSubjectRequest Select(Expression<Func<AccessPackageSubject, object>> selectExpression);

    }
}

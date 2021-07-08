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
    /// The interface ISecurityActionRequest.
    /// </summary>
    public partial interface ISecurityActionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecurityAction using POST.
        /// </summary>
        /// <param name="securityActionToCreate">The SecurityAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecurityAction.</returns>
        System.Threading.Tasks.Task<SecurityAction> CreateAsync(SecurityAction securityActionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SecurityAction using POST and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <param name="securityActionToCreate">The SecurityAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityAction>> CreateResponseAsync(SecurityAction securityActionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SecurityAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SecurityAction and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SecurityAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecurityAction.</returns>
        System.Threading.Tasks.Task<SecurityAction> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SecurityAction and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityAction>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SecurityAction using PATCH.
        /// </summary>
        /// <param name="securityActionToUpdate">The SecurityAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecurityAction.</returns>
        System.Threading.Tasks.Task<SecurityAction> UpdateAsync(SecurityAction securityActionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SecurityAction using PATCH and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <param name="securityActionToUpdate">The SecurityAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SecurityAction}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityAction>> UpdateResponseAsync(SecurityAction securityActionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SecurityAction using PUT.
        /// </summary>
        /// <param name="securityActionToUpdate">The SecurityAction object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SecurityAction> PutAsync(SecurityAction securityActionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SecurityAction using PUT and returns a <see cref="GraphResponse{SecurityAction}"/> object.
        /// </summary>
        /// <param name="securityActionToUpdate">The SecurityAction object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SecurityAction}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityAction>> PutResponseAsync(SecurityAction securityActionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityActionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityActionRequest Expand(Expression<Func<SecurityAction, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityActionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityActionRequest Select(Expression<Func<SecurityAction, object>> selectExpression);

    }
}

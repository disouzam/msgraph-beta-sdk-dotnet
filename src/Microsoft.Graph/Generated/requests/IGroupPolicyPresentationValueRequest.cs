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
    /// The interface IGroupPolicyPresentationValueRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationValueRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyPresentationValue using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToCreate">The GroupPolicyPresentationValue to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> CreateAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified GroupPolicyPresentationValue using POST and returns a <see cref="GraphResponse{GroupPolicyPresentationValue}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToCreate">The GroupPolicyPresentationValue to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationValue}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValue>> CreateResponseAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValue.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValue and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValue.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValue and returns a <see cref="GraphResponse{GroupPolicyPresentationValue}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationValue}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValue>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValue using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToUpdate">The GroupPolicyPresentationValue to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyPresentationValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> UpdateAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValue using PATCH and returns a <see cref="GraphResponse{GroupPolicyPresentationValue}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToUpdate">The GroupPolicyPresentationValue to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationValue}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValue>> UpdateResponseAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValue using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToUpdate">The GroupPolicyPresentationValue object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> PutAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValue using PUT and returns a <see cref="GraphResponse{GroupPolicyPresentationValue}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToUpdate">The GroupPolicyPresentationValue object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{GroupPolicyPresentationValue}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationValue>> PutResponseAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueRequest Expand(Expression<Func<GroupPolicyPresentationValue, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueRequest Select(Expression<Func<GroupPolicyPresentationValue, object>> selectExpression);

    }
}

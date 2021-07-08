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
    /// The interface IExternalGroupMemberRequest.
    /// </summary>
    public partial interface IExternalGroupMemberRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ExternalGroupMember using POST.
        /// </summary>
        /// <param name="externalGroupMemberToCreate">The ExternalGroupMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExternalGroupMember.</returns>
        System.Threading.Tasks.Task<ExternalGroupMember> CreateAsync(ExternalGroupMember externalGroupMemberToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ExternalGroupMember using POST and returns a <see cref="GraphResponse{ExternalGroupMember}"/> object.
        /// </summary>
        /// <param name="externalGroupMemberToCreate">The ExternalGroupMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalGroupMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalGroupMember>> CreateResponseAsync(ExternalGroupMember externalGroupMemberToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ExternalGroupMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ExternalGroupMember and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ExternalGroupMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExternalGroupMember.</returns>
        System.Threading.Tasks.Task<ExternalGroupMember> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ExternalGroupMember and returns a <see cref="GraphResponse{ExternalGroupMember}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalGroupMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalGroupMember>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ExternalGroupMember using PATCH.
        /// </summary>
        /// <param name="externalGroupMemberToUpdate">The ExternalGroupMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExternalGroupMember.</returns>
        System.Threading.Tasks.Task<ExternalGroupMember> UpdateAsync(ExternalGroupMember externalGroupMemberToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ExternalGroupMember using PATCH and returns a <see cref="GraphResponse{ExternalGroupMember}"/> object.
        /// </summary>
        /// <param name="externalGroupMemberToUpdate">The ExternalGroupMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ExternalGroupMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalGroupMember>> UpdateResponseAsync(ExternalGroupMember externalGroupMemberToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ExternalGroupMember using PUT.
        /// </summary>
        /// <param name="externalGroupMemberToUpdate">The ExternalGroupMember object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ExternalGroupMember> PutAsync(ExternalGroupMember externalGroupMemberToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ExternalGroupMember using PUT and returns a <see cref="GraphResponse{ExternalGroupMember}"/> object.
        /// </summary>
        /// <param name="externalGroupMemberToUpdate">The ExternalGroupMember object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ExternalGroupMember}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalGroupMember>> PutResponseAsync(ExternalGroupMember externalGroupMemberToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalGroupMemberRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalGroupMemberRequest Expand(Expression<Func<ExternalGroupMember, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalGroupMemberRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalGroupMemberRequest Select(Expression<Func<ExternalGroupMember, object>> selectExpression);

    }
}

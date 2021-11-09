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
    /// The interface IUserSignInInsightRequest.
    /// </summary>
    public partial interface IUserSignInInsightRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserSignInInsight using POST.
        /// </summary>
        /// <param name="userSignInInsightToCreate">The UserSignInInsight to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserSignInInsight.</returns>
        System.Threading.Tasks.Task<UserSignInInsight> CreateAsync(UserSignInInsight userSignInInsightToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified UserSignInInsight using POST and returns a <see cref="GraphResponse{UserSignInInsight}"/> object.
        /// </summary>
        /// <param name="userSignInInsightToCreate">The UserSignInInsight to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserSignInInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserSignInInsight>> CreateResponseAsync(UserSignInInsight userSignInInsightToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UserSignInInsight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UserSignInInsight and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UserSignInInsight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserSignInInsight.</returns>
        System.Threading.Tasks.Task<UserSignInInsight> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UserSignInInsight and returns a <see cref="GraphResponse{UserSignInInsight}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserSignInInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserSignInInsight>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserSignInInsight using PATCH.
        /// </summary>
        /// <param name="userSignInInsightToUpdate">The UserSignInInsight to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserSignInInsight.</returns>
        System.Threading.Tasks.Task<UserSignInInsight> UpdateAsync(UserSignInInsight userSignInInsightToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserSignInInsight using PATCH and returns a <see cref="GraphResponse{UserSignInInsight}"/> object.
        /// </summary>
        /// <param name="userSignInInsightToUpdate">The UserSignInInsight to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserSignInInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserSignInInsight>> UpdateResponseAsync(UserSignInInsight userSignInInsightToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserSignInInsight using PUT.
        /// </summary>
        /// <param name="userSignInInsightToUpdate">The UserSignInInsight object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UserSignInInsight> PutAsync(UserSignInInsight userSignInInsightToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserSignInInsight using PUT and returns a <see cref="GraphResponse{UserSignInInsight}"/> object.
        /// </summary>
        /// <param name="userSignInInsightToUpdate">The UserSignInInsight object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UserSignInInsight}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserSignInInsight>> PutResponseAsync(UserSignInInsight userSignInInsightToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserSignInInsightRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserSignInInsightRequest Expand(Expression<Func<UserSignInInsight, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserSignInInsightRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserSignInInsightRequest Select(Expression<Func<UserSignInInsight, object>> selectExpression);

    }
}

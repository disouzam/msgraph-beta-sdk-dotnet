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
    /// The interface IPersonAwardRequest.
    /// </summary>
    public partial interface IPersonAwardRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PersonAward using POST.
        /// </summary>
        /// <param name="personAwardToCreate">The PersonAward to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PersonAward.</returns>
        System.Threading.Tasks.Task<PersonAward> CreateAsync(PersonAward personAwardToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified PersonAward using POST and returns a <see cref="GraphResponse{PersonAward}"/> object.
        /// </summary>
        /// <param name="personAwardToCreate">The PersonAward to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PersonAward}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonAward>> CreateResponseAsync(PersonAward personAwardToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PersonAward.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PersonAward and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PersonAward.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PersonAward.</returns>
        System.Threading.Tasks.Task<PersonAward> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PersonAward and returns a <see cref="GraphResponse{PersonAward}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PersonAward}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonAward>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PersonAward using PATCH.
        /// </summary>
        /// <param name="personAwardToUpdate">The PersonAward to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PersonAward.</returns>
        System.Threading.Tasks.Task<PersonAward> UpdateAsync(PersonAward personAwardToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PersonAward using PATCH and returns a <see cref="GraphResponse{PersonAward}"/> object.
        /// </summary>
        /// <param name="personAwardToUpdate">The PersonAward to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PersonAward}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonAward>> UpdateResponseAsync(PersonAward personAwardToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PersonAward using PUT.
        /// </summary>
        /// <param name="personAwardToUpdate">The PersonAward object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PersonAward> PutAsync(PersonAward personAwardToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PersonAward using PUT and returns a <see cref="GraphResponse{PersonAward}"/> object.
        /// </summary>
        /// <param name="personAwardToUpdate">The PersonAward object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PersonAward}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonAward>> PutResponseAsync(PersonAward personAwardToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPersonAwardRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPersonAwardRequest Expand(Expression<Func<PersonAward, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPersonAwardRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPersonAwardRequest Select(Expression<Func<PersonAward, object>> selectExpression);

    }
}

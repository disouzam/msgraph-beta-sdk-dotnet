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
    /// The interface IUserExperienceAnalyticsDevicePerformanceRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsDevicePerformanceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDevicePerformance using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsDevicePerformanceToCreate">The UserExperienceAnalyticsDevicePerformance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsDevicePerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDevicePerformance> CreateAsync(UserExperienceAnalyticsDevicePerformance userExperienceAnalyticsDevicePerformanceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDevicePerformance using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsDevicePerformance}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDevicePerformanceToCreate">The UserExperienceAnalyticsDevicePerformance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDevicePerformance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDevicePerformance>> CreateResponseAsync(UserExperienceAnalyticsDevicePerformance userExperienceAnalyticsDevicePerformanceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDevicePerformance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDevicePerformance and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDevicePerformance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsDevicePerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDevicePerformance> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDevicePerformance and returns a <see cref="GraphResponse{UserExperienceAnalyticsDevicePerformance}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDevicePerformance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDevicePerformance>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDevicePerformance using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsDevicePerformanceToUpdate">The UserExperienceAnalyticsDevicePerformance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsDevicePerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDevicePerformance> UpdateAsync(UserExperienceAnalyticsDevicePerformance userExperienceAnalyticsDevicePerformanceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDevicePerformance using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsDevicePerformance}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDevicePerformanceToUpdate">The UserExperienceAnalyticsDevicePerformance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDevicePerformance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDevicePerformance>> UpdateResponseAsync(UserExperienceAnalyticsDevicePerformance userExperienceAnalyticsDevicePerformanceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDevicePerformance using PUT.
        /// </summary>
        /// <param name="userExperienceAnalyticsDevicePerformanceToUpdate">The UserExperienceAnalyticsDevicePerformance object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDevicePerformance> PutAsync(UserExperienceAnalyticsDevicePerformance userExperienceAnalyticsDevicePerformanceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDevicePerformance using PUT and returns a <see cref="GraphResponse{UserExperienceAnalyticsDevicePerformance}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDevicePerformanceToUpdate">The UserExperienceAnalyticsDevicePerformance object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UserExperienceAnalyticsDevicePerformance}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDevicePerformance>> PutResponseAsync(UserExperienceAnalyticsDevicePerformance userExperienceAnalyticsDevicePerformanceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDevicePerformanceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDevicePerformanceRequest Expand(Expression<Func<UserExperienceAnalyticsDevicePerformance, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDevicePerformanceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDevicePerformanceRequest Select(Expression<Func<UserExperienceAnalyticsDevicePerformance, object>> selectExpression);

    }
}

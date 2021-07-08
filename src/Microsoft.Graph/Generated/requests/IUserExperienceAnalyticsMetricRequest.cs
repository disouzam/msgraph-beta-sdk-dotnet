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
    /// The interface IUserExperienceAnalyticsMetricRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsMetricRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsMetric using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricToCreate">The UserExperienceAnalyticsMetric to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsMetric.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetric> CreateAsync(UserExperienceAnalyticsMetric userExperienceAnalyticsMetricToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsMetric using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsMetric}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricToCreate">The UserExperienceAnalyticsMetric to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsMetric}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsMetric>> CreateResponseAsync(UserExperienceAnalyticsMetric userExperienceAnalyticsMetricToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsMetric.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsMetric and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsMetric.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsMetric.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetric> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsMetric and returns a <see cref="GraphResponse{UserExperienceAnalyticsMetric}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsMetric}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsMetric>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsMetric using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricToUpdate">The UserExperienceAnalyticsMetric to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsMetric.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetric> UpdateAsync(UserExperienceAnalyticsMetric userExperienceAnalyticsMetricToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsMetric using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsMetric}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricToUpdate">The UserExperienceAnalyticsMetric to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsMetric}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsMetric>> UpdateResponseAsync(UserExperienceAnalyticsMetric userExperienceAnalyticsMetricToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsMetric using PUT.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricToUpdate">The UserExperienceAnalyticsMetric object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetric> PutAsync(UserExperienceAnalyticsMetric userExperienceAnalyticsMetricToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsMetric using PUT and returns a <see cref="GraphResponse{UserExperienceAnalyticsMetric}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricToUpdate">The UserExperienceAnalyticsMetric object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UserExperienceAnalyticsMetric}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsMetric>> PutResponseAsync(UserExperienceAnalyticsMetric userExperienceAnalyticsMetricToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsMetricRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsMetricRequest Expand(Expression<Func<UserExperienceAnalyticsMetric, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsMetricRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsMetricRequest Select(Expression<Func<UserExperienceAnalyticsMetric, object>> selectExpression);

    }
}

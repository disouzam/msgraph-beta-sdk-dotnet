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
    /// The interface IAdvancedThreatProtectionOnboardingStateSummaryRequest.
    /// </summary>
    public partial interface IAdvancedThreatProtectionOnboardingStateSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AdvancedThreatProtectionOnboardingStateSummary using POST.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToCreate">The AdvancedThreatProtectionOnboardingStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AdvancedThreatProtectionOnboardingStateSummary.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> CreateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AdvancedThreatProtectionOnboardingStateSummary using POST and returns a <see cref="GraphResponse{AdvancedThreatProtectionOnboardingStateSummary}"/> object.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToCreate">The AdvancedThreatProtectionOnboardingStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdvancedThreatProtectionOnboardingStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdvancedThreatProtectionOnboardingStateSummary>> CreateResponseAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AdvancedThreatProtectionOnboardingStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AdvancedThreatProtectionOnboardingStateSummary.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AdvancedThreatProtectionOnboardingStateSummary and returns a <see cref="GraphResponse{AdvancedThreatProtectionOnboardingStateSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdvancedThreatProtectionOnboardingStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdvancedThreatProtectionOnboardingStateSummary>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingStateSummary using PATCH.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToUpdate">The AdvancedThreatProtectionOnboardingStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AdvancedThreatProtectionOnboardingStateSummary.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> UpdateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingStateSummary using PATCH and returns a <see cref="GraphResponse{AdvancedThreatProtectionOnboardingStateSummary}"/> object.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToUpdate">The AdvancedThreatProtectionOnboardingStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AdvancedThreatProtectionOnboardingStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdvancedThreatProtectionOnboardingStateSummary>> UpdateResponseAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingStateSummary using PUT.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToUpdate">The AdvancedThreatProtectionOnboardingStateSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> PutAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingStateSummary using PUT and returns a <see cref="GraphResponse{AdvancedThreatProtectionOnboardingStateSummary}"/> object.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToUpdate">The AdvancedThreatProtectionOnboardingStateSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AdvancedThreatProtectionOnboardingStateSummary}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdvancedThreatProtectionOnboardingStateSummary>> PutResponseAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingStateSummaryRequest Expand(Expression<Func<AdvancedThreatProtectionOnboardingStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingStateSummaryRequest Select(Expression<Func<AdvancedThreatProtectionOnboardingStateSummary, object>> selectExpression);

    }
}

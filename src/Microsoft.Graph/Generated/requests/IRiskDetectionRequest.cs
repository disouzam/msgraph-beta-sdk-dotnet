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
    /// The interface IRiskDetectionRequest.
    /// </summary>
    public partial interface IRiskDetectionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RiskDetection using POST.
        /// </summary>
        /// <param name="riskDetectionToCreate">The RiskDetection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RiskDetection.</returns>
        System.Threading.Tasks.Task<RiskDetection> CreateAsync(RiskDetection riskDetectionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified RiskDetection using POST and returns a <see cref="GraphResponse{RiskDetection}"/> object.
        /// </summary>
        /// <param name="riskDetectionToCreate">The RiskDetection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskDetection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskDetection>> CreateResponseAsync(RiskDetection riskDetectionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified RiskDetection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified RiskDetection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified RiskDetection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RiskDetection.</returns>
        System.Threading.Tasks.Task<RiskDetection> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified RiskDetection and returns a <see cref="GraphResponse{RiskDetection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskDetection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskDetection>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RiskDetection using PATCH.
        /// </summary>
        /// <param name="riskDetectionToUpdate">The RiskDetection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RiskDetection.</returns>
        System.Threading.Tasks.Task<RiskDetection> UpdateAsync(RiskDetection riskDetectionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RiskDetection using PATCH and returns a <see cref="GraphResponse{RiskDetection}"/> object.
        /// </summary>
        /// <param name="riskDetectionToUpdate">The RiskDetection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RiskDetection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskDetection>> UpdateResponseAsync(RiskDetection riskDetectionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RiskDetection using PUT.
        /// </summary>
        /// <param name="riskDetectionToUpdate">The RiskDetection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<RiskDetection> PutAsync(RiskDetection riskDetectionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RiskDetection using PUT and returns a <see cref="GraphResponse{RiskDetection}"/> object.
        /// </summary>
        /// <param name="riskDetectionToUpdate">The RiskDetection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{RiskDetection}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskDetection>> PutResponseAsync(RiskDetection riskDetectionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRiskDetectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRiskDetectionRequest Expand(Expression<Func<RiskDetection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRiskDetectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRiskDetectionRequest Select(Expression<Func<RiskDetection, object>> selectExpression);

    }
}

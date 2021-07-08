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
    /// The interface IPlannerAssignedToTaskBoardTaskFormatRequest.
    /// </summary>
    public partial interface IPlannerAssignedToTaskBoardTaskFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerAssignedToTaskBoardTaskFormat using POST.
        /// </summary>
        /// <param name="plannerAssignedToTaskBoardTaskFormatToCreate">The PlannerAssignedToTaskBoardTaskFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerAssignedToTaskBoardTaskFormat.</returns>
        System.Threading.Tasks.Task<PlannerAssignedToTaskBoardTaskFormat> CreateAsync(PlannerAssignedToTaskBoardTaskFormat plannerAssignedToTaskBoardTaskFormatToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified PlannerAssignedToTaskBoardTaskFormat using POST and returns a <see cref="GraphResponse{PlannerAssignedToTaskBoardTaskFormat}"/> object.
        /// </summary>
        /// <param name="plannerAssignedToTaskBoardTaskFormatToCreate">The PlannerAssignedToTaskBoardTaskFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerAssignedToTaskBoardTaskFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerAssignedToTaskBoardTaskFormat>> CreateResponseAsync(PlannerAssignedToTaskBoardTaskFormat plannerAssignedToTaskBoardTaskFormatToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PlannerAssignedToTaskBoardTaskFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PlannerAssignedToTaskBoardTaskFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PlannerAssignedToTaskBoardTaskFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerAssignedToTaskBoardTaskFormat.</returns>
        System.Threading.Tasks.Task<PlannerAssignedToTaskBoardTaskFormat> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PlannerAssignedToTaskBoardTaskFormat and returns a <see cref="GraphResponse{PlannerAssignedToTaskBoardTaskFormat}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerAssignedToTaskBoardTaskFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerAssignedToTaskBoardTaskFormat>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PlannerAssignedToTaskBoardTaskFormat using PATCH.
        /// </summary>
        /// <param name="plannerAssignedToTaskBoardTaskFormatToUpdate">The PlannerAssignedToTaskBoardTaskFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerAssignedToTaskBoardTaskFormat.</returns>
        System.Threading.Tasks.Task<PlannerAssignedToTaskBoardTaskFormat> UpdateAsync(PlannerAssignedToTaskBoardTaskFormat plannerAssignedToTaskBoardTaskFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PlannerAssignedToTaskBoardTaskFormat using PATCH and returns a <see cref="GraphResponse{PlannerAssignedToTaskBoardTaskFormat}"/> object.
        /// </summary>
        /// <param name="plannerAssignedToTaskBoardTaskFormatToUpdate">The PlannerAssignedToTaskBoardTaskFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlannerAssignedToTaskBoardTaskFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerAssignedToTaskBoardTaskFormat>> UpdateResponseAsync(PlannerAssignedToTaskBoardTaskFormat plannerAssignedToTaskBoardTaskFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PlannerAssignedToTaskBoardTaskFormat using PUT.
        /// </summary>
        /// <param name="plannerAssignedToTaskBoardTaskFormatToUpdate">The PlannerAssignedToTaskBoardTaskFormat object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PlannerAssignedToTaskBoardTaskFormat> PutAsync(PlannerAssignedToTaskBoardTaskFormat plannerAssignedToTaskBoardTaskFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PlannerAssignedToTaskBoardTaskFormat using PUT and returns a <see cref="GraphResponse{PlannerAssignedToTaskBoardTaskFormat}"/> object.
        /// </summary>
        /// <param name="plannerAssignedToTaskBoardTaskFormatToUpdate">The PlannerAssignedToTaskBoardTaskFormat object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PlannerAssignedToTaskBoardTaskFormat}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerAssignedToTaskBoardTaskFormat>> PutResponseAsync(PlannerAssignedToTaskBoardTaskFormat plannerAssignedToTaskBoardTaskFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerAssignedToTaskBoardTaskFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerAssignedToTaskBoardTaskFormatRequest Expand(Expression<Func<PlannerAssignedToTaskBoardTaskFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerAssignedToTaskBoardTaskFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerAssignedToTaskBoardTaskFormatRequest Select(Expression<Func<PlannerAssignedToTaskBoardTaskFormat, object>> selectExpression);

    }
}

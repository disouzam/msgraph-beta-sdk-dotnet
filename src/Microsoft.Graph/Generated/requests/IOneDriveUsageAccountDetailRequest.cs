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
    /// The interface IOneDriveUsageAccountDetailRequest.
    /// </summary>
    public partial interface IOneDriveUsageAccountDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OneDriveUsageAccountDetail using POST.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToCreate">The OneDriveUsageAccountDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OneDriveUsageAccountDetail.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountDetail> CreateAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified OneDriveUsageAccountDetail using POST and returns a <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToCreate">The OneDriveUsageAccountDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountDetail>> CreateResponseAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OneDriveUsageAccountDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OneDriveUsageAccountDetail and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OneDriveUsageAccountDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OneDriveUsageAccountDetail.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountDetail> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OneDriveUsageAccountDetail and returns a <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountDetail>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OneDriveUsageAccountDetail using PATCH.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToUpdate">The OneDriveUsageAccountDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OneDriveUsageAccountDetail.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountDetail> UpdateAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OneDriveUsageAccountDetail using PATCH and returns a <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToUpdate">The OneDriveUsageAccountDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountDetail>> UpdateResponseAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OneDriveUsageAccountDetail using PUT.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToUpdate">The OneDriveUsageAccountDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountDetail> PutAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OneDriveUsageAccountDetail using PUT and returns a <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountDetailToUpdate">The OneDriveUsageAccountDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{OneDriveUsageAccountDetail}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountDetail>> PutResponseAsync(OneDriveUsageAccountDetail oneDriveUsageAccountDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOneDriveUsageAccountDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOneDriveUsageAccountDetailRequest Expand(Expression<Func<OneDriveUsageAccountDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOneDriveUsageAccountDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOneDriveUsageAccountDetailRequest Select(Expression<Func<OneDriveUsageAccountDetail, object>> selectExpression);

    }
}

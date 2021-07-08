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
    /// The interface IYammerDeviceUsageUserDetailRequest.
    /// </summary>
    public partial interface IYammerDeviceUsageUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified YammerDeviceUsageUserDetail using POST.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToCreate">The YammerDeviceUsageUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created YammerDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> CreateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified YammerDeviceUsageUserDetail using POST and returns a <see cref="GraphResponse{YammerDeviceUsageUserDetail}"/> object.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToCreate">The YammerDeviceUsageUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{YammerDeviceUsageUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerDeviceUsageUserDetail>> CreateResponseAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified YammerDeviceUsageUserDetail and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The YammerDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified YammerDeviceUsageUserDetail and returns a <see cref="GraphResponse{YammerDeviceUsageUserDetail}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{YammerDeviceUsageUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerDeviceUsageUserDetail>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified YammerDeviceUsageUserDetail using PATCH.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToUpdate">The YammerDeviceUsageUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated YammerDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> UpdateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified YammerDeviceUsageUserDetail using PATCH and returns a <see cref="GraphResponse{YammerDeviceUsageUserDetail}"/> object.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToUpdate">The YammerDeviceUsageUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{YammerDeviceUsageUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerDeviceUsageUserDetail>> UpdateResponseAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified YammerDeviceUsageUserDetail using PUT.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToUpdate">The YammerDeviceUsageUserDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> PutAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified YammerDeviceUsageUserDetail using PUT and returns a <see cref="GraphResponse{YammerDeviceUsageUserDetail}"/> object.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToUpdate">The YammerDeviceUsageUserDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{YammerDeviceUsageUserDetail}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerDeviceUsageUserDetail>> PutResponseAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IYammerDeviceUsageUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IYammerDeviceUsageUserDetailRequest Expand(Expression<Func<YammerDeviceUsageUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IYammerDeviceUsageUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IYammerDeviceUsageUserDetailRequest Select(Expression<Func<YammerDeviceUsageUserDetail, object>> selectExpression);

    }
}

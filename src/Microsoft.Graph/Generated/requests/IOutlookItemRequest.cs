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
    /// The interface IOutlookItemRequest.
    /// </summary>
    public partial interface IOutlookItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OutlookItem using POST.
        /// </summary>
        /// <param name="outlookItemToCreate">The OutlookItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OutlookItem.</returns>
        System.Threading.Tasks.Task<OutlookItem> CreateAsync(OutlookItem outlookItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified OutlookItem using POST and returns a <see cref="GraphResponse{OutlookItem}"/> object.
        /// </summary>
        /// <param name="outlookItemToCreate">The OutlookItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookItem>> CreateResponseAsync(OutlookItem outlookItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OutlookItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OutlookItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OutlookItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OutlookItem.</returns>
        System.Threading.Tasks.Task<OutlookItem> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OutlookItem and returns a <see cref="GraphResponse{OutlookItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OutlookItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookItem>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OutlookItem using PATCH.
        /// </summary>
        /// <param name="outlookItemToUpdate">The OutlookItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OutlookItem.</returns>
        System.Threading.Tasks.Task<OutlookItem> UpdateAsync(OutlookItem outlookItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OutlookItem using PATCH and returns a <see cref="GraphResponse{OutlookItem}"/> object.
        /// </summary>
        /// <param name="outlookItemToUpdate">The OutlookItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OutlookItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookItem>> UpdateResponseAsync(OutlookItem outlookItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OutlookItem using PUT.
        /// </summary>
        /// <param name="outlookItemToUpdate">The OutlookItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<OutlookItem> PutAsync(OutlookItem outlookItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OutlookItem using PUT and returns a <see cref="GraphResponse{OutlookItem}"/> object.
        /// </summary>
        /// <param name="outlookItemToUpdate">The OutlookItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{OutlookItem}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<OutlookItem>> PutResponseAsync(OutlookItem outlookItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookItemRequest Expand(Expression<Func<OutlookItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookItemRequest Select(Expression<Func<OutlookItem, object>> selectExpression);

    }
}

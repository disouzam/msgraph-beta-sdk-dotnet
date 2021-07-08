// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest.
    /// </summary>
    public partial interface IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified TelecomExpenseManagementPartner to the collection via POST.
        /// </summary>
        /// <param name="telecomExpenseManagementPartner">The TelecomExpenseManagementPartner to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TelecomExpenseManagementPartner.</returns>
        System.Threading.Tasks.Task<TelecomExpenseManagementPartner> AddAsync(TelecomExpenseManagementPartner telecomExpenseManagementPartner, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified TelecomExpenseManagementPartner to the collection via POST and returns a <see cref="GraphResponse{TelecomExpenseManagementPartner}"/> object of the request.
        /// </summary>
        /// <param name="telecomExpenseManagementPartner">The TelecomExpenseManagementPartner to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TelecomExpenseManagementPartner}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TelecomExpenseManagementPartner>> AddResponseAsync(TelecomExpenseManagementPartner telecomExpenseManagementPartner, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementTelecomExpenseManagementPartnersCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceManagementTelecomExpenseManagementPartnersCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTelecomExpenseManagementPartnersCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTelecomExpenseManagementPartnersCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest Expand(Expression<Func<TelecomExpenseManagementPartner, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest Select(Expression<Func<TelecomExpenseManagementPartner, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest OrderBy(string value);
    }
}

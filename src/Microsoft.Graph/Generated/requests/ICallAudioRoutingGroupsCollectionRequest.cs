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
    /// The interface ICallAudioRoutingGroupsCollectionRequest.
    /// </summary>
    public partial interface ICallAudioRoutingGroupsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified AudioRoutingGroup to the collection via POST.
        /// </summary>
        /// <param name="audioRoutingGroup">The AudioRoutingGroup to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AudioRoutingGroup.</returns>
        System.Threading.Tasks.Task<AudioRoutingGroup> AddAsync(AudioRoutingGroup audioRoutingGroup, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified AudioRoutingGroup to the collection via POST and returns a <see cref="GraphResponse{AudioRoutingGroup}"/> object of the request.
        /// </summary>
        /// <param name="audioRoutingGroup">The AudioRoutingGroup to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AudioRoutingGroup}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AudioRoutingGroup>> AddResponseAsync(AudioRoutingGroup audioRoutingGroup, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICallAudioRoutingGroupsCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CallAudioRoutingGroupsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CallAudioRoutingGroupsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CallAudioRoutingGroupsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICallAudioRoutingGroupsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICallAudioRoutingGroupsCollectionRequest Expand(Expression<Func<AudioRoutingGroup, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICallAudioRoutingGroupsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICallAudioRoutingGroupsCollectionRequest Select(Expression<Func<AudioRoutingGroup, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICallAudioRoutingGroupsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICallAudioRoutingGroupsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICallAudioRoutingGroupsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICallAudioRoutingGroupsCollectionRequest OrderBy(string value);
    }
}

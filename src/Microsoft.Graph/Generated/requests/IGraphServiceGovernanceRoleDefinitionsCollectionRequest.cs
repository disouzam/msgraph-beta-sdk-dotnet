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
    /// The interface IGraphServiceGovernanceRoleDefinitionsCollectionRequest.
    /// </summary>
    public partial interface IGraphServiceGovernanceRoleDefinitionsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified GovernanceRoleDefinition to the collection via POST.
        /// </summary>
        /// <param name="governanceRoleDefinition">The GovernanceRoleDefinition to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceRoleDefinition.</returns>
        System.Threading.Tasks.Task<GovernanceRoleDefinition> AddAsync(GovernanceRoleDefinition governanceRoleDefinition, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified GovernanceRoleDefinition to the collection via POST and returns a <see cref="GraphResponse{GovernanceRoleDefinition}"/> object of the request.
        /// </summary>
        /// <param name="governanceRoleDefinition">The GovernanceRoleDefinition to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceRoleDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernanceRoleDefinition>> AddResponseAsync(GovernanceRoleDefinition governanceRoleDefinition, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IGraphServiceGovernanceRoleDefinitionsCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{GraphServiceGovernanceRoleDefinitionsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GraphServiceGovernanceRoleDefinitionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<GraphServiceGovernanceRoleDefinitionsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceGovernanceRoleDefinitionsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceGovernanceRoleDefinitionsCollectionRequest Expand(Expression<Func<GovernanceRoleDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceGovernanceRoleDefinitionsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceGovernanceRoleDefinitionsCollectionRequest Select(Expression<Func<GovernanceRoleDefinition, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceGovernanceRoleDefinitionsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceGovernanceRoleDefinitionsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceGovernanceRoleDefinitionsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceGovernanceRoleDefinitionsCollectionRequest OrderBy(string value);
    }
}

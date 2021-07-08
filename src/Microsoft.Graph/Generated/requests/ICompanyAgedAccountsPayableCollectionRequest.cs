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
    /// The interface ICompanyAgedAccountsPayableCollectionRequest.
    /// </summary>
    public partial interface ICompanyAgedAccountsPayableCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified AgedAccountsPayable to the collection via POST.
        /// </summary>
        /// <param name="agedAccountsPayable">The AgedAccountsPayable to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AgedAccountsPayable.</returns>
        System.Threading.Tasks.Task<AgedAccountsPayable> AddAsync(AgedAccountsPayable agedAccountsPayable, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified AgedAccountsPayable to the collection via POST and returns a <see cref="GraphResponse{AgedAccountsPayable}"/> object of the request.
        /// </summary>
        /// <param name="agedAccountsPayable">The AgedAccountsPayable to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgedAccountsPayable}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgedAccountsPayable>> AddResponseAsync(AgedAccountsPayable agedAccountsPayable, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICompanyAgedAccountsPayableCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CompanyAgedAccountsPayableCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CompanyAgedAccountsPayableCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CompanyAgedAccountsPayableCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyAgedAccountsPayableCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyAgedAccountsPayableCollectionRequest Expand(Expression<Func<AgedAccountsPayable, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyAgedAccountsPayableCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyAgedAccountsPayableCollectionRequest Select(Expression<Func<AgedAccountsPayable, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyAgedAccountsPayableCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyAgedAccountsPayableCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyAgedAccountsPayableCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyAgedAccountsPayableCollectionRequest OrderBy(string value);
    }
}

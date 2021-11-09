// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ILicenseDetailsWithReferenceRequest.
    /// </summary>
    public partial interface ILicenseDetailsWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified LicenseDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The LicenseDetails.</returns>
        System.Threading.Tasks.Task<LicenseDetails> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified LicenseDetails and returns a <see cref="GraphResponse{LicenseDetails}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LicenseDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<LicenseDetails>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified LicenseDetails using POST.
        /// </summary>
        /// <param name="licenseDetailsToCreate">The LicenseDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LicenseDetails.</returns>
        System.Threading.Tasks.Task<LicenseDetails> CreateAsync(LicenseDetails licenseDetailsToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified LicenseDetails using POST and returns a <see cref="GraphResponse{LicenseDetails}"/> object.
        /// </summary>
        /// <param name="licenseDetailsToCreate">The LicenseDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LicenseDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<LicenseDetails>> CreateResponseAsync(LicenseDetails licenseDetailsToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified LicenseDetails using PATCH.
        /// </summary>
        /// <param name="licenseDetailsToUpdate">The LicenseDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated LicenseDetails.</returns>
        System.Threading.Tasks.Task<LicenseDetails> UpdateAsync(LicenseDetails licenseDetailsToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified LicenseDetails using PATCH and returns a <see cref="GraphResponse{LicenseDetails}"/> object.
        /// </summary>
        /// <param name="licenseDetailsToUpdate">The LicenseDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{LicenseDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<LicenseDetails>> UpdateResponseAsync(LicenseDetails licenseDetailsToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified LicenseDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified LicenseDetails and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ILicenseDetailsWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ILicenseDetailsWithReferenceRequest Expand(Expression<Func<LicenseDetails, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ILicenseDetailsWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ILicenseDetailsWithReferenceRequest Select(Expression<Func<LicenseDetails, object>> selectExpression);

    }
}

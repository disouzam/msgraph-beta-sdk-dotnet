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
    /// The interface IAndroidWorkProfilePkcsCertificateProfileRequest.
    /// </summary>
    public partial interface IAndroidWorkProfilePkcsCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidWorkProfilePkcsCertificateProfile using POST.
        /// </summary>
        /// <param name="androidWorkProfilePkcsCertificateProfileToCreate">The AndroidWorkProfilePkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfilePkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfilePkcsCertificateProfile> CreateAsync(AndroidWorkProfilePkcsCertificateProfile androidWorkProfilePkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidWorkProfilePkcsCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidWorkProfilePkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidWorkProfilePkcsCertificateProfileToCreate">The AndroidWorkProfilePkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfilePkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfilePkcsCertificateProfile>> CreateResponseAsync(AndroidWorkProfilePkcsCertificateProfile androidWorkProfilePkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidWorkProfilePkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidWorkProfilePkcsCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidWorkProfilePkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfilePkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfilePkcsCertificateProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidWorkProfilePkcsCertificateProfile and returns a <see cref="GraphResponse{AndroidWorkProfilePkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfilePkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfilePkcsCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidWorkProfilePkcsCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidWorkProfilePkcsCertificateProfileToUpdate">The AndroidWorkProfilePkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidWorkProfilePkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfilePkcsCertificateProfile> UpdateAsync(AndroidWorkProfilePkcsCertificateProfile androidWorkProfilePkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidWorkProfilePkcsCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidWorkProfilePkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidWorkProfilePkcsCertificateProfileToUpdate">The AndroidWorkProfilePkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfilePkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfilePkcsCertificateProfile>> UpdateResponseAsync(AndroidWorkProfilePkcsCertificateProfile androidWorkProfilePkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidWorkProfilePkcsCertificateProfile using PUT.
        /// </summary>
        /// <param name="androidWorkProfilePkcsCertificateProfileToUpdate">The AndroidWorkProfilePkcsCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfilePkcsCertificateProfile> PutAsync(AndroidWorkProfilePkcsCertificateProfile androidWorkProfilePkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidWorkProfilePkcsCertificateProfile using PUT and returns a <see cref="GraphResponse{AndroidWorkProfilePkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidWorkProfilePkcsCertificateProfileToUpdate">The AndroidWorkProfilePkcsCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidWorkProfilePkcsCertificateProfile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfilePkcsCertificateProfile>> PutResponseAsync(AndroidWorkProfilePkcsCertificateProfile androidWorkProfilePkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfilePkcsCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfilePkcsCertificateProfileRequest Expand(Expression<Func<AndroidWorkProfilePkcsCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfilePkcsCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfilePkcsCertificateProfileRequest Select(Expression<Func<AndroidWorkProfilePkcsCertificateProfile, object>> selectExpression);

    }
}

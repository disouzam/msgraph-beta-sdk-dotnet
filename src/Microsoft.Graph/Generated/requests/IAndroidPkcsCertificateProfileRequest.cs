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
    /// The interface IAndroidPkcsCertificateProfileRequest.
    /// </summary>
    public partial interface IAndroidPkcsCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidPkcsCertificateProfile using POST.
        /// </summary>
        /// <param name="androidPkcsCertificateProfileToCreate">The AndroidPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidPkcsCertificateProfile> CreateAsync(AndroidPkcsCertificateProfile androidPkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidPkcsCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidPkcsCertificateProfileToCreate">The AndroidPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidPkcsCertificateProfile>> CreateResponseAsync(AndroidPkcsCertificateProfile androidPkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidPkcsCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidPkcsCertificateProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidPkcsCertificateProfile and returns a <see cref="GraphResponse{AndroidPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidPkcsCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidPkcsCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidPkcsCertificateProfileToUpdate">The AndroidPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidPkcsCertificateProfile> UpdateAsync(AndroidPkcsCertificateProfile androidPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidPkcsCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidPkcsCertificateProfileToUpdate">The AndroidPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidPkcsCertificateProfile>> UpdateResponseAsync(AndroidPkcsCertificateProfile androidPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidPkcsCertificateProfile using PUT.
        /// </summary>
        /// <param name="androidPkcsCertificateProfileToUpdate">The AndroidPkcsCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidPkcsCertificateProfile> PutAsync(AndroidPkcsCertificateProfile androidPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidPkcsCertificateProfile using PUT and returns a <see cref="GraphResponse{AndroidPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidPkcsCertificateProfileToUpdate">The AndroidPkcsCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidPkcsCertificateProfile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidPkcsCertificateProfile>> PutResponseAsync(AndroidPkcsCertificateProfile androidPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidPkcsCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidPkcsCertificateProfileRequest Expand(Expression<Func<AndroidPkcsCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidPkcsCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidPkcsCertificateProfileRequest Select(Expression<Func<AndroidPkcsCertificateProfile, object>> selectExpression);

    }
}

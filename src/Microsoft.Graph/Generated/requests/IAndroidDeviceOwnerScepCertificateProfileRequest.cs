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
    /// The interface IAndroidDeviceOwnerScepCertificateProfileRequest.
    /// </summary>
    public partial interface IAndroidDeviceOwnerScepCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidDeviceOwnerScepCertificateProfile using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerScepCertificateProfileToCreate">The AndroidDeviceOwnerScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceOwnerScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerScepCertificateProfile> CreateAsync(AndroidDeviceOwnerScepCertificateProfile androidDeviceOwnerScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerScepCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerScepCertificateProfileToCreate">The AndroidDeviceOwnerScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerScepCertificateProfile>> CreateResponseAsync(AndroidDeviceOwnerScepCertificateProfile androidDeviceOwnerScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerScepCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceOwnerScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerScepCertificateProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerScepCertificateProfile and returns a <see cref="GraphResponse{AndroidDeviceOwnerScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerScepCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerScepCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerScepCertificateProfileToUpdate">The AndroidDeviceOwnerScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceOwnerScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerScepCertificateProfile> UpdateAsync(AndroidDeviceOwnerScepCertificateProfile androidDeviceOwnerScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerScepCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerScepCertificateProfileToUpdate">The AndroidDeviceOwnerScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerScepCertificateProfile>> UpdateResponseAsync(AndroidDeviceOwnerScepCertificateProfile androidDeviceOwnerScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerScepCertificateProfile using PUT.
        /// </summary>
        /// <param name="androidDeviceOwnerScepCertificateProfileToUpdate">The AndroidDeviceOwnerScepCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerScepCertificateProfile> PutAsync(AndroidDeviceOwnerScepCertificateProfile androidDeviceOwnerScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerScepCertificateProfile using PUT and returns a <see cref="GraphResponse{AndroidDeviceOwnerScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerScepCertificateProfileToUpdate">The AndroidDeviceOwnerScepCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidDeviceOwnerScepCertificateProfile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerScepCertificateProfile>> PutResponseAsync(AndroidDeviceOwnerScepCertificateProfile androidDeviceOwnerScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerScepCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerScepCertificateProfileRequest Expand(Expression<Func<AndroidDeviceOwnerScepCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerScepCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerScepCertificateProfileRequest Select(Expression<Func<AndroidDeviceOwnerScepCertificateProfile, object>> selectExpression);

    }
}

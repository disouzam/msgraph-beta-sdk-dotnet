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
    /// The interface IAndroidForWorkScepCertificateProfileRequest.
    /// </summary>
    public partial interface IAndroidForWorkScepCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidForWorkScepCertificateProfile using POST.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToCreate">The AndroidForWorkScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkScepCertificateProfile> CreateAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidForWorkScepCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToCreate">The AndroidForWorkScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkScepCertificateProfile>> CreateResponseAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidForWorkScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidForWorkScepCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidForWorkScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkScepCertificateProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidForWorkScepCertificateProfile and returns a <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkScepCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidForWorkScepCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToUpdate">The AndroidForWorkScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidForWorkScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkScepCertificateProfile> UpdateAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidForWorkScepCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToUpdate">The AndroidForWorkScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkScepCertificateProfile>> UpdateResponseAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidForWorkScepCertificateProfile using PUT.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToUpdate">The AndroidForWorkScepCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidForWorkScepCertificateProfile> PutAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidForWorkScepCertificateProfile using PUT and returns a <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToUpdate">The AndroidForWorkScepCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkScepCertificateProfile>> PutResponseAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkScepCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkScepCertificateProfileRequest Expand(Expression<Func<AndroidForWorkScepCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkScepCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkScepCertificateProfileRequest Select(Expression<Func<AndroidForWorkScepCertificateProfile, object>> selectExpression);

    }
}

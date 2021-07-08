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
    /// The interface IWindows10PFXImportCertificateProfileRequest.
    /// </summary>
    public partial interface IWindows10PFXImportCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10PFXImportCertificateProfile using POST.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToCreate">The Windows10PFXImportCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10PFXImportCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> CreateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified Windows10PFXImportCertificateProfile using POST and returns a <see cref="GraphResponse{Windows10PFXImportCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToCreate">The Windows10PFXImportCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10PFXImportCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10PFXImportCertificateProfile>> CreateResponseAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Windows10PFXImportCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10PFXImportCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified Windows10PFXImportCertificateProfile and returns a <see cref="GraphResponse{Windows10PFXImportCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10PFXImportCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10PFXImportCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Windows10PFXImportCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToUpdate">The Windows10PFXImportCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10PFXImportCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> UpdateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Windows10PFXImportCertificateProfile using PATCH and returns a <see cref="GraphResponse{Windows10PFXImportCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToUpdate">The Windows10PFXImportCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows10PFXImportCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10PFXImportCertificateProfile>> UpdateResponseAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Windows10PFXImportCertificateProfile using PUT.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToUpdate">The Windows10PFXImportCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> PutAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Windows10PFXImportCertificateProfile using PUT and returns a <see cref="GraphResponse{Windows10PFXImportCertificateProfile}"/> object.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToUpdate">The Windows10PFXImportCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Windows10PFXImportCertificateProfile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10PFXImportCertificateProfile>> PutResponseAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10PFXImportCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10PFXImportCertificateProfileRequest Expand(Expression<Func<Windows10PFXImportCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10PFXImportCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10PFXImportCertificateProfileRequest Select(Expression<Func<Windows10PFXImportCertificateProfile, object>> selectExpression);

    }
}

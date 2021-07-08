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
    /// The interface IImportedDeviceIdentityResultRequest.
    /// </summary>
    public partial interface IImportedDeviceIdentityResultRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ImportedDeviceIdentityResult using POST.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToCreate">The ImportedDeviceIdentityResult to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ImportedDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> CreateAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ImportedDeviceIdentityResult using POST and returns a <see cref="GraphResponse{ImportedDeviceIdentityResult}"/> object.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToCreate">The ImportedDeviceIdentityResult to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ImportedDeviceIdentityResult}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ImportedDeviceIdentityResult>> CreateResponseAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ImportedDeviceIdentityResult.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ImportedDeviceIdentityResult and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ImportedDeviceIdentityResult.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ImportedDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ImportedDeviceIdentityResult and returns a <see cref="GraphResponse{ImportedDeviceIdentityResult}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ImportedDeviceIdentityResult}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ImportedDeviceIdentityResult>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ImportedDeviceIdentityResult using PATCH.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToUpdate">The ImportedDeviceIdentityResult to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ImportedDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> UpdateAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ImportedDeviceIdentityResult using PATCH and returns a <see cref="GraphResponse{ImportedDeviceIdentityResult}"/> object.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToUpdate">The ImportedDeviceIdentityResult to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ImportedDeviceIdentityResult}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ImportedDeviceIdentityResult>> UpdateResponseAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ImportedDeviceIdentityResult using PUT.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToUpdate">The ImportedDeviceIdentityResult object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> PutAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ImportedDeviceIdentityResult using PUT and returns a <see cref="GraphResponse{ImportedDeviceIdentityResult}"/> object.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToUpdate">The ImportedDeviceIdentityResult object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ImportedDeviceIdentityResult}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ImportedDeviceIdentityResult>> PutResponseAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IImportedDeviceIdentityResultRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IImportedDeviceIdentityResultRequest Expand(Expression<Func<ImportedDeviceIdentityResult, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IImportedDeviceIdentityResultRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IImportedDeviceIdentityResultRequest Select(Expression<Func<ImportedDeviceIdentityResult, object>> selectExpression);

    }
}

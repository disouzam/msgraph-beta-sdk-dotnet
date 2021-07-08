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
    /// The interface IEducationAssignmentResourceRequest.
    /// </summary>
    public partial interface IEducationAssignmentResourceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationAssignmentResource using POST.
        /// </summary>
        /// <param name="educationAssignmentResourceToCreate">The EducationAssignmentResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationAssignmentResource.</returns>
        System.Threading.Tasks.Task<EducationAssignmentResource> CreateAsync(EducationAssignmentResource educationAssignmentResourceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified EducationAssignmentResource using POST and returns a <see cref="GraphResponse{EducationAssignmentResource}"/> object.
        /// </summary>
        /// <param name="educationAssignmentResourceToCreate">The EducationAssignmentResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignmentResource>> CreateResponseAsync(EducationAssignmentResource educationAssignmentResourceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EducationAssignmentResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EducationAssignmentResource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EducationAssignmentResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationAssignmentResource.</returns>
        System.Threading.Tasks.Task<EducationAssignmentResource> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EducationAssignmentResource and returns a <see cref="GraphResponse{EducationAssignmentResource}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignmentResource>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EducationAssignmentResource using PATCH.
        /// </summary>
        /// <param name="educationAssignmentResourceToUpdate">The EducationAssignmentResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationAssignmentResource.</returns>
        System.Threading.Tasks.Task<EducationAssignmentResource> UpdateAsync(EducationAssignmentResource educationAssignmentResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EducationAssignmentResource using PATCH and returns a <see cref="GraphResponse{EducationAssignmentResource}"/> object.
        /// </summary>
        /// <param name="educationAssignmentResourceToUpdate">The EducationAssignmentResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignmentResource>> UpdateResponseAsync(EducationAssignmentResource educationAssignmentResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EducationAssignmentResource using PUT.
        /// </summary>
        /// <param name="educationAssignmentResourceToUpdate">The EducationAssignmentResource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EducationAssignmentResource> PutAsync(EducationAssignmentResource educationAssignmentResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EducationAssignmentResource using PUT and returns a <see cref="GraphResponse{EducationAssignmentResource}"/> object.
        /// </summary>
        /// <param name="educationAssignmentResourceToUpdate">The EducationAssignmentResource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EducationAssignmentResource}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignmentResource>> PutResponseAsync(EducationAssignmentResource educationAssignmentResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentResourceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentResourceRequest Expand(Expression<Func<EducationAssignmentResource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentResourceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentResourceRequest Select(Expression<Func<EducationAssignmentResource, object>> selectExpression);

    }
}

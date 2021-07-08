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
    /// The interface IPublishedResourceRequest.
    /// </summary>
    public partial interface IPublishedResourceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PublishedResource using POST.
        /// </summary>
        /// <param name="publishedResourceToCreate">The PublishedResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PublishedResource.</returns>
        System.Threading.Tasks.Task<PublishedResource> CreateAsync(PublishedResource publishedResourceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified PublishedResource using POST and returns a <see cref="GraphResponse{PublishedResource}"/> object.
        /// </summary>
        /// <param name="publishedResourceToCreate">The PublishedResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PublishedResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PublishedResource>> CreateResponseAsync(PublishedResource publishedResourceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PublishedResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PublishedResource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PublishedResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PublishedResource.</returns>
        System.Threading.Tasks.Task<PublishedResource> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PublishedResource and returns a <see cref="GraphResponse{PublishedResource}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PublishedResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PublishedResource>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PublishedResource using PATCH.
        /// </summary>
        /// <param name="publishedResourceToUpdate">The PublishedResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PublishedResource.</returns>
        System.Threading.Tasks.Task<PublishedResource> UpdateAsync(PublishedResource publishedResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PublishedResource using PATCH and returns a <see cref="GraphResponse{PublishedResource}"/> object.
        /// </summary>
        /// <param name="publishedResourceToUpdate">The PublishedResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PublishedResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PublishedResource>> UpdateResponseAsync(PublishedResource publishedResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PublishedResource using PUT.
        /// </summary>
        /// <param name="publishedResourceToUpdate">The PublishedResource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PublishedResource> PutAsync(PublishedResource publishedResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PublishedResource using PUT and returns a <see cref="GraphResponse{PublishedResource}"/> object.
        /// </summary>
        /// <param name="publishedResourceToUpdate">The PublishedResource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PublishedResource}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PublishedResource>> PutResponseAsync(PublishedResource publishedResourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPublishedResourceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPublishedResourceRequest Expand(Expression<Func<PublishedResource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPublishedResourceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPublishedResourceRequest Select(Expression<Func<PublishedResource, object>> selectExpression);

    }
}

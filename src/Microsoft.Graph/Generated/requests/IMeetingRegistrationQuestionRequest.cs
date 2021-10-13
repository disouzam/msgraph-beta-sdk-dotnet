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
    /// The interface IMeetingRegistrationQuestionRequest.
    /// </summary>
    public partial interface IMeetingRegistrationQuestionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MeetingRegistrationQuestion using POST.
        /// </summary>
        /// <param name="meetingRegistrationQuestionToCreate">The MeetingRegistrationQuestion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MeetingRegistrationQuestion.</returns>
        System.Threading.Tasks.Task<MeetingRegistrationQuestion> CreateAsync(MeetingRegistrationQuestion meetingRegistrationQuestionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MeetingRegistrationQuestion using POST and returns a <see cref="GraphResponse{MeetingRegistrationQuestion}"/> object.
        /// </summary>
        /// <param name="meetingRegistrationQuestionToCreate">The MeetingRegistrationQuestion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MeetingRegistrationQuestion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MeetingRegistrationQuestion>> CreateResponseAsync(MeetingRegistrationQuestion meetingRegistrationQuestionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MeetingRegistrationQuestion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MeetingRegistrationQuestion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MeetingRegistrationQuestion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MeetingRegistrationQuestion.</returns>
        System.Threading.Tasks.Task<MeetingRegistrationQuestion> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MeetingRegistrationQuestion and returns a <see cref="GraphResponse{MeetingRegistrationQuestion}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MeetingRegistrationQuestion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MeetingRegistrationQuestion>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MeetingRegistrationQuestion using PATCH.
        /// </summary>
        /// <param name="meetingRegistrationQuestionToUpdate">The MeetingRegistrationQuestion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MeetingRegistrationQuestion.</returns>
        System.Threading.Tasks.Task<MeetingRegistrationQuestion> UpdateAsync(MeetingRegistrationQuestion meetingRegistrationQuestionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MeetingRegistrationQuestion using PATCH and returns a <see cref="GraphResponse{MeetingRegistrationQuestion}"/> object.
        /// </summary>
        /// <param name="meetingRegistrationQuestionToUpdate">The MeetingRegistrationQuestion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MeetingRegistrationQuestion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MeetingRegistrationQuestion>> UpdateResponseAsync(MeetingRegistrationQuestion meetingRegistrationQuestionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MeetingRegistrationQuestion using PUT.
        /// </summary>
        /// <param name="meetingRegistrationQuestionToUpdate">The MeetingRegistrationQuestion object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MeetingRegistrationQuestion> PutAsync(MeetingRegistrationQuestion meetingRegistrationQuestionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MeetingRegistrationQuestion using PUT and returns a <see cref="GraphResponse{MeetingRegistrationQuestion}"/> object.
        /// </summary>
        /// <param name="meetingRegistrationQuestionToUpdate">The MeetingRegistrationQuestion object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MeetingRegistrationQuestion}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MeetingRegistrationQuestion>> PutResponseAsync(MeetingRegistrationQuestion meetingRegistrationQuestionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMeetingRegistrationQuestionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMeetingRegistrationQuestionRequest Expand(Expression<Func<MeetingRegistrationQuestion, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMeetingRegistrationQuestionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMeetingRegistrationQuestionRequest Select(Expression<Func<MeetingRegistrationQuestion, object>> selectExpression);

    }
}

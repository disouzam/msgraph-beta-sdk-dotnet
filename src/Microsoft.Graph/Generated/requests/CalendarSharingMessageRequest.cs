// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type CalendarSharingMessageRequest.
    /// </summary>
    public partial class CalendarSharingMessageRequest : BaseRequest, ICalendarSharingMessageRequest
    {
        /// <summary>
        /// Constructs a new CalendarSharingMessageRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CalendarSharingMessageRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CalendarSharingMessage using POST.
        /// </summary>
        /// <param name="calendarSharingMessageToCreate">The CalendarSharingMessage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CalendarSharingMessage.</returns>
        public async System.Threading.Tasks.Task<CalendarSharingMessage> CreateAsync(CalendarSharingMessage calendarSharingMessageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<CalendarSharingMessage>(calendarSharingMessageToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CalendarSharingMessage using POST and returns a <see cref="GraphResponse{CalendarSharingMessage}"/> object.
        /// </summary>
        /// <param name="calendarSharingMessageToCreate">The CalendarSharingMessage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CalendarSharingMessage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CalendarSharingMessage>> CreateResponseAsync(CalendarSharingMessage calendarSharingMessageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<CalendarSharingMessage>(calendarSharingMessageToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified CalendarSharingMessage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<CalendarSharingMessage>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CalendarSharingMessage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified CalendarSharingMessage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CalendarSharingMessage.</returns>
        public async System.Threading.Tasks.Task<CalendarSharingMessage> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<CalendarSharingMessage>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CalendarSharingMessage and returns a <see cref="GraphResponse{CalendarSharingMessage}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CalendarSharingMessage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CalendarSharingMessage>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<CalendarSharingMessage>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CalendarSharingMessage using PATCH.
        /// </summary>
        /// <param name="calendarSharingMessageToUpdate">The CalendarSharingMessage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CalendarSharingMessage.</returns>
        public async System.Threading.Tasks.Task<CalendarSharingMessage> UpdateAsync(CalendarSharingMessage calendarSharingMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<CalendarSharingMessage>(calendarSharingMessageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CalendarSharingMessage using PATCH and returns a <see cref="GraphResponse{CalendarSharingMessage}"/> object.
        /// </summary>
        /// <param name="calendarSharingMessageToUpdate">The CalendarSharingMessage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CalendarSharingMessage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CalendarSharingMessage>> UpdateResponseAsync(CalendarSharingMessage calendarSharingMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<CalendarSharingMessage>(calendarSharingMessageToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CalendarSharingMessage using PUT.
        /// </summary>
        /// <param name="calendarSharingMessageToUpdate">The CalendarSharingMessage object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<CalendarSharingMessage> PutAsync(CalendarSharingMessage calendarSharingMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<CalendarSharingMessage>(calendarSharingMessageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CalendarSharingMessage using PUT and returns a <see cref="GraphResponse{CalendarSharingMessage}"/> object.
        /// </summary>
        /// <param name="calendarSharingMessageToUpdate">The CalendarSharingMessage object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{CalendarSharingMessage}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CalendarSharingMessage>> PutResponseAsync(CalendarSharingMessage calendarSharingMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<CalendarSharingMessage>(calendarSharingMessageToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICalendarSharingMessageRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICalendarSharingMessageRequest Expand(Expression<Func<CalendarSharingMessage, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ICalendarSharingMessageRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICalendarSharingMessageRequest Select(Expression<Func<CalendarSharingMessage, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="calendarSharingMessageToInitialize">The <see cref="CalendarSharingMessage"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CalendarSharingMessage calendarSharingMessageToInitialize)
        {

        }
    }
}

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type MeetingRegistrationRequestBuilder.
    /// </summary>
    public partial class MeetingRegistrationRequestBuilder : EntityRequestBuilder, IMeetingRegistrationRequestBuilder
    {

        /// <summary>
        /// Constructs a new MeetingRegistrationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MeetingRegistrationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IMeetingRegistrationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IMeetingRegistrationRequest Request(IEnumerable<Option> options)
        {
            return new MeetingRegistrationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for CustomQuestions.
        /// </summary>
        /// <returns>The <see cref="IMeetingRegistrationCustomQuestionsCollectionRequestBuilder"/>.</returns>
        public IMeetingRegistrationCustomQuestionsCollectionRequestBuilder CustomQuestions
        {
            get
            {
                return new MeetingRegistrationCustomQuestionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("customQuestions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Registrants.
        /// </summary>
        /// <returns>The <see cref="IMeetingRegistrationRegistrantsCollectionRequestBuilder"/>.</returns>
        public IMeetingRegistrationRegistrantsCollectionRequestBuilder Registrants
        {
            get
            {
                return new MeetingRegistrationRegistrantsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("registrants"), this.Client);
            }
        }
    
    }
}

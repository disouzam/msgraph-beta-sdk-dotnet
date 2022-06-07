// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: StreamRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;

    /// <summary>
    /// The type Attachment_v2ContentRequestBuilder.
    /// </summary>
    public partial class Attachment_v2ContentRequestBuilder : BaseRequestBuilder, IAttachment_v2ContentRequestBuilder
    {
        /// <summary>
        /// Constructs a new Attachment_v2ContentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public Attachment_v2ContentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAttachment_v2ContentRequest Request(IEnumerable<Option> options = null)
        {
            return new Attachment_v2ContentRequest(this.RequestUrl, this.Client, options);
        }
    }
}

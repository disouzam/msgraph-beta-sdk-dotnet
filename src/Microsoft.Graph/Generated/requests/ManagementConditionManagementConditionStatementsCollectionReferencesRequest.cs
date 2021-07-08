// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ManagementConditionManagementConditionStatementsCollectionReferencesRequest.
    /// </summary>
    public partial class ManagementConditionManagementConditionStatementsCollectionReferencesRequest : BaseRequest, IManagementConditionManagementConditionStatementsCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new ManagementConditionManagementConditionStatementsCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagementConditionManagementConditionStatementsCollectionReferencesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified ManagementConditionStatement to the collection via POST.
        /// </summary>
        /// <param name="managementConditionStatement">The ManagementConditionStatement to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(ManagementConditionStatement managementConditionStatement, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;

            if (string.IsNullOrEmpty(managementConditionStatement.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/deviceManagement/managementConditionStatements/{1}", this.Client.BaseUrl, managementConditionStatement.Id) };
            return this.SendAsync(requestBody, cancellationToken);
        }

        /// <summary>
        /// Adds the specified ManagementConditionStatement to the collection via POST and returns a <see cref="GraphResponse{ManagementConditionStatement}"/> object of the request.
        /// </summary>
        /// <param name="managementConditionStatement">The ManagementConditionStatement to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(ManagementConditionStatement managementConditionStatement, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;

            if (string.IsNullOrEmpty(managementConditionStatement.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/deviceManagement/managementConditionStatements/{1}", this.Client.BaseUrl, managementConditionStatement.Id) };
            return this.SendAsyncWithGraphResponse(requestBody, cancellationToken);
        }

    }
}

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsEoMonthRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsEoMonthRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsEoMonthRequest>, IWorkbookFunctionsEoMonthRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsEoMonthRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="startDate">A startDate parameter for the OData method call.</param>
        /// <param name="months">A months parameter for the OData method call.</param>
        public WorkbookFunctionsEoMonthRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument startDate,
            System.Text.Json.JsonDocument months)
            : base(requestUrl, client)
        {
            this.SetParameter("startDate", startDate, true);
            this.SetParameter("months", months, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsEoMonthRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsEoMonthRequest(functionUrl, this.Client, options);

            if (this.HasParameter("startDate"))
            {
                request.RequestBody.StartDate = this.GetParameter<System.Text.Json.JsonDocument>("startDate");
            }

            if (this.HasParameter("months"))
            {
                request.RequestBody.Months = this.GetParameter<System.Text.Json.JsonDocument>("months");
            }

            return request;
        }
    }
}

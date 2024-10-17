// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ClearFilters;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Columns;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ConvertToRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.DataBodyRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.HeaderRowRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.RangeNamespace;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ReapplyFilters;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Rows;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Sort;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.TotalRowRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Worksheet;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex
{
    /// <summary>
    /// Provides operations to call the itemAt method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ItemAtWithIndexRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the clearFilters method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ClearFilters.ClearFiltersRequestBuilder ClearFilters
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ClearFilters.ClearFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.workbookTable entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Columns.ColumnsRequestBuilder Columns
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the convertToRange method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ConvertToRange.ConvertToRangeRequestBuilder ConvertToRange
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ConvertToRange.ConvertToRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the dataBodyRange method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.DataBodyRange.DataBodyRangeRequestBuilder DataBodyRange
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.DataBodyRange.DataBodyRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the headerRowRange method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.HeaderRowRange.HeaderRowRangeRequestBuilder HeaderRowRange
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.HeaderRowRange.HeaderRowRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the range method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.RangeNamespace.RangeRequestBuilder Range
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.RangeNamespace.RangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reapplyFilters method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ReapplyFilters.ReapplyFiltersRequestBuilder ReapplyFilters
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ReapplyFilters.ReapplyFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the rows property of the microsoft.graph.workbookTable entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Rows.RowsRequestBuilder Rows
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Rows.RowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sort property of the microsoft.graph.workbookTable entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Sort.SortRequestBuilder Sort
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Sort.SortRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the totalRowRange method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.TotalRowRange.TotalRowRangeRequestBuilder TotalRowRange
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.TotalRowRange.TotalRowRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookTable entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Worksheet.WorksheetRequestBuilder Worksheet
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="index">Usage: index={index}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? index = default) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/itemAt(index={index})", pathParameters)
        {
            if (index != null) PathParameters.Add("index", index);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/itemAt(index={index})", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function itemAt
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WorkbookTable"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.WorkbookTable?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.WorkbookTable> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.WorkbookTable>(requestInfo, global::Microsoft.Graph.Beta.Models.WorkbookTable.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function itemAt
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ItemAtWithIndexRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.ItemAtWithIndex.ItemAtWithIndexRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ItemAtWithIndexRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

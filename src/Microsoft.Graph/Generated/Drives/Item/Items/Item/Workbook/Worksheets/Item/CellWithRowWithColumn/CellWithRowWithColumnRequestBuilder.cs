// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.BoundingRectWithAnotherRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Clear;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnWithColumn1;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsAfter;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsAfterWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsBefore;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsBeforeWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Delete;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.EntireColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.EntireRow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Format;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Insert;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.IntersectionWithAnotherRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.LastCell;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.LastColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.LastRow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Merge;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.OffsetRangeWithRowOffsetWithColumnOffset;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ResizedRangeWithDeltaRowsWithDeltaColumns;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowWithRow1;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsAbove;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsAboveWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsBelow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsBelowWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Sort;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Unmerge;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.UsedRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.UsedRangeWithValuesOnly;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.VisibleView;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Worksheet;
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
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn
{
    /// <summary>
    /// Provides operations to call the cell method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class CellWithRowWithColumnRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the clear method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Clear.ClearRequestBuilder Clear
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Clear.ClearRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsAfter method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsAfter.ColumnsAfterRequestBuilder ColumnsAfter
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsAfter.ColumnsAfterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsBefore method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsBefore.ColumnsBeforeRequestBuilder ColumnsBefore
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsBefore.ColumnsBeforeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delete method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Delete.DeleteRequestBuilder DeletePath
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Delete.DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireColumn method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.EntireColumn.EntireColumnRequestBuilder EntireColumn
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.EntireColumn.EntireColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireRow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.EntireRow.EntireRowRequestBuilder EntireRow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.EntireRow.EntireRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the format property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Format.FormatRequestBuilder Format
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Format.FormatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the insert method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Insert.InsertRequestBuilder Insert
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Insert.InsertRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastCell method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.LastCell.LastCellRequestBuilder LastCell
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.LastCell.LastCellRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastColumn method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.LastColumn.LastColumnRequestBuilder LastColumn
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.LastColumn.LastColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastRow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.LastRow.LastRowRequestBuilder LastRow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.LastRow.LastRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the merge method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Merge.MergeRequestBuilder Merge
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Merge.MergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsAbove method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsAbove.RowsAboveRequestBuilder RowsAbove
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsAbove.RowsAboveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsBelow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsBelow.RowsBelowRequestBuilder RowsBelow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsBelow.RowsBelowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sort property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Sort.SortRequestBuilder Sort
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Sort.SortRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unmerge method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Unmerge.UnmergeRequestBuilder Unmerge
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Unmerge.UnmergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the usedRange method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.UsedRange.UsedRangeRequestBuilder UsedRange
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.UsedRange.UsedRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the visibleView method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.VisibleView.VisibleViewRequestBuilder VisibleView
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.VisibleView.VisibleViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Worksheet.WorksheetRequestBuilder Worksheet
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the boundingRect method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder BoundingRectWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the columnsAfter method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder ColumnsAfterWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the columnsBefore method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder ColumnsBeforeWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the column method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnWithColumn1.ColumnWithColumn1RequestBuilder"/></returns>
        /// <param name="column1">Usage: column={column1}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnWithColumn1.ColumnWithColumn1RequestBuilder ColumnWithColumn1(int? column1)
        {
            _ = column1 ?? throw new ArgumentNullException(nameof(column1));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ColumnWithColumn1.ColumnWithColumn1RequestBuilder(PathParameters, RequestAdapter, column1);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="column">Usage: column={column}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="row">Usage: row={row}</param>
        public CellWithRowWithColumnRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? column = default, int? row = default) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/cell(row={row},column={column})", pathParameters)
        {
            if (column != null) PathParameters.Add("column", column);
            if (row != null) PathParameters.Add("row", row);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CellWithRowWithColumnRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/cell(row={row},column={column})", rawUrl)
        {
        }
        /// <summary>
        /// Gets the range object containing the single cell based on row and column numbers. The cell can be outside the bounds of its parent range, so long as it&apos;s stays within the worksheet grid.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/worksheet-cell?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WorkbookRange"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.WorkbookRange?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.WorkbookRange> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.WorkbookRange>(requestInfo, global::Microsoft.Graph.Beta.Models.WorkbookRange.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the intersection method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder IntersectionWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the offsetRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder"/></returns>
        /// <param name="columnOffset">Usage: columnOffset={columnOffset}</param>
        /// <param name="rowOffset">Usage: rowOffset={rowOffset}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder OffsetRangeWithRowOffsetWithColumnOffset(int? columnOffset, int? rowOffset)
        {
            _ = columnOffset ?? throw new ArgumentNullException(nameof(columnOffset));
            _ = rowOffset ?? throw new ArgumentNullException(nameof(rowOffset));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder(PathParameters, RequestAdapter, columnOffset, rowOffset);
        }
        /// <summary>
        /// Provides operations to call the resizedRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder"/></returns>
        /// <param name="deltaColumns">Usage: deltaColumns={deltaColumns}</param>
        /// <param name="deltaRows">Usage: deltaRows={deltaRows}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder ResizedRangeWithDeltaRowsWithDeltaColumns(int? deltaColumns, int? deltaRows)
        {
            _ = deltaColumns ?? throw new ArgumentNullException(nameof(deltaColumns));
            _ = deltaRows ?? throw new ArgumentNullException(nameof(deltaRows));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder(PathParameters, RequestAdapter, deltaColumns, deltaRows);
        }
        /// <summary>
        /// Provides operations to call the rowsAbove method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsAboveWithCount.RowsAboveWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsAboveWithCount.RowsAboveWithCountRequestBuilder RowsAboveWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsAboveWithCount.RowsAboveWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the rowsBelow method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsBelowWithCount.RowsBelowWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsBelowWithCount.RowsBelowWithCountRequestBuilder RowsBelowWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowsBelowWithCount.RowsBelowWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the row method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowWithRow1.RowWithRow1RequestBuilder"/></returns>
        /// <param name="row1">Usage: row={row1}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowWithRow1.RowWithRow1RequestBuilder RowWithRow1(int? row1)
        {
            _ = row1 ?? throw new ArgumentNullException(nameof(row1));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.RowWithRow1.RowWithRow1RequestBuilder(PathParameters, RequestAdapter, row1);
        }
        /// <summary>
        /// Gets the range object containing the single cell based on row and column numbers. The cell can be outside the bounds of its parent range, so long as it&apos;s stays within the worksheet grid.
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
        /// Provides operations to call the usedRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder"/></returns>
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder UsedRangeWithValuesOnly(bool? valuesOnly)
        {
            _ = valuesOnly ?? throw new ArgumentNullException(nameof(valuesOnly));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder(PathParameters, RequestAdapter, valuesOnly);
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class CellWithRowWithColumnRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

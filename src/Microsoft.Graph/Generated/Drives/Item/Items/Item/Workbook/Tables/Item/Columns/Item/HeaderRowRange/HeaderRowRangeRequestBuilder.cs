// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.BoundingRectWithAnotherRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.CellWithRowWithColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Clear;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnWithColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfter;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfterWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBefore;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBeforeWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Delete;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.EntireColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.EntireRow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Format;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Insert;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.IntersectionWithAnotherRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.LastCell;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.LastColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.LastRow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Merge;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.OffsetRangeWithRowOffsetWithColumnOffset;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ResizedRangeWithDeltaRowsWithDeltaColumns;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowWithRow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsAbove;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsAboveWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsBelow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsBelowWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Sort;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Unmerge;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.UsedRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.UsedRangeWithValuesOnly;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.VisibleView;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Worksheet;
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
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange
{
    /// <summary>
    /// Provides operations to call the headerRowRange method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class HeaderRowRangeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the clear method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Clear.ClearRequestBuilder Clear
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Clear.ClearRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsAfter method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfter.ColumnsAfterRequestBuilder ColumnsAfter
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfter.ColumnsAfterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsBefore method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBefore.ColumnsBeforeRequestBuilder ColumnsBefore
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBefore.ColumnsBeforeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delete method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Delete.DeleteRequestBuilder DeletePath
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Delete.DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireColumn method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.EntireColumn.EntireColumnRequestBuilder EntireColumn
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.EntireColumn.EntireColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireRow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.EntireRow.EntireRowRequestBuilder EntireRow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.EntireRow.EntireRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the format property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Format.FormatRequestBuilder Format
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Format.FormatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the insert method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Insert.InsertRequestBuilder Insert
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Insert.InsertRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastCell method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.LastCell.LastCellRequestBuilder LastCell
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.LastCell.LastCellRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastColumn method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.LastColumn.LastColumnRequestBuilder LastColumn
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.LastColumn.LastColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastRow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.LastRow.LastRowRequestBuilder LastRow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.LastRow.LastRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the merge method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Merge.MergeRequestBuilder Merge
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Merge.MergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsAbove method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsAbove.RowsAboveRequestBuilder RowsAbove
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsAbove.RowsAboveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsBelow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsBelow.RowsBelowRequestBuilder RowsBelow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsBelow.RowsBelowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sort property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Sort.SortRequestBuilder Sort
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Sort.SortRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unmerge method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Unmerge.UnmergeRequestBuilder Unmerge
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Unmerge.UnmergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the usedRange method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.UsedRange.UsedRangeRequestBuilder UsedRange
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.UsedRange.UsedRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the visibleView method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.VisibleView.VisibleViewRequestBuilder VisibleView
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.VisibleView.VisibleViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Worksheet.WorksheetRequestBuilder Worksheet
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the boundingRect method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder BoundingRectWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the cell method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder"/></returns>
        /// <param name="column">Usage: column={column}</param>
        /// <param name="row">Usage: row={row}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder CellWithRowWithColumn(int? column, int? row)
        {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder(PathParameters, RequestAdapter, column, row);
        }
        /// <summary>
        /// Provides operations to call the columnsAfter method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder ColumnsAfterWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the columnsBefore method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder ColumnsBeforeWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the column method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnWithColumn.ColumnWithColumnRequestBuilder"/></returns>
        /// <param name="column">Usage: column={column}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnWithColumn.ColumnWithColumnRequestBuilder ColumnWithColumn(int? column)
        {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ColumnWithColumn.ColumnWithColumnRequestBuilder(PathParameters, RequestAdapter, column);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.HeaderRowRangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HeaderRowRangeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/headerRowRange()", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.HeaderRowRangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HeaderRowRangeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/headerRowRange()", rawUrl)
        {
        }
        /// <summary>
        /// Gets the range object associated with the header row of the column.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/tablecolumn-headerrowrange?view=graph-rest-beta" />
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder IntersectionWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the offsetRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder"/></returns>
        /// <param name="columnOffset">Usage: columnOffset={columnOffset}</param>
        /// <param name="rowOffset">Usage: rowOffset={rowOffset}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder OffsetRangeWithRowOffsetWithColumnOffset(int? columnOffset, int? rowOffset)
        {
            _ = columnOffset ?? throw new ArgumentNullException(nameof(columnOffset));
            _ = rowOffset ?? throw new ArgumentNullException(nameof(rowOffset));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder(PathParameters, RequestAdapter, columnOffset, rowOffset);
        }
        /// <summary>
        /// Provides operations to call the resizedRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder"/></returns>
        /// <param name="deltaColumns">Usage: deltaColumns={deltaColumns}</param>
        /// <param name="deltaRows">Usage: deltaRows={deltaRows}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder ResizedRangeWithDeltaRowsWithDeltaColumns(int? deltaColumns, int? deltaRows)
        {
            _ = deltaColumns ?? throw new ArgumentNullException(nameof(deltaColumns));
            _ = deltaRows ?? throw new ArgumentNullException(nameof(deltaRows));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder(PathParameters, RequestAdapter, deltaColumns, deltaRows);
        }
        /// <summary>
        /// Provides operations to call the rowsAbove method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsAboveWithCount.RowsAboveWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsAboveWithCount.RowsAboveWithCountRequestBuilder RowsAboveWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsAboveWithCount.RowsAboveWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the rowsBelow method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsBelowWithCount.RowsBelowWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsBelowWithCount.RowsBelowWithCountRequestBuilder RowsBelowWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowsBelowWithCount.RowsBelowWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the row method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowWithRow.RowWithRowRequestBuilder"/></returns>
        /// <param name="row">Usage: row={row}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowWithRow.RowWithRowRequestBuilder RowWithRow(int? row)
        {
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.RowWithRow.RowWithRowRequestBuilder(PathParameters, RequestAdapter, row);
        }
        /// <summary>
        /// Gets the range object associated with the header row of the column.
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder"/></returns>
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder UsedRangeWithValuesOnly(bool? valuesOnly)
        {
            _ = valuesOnly ?? throw new ArgumentNullException(nameof(valuesOnly));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder(PathParameters, RequestAdapter, valuesOnly);
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.HeaderRowRangeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.HeaderRowRangeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.Item.Columns.Item.HeaderRowRange.HeaderRowRangeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class HeaderRowRangeRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

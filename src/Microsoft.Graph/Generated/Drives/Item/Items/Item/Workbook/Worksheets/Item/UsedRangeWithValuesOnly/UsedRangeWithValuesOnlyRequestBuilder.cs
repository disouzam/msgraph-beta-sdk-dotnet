// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.BoundingRectWithAnotherRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.CellWithRowWithColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Clear;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnWithColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsAfter;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsAfterWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsBefore;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsBeforeWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Delete;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.EntireColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.EntireRow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Format;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Insert;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.IntersectionWithAnotherRange;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.LastCell;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.LastColumn;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.LastRow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Merge;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.OffsetRangeWithRowOffsetWithColumnOffset;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ResizedRangeWithDeltaRowsWithDeltaColumns;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowWithRow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsAbove;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsAboveWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsBelow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsBelowWithCount;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Sort;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Unmerge;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.VisibleView;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Worksheet;
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
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly
{
    /// <summary>
    /// Provides operations to call the usedRange method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UsedRangeWithValuesOnlyRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the clear method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Clear.ClearRequestBuilder Clear
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Clear.ClearRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsAfter method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsAfter.ColumnsAfterRequestBuilder ColumnsAfter
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsAfter.ColumnsAfterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsBefore method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsBefore.ColumnsBeforeRequestBuilder ColumnsBefore
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsBefore.ColumnsBeforeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delete method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Delete.DeleteRequestBuilder DeletePath
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Delete.DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireColumn method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.EntireColumn.EntireColumnRequestBuilder EntireColumn
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.EntireColumn.EntireColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireRow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.EntireRow.EntireRowRequestBuilder EntireRow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.EntireRow.EntireRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the format property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Format.FormatRequestBuilder Format
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Format.FormatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the insert method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Insert.InsertRequestBuilder Insert
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Insert.InsertRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastCell method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.LastCell.LastCellRequestBuilder LastCell
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.LastCell.LastCellRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastColumn method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.LastColumn.LastColumnRequestBuilder LastColumn
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.LastColumn.LastColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastRow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.LastRow.LastRowRequestBuilder LastRow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.LastRow.LastRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the merge method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Merge.MergeRequestBuilder Merge
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Merge.MergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsAbove method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsAbove.RowsAboveRequestBuilder RowsAbove
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsAbove.RowsAboveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsBelow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsBelow.RowsBelowRequestBuilder RowsBelow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsBelow.RowsBelowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sort property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Sort.SortRequestBuilder Sort
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Sort.SortRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unmerge method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Unmerge.UnmergeRequestBuilder Unmerge
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Unmerge.UnmergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the visibleView method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.VisibleView.VisibleViewRequestBuilder VisibleView
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.VisibleView.VisibleViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Worksheet.WorksheetRequestBuilder Worksheet
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the boundingRect method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder BoundingRectWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the cell method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder"/></returns>
        /// <param name="column">Usage: column={column}</param>
        /// <param name="row">Usage: row={row}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder CellWithRowWithColumn(int? column, int? row)
        {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder(PathParameters, RequestAdapter, column, row);
        }
        /// <summary>
        /// Provides operations to call the columnsAfter method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder ColumnsAfterWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the columnsBefore method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder ColumnsBeforeWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the column method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnWithColumn.ColumnWithColumnRequestBuilder"/></returns>
        /// <param name="column">Usage: column={column}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnWithColumn.ColumnWithColumnRequestBuilder ColumnWithColumn(int? column)
        {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ColumnWithColumn.ColumnWithColumnRequestBuilder(PathParameters, RequestAdapter, column);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        public UsedRangeWithValuesOnlyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, bool? valuesOnly = default) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/usedRange(valuesOnly={valuesOnly})", pathParameters)
        {
            if (valuesOnly != null) PathParameters.Add("valuesOnly", valuesOnly);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsedRangeWithValuesOnlyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/usedRange(valuesOnly={valuesOnly})", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function usedRange
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder IntersectionWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the offsetRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder"/></returns>
        /// <param name="columnOffset">Usage: columnOffset={columnOffset}</param>
        /// <param name="rowOffset">Usage: rowOffset={rowOffset}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder OffsetRangeWithRowOffsetWithColumnOffset(int? columnOffset, int? rowOffset)
        {
            _ = columnOffset ?? throw new ArgumentNullException(nameof(columnOffset));
            _ = rowOffset ?? throw new ArgumentNullException(nameof(rowOffset));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder(PathParameters, RequestAdapter, columnOffset, rowOffset);
        }
        /// <summary>
        /// Provides operations to call the resizedRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder"/></returns>
        /// <param name="deltaColumns">Usage: deltaColumns={deltaColumns}</param>
        /// <param name="deltaRows">Usage: deltaRows={deltaRows}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder ResizedRangeWithDeltaRowsWithDeltaColumns(int? deltaColumns, int? deltaRows)
        {
            _ = deltaColumns ?? throw new ArgumentNullException(nameof(deltaColumns));
            _ = deltaRows ?? throw new ArgumentNullException(nameof(deltaRows));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder(PathParameters, RequestAdapter, deltaColumns, deltaRows);
        }
        /// <summary>
        /// Provides operations to call the rowsAbove method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsAboveWithCount.RowsAboveWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsAboveWithCount.RowsAboveWithCountRequestBuilder RowsAboveWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsAboveWithCount.RowsAboveWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the rowsBelow method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsBelowWithCount.RowsBelowWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsBelowWithCount.RowsBelowWithCountRequestBuilder RowsBelowWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowsBelowWithCount.RowsBelowWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the row method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowWithRow.RowWithRowRequestBuilder"/></returns>
        /// <param name="row">Usage: row={row}</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowWithRow.RowWithRowRequestBuilder RowWithRow(int? row)
        {
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.RowWithRow.RowWithRowRequestBuilder(PathParameters, RequestAdapter, row);
        }
        /// <summary>
        /// Invoke function usedRange
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UsedRangeWithValuesOnlyRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

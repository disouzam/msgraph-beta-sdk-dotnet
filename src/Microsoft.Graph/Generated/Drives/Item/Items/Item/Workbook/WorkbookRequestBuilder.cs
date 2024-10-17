// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Application;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.CloseSession;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Comments;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.CreateSession;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Names;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Operations;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.RefreshSession;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.SessionInfoResourceWithKey;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.TableRowOperationResultWithKey;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets;
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
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook
{
    /// <summary>
    /// Provides operations to manage the workbook property of the microsoft.graph.driveItem entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WorkbookRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the application property of the microsoft.graph.workbook entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Application.ApplicationRequestBuilder Application
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Application.ApplicationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the closeSession method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.CloseSession.CloseSessionRequestBuilder CloseSession
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.CloseSession.CloseSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the comments property of the microsoft.graph.workbook entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Comments.CommentsRequestBuilder Comments
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Comments.CommentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createSession method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.CreateSession.CreateSessionRequestBuilder CreateSession
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.CreateSession.CreateSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the functions property of the microsoft.graph.workbook entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.FunctionsRequestBuilder Functions
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.FunctionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the names property of the microsoft.graph.workbook entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Names.NamesRequestBuilder Names
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Names.NamesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.workbook entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Operations.OperationsRequestBuilder Operations
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the refreshSession method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.RefreshSession.RefreshSessionRequestBuilder RefreshSession
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.RefreshSession.RefreshSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tables property of the microsoft.graph.workbook entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.TablesRequestBuilder Tables
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Tables.TablesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.WorksheetsRequestBuilder Worksheets
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.WorksheetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkbookRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkbookRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property workbook for drives
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// For files that are Excel spreadsheets, access to the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Workbook"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Workbook?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder.WorkbookRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Workbook> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder.WorkbookRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Workbook>(requestInfo, global::Microsoft.Graph.Beta.Models.Workbook.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property workbook in drives
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Workbook"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Workbook?> PatchAsync(global::Microsoft.Graph.Beta.Models.Workbook body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Workbook> PatchAsync(global::Microsoft.Graph.Beta.Models.Workbook body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Workbook>(requestInfo, global::Microsoft.Graph.Beta.Models.Workbook.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the sessionInfoResource method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.SessionInfoResourceWithKey.SessionInfoResourceWithKeyRequestBuilder"/></returns>
        /// <param name="key">Usage: key=&apos;{key}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.SessionInfoResourceWithKey.SessionInfoResourceWithKeyRequestBuilder SessionInfoResourceWithKey(string key)
        {
            if(string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.SessionInfoResourceWithKey.SessionInfoResourceWithKeyRequestBuilder(PathParameters, RequestAdapter, key);
        }
        /// <summary>
        /// Provides operations to call the tableRowOperationResult method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.TableRowOperationResultWithKey.TableRowOperationResultWithKeyRequestBuilder"/></returns>
        /// <param name="key">Usage: key=&apos;{key}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.TableRowOperationResultWithKey.TableRowOperationResultWithKeyRequestBuilder TableRowOperationResultWithKey(string key)
        {
            if(string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.TableRowOperationResultWithKey.TableRowOperationResultWithKeyRequestBuilder(PathParameters, RequestAdapter, key);
        }
        /// <summary>
        /// Delete navigation property workbook for drives
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, access to the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder.WorkbookRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder.WorkbookRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property workbook in drives
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Workbook body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Workbook body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WorkbookRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// For files that are Excel spreadsheets, access to the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WorkbookRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WorkbookRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder.WorkbookRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WorkbookRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.PermanentDelete
{
    /// <summary>
    /// Provides operations to call the permanentDelete method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PermanentDeleteRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.PermanentDelete.PermanentDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermanentDeleteRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/calendar/events/{event%2Did}/instances/{event%2Did1}/permanentDelete", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.PermanentDelete.PermanentDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermanentDeleteRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/calendar/events/{event%2Did}/instances/{event%2Did1}/permanentDelete", rawUrl)
        {
        }
        /// <summary>
        /// Permanently delete an event and place it in the Purges folder in the dumpster in the user&apos;s mailbox. Email clients such as Outlook or the Outlook on the web can&apos;t access permanently deleted items. Unless there&apos;s a hold set on the mailbox, the items are permanently deleted after a set period of time. For more information about item retention, see Configure Deleted Item retention and Recoverable Items quotas.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/event-permanentdelete?view=graph-rest-beta" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Permanently delete an event and place it in the Purges folder in the dumpster in the user&apos;s mailbox. Email clients such as Outlook or the Outlook on the web can&apos;t access permanently deleted items. Unless there&apos;s a hold set on the mailbox, the items are permanently deleted after a set period of time. For more information about item retention, see Configure Deleted Item retention and Recoverable Items quotas.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.PermanentDelete.PermanentDeleteRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.PermanentDelete.PermanentDeleteRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.PermanentDelete.PermanentDeleteRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PermanentDeleteRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

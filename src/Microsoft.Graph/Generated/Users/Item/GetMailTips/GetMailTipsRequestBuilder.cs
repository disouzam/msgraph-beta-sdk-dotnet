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
namespace Microsoft.Graph.Beta.Users.Item.GetMailTips
{
    /// <summary>
    /// Provides operations to call the getMailTips method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class GetMailTipsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetMailTipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/getMailTips", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetMailTipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/getMailTips", rawUrl)
        {
        }
        /// <summary>
        /// Get the MailTips of one or more recipients as available to the signed-in user. Note that by making a POST call to the getMailTips action, you can request specific types of MailTips tobe returned for more than one recipient at one time. The requested MailTips are returned in a mailTips collection.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-getmailtips?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostResponse?> PostAsGetMailTipsPostResponseAsync(global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostResponse> PostAsGetMailTipsPostResponseAsync(global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostResponse>(requestInfo, global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the MailTips of one or more recipients as available to the signed-in user. Note that by making a POST call to the getMailTips action, you can request specific types of MailTips tobe returned for more than one recipient at one time. The requested MailTips are returned in a mailTips collection.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-getmailtips?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsGetMailTipsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsResponse?> PostAsync(global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsResponse> PostAsync(global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsResponse>(requestInfo, global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the MailTips of one or more recipients as available to the signed-in user. Note that by making a POST call to the getMailTips action, you can request specific types of MailTips tobe returned for more than one recipient at one time. The requested MailTips are returned in a mailTips collection.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
        public global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Users.Item.GetMailTips.GetMailTipsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class GetMailTipsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

// <auto-generated/>
#pragma warning disable CS0618
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
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetFrontlineCloudPcAccessState
{
    /// <summary>
    /// Provides operations to call the getFrontlineCloudPcAccessState method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class GetFrontlineCloudPcAccessStateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetFrontlineCloudPcAccessState.GetFrontlineCloudPcAccessStateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetFrontlineCloudPcAccessStateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC%2Did}/getFrontlineCloudPcAccessState()", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetFrontlineCloudPcAccessState.GetFrontlineCloudPcAccessStateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetFrontlineCloudPcAccessStateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC%2Did}/getFrontlineCloudPcAccessState()", rawUrl)
        {
        }
        /// <summary>
        /// Get the frontlineCloudPcAccessState of a frontline Cloud PC.  This API only supports shared-use licenses. For more information, see cloudPcProvisioningPolicy. Shared-use licenses allow three users per license, with one user signed in at a time. Callers can get the latest frontline Cloud PC accessState and determine whether the frontline Cloud PC is accessible to a user.  If a web client needs to connect to a frontline Cloud PC, the sharedCloudPcAccessState validates the bookmark scenario. If sharedCloudPcAccessState isn&apos;t active/activating/standbyMode, the web client shows a bad bookmark.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-getfrontlinecloudpcaccessstate?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.FrontlineCloudPcAccessState"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.FrontlineCloudPcAccessState?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.FrontlineCloudPcAccessState?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<global::Microsoft.Graph.Beta.Models.FrontlineCloudPcAccessState?>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the frontlineCloudPcAccessState of a frontline Cloud PC.  This API only supports shared-use licenses. For more information, see cloudPcProvisioningPolicy. Shared-use licenses allow three users per license, with one user signed in at a time. Callers can get the latest frontline Cloud PC accessState and determine whether the frontline Cloud PC is accessible to a user.  If a web client needs to connect to a frontline Cloud PC, the sharedCloudPcAccessState validates the bookmark scenario. If sharedCloudPcAccessState isn&apos;t active/activating/standbyMode, the web client shows a bad bookmark.
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetFrontlineCloudPcAccessState.GetFrontlineCloudPcAccessStateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetFrontlineCloudPcAccessState.GetFrontlineCloudPcAccessStateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.GetFrontlineCloudPcAccessState.GetFrontlineCloudPcAccessStateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class GetFrontlineCloudPcAccessStateRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

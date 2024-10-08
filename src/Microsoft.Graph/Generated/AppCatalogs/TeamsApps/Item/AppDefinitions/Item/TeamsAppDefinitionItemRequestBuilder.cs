// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.Bot;
using Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.ColorIcon;
using Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.DashboardCards;
using Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.OutlineIcon;
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
namespace Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item
{
    /// <summary>
    /// Provides operations to manage the appDefinitions property of the microsoft.graph.teamsApp entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class TeamsAppDefinitionItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the bot property of the microsoft.graph.teamsAppDefinition entity.</summary>
        public global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.Bot.BotRequestBuilder Bot
        {
            get => new global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.Bot.BotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the colorIcon property of the microsoft.graph.teamsAppDefinition entity.</summary>
        public global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.ColorIcon.ColorIconRequestBuilder ColorIcon
        {
            get => new global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.ColorIcon.ColorIconRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dashboardCards property of the microsoft.graph.teamsAppDefinition entity.</summary>
        public global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.DashboardCards.DashboardCardsRequestBuilder DashboardCards
        {
            get => new global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.DashboardCards.DashboardCardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the outlineIcon property of the microsoft.graph.teamsAppDefinition entity.</summary>
        public global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.OutlineIcon.OutlineIconRequestBuilder OutlineIcon
        {
            get => new global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.OutlineIcon.OutlineIconRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsAppDefinitionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/appCatalogs/teamsApps/{teamsApp%2Did}/appDefinitions/{teamsAppDefinition%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsAppDefinitionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/appCatalogs/teamsApps/{teamsApp%2Did}/appDefinitions/{teamsAppDefinition%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property appDefinitions for appCatalogs
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
        /// The details for each version of the app.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TeamsAppDefinition"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.TeamsAppDefinition?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder.TeamsAppDefinitionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.TeamsAppDefinition> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder.TeamsAppDefinitionItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.TeamsAppDefinition>(requestInfo, global::Microsoft.Graph.Beta.Models.TeamsAppDefinition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Publish an app to the Microsoft Teams app catalog.Specifically, this API publishes the app to your organization&apos;s catalog (the tenant app catalog);the created resource has a distributionMethod property value of organization. The requiresReview property allows any user to submit an app for review by an administrator. Admins can approve or reject these apps via this API or the Microsoft Teams admin center.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/teamsapp-publish?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TeamsAppDefinition"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.TeamsAppDefinition?> PatchAsync(global::Microsoft.Graph.Beta.Models.TeamsAppDefinition body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.TeamsAppDefinition> PatchAsync(global::Microsoft.Graph.Beta.Models.TeamsAppDefinition body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.TeamsAppDefinition>(requestInfo, global::Microsoft.Graph.Beta.Models.TeamsAppDefinition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property appDefinitions for appCatalogs
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
        /// The details for each version of the app.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder.TeamsAppDefinitionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder.TeamsAppDefinitionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Publish an app to the Microsoft Teams app catalog.Specifically, this API publishes the app to your organization&apos;s catalog (the tenant app catalog);the created resource has a distributionMethod property value of organization. The requiresReview property allows any user to submit an app for review by an administrator. Admins can approve or reject these apps via this API or the Microsoft Teams admin center.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.TeamsAppDefinition body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.TeamsAppDefinition body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TeamsAppDefinitionItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The details for each version of the app.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TeamsAppDefinitionItemRequestBuilderGetQueryParameters 
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TeamsAppDefinitionItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder.TeamsAppDefinitionItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TeamsAppDefinitionItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Archive;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.CompleteMigration;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalName;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.FilesFolder;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.GetAllMembers;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Members;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Messages;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ProvisionEmail;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.RemoveEmail;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.SharedWithTeams;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Tabs;
using Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Unarchive;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item
{
    /// <summary>
    /// Provides operations to manage the channels property of the microsoft.graph.team entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ChannelItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the archive method.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Archive.ArchiveRequestBuilder Archive
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Archive.ArchiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the completeMigration method.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.CompleteMigration.CompleteMigrationRequestBuilder CompleteMigration
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.CompleteMigration.CompleteMigrationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the doesUserHaveAccess method.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalName.DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilder DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalName
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalName.DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the filesFolder property of the microsoft.graph.channel entity.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.FilesFolder.FilesFolderRequestBuilder FilesFolder
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.FilesFolder.FilesFolderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the getAllMembers property of the microsoft.graph.channel entity.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.GetAllMembers.GetAllMembersRequestBuilder GetAllMembers
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.GetAllMembers.GetAllMembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the members property of the microsoft.graph.channel entity.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Members.MembersRequestBuilder Members
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Members.MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the messages property of the microsoft.graph.channel entity.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Messages.MessagesRequestBuilder Messages
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Messages.MessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the provisionEmail method.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ProvisionEmail.ProvisionEmailRequestBuilder ProvisionEmail
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ProvisionEmail.ProvisionEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeEmail method.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.RemoveEmail.RemoveEmailRequestBuilder RemoveEmail
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.RemoveEmail.RemoveEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sharedWithTeams property of the microsoft.graph.channel entity.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.SharedWithTeams.SharedWithTeamsRequestBuilder SharedWithTeams
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.SharedWithTeams.SharedWithTeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tabs property of the microsoft.graph.channel entity.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Tabs.TabsRequestBuilder Tabs
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Tabs.TabsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unarchive method.</summary>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Unarchive.UnarchiveRequestBuilder Unarchive
        {
            get => new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.Unarchive.UnarchiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChannelItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teamTemplateDefinition/{teamTemplateDefinition%2Did}/teamDefinition/channels/{channel%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChannelItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teamTemplateDefinition/{teamTemplateDefinition%2Did}/teamDefinition/channels/{channel%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property channels for teamTemplateDefinition
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
        /// The collection of channels and messages associated with the team.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Channel"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Channel?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder.ChannelItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Channel> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder.ChannelItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Channel>(requestInfo, global::Microsoft.Graph.Beta.Models.Channel.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property channels in teamTemplateDefinition
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Channel"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Channel?> PatchAsync(global::Microsoft.Graph.Beta.Models.Channel body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Channel> PatchAsync(global::Microsoft.Graph.Beta.Models.Channel body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Channel>(requestInfo, global::Microsoft.Graph.Beta.Models.Channel.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property channels for teamTemplateDefinition
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
        /// The collection of channels and messages associated with the team.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder.ChannelItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder.ChannelItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property channels in teamTemplateDefinition
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Channel body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Channel body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ChannelItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The collection of channels and messages associated with the team.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ChannelItemRequestBuilderGetQueryParameters 
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
        public partial class ChannelItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.TeamTemplateDefinition.Item.TeamDefinition.Channels.Item.ChannelItemRequestBuilder.ChannelItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ChannelItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

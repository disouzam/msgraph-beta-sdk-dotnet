// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Users.Item.Profile.Account;
using Microsoft.Graph.Beta.Users.Item.Profile.Addresses;
using Microsoft.Graph.Beta.Users.Item.Profile.Anniversaries;
using Microsoft.Graph.Beta.Users.Item.Profile.Awards;
using Microsoft.Graph.Beta.Users.Item.Profile.Certifications;
using Microsoft.Graph.Beta.Users.Item.Profile.EducationalActivities;
using Microsoft.Graph.Beta.Users.Item.Profile.Emails;
using Microsoft.Graph.Beta.Users.Item.Profile.Interests;
using Microsoft.Graph.Beta.Users.Item.Profile.Languages;
using Microsoft.Graph.Beta.Users.Item.Profile.Names;
using Microsoft.Graph.Beta.Users.Item.Profile.Notes;
using Microsoft.Graph.Beta.Users.Item.Profile.Patents;
using Microsoft.Graph.Beta.Users.Item.Profile.Phones;
using Microsoft.Graph.Beta.Users.Item.Profile.Positions;
using Microsoft.Graph.Beta.Users.Item.Profile.Projects;
using Microsoft.Graph.Beta.Users.Item.Profile.Publications;
using Microsoft.Graph.Beta.Users.Item.Profile.Skills;
using Microsoft.Graph.Beta.Users.Item.Profile.WebAccounts;
using Microsoft.Graph.Beta.Users.Item.Profile.Websites;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item.Profile
{
    /// <summary>
    /// Provides operations to manage the profile property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ProfileRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the account property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Account.AccountRequestBuilder Account
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Account.AccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the addresses property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Addresses.AddressesRequestBuilder Addresses
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Addresses.AddressesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the anniversaries property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Anniversaries.AnniversariesRequestBuilder Anniversaries
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Anniversaries.AnniversariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the awards property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Awards.AwardsRequestBuilder Awards
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Awards.AwardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the certifications property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Certifications.CertificationsRequestBuilder Certifications
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Certifications.CertificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the educationalActivities property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.EducationalActivities.EducationalActivitiesRequestBuilder EducationalActivities
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.EducationalActivities.EducationalActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the emails property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Emails.EmailsRequestBuilder Emails
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Emails.EmailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the interests property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Interests.InterestsRequestBuilder Interests
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Interests.InterestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the languages property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Languages.LanguagesRequestBuilder Languages
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Languages.LanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the names property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Names.NamesRequestBuilder Names
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Names.NamesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the notes property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Notes.NotesRequestBuilder Notes
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Notes.NotesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the patents property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Patents.PatentsRequestBuilder Patents
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Patents.PatentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the phones property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Phones.PhonesRequestBuilder Phones
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Phones.PhonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the positions property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Positions.PositionsRequestBuilder Positions
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Positions.PositionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the projects property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Projects.ProjectsRequestBuilder Projects
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Projects.ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the publications property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Publications.PublicationsRequestBuilder Publications
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Publications.PublicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the skills property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Skills.SkillsRequestBuilder Skills
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Skills.SkillsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the webAccounts property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.WebAccounts.WebAccountsRequestBuilder WebAccounts
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.WebAccounts.WebAccountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the websites property of the microsoft.graph.profile entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.Websites.WebsitesRequestBuilder Websites
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Profile.Websites.WebsitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/profile{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/profile{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property profile for users
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
        /// Represents properties that are descriptive of a user in a tenant.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Profile"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Profile?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder.ProfileRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Profile> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder.ProfileRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Profile>(requestInfo, global::Microsoft.Graph.Beta.Models.Profile.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property profile in users
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Profile"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Profile?> PatchAsync(global::Microsoft.Graph.Beta.Models.Profile body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Profile> PatchAsync(global::Microsoft.Graph.Beta.Models.Profile body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Profile>(requestInfo, global::Microsoft.Graph.Beta.Models.Profile.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property profile for users
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
        /// Represents properties that are descriptive of a user in a tenant.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder.ProfileRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder.ProfileRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property profile in users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Profile body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Profile body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ProfileRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Represents properties that are descriptive of a user in a tenant.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ProfileRequestBuilderGetQueryParameters 
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
        public partial class ProfileRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Profile.ProfileRequestBuilder.ProfileRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ProfileRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

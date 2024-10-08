// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.DirectoryNamespace.AdministrativeUnits;
using Microsoft.Graph.Beta.DirectoryNamespace.AttributeSets;
using Microsoft.Graph.Beta.DirectoryNamespace.CertificateAuthorities;
using Microsoft.Graph.Beta.DirectoryNamespace.CustomSecurityAttributeDefinitions;
using Microsoft.Graph.Beta.DirectoryNamespace.DeletedItems;
using Microsoft.Graph.Beta.DirectoryNamespace.DeviceLocalCredentials;
using Microsoft.Graph.Beta.DirectoryNamespace.ExternalUserProfiles;
using Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies;
using Microsoft.Graph.Beta.DirectoryNamespace.FederationConfigurations;
using Microsoft.Graph.Beta.DirectoryNamespace.ImpactedResources;
using Microsoft.Graph.Beta.DirectoryNamespace.InboundSharedUserProfiles;
using Microsoft.Graph.Beta.DirectoryNamespace.OnPremisesSynchronization;
using Microsoft.Graph.Beta.DirectoryNamespace.OutboundSharedUserProfiles;
using Microsoft.Graph.Beta.DirectoryNamespace.PendingExternalUserProfiles;
using Microsoft.Graph.Beta.DirectoryNamespace.Recommendations;
using Microsoft.Graph.Beta.DirectoryNamespace.SharedEmailDomains;
using Microsoft.Graph.Beta.DirectoryNamespace.Subscriptions;
using Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithCommerceSubscriptionId;
using Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithOcpSubscriptionId;
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
namespace Microsoft.Graph.Beta.DirectoryNamespace
{
    /// <summary>
    /// Provides operations to manage the directory singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DirectoryRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the administrativeUnits property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.AdministrativeUnits.AdministrativeUnitsRequestBuilder AdministrativeUnits
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.AdministrativeUnits.AdministrativeUnitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attributeSets property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.AttributeSets.AttributeSetsRequestBuilder AttributeSets
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.AttributeSets.AttributeSetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the certificateAuthorities property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.CertificateAuthorities.CertificateAuthoritiesRequestBuilder CertificateAuthorities
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.CertificateAuthorities.CertificateAuthoritiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customSecurityAttributeDefinitions property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.CustomSecurityAttributeDefinitions.CustomSecurityAttributeDefinitionsRequestBuilder CustomSecurityAttributeDefinitions
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.CustomSecurityAttributeDefinitions.CustomSecurityAttributeDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deletedItems property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.DeletedItems.DeletedItemsRequestBuilder DeletedItems
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.DeletedItems.DeletedItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceLocalCredentials property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.DeviceLocalCredentials.DeviceLocalCredentialsRequestBuilder DeviceLocalCredentials
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.DeviceLocalCredentials.DeviceLocalCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the externalUserProfiles property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.ExternalUserProfiles.ExternalUserProfilesRequestBuilder ExternalUserProfiles
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.ExternalUserProfiles.ExternalUserProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the featureRolloutPolicies property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.FeatureRolloutPoliciesRequestBuilder FeatureRolloutPolicies
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies.FeatureRolloutPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the federationConfigurations property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.FederationConfigurations.FederationConfigurationsRequestBuilder FederationConfigurations
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.FederationConfigurations.FederationConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the impactedResources property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.ImpactedResources.ImpactedResourcesRequestBuilder ImpactedResources
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.ImpactedResources.ImpactedResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the inboundSharedUserProfiles property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.InboundSharedUserProfiles.InboundSharedUserProfilesRequestBuilder InboundSharedUserProfiles
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.InboundSharedUserProfiles.InboundSharedUserProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onPremisesSynchronization property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.OnPremisesSynchronization.OnPremisesSynchronizationRequestBuilder OnPremisesSynchronization
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.OnPremisesSynchronization.OnPremisesSynchronizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the outboundSharedUserProfiles property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.OutboundSharedUserProfiles.OutboundSharedUserProfilesRequestBuilder OutboundSharedUserProfiles
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.OutboundSharedUserProfiles.OutboundSharedUserProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the pendingExternalUserProfiles property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.PendingExternalUserProfiles.PendingExternalUserProfilesRequestBuilder PendingExternalUserProfiles
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.PendingExternalUserProfiles.PendingExternalUserProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the recommendations property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.Recommendations.RecommendationsRequestBuilder Recommendations
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.Recommendations.RecommendationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sharedEmailDomains property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.SharedEmailDomains.SharedEmailDomainsRequestBuilder SharedEmailDomains
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.SharedEmailDomains.SharedEmailDomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.</summary>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.Subscriptions.SubscriptionsRequestBuilder Subscriptions
        {
            get => new global::Microsoft.Graph.Beta.DirectoryNamespace.Subscriptions.SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directory{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directory{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get directory
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DirectoryObject1"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObject1?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObject1> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.DirectoryObject1>(requestInfo, global::Microsoft.Graph.Beta.Models.DirectoryObject1.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update directory
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DirectoryObject1"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObject1?> PatchAsync(global::Microsoft.Graph.Beta.Models.DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObject1> PatchAsync(global::Microsoft.Graph.Beta.Models.DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.DirectoryObject1>(requestInfo, global::Microsoft.Graph.Beta.Models.DirectoryObject1.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithCommerceSubscriptionId.SubscriptionsWithCommerceSubscriptionIdRequestBuilder"/></returns>
        /// <param name="commerceSubscriptionId">Alternate key of companySubscription</param>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithCommerceSubscriptionId.SubscriptionsWithCommerceSubscriptionIdRequestBuilder SubscriptionsWithCommerceSubscriptionId(string commerceSubscriptionId)
        {
            if(string.IsNullOrEmpty(commerceSubscriptionId)) throw new ArgumentNullException(nameof(commerceSubscriptionId));
            return new global::Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithCommerceSubscriptionId.SubscriptionsWithCommerceSubscriptionIdRequestBuilder(PathParameters, RequestAdapter, commerceSubscriptionId);
        }
        /// <summary>
        /// Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithOcpSubscriptionId.SubscriptionsWithOcpSubscriptionIdRequestBuilder"/></returns>
        /// <param name="ocpSubscriptionId">Alternate key of companySubscription</param>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithOcpSubscriptionId.SubscriptionsWithOcpSubscriptionIdRequestBuilder SubscriptionsWithOcpSubscriptionId(string ocpSubscriptionId)
        {
            if(string.IsNullOrEmpty(ocpSubscriptionId)) throw new ArgumentNullException(nameof(ocpSubscriptionId));
            return new global::Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithOcpSubscriptionId.SubscriptionsWithOcpSubscriptionIdRequestBuilder(PathParameters, RequestAdapter, ocpSubscriptionId);
        }
        /// <summary>
        /// Get directory
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update directory
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get directory
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DirectoryRequestBuilderGetQueryParameters 
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
        public partial class DirectoryRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DirectoryRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

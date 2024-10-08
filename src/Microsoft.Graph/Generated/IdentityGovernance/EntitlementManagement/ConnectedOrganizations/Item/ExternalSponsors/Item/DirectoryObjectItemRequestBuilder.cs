// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.ExternalSponsors.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.ExternalSponsors.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \identityGovernance\entitlementManagement\connectedOrganizations\{connectedOrganization-id}\externalSponsors\{directoryObject-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DirectoryObjectItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of identityGovernance entities.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.ExternalSponsors.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.ExternalSponsors.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.ExternalSponsors.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/connectedOrganizations/{connectedOrganization%2Did}/externalSponsors/{directoryObject%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.Item.ExternalSponsors.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/connectedOrganizations/{connectedOrganization%2Did}/externalSponsors/{directoryObject%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618

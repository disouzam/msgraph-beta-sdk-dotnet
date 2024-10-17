// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Applications.Item.AppManagementPolicies.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.Applications.Item.AppManagementPolicies.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \applications\{application-id}\appManagementPolicies\{appManagementPolicy-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AppManagementPolicyItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of application entities.</summary>
        public global::Microsoft.Graph.Beta.Applications.Item.AppManagementPolicies.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Beta.Applications.Item.AppManagementPolicies.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Applications.Item.AppManagementPolicies.Item.AppManagementPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppManagementPolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/appManagementPolicies/{appManagementPolicy%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Applications.Item.AppManagementPolicies.Item.AppManagementPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppManagementPolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/appManagementPolicies/{appManagementPolicy%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618

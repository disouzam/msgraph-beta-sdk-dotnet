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
namespace Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate
{
    /// <summary>
    /// Provides operations to call the addTokenSigningCertificate method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class AddTokenSigningCertificateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddTokenSigningCertificateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/addTokenSigningCertificate", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddTokenSigningCertificateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/addTokenSigningCertificate", rawUrl)
        {
        }
        /// <summary>
        /// Creates a self-signed signing certificate and returns a selfSignedCertificate object, which is the public part of the generated certificate. The self-signed signing certificate is composed of the following objects which are added to the servicePrincipal: + The keyCredentials object with the following objects:    + A private key object with usage set to Sign.    + A public key object with usage set to Verify.+ The passwordCredentials object. All the objects have the same value of customKeyIdentifier. The passwordCredential is used to open the PFX file (private key). It and the associated private key object have the same value of keyId. Once set during creation through the displayName property, the subject of the certificate cannot be updated. The startDateTime is set to the same time the certificate is created using the action. The endDateTime can be up to three years after the certificate is created.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/serviceprincipal-addtokensigningcertificate?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SelfSignedCertificate"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.SelfSignedCertificate?> PostAsync(global::Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificatePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.SelfSignedCertificate> PostAsync(global::Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificatePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.SelfSignedCertificate>(requestInfo, global::Microsoft.Graph.Beta.Models.SelfSignedCertificate.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a self-signed signing certificate and returns a selfSignedCertificate object, which is the public part of the generated certificate. The self-signed signing certificate is composed of the following objects which are added to the servicePrincipal: + The keyCredentials object with the following objects:    + A private key object with usage set to Sign.    + A public key object with usage set to Verify.+ The passwordCredentials object. All the objects have the same value of customKeyIdentifier. The passwordCredential is used to open the PFX file (private key). It and the associated private key object have the same value of keyId. Once set during creation through the displayName property, the subject of the certificate cannot be updated. The startDateTime is set to the same time the certificate is created using the action. The endDateTime can be up to three years after the certificate is created.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificatePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificatePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class AddTokenSigningCertificateRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

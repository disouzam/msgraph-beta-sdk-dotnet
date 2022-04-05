using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Print.Reports.AuthenticationMethods.UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRoles {
    /// <summary>Provides operations to call the usersRegisteredByMethod method.</summary>
    public class UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRolesRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRolesRequestBuilder and sets the default values.
        /// <param name="includedUserRoles">Usage: includedUserRoles=&apos;{includedUserRoles}&apos;</param>
        /// <param name="includedUserTypes">Usage: includedUserTypes=&apos;{includedUserTypes}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRolesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string includedUserRoles = default, string includedUserTypes = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/print/reports/authenticationMethods/microsoft.graph.usersRegisteredByMethod(includedUserTypes='{includedUserTypes}',includedUserRoles='{includedUserRoles}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("includedUserRoles", includedUserRoles);
            urlTplParams.Add("includedUserTypes", includedUserTypes);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRolesRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRolesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/print/reports/authenticationMethods/microsoft.graph.usersRegisteredByMethod(includedUserTypes='{includedUserTypes}',includedUserRoles='{includedUserRoles}')";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function usersRegisteredByMethod
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke function usersRegisteredByMethod
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<UserRegistrationMethodSummary> GetAsync(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(headers, options);
            return await RequestAdapter.SendAsync<UserRegistrationMethodSummary>(requestInfo, UserRegistrationMethodSummary.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
    }
}

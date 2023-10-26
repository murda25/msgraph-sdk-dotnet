// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Security.ThreatIntelligence.Hosts.Item.Whois {
    /// <summary>
    /// Provides operations to manage the whois property of the microsoft.graph.security.host entity.
    /// </summary>
    public class WhoisRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WhoisRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WhoisRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence/hosts/{host%2Did}/whois{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WhoisRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WhoisRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence/hosts/{host%2Did}/whois{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get the specified whoisRecord resource.  Specify the desired whoisRecord in one of the following two ways:- Identify a host and get its current whoisRecord. - Specify an id value to get the corresponding whoisRecord. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-whoisrecord-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WhoisRecord?> GetAsync(Action<WhoisRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WhoisRecord> GetAsync(Action<WhoisRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WhoisRecord>(requestInfo, WhoisRecord.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the specified whoisRecord resource.  Specify the desired whoisRecord in one of the following two ways:- Identify a host and get its current whoisRecord. - Specify an id value to get the corresponding whoisRecord. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WhoisRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WhoisRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WhoisRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WhoisRequestBuilder WithUrl(string rawUrl) {
            return new WhoisRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the specified whoisRecord resource.  Specify the desired whoisRecord in one of the following two ways:- Identify a host and get its current whoisRecord. - Specify an id value to get the corresponding whoisRecord. This API is available in the following national cloud deployments.
        /// </summary>
        public class WhoisRequestBuilderGetQueryParameters {
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
        public class WhoisRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WhoisRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WhoisRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new whoisRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WhoisRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

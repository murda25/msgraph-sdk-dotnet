// <auto-generated/>
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.Assign;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.Assignments;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.Categories;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphAndroidStoreApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphIosLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphIosStoreApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphIosVppApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphMacOSDmgApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphMacOSLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphManagedAndroidLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphManagedIOSLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphManagedMobileLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphMicrosoftStoreForBusinessApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphWin32LobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphWindowsAppX;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphWindowsMobileMSI;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphWindowsUniversalAppX;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphWindowsWebApp;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.DeviceAppManagement.MobileApps.Item {
    /// <summary>
    /// Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.
    /// </summary>
    public class MobileAppItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to call the assign method.</summary>
        public AssignRequestBuilder Assign { get =>
            new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.mobileApp entity.</summary>
        public AssignmentsRequestBuilder Assignments { get =>
            new AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the categories property of the microsoft.graph.mobileApp entity.</summary>
        public CategoriesRequestBuilder Categories { get =>
            new CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidLobApp.</summary>
        public GraphAndroidLobAppRequestBuilder GraphAndroidLobApp { get =>
            new GraphAndroidLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidStoreApp.</summary>
        public GraphAndroidStoreAppRequestBuilder GraphAndroidStoreApp { get =>
            new GraphAndroidStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosLobApp.</summary>
        public GraphIosLobAppRequestBuilder GraphIosLobApp { get =>
            new GraphIosLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosStoreApp.</summary>
        public GraphIosStoreAppRequestBuilder GraphIosStoreApp { get =>
            new GraphIosStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosVppApp.</summary>
        public GraphIosVppAppRequestBuilder GraphIosVppApp { get =>
            new GraphIosVppAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to macOSDmgApp.</summary>
        public GraphMacOSDmgAppRequestBuilder GraphMacOSDmgApp { get =>
            new GraphMacOSDmgAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to macOSLobApp.</summary>
        public GraphMacOSLobAppRequestBuilder GraphMacOSLobApp { get =>
            new GraphMacOSLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedAndroidLobApp.</summary>
        public GraphManagedAndroidLobAppRequestBuilder GraphManagedAndroidLobApp { get =>
            new GraphManagedAndroidLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedIOSLobApp.</summary>
        public GraphManagedIOSLobAppRequestBuilder GraphManagedIOSLobApp { get =>
            new GraphManagedIOSLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedMobileLobApp.</summary>
        public GraphManagedMobileLobAppRequestBuilder GraphManagedMobileLobApp { get =>
            new GraphManagedMobileLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to microsoftStoreForBusinessApp.</summary>
        public GraphMicrosoftStoreForBusinessAppRequestBuilder GraphMicrosoftStoreForBusinessApp { get =>
            new GraphMicrosoftStoreForBusinessAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to win32LobApp.</summary>
        public GraphWin32LobAppRequestBuilder GraphWin32LobApp { get =>
            new GraphWin32LobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsAppX.</summary>
        public GraphWindowsAppXRequestBuilder GraphWindowsAppX { get =>
            new GraphWindowsAppXRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsMobileMSI.</summary>
        public GraphWindowsMobileMSIRequestBuilder GraphWindowsMobileMSI { get =>
            new GraphWindowsMobileMSIRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsUniversalAppX.</summary>
        public GraphWindowsUniversalAppXRequestBuilder GraphWindowsUniversalAppX { get =>
            new GraphWindowsUniversalAppXRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsWebApp.</summary>
        public GraphWindowsWebAppRequestBuilder GraphWindowsWebApp { get =>
            new GraphWindowsWebAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new MobileAppItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MobileAppItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Deletes a windowsMicrosoftEdgeApp.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-apps-windowsmicrosoftedgeapp-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<MobileAppItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<MobileAppItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Read properties and relationships of the win32LobApp object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-apps-win32lobapp-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<MobileApp?> GetAsync(Action<MobileAppItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<MobileApp> GetAsync(Action<MobileAppItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MobileApp>(requestInfo, MobileApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of a managedIOSStoreApp object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-apps-managediosstoreapp-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<MobileApp?> PatchAsync(MobileApp body, Action<MobileAppItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<MobileApp> PatchAsync(MobileApp body, Action<MobileAppItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MobileApp>(requestInfo, MobileApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a windowsMicrosoftEdgeApp.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<MobileAppItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<MobileAppItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MobileAppItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read properties and relationships of the win32LobApp object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MobileAppItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MobileAppItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MobileAppItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a managedIOSStoreApp object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(MobileApp body, Action<MobileAppItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(MobileApp body, Action<MobileAppItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MobileAppItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MobileAppItemRequestBuilder WithUrl(string rawUrl) {
            return new MobileAppItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MobileAppItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new MobileAppItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public MobileAppItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Read properties and relationships of the win32LobApp object.
        /// </summary>
        public class MobileAppItemRequestBuilderGetQueryParameters {
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
        public class MobileAppItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MobileAppItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new MobileAppItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new MobileAppItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MobileAppItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MobileAppItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new MobileAppItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public MobileAppItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

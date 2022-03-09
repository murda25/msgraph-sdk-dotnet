using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DeviceManagement.ApplePushNotificationCertificate;
using MicrosoftGraphSdk.DeviceManagement.ComplianceManagementPartners;
using MicrosoftGraphSdk.DeviceManagement.ConditionalAccessSettings;
using MicrosoftGraphSdk.DeviceManagement.DetectedApps;
using MicrosoftGraphSdk.DeviceManagement.DeviceCategories;
using MicrosoftGraphSdk.DeviceManagement.DeviceCompliancePolicies;
using MicrosoftGraphSdk.DeviceManagement.DeviceCompliancePolicyDeviceStateSummary;
using MicrosoftGraphSdk.DeviceManagement.DeviceCompliancePolicySettingStateSummaries;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurationDeviceStateSummaries;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations;
using MicrosoftGraphSdk.DeviceManagement.DeviceEnrollmentConfigurations;
using MicrosoftGraphSdk.DeviceManagement.DeviceManagementPartners;
using MicrosoftGraphSdk.DeviceManagement.ExchangeConnectors;
using MicrosoftGraphSdk.DeviceManagement.GetEffectivePermissionsWithScope;
using MicrosoftGraphSdk.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities;
using MicrosoftGraphSdk.DeviceManagement.IosUpdateStatuses;
using MicrosoftGraphSdk.DeviceManagement.ManagedDeviceOverview;
using MicrosoftGraphSdk.DeviceManagement.ManagedDevices;
using MicrosoftGraphSdk.DeviceManagement.MobileThreatDefenseConnectors;
using MicrosoftGraphSdk.DeviceManagement.NotificationMessageTemplates;
using MicrosoftGraphSdk.DeviceManagement.RemoteAssistancePartners;
using MicrosoftGraphSdk.DeviceManagement.Reports;
using MicrosoftGraphSdk.DeviceManagement.ResourceOperations;
using MicrosoftGraphSdk.DeviceManagement.RoleAssignments;
using MicrosoftGraphSdk.DeviceManagement.RoleDefinitions;
using MicrosoftGraphSdk.DeviceManagement.SoftwareUpdateStatusSummary;
using MicrosoftGraphSdk.DeviceManagement.TelecomExpenseManagementPartners;
using MicrosoftGraphSdk.DeviceManagement.TermsAndConditions;
using MicrosoftGraphSdk.DeviceManagement.TroubleshootingEvents;
using MicrosoftGraphSdk.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName;
using MicrosoftGraphSdk.DeviceManagement.WindowsAutopilotDeviceIdentities;
using MicrosoftGraphSdk.DeviceManagement.WindowsInformationProtectionAppLearningSummaries;
using MicrosoftGraphSdk.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceManagement {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementRequestBuilder {
        public ApplePushNotificationCertificateRequestBuilder ApplePushNotificationCertificate { get =>
            new ApplePushNotificationCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        public ComplianceManagementPartnersRequestBuilder ComplianceManagementPartners { get =>
            new ComplianceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConditionalAccessSettingsRequestBuilder ConditionalAccessSettings { get =>
            new ConditionalAccessSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCategoriesRequestBuilder DeviceCategories { get =>
            new DeviceCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCompliancePoliciesRequestBuilder DeviceCompliancePolicies { get =>
            new DeviceCompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCompliancePolicyDeviceStateSummaryRequestBuilder DeviceCompliancePolicyDeviceStateSummary { get =>
            new DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceConfigurationDeviceStateSummariesRequestBuilder DeviceConfigurationDeviceStateSummaries { get =>
            new DeviceConfigurationDeviceStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceConfigurationsRequestBuilder DeviceConfigurations { get =>
            new DeviceConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceManagementPartnersRequestBuilder DeviceManagementPartners { get =>
            new DeviceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExchangeConnectorsRequestBuilder ExchangeConnectors { get =>
            new ExchangeConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder ImportedWindowsAutopilotDeviceIdentities { get =>
            new ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        public IosUpdateStatusesRequestBuilder IosUpdateStatuses { get =>
            new IosUpdateStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDeviceOverviewRequestBuilder ManagedDeviceOverview { get =>
            new ManagedDeviceOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobileThreatDefenseConnectorsRequestBuilder MobileThreatDefenseConnectors { get =>
            new MobileThreatDefenseConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        public NotificationMessageTemplatesRequestBuilder NotificationMessageTemplates { get =>
            new NotificationMessageTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public RemoteAssistancePartnersRequestBuilder RemoteAssistancePartners { get =>
            new RemoteAssistancePartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ResourceOperationsRequestBuilder ResourceOperations { get =>
            new ResourceOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SoftwareUpdateStatusSummaryRequestBuilder SoftwareUpdateStatusSummary { get =>
            new SoftwareUpdateStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public TelecomExpenseManagementPartnersRequestBuilder TelecomExpenseManagementPartners { get =>
            new TelecomExpenseManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        public TermsAndConditionsRequestBuilder TermsAndConditions { get =>
            new TermsAndConditionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TroubleshootingEventsRequestBuilder TroubleshootingEvents { get =>
            new TroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public WindowsAutopilotDeviceIdentitiesRequestBuilder WindowsAutopilotDeviceIdentities { get =>
            new WindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsInformationProtectionAppLearningSummariesRequestBuilder WindowsInformationProtectionAppLearningSummaries { get =>
            new WindowsInformationProtectionAppLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsInformationProtectionNetworkLearningSummariesRequestBuilder WindowsInformationProtectionNetworkLearningSummaries { get =>
            new WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get deviceManagement
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get deviceManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getEffectivePermissions method.
        /// <param name="scope">Usage: scope='{scope}'</param>
        /// </summary>
        public GetEffectivePermissionsWithScopeRequestBuilder GetEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(PathParameters, RequestAdapter, scope);
        }
        /// <summary>
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the verifyWindowsEnrollmentAutoDiscovery method.
        /// <param name="domainName">Usage: domainName='{domainName}'</param>
        /// </summary>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder VerifyWindowsEnrollmentAutoDiscoveryWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(PathParameters, RequestAdapter, domainName);
        }
        /// <summary>Get deviceManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}

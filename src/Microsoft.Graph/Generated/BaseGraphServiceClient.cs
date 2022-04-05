using Microsoft.Graph.Admin;
using Microsoft.Graph.AgreementAcceptances;
using Microsoft.Graph.Agreements;
using Microsoft.Graph.AppCatalogs;
using Microsoft.Graph.Applications;
using Microsoft.Graph.ApplicationTemplates;
using Microsoft.Graph.AuditLogs;
using Microsoft.Graph.AuthenticationMethodConfigurations;
using Microsoft.Graph.AuthenticationMethodsPolicy;
using Microsoft.Graph.Branding;
using Microsoft.Graph.CertificateBasedAuthConfiguration;
using Microsoft.Graph.Chats;
using Microsoft.Graph.Communications;
using Microsoft.Graph.Compliance;
using Microsoft.Graph.Connections;
using Microsoft.Graph.Contacts;
using Microsoft.Graph.Contracts;
using Microsoft.Graph.DataPolicyOperations;
using Microsoft.Graph.DeviceAppManagement;
using Microsoft.Graph.DeviceManagement;
using Microsoft.Graph.Devices;
using Microsoft.Graph.Directory;
using Microsoft.Graph.DirectoryObjects;
using Microsoft.Graph.DirectoryRoles;
using Microsoft.Graph.DirectoryRoleTemplates;
using Microsoft.Graph.DomainDnsRecords;
using Microsoft.Graph.Domains;
using Microsoft.Graph.Drive;
using Microsoft.Graph.Drives;
using Microsoft.Graph.Education;
using Microsoft.Graph.External;
using Microsoft.Graph.GroupLifecyclePolicies;
using Microsoft.Graph.Groups;
using Microsoft.Graph.GroupSettings;
using Microsoft.Graph.GroupSettingTemplates;
using Microsoft.Graph.Identity;
using Microsoft.Graph.IdentityGovernance;
using Microsoft.Graph.IdentityProtection;
using Microsoft.Graph.IdentityProviders;
using Microsoft.Graph.InformationProtection;
using Microsoft.Graph.Invitations;
using Microsoft.Graph.Localizations;
using Microsoft.Graph.Me;
using Microsoft.Graph.Oauth2PermissionGrants;
using Microsoft.Graph.Organization;
using Microsoft.Graph.PermissionGrants;
using Microsoft.Graph.Places;
using Microsoft.Graph.Planner;
using Microsoft.Graph.Policies;
using Microsoft.Graph.Print;
using Microsoft.Graph.Privacy;
using Microsoft.Graph.Reports;
using Microsoft.Graph.RoleManagement;
using Microsoft.Graph.SchemaExtensions;
using Microsoft.Graph.ScopedRoleMemberships;
using Microsoft.Graph.Search;
using Microsoft.Graph.Security;
using Microsoft.Graph.ServicePrincipals;
using Microsoft.Graph.Shares;
using Microsoft.Graph.Sites;
using Microsoft.Graph.Solutions;
using Microsoft.Graph.SubscribedSkus;
using Microsoft.Graph.Subscriptions;
using Microsoft.Graph.Teams;
using Microsoft.Graph.TeamsTemplates;
using Microsoft.Graph.Teamwork;
using Microsoft.Graph.Users;
using Microsoft.Graph.Workbooks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph {
    /// <summary>The main entry point of the SDK, exposes the configuration and the fluent API.</summary>
    public class BaseGraphServiceClient {
        /// <summary>The admin property</summary>
        public AdminRequestBuilder Admin { get =>
            new AdminRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The agreementAcceptances property</summary>
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The agreements property</summary>
        public AgreementsRequestBuilder Agreements { get =>
            new AgreementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appCatalogs property</summary>
        public AppCatalogsRequestBuilder AppCatalogs { get =>
            new AppCatalogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The applications property</summary>
        public ApplicationsRequestBuilder Applications { get =>
            new ApplicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The applicationTemplates property</summary>
        public ApplicationTemplatesRequestBuilder ApplicationTemplates { get =>
            new ApplicationTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The auditLogs property</summary>
        public AuditLogsRequestBuilder AuditLogs { get =>
            new AuditLogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authenticationMethodConfigurations property</summary>
        public AuthenticationMethodConfigurationsRequestBuilder AuthenticationMethodConfigurations { get =>
            new AuthenticationMethodConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authenticationMethodsPolicy property</summary>
        public AuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy { get =>
            new AuthenticationMethodsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The branding property</summary>
        public BrandingRequestBuilder Branding { get =>
            new BrandingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The certificateBasedAuthConfiguration property</summary>
        public CertificateBasedAuthConfigurationRequestBuilder CertificateBasedAuthConfiguration { get =>
            new CertificateBasedAuthConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The chats property</summary>
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The communications property</summary>
        public CommunicationsRequestBuilder Communications { get =>
            new CommunicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The compliance property</summary>
        public ComplianceRequestBuilder Compliance { get =>
            new ComplianceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The connections property</summary>
        public ConnectionsRequestBuilder Connections { get =>
            new ConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contacts property</summary>
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contracts property</summary>
        public ContractsRequestBuilder Contracts { get =>
            new ContractsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dataPolicyOperations property</summary>
        public DataPolicyOperationsRequestBuilder DataPolicyOperations { get =>
            new DataPolicyOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceAppManagement property</summary>
        public DeviceAppManagementRequestBuilder DeviceAppManagement { get =>
            new DeviceAppManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceManagement property</summary>
        public DeviceManagementRequestBuilder DeviceManagement { get =>
            new DeviceManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The devices property</summary>
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directory property</summary>
        public DirectoryRequestBuilder Directory { get =>
            new DirectoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directoryObjects property</summary>
        public DirectoryObjectsRequestBuilder DirectoryObjects { get =>
            new DirectoryObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directoryRoles property</summary>
        public DirectoryRolesRequestBuilder DirectoryRoles { get =>
            new DirectoryRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directoryRoleTemplates property</summary>
        public DirectoryRoleTemplatesRequestBuilder DirectoryRoleTemplates { get =>
            new DirectoryRoleTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The domainDnsRecords property</summary>
        public DomainDnsRecordsRequestBuilder DomainDnsRecords { get =>
            new DomainDnsRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The domains property</summary>
        public DomainsRequestBuilder Domains { get =>
            new DomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The drive property</summary>
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The drives property</summary>
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The education property</summary>
        public EducationRequestBuilder Education { get =>
            new EducationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The external property</summary>
        public ExternalRequestBuilder External { get =>
            new ExternalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupLifecyclePolicies property</summary>
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groups property</summary>
        public GroupsRequestBuilder Groups { get =>
            new GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupSettings property</summary>
        public GroupSettingsRequestBuilder GroupSettings { get =>
            new GroupSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupSettingTemplates property</summary>
        public GroupSettingTemplatesRequestBuilder GroupSettingTemplates { get =>
            new GroupSettingTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identity property</summary>
        public IdentityRequestBuilder Identity { get =>
            new IdentityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identityGovernance property</summary>
        public IdentityGovernanceRequestBuilder IdentityGovernance { get =>
            new IdentityGovernanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identityProtection property</summary>
        public IdentityProtectionRequestBuilder IdentityProtection { get =>
            new IdentityProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identityProviders property</summary>
        public IdentityProvidersRequestBuilder IdentityProviders { get =>
            new IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The informationProtection property</summary>
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invitations property</summary>
        public InvitationsRequestBuilder Invitations { get =>
            new InvitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The localizations property</summary>
        public LocalizationsRequestBuilder Localizations { get =>
            new LocalizationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The me property</summary>
        public MeRequestBuilder Me { get =>
            new MeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The oauth2PermissionGrants property</summary>
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organization property</summary>
        public OrganizationRequestBuilder Organization { get =>
            new OrganizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The permissionGrants property</summary>
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The places property</summary>
        public PlacesRequestBuilder Places { get =>
            new PlacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The planner property</summary>
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The policies property</summary>
        public PoliciesRequestBuilder Policies { get =>
            new PoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The print property</summary>
        public PrintRequestBuilder Print { get =>
            new PrintRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The privacy property</summary>
        public PrivacyRequestBuilder Privacy { get =>
            new PrivacyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reports property</summary>
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The roleManagement property</summary>
        public RoleManagementRequestBuilder RoleManagement { get =>
            new RoleManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The schemaExtensions property</summary>
        public SchemaExtensionsRequestBuilder SchemaExtensions { get =>
            new SchemaExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The scopedRoleMemberships property</summary>
        public ScopedRoleMembershipsRequestBuilder ScopedRoleMemberships { get =>
            new ScopedRoleMembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The security property</summary>
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The servicePrincipals property</summary>
        public ServicePrincipalsRequestBuilder ServicePrincipals { get =>
            new ServicePrincipalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The shares property</summary>
        public SharesRequestBuilder Shares { get =>
            new SharesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sites property</summary>
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The solutions property</summary>
        public SolutionsRequestBuilder Solutions { get =>
            new SolutionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscribedSkus property</summary>
        public SubscribedSkusRequestBuilder SubscribedSkus { get =>
            new SubscribedSkusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscriptions property</summary>
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public TeamsRequestBuilder Teams { get =>
            new TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teamsTemplates property</summary>
        public TeamsTemplatesRequestBuilder TeamsTemplates { get =>
            new TeamsTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teamwork property</summary>
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The users property</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The workbooks property</summary>
        public WorkbooksRequestBuilder Workbooks { get =>
            new WorkbooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new BaseGraphServiceClient and sets the default values.
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public BaseGraphServiceClient(IRequestAdapter requestAdapter) {
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathParameters = new Dictionary<string, object>();
            UrlTemplate = "{+baseurl}";
            RequestAdapter = requestAdapter;
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl)) {
                RequestAdapter.BaseUrl = "https://graph.microsoft.com/v1.0";
            }
        }
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
        public async Task<Stream> GetAsync(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(headers, options);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, responseHandler, default, cancellationToken);
        }
    }
}

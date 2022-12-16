namespace Microsoft.Graph.Models.Security {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum DataSourceScopes {
        None,
        AllTenantMailboxes,
        AllTenantSites,
        AllCaseCustodians,
        AllCaseNoncustodialDataSources,
        UnknownFutureValue,
    }
}

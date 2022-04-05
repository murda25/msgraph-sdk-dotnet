namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum InstallState {
        NotApplicable,
        Installed,
        Failed,
        NotInstalled,
        UninstallFailed,
        Unknown,
    }
}

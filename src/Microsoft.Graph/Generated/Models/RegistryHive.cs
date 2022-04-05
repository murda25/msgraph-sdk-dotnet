namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public enum RegistryHive {
        Unknown,
        CurrentConfig,
        CurrentUser,
        LocalMachineSam,
        LocalMachineSecurity,
        LocalMachineSoftware,
        LocalMachineSystem,
        UsersDefault,
        UnknownFutureValue,
    }
}

namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum ConditionalAccessGrantControl {
        Block,
        Mfa,
        CompliantDevice,
        DomainJoinedDevice,
        ApprovedApplication,
        CompliantApplication,
        PasswordChange,
        UnknownFutureValue,
    }
}

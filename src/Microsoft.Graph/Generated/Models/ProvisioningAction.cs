namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum ProvisioningAction {
        Other,
        Create,
        Delete,
        Disable,
        Update,
        StagedDelete,
        UnknownFutureValue,
    }
}
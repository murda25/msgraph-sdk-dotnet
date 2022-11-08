namespace Microsoft.Graph.Models.ExternalConnectors {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum AclType {
        User,
        Group,
        Everyone,
        EveryoneExceptGuests,
        ExternalGroup,
        UnknownFutureValue,
    }
}

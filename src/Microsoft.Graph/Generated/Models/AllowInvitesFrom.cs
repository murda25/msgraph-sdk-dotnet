namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum AllowInvitesFrom {
        None,
        AdminsAndGuestInviters,
        AdminsGuestInvitersAndAllMembers,
        Everyone,
        UnknownFutureValue,
    }
}

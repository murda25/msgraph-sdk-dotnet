namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the policyRoot singleton.</summary>
    public enum AllowInvitesFrom {
        None,
        AdminsAndGuestInviters,
        AdminsGuestInvitersAndAllMembers,
        Everyone,
        UnknownFutureValue,
    }
}
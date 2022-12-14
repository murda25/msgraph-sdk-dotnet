namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum RiskDetail {
        None,
        AdminGeneratedTemporaryPassword,
        UserPerformedSecuredPasswordChange,
        UserPerformedSecuredPasswordReset,
        AdminConfirmedSigninSafe,
        AiConfirmedSigninSafe,
        UserPassedMFADrivenByRiskBasedPolicy,
        AdminDismissedAllRiskForUser,
        AdminConfirmedSigninCompromised,
        Hidden,
        AdminConfirmedUserCompromised,
        UnknownFutureValue,
        AdminConfirmedServicePrincipalCompromised,
        AdminDismissedAllRiskForServicePrincipal,
        M365DAdminDismissedDetection,
    }
}

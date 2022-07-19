namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum AuthenticationMethodSignInState {
        NotSupported,
        NotAllowedByPolicy,
        NotEnabled,
        PhoneNumberNotUnique,
        Ready,
        NotConfigured,
        UnknownFutureValue,
    }
}

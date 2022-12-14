namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum UserFlowType {
        SignUp,
        SignIn,
        SignUpOrSignIn,
        PasswordReset,
        ProfileUpdate,
        ResourceOwner,
        UnknownFutureValue,
    }
}

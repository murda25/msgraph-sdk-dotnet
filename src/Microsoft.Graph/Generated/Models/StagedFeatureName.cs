namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the policyRoot singleton.</summary>
    public enum StagedFeatureName {
        PassthroughAuthentication,
        SeamlessSso,
        PasswordHashSync,
        EmailAsAlternateId,
        UnknownFutureValue,
        CertificateBasedAuthentication,
        MultiFactorAuthentication,
    }
}

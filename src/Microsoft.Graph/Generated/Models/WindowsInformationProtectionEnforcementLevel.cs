namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum WindowsInformationProtectionEnforcementLevel {
        NoProtection,
        EncryptAndAuditOnly,
        EncryptAuditAndPrompt,
        EncryptAuditAndBlock,
    }
}

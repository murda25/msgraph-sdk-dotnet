namespace Microsoft.Graph.Models.Security {
    /// <summary>Provides operations to manage the collection of agreementAcceptance entities.</summary>
    public enum AlertDetermination {
        Unknown,
        Apt,
        Malware,
        SecurityPersonnel,
        SecurityTesting,
        UnwantedSoftware,
        Other,
        MultiStagedAttack,
        CompromisedAccount,
        Phishing,
        MaliciousUserActivity,
        NotMalicious,
        NotEnoughDataToValidate,
        ConfirmedActivity,
        LineOfBusinessApplication,
        UnknownFutureValue,
    }
}

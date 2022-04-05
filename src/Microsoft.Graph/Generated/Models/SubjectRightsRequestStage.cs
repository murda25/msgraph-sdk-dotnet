namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the privacy singleton.</summary>
    public enum SubjectRightsRequestStage {
        ContentRetrieval,
        ContentReview,
        GenerateReport,
        ContentDeletion,
        CaseResolved,
        ContentEstimate,
        UnknownFutureValue,
    }
}

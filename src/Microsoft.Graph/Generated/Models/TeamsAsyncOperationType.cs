namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum TeamsAsyncOperationType {
        Invalid,
        CloneTeam,
        ArchiveTeam,
        UnarchiveTeam,
        CreateTeam,
        UnknownFutureValue,
        TeamifyGroup,
        CreateChannel,
    }
}

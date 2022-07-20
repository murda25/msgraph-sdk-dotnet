namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum EventType {
        SingleInstance,
        Occurrence,
        Exception,
        SeriesMaster,
    }
}
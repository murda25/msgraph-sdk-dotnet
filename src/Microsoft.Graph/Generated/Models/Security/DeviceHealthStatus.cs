namespace Microsoft.Graph.Models.Security {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum DeviceHealthStatus {
        Active,
        Inactive,
        ImpairedCommunication,
        NoSensorData,
        NoSensorDataImpairedCommunication,
        Unknown,
        UnknownFutureValue,
    }
}

namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum ConfigurationUsage {
        /// <summary>Disallowed.</summary>
        Blocked,
        /// <summary>Required.</summary>
        Required,
        /// <summary>Optional.</summary>
        Allowed,
        /// <summary>Not Configured.</summary>
        NotConfigured,
    }
}

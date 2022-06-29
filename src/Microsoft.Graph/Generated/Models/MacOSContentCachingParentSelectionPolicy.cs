namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum MacOSContentCachingParentSelectionPolicy {
        /// <summary>Defaults to round-robin strategy.</summary>
        NotConfigured,
        /// <summary>Rotate through the parents in order. Use this policy for load balancing.</summary>
        RoundRobin,
        /// <summary>Always use the first available parent in the Parents list. Use this policy to designate permanent primary, secondary, and subsequent parents.</summary>
        FirstAvailable,
        /// <summary>Hash the path part of the requested URL so that the same parent is always used for the same URL. This is useful for maximizing the size of the combined caches of the parents.</summary>
        UrlPathHash,
        /// <summary>Choose a parent at random. Use this policy for load balancing.</summary>
        Random,
        /// <summary>Use the first available parent that is available in the Parents list until it becomes unavailable, then advance to the next one. Use this policy for designating floating primary, secondary, and subsequent parents.</summary>
        StickyAvailable,
    }
}

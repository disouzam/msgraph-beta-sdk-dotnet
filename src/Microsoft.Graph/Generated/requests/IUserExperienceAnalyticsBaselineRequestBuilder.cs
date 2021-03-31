// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IUserExperienceAnalyticsBaselineRequestBuilder.
    /// </summary>
    public partial interface IUserExperienceAnalyticsBaselineRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IUserExperienceAnalyticsBaselineRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IUserExperienceAnalyticsBaselineRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AppHealthMetrics.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder AppHealthMetrics { get; }

        /// <summary>
        /// Gets the request builder for BestPracticesMetrics.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder BestPracticesMetrics { get; }

        /// <summary>
        /// Gets the request builder for DeviceBootPerformanceMetrics.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder DeviceBootPerformanceMetrics { get; }

        /// <summary>
        /// Gets the request builder for RebootAnalyticsMetrics.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder RebootAnalyticsMetrics { get; }

        /// <summary>
        /// Gets the request builder for ResourcePerformanceMetrics.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder ResourcePerformanceMetrics { get; }

        /// <summary>
        /// Gets the request builder for WorkFromAnywhereMetrics.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsCategoryWithReferenceRequestBuilder WorkFromAnywhereMetrics { get; }
    
    }
}

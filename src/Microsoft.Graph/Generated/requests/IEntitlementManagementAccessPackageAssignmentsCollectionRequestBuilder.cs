// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IEntitlementManagementAccessPackageAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface IEntitlementManagementAccessPackageAssignmentsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IEntitlementManagementAccessPackageAssignmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IEntitlementManagementAccessPackageAssignmentsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAccessPackageAssignmentRequestBuilder"/> for the specified AccessPackageAssignment.
        /// </summary>
        /// <param name="id">The ID for the AccessPackageAssignment.</param>
        /// <returns>The <see cref="IAccessPackageAssignmentRequestBuilder"/>.</returns>
        IAccessPackageAssignmentRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentFilterByCurrentUserRequestBuilder"/>.</returns>
        IAccessPackageAssignmentFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            AccessPackageAssignmentFilterByCurrentUserOptions on);

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentAdditionalAccess.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentAdditionalAccessRequestBuilder"/>.</returns>
        IAccessPackageAssignmentAdditionalAccessRequestBuilder AdditionalAccess();

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentAdditionalAccess.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentAdditionalAccessRequestBuilder"/>.</returns>
        IAccessPackageAssignmentAdditionalAccessRequestBuilder AdditionalAccess(
            string accessPackageId = null);

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentAdditionalAccess.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentAdditionalAccessRequestBuilder"/>.</returns>
        IAccessPackageAssignmentAdditionalAccessRequestBuilder AdditionalAccess(
            string accessPackageId = null,
            string incompatibleAccessPackageId = null);
    }
}

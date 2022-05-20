using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class EntitlementManagement : Entity, IParsable {
        /// <summary>Approval stages for assignment requests.</summary>
        public List<Approval> AccessPackageAssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>>(nameof(AccessPackageAssignmentApprovals)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignmentApprovals), value); }
        }
        /// <summary>Represents access package objects.</summary>
        public List<AccessPackage> AccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>>(nameof(AccessPackages)); }
            set { BackingStore?.Set(nameof(AccessPackages), value); }
        }
        /// <summary>Access package assignment policies.</summary>
        public List<AccessPackageAssignmentPolicy> AssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>>(nameof(AssignmentPolicies)); }
            set { BackingStore?.Set(nameof(AssignmentPolicies), value); }
        }
        /// <summary>Represents access package assignment requests created by or on behalf of a user.</summary>
        public List<AccessPackageAssignmentRequest> AssignmentRequests {
            get { return BackingStore?.Get<List<AccessPackageAssignmentRequest>>(nameof(AssignmentRequests)); }
            set { BackingStore?.Set(nameof(AssignmentRequests), value); }
        }
        /// <summary>Represents the grant of an access package to a subject (user or group).</summary>
        public List<AccessPackageAssignment> Assignments {
            get { return BackingStore?.Get<List<AccessPackageAssignment>>(nameof(Assignments)); }
            set { BackingStore?.Set(nameof(Assignments), value); }
        }
        /// <summary>Represents a collection of access packages.</summary>
        public List<AccessPackageCatalog> Catalogs {
            get { return BackingStore?.Get<List<AccessPackageCatalog>>(nameof(Catalogs)); }
            set { BackingStore?.Set(nameof(Catalogs), value); }
        }
        /// <summary>Represents references to a directory or domain of another organization whose users can request access.</summary>
        public List<ConnectedOrganization> ConnectedOrganizations {
            get { return BackingStore?.Get<List<ConnectedOrganization>>(nameof(ConnectedOrganizations)); }
            set { BackingStore?.Set(nameof(ConnectedOrganizations), value); }
        }
        /// <summary>Represents the settings that control the behavior of Azure AD entitlement management.</summary>
        public EntitlementManagementSettings Settings {
            get { return BackingStore?.Get<EntitlementManagementSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EntitlementManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageAssignmentApprovals", n => { AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackages", n => { AccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue).ToList(); } },
                {"assignmentPolicies", n => { AssignmentPolicies = n.GetCollectionOfObjectValues<AccessPackageAssignmentPolicy>(AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"assignmentRequests", n => { AssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>(AccessPackageAssignmentRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<AccessPackageAssignment>(AccessPackageAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"catalogs", n => { Catalogs = n.GetCollectionOfObjectValues<AccessPackageCatalog>(AccessPackageCatalog.CreateFromDiscriminatorValue).ToList(); } },
                {"connectedOrganizations", n => { ConnectedOrganizations = n.GetCollectionOfObjectValues<ConnectedOrganization>(ConnectedOrganization.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<EntitlementManagementSettings>(EntitlementManagementSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Approval>("accessPackageAssignmentApprovals", AccessPackageAssignmentApprovals);
            writer.WriteCollectionOfObjectValues<AccessPackage>("accessPackages", AccessPackages);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentPolicy>("assignmentPolicies", AssignmentPolicies);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequest>("assignmentRequests", AssignmentRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<AccessPackageCatalog>("catalogs", Catalogs);
            writer.WriteCollectionOfObjectValues<ConnectedOrganization>("connectedOrganizations", ConnectedOrganizations);
            writer.WriteObjectValue<EntitlementManagementSettings>("settings", Settings);
        }
    }
}

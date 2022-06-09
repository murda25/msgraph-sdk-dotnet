using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UnifiedRoleEligibilityScheduleRequest : Request, IParsable {
        /// <summary>Represents the type of the operation on the role eligibility assignment. The possible values are: AdminAssign: For administrators to assign role eligibility to users or groups to roles.AdminExtend: For administrators to extend expiring assignments.AdminUpdate: For administrators to change existing role assignments.AdminRenew: For administrators to renew expired assignments.AdminRemove: For administrators to remove users or groups from eligible roles.UserAdd: For users to activate their eligible assignments.UserExtend: For users to request to extend their expiring eligible assignments.UserRemove: For users to deactivate their active eligible assignments.UserRenew: For users to request to renew their expired eligible assignments.</summary>
        public UnifiedRoleScheduleRequestActions? Action {
            get { return BackingStore?.Get<UnifiedRoleScheduleRequestActions?>(nameof(Action)); }
            set { BackingStore?.Set(nameof(Action), value); }
        }
        /// <summary>Read-only property with details of the app-specific scope when the assignment scope is app-specific. Containment entity.</summary>
        public Microsoft.Graph.Models.AppScope AppScope {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AppScope>(nameof(AppScope)); }
            set { BackingStore?.Set(nameof(AppScope), value); }
        }
        /// <summary>Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.</summary>
        public string AppScopeId {
            get { return BackingStore?.Get<string>(nameof(AppScopeId)); }
            set { BackingStore?.Set(nameof(AppScopeId), value); }
        }
        /// <summary>Property referencing the directory object that is the scope of the assignment. Provided so that callers can get the directory object using $expand at the same time as getting the role assignment. Read-only.</summary>
        public DirectoryObject DirectoryScope {
            get { return BackingStore?.Get<DirectoryObject>(nameof(DirectoryScope)); }
            set { BackingStore?.Set(nameof(DirectoryScope), value); }
        }
        /// <summary>Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.</summary>
        public string DirectoryScopeId {
            get { return BackingStore?.Get<string>(nameof(DirectoryScopeId)); }
            set { BackingStore?.Set(nameof(DirectoryScopeId), value); }
        }
        /// <summary>A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.</summary>
        public bool? IsValidationOnly {
            get { return BackingStore?.Get<bool?>(nameof(IsValidationOnly)); }
            set { BackingStore?.Set(nameof(IsValidationOnly), value); }
        }
        /// <summary>A message provided by users and administrators when create the request about why it is needed.</summary>
        public string Justification {
            get { return BackingStore?.Get<string>(nameof(Justification)); }
            set { BackingStore?.Set(nameof(Justification), value); }
        }
        /// <summary>Property referencing the principal that is getting a role assignment through the request. Provided so that callers can get the principal using $expand at the same time as getting the role assignment. Read-only.</summary>
        public DirectoryObject Principal {
            get { return BackingStore?.Get<DirectoryObject>(nameof(Principal)); }
            set { BackingStore?.Set(nameof(Principal), value); }
        }
        /// <summary>Identifier of the principal to which the assignment is being granted to. For example, a user or a group. For groups, they must be assignable to roles, that is, the isAssignableToRole of the group property set to true.</summary>
        public string PrincipalId {
            get { return BackingStore?.Get<string>(nameof(PrincipalId)); }
            set { BackingStore?.Set(nameof(PrincipalId), value); }
        }
        /// <summary>Property indicating the roleDefinition the assignment is for. Provided so that callers can get the role definition using $expand at the same time as getting the role assignment. roleDefinition.Id will be auto expanded.</summary>
        public UnifiedRoleDefinition RoleDefinition {
            get { return BackingStore?.Get<UnifiedRoleDefinition>(nameof(RoleDefinition)); }
            set { BackingStore?.Set(nameof(RoleDefinition), value); }
        }
        /// <summary>Identifier of the unifiedRoleDefinition the assignment is for. Read only.</summary>
        public string RoleDefinitionId {
            get { return BackingStore?.Get<string>(nameof(RoleDefinitionId)); }
            set { BackingStore?.Set(nameof(RoleDefinitionId), value); }
        }
        /// <summary>The schedule object of the role assignment request.</summary>
        public RequestSchedule ScheduleInfo {
            get { return BackingStore?.Get<RequestSchedule>(nameof(ScheduleInfo)); }
            set { BackingStore?.Set(nameof(ScheduleInfo), value); }
        }
        /// <summary>Property indicating the schedule for an eligible role assignment.</summary>
        public UnifiedRoleEligibilitySchedule TargetSchedule {
            get { return BackingStore?.Get<UnifiedRoleEligibilitySchedule>(nameof(TargetSchedule)); }
            set { BackingStore?.Set(nameof(TargetSchedule), value); }
        }
        /// <summary>The time period for which the eligibility assignment is valid.</summary>
        public string TargetScheduleId {
            get { return BackingStore?.Get<string>(nameof(TargetScheduleId)); }
            set { BackingStore?.Set(nameof(TargetScheduleId), value); }
        }
        /// <summary>The details of the ticket number and ticket system that is attached to the role assignment request.</summary>
        public Microsoft.Graph.Models.TicketInfo TicketInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TicketInfo>(nameof(TicketInfo)); }
            set { BackingStore?.Set(nameof(TicketInfo), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleEligibilityScheduleRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleEligibilityScheduleRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetEnumValue<UnifiedRoleScheduleRequestActions>(); } },
                {"appScope", n => { AppScope = n.GetObjectValue<Microsoft.Graph.Models.AppScope>(Microsoft.Graph.Models.AppScope.CreateFromDiscriminatorValue); } },
                {"appScopeId", n => { AppScopeId = n.GetStringValue(); } },
                {"directoryScope", n => { DirectoryScope = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"directoryScopeId", n => { DirectoryScopeId = n.GetStringValue(); } },
                {"isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"scheduleInfo", n => { ScheduleInfo = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                {"targetSchedule", n => { TargetSchedule = n.GetObjectValue<UnifiedRoleEligibilitySchedule>(UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue); } },
                {"targetScheduleId", n => { TargetScheduleId = n.GetStringValue(); } },
                {"ticketInfo", n => { TicketInfo = n.GetObjectValue<Microsoft.Graph.Models.TicketInfo>(Microsoft.Graph.Models.TicketInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<UnifiedRoleScheduleRequestActions>("action", Action);
            writer.WriteObjectValue<Microsoft.Graph.Models.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteObjectValue<DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteObjectValue<RequestSchedule>("scheduleInfo", ScheduleInfo);
            writer.WriteObjectValue<UnifiedRoleEligibilitySchedule>("targetSchedule", TargetSchedule);
            writer.WriteStringValue("targetScheduleId", TargetScheduleId);
            writer.WriteObjectValue<Microsoft.Graph.Models.TicketInfo>("ticketInfo", TicketInfo);
        }
    }
}
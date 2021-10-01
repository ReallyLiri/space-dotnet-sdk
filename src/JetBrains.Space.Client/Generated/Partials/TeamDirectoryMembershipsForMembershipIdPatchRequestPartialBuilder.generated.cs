// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.TeamDirectoryMembershipsForMembershipIdPatchRequestPartialBuilder;

public static class TeamDirectoryMembershipsForMembershipIdPatchRequestPartialExtensions
{
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithTeamId(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it)
        => it.AddFieldName("teamId");
    
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithRoleId(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it)
        => it.AddFieldName("roleId");
    
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithIsLead(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it)
        => it.AddFieldName("lead");
    
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithManager(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it)
        => it.AddFieldName("manager");
    
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithManager(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it, Func<Partial<ProfileIdentifier>, Partial<ProfileIdentifier>> partialBuilder)
        => it.AddFieldName("manager", partialBuilder(new Partial<ProfileIdentifier>(it)));
    
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithActiveSince(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it)
        => it.AddFieldName("activeSince");
    
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithActiveTill(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it)
        => it.AddFieldName("activeTill");
    
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithIsRequiresApproval(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it)
        => it.AddFieldName("requiresApproval");
    
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithCustomFieldValues(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it)
        => it.AddFieldName("customFieldValues");
    
    public static Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> WithCustomFieldValues(this Partial<TeamDirectoryMembershipsForMembershipIdPatchRequest> it, Func<Partial<CustomFieldInputValue>, Partial<CustomFieldInputValue>> partialBuilder)
        => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldInputValue>(it)));
    
}


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

namespace JetBrains.Space.Client.InvitationLinkPartialBuilder;

public static class InvitationLinkPartialExtensions
{
    public static Partial<InvitationLink> WithId(this Partial<InvitationLink> it)
        => it.AddFieldName("id");
    
    public static Partial<InvitationLink> WithName(this Partial<InvitationLink> it)
        => it.AddFieldName("name");
    
    public static Partial<InvitationLink> WithCreatedBy(this Partial<InvitationLink> it)
        => it.AddFieldName("createdBy");
    
    public static Partial<InvitationLink> WithCreatedBy(this Partial<InvitationLink> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("createdBy", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<InvitationLink> WithCreatedAt(this Partial<InvitationLink> it)
        => it.AddFieldName("createdAt");
    
    public static Partial<InvitationLink> WithExpiresAt(this Partial<InvitationLink> it)
        => it.AddFieldName("expiresAt");
    
    public static Partial<InvitationLink> WithInviteeLimit(this Partial<InvitationLink> it)
        => it.AddFieldName("inviteeLimit");
    
    public static Partial<InvitationLink> WithInviteeUsage(this Partial<InvitationLink> it)
        => it.AddFieldName("inviteeUsage");
    
    public static Partial<InvitationLink> WithTeam(this Partial<InvitationLink> it)
        => it.AddFieldName("team");
    
    public static Partial<InvitationLink> WithTeam(this Partial<InvitationLink> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
        => it.AddFieldName("team", partialBuilder(new Partial<TDTeam>(it)));
    
    public static Partial<InvitationLink> WithPosition(this Partial<InvitationLink> it)
        => it.AddFieldName("position");
    
    public static Partial<InvitationLink> WithPosition(this Partial<InvitationLink> it, Func<Partial<TDRole>, Partial<TDRole>> partialBuilder)
        => it.AddFieldName("position", partialBuilder(new Partial<TDRole>(it)));
    
    public static Partial<InvitationLink> WithProject(this Partial<InvitationLink> it)
        => it.AddFieldName("project");
    
    public static Partial<InvitationLink> WithProject(this Partial<InvitationLink> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
    
    public static Partial<InvitationLink> WithProjectRole(this Partial<InvitationLink> it)
        => it.AddFieldName("projectRole");
    
    public static Partial<InvitationLink> WithProjectRole(this Partial<InvitationLink> it, Func<Partial<ProjectTeamRole>, Partial<ProjectTeamRole>> partialBuilder)
        => it.AddFieldName("projectRole", partialBuilder(new Partial<ProjectTeamRole>(it)));
    
    public static Partial<InvitationLink> WithLink(this Partial<InvitationLink> it)
        => it.AddFieldName("link");
    
    public static Partial<InvitationLink> WithIsDeleted(this Partial<InvitationLink> it)
        => it.AddFieldName("deleted");
    
}


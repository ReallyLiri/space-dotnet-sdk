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

namespace JetBrains.Space.Client.InvitationPartialBuilder;

public static class InvitationPartialExtensions
{
    public static Partial<Invitation> WithId(this Partial<Invitation> it)
        => it.AddFieldName("id");
    
    public static Partial<Invitation> WithExpiresAt(this Partial<Invitation> it)
        => it.AddFieldName("expiresAt");
    
    public static Partial<Invitation> WithInviteeEmail(this Partial<Invitation> it)
        => it.AddFieldName("inviteeEmail");
    
    public static Partial<Invitation> WithIsInviteeEmailBlocked(this Partial<Invitation> it)
        => it.AddFieldName("inviteeEmailBlocked");
    
    public static Partial<Invitation> WithInviteeEmailBlockedReason(this Partial<Invitation> it)
        => it.AddFieldName("inviteeEmailBlockedReason");
    
    public static Partial<Invitation> WithInviteeFirstName(this Partial<Invitation> it)
        => it.AddFieldName("inviteeFirstName");
    
    public static Partial<Invitation> WithInviteeLastName(this Partial<Invitation> it)
        => it.AddFieldName("inviteeLastName");
    
    public static Partial<Invitation> WithInvitee(this Partial<Invitation> it)
        => it.AddFieldName("invitee");
    
    public static Partial<Invitation> WithInvitee(this Partial<Invitation> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("invitee", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<Invitation> WithInviter(this Partial<Invitation> it)
        => it.AddFieldName("inviter");
    
    public static Partial<Invitation> WithInviter(this Partial<Invitation> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("inviter", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<Invitation> WithTeam(this Partial<Invitation> it)
        => it.AddFieldName("team");
    
    public static Partial<Invitation> WithTeam(this Partial<Invitation> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
        => it.AddFieldName("team", partialBuilder(new Partial<TDTeam>(it)));
    
    public static Partial<Invitation> WithRole(this Partial<Invitation> it)
        => it.AddFieldName("role");
    
    public static Partial<Invitation> WithRole(this Partial<Invitation> it, Func<Partial<TDRole>, Partial<TDRole>> partialBuilder)
        => it.AddFieldName("role", partialBuilder(new Partial<TDRole>(it)));
    
    public static Partial<Invitation> WithIsRevoked(this Partial<Invitation> it)
        => it.AddFieldName("revoked");
    
}


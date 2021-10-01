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

namespace JetBrains.Space.Client.PollRecordPartialBuilder;

public static class PollRecordPartialExtensions
{
    public static Partial<PollRecord> WithId(this Partial<PollRecord> it)
        => it.AddFieldName("id");
    
    public static Partial<PollRecord> WithOwner(this Partial<PollRecord> it)
        => it.AddFieldName("owner");
    
    public static Partial<PollRecord> WithOwner(this Partial<PollRecord> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("owner", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<PollRecord> WithQuestion(this Partial<PollRecord> it)
        => it.AddFieldName("question");
    
    public static Partial<PollRecord> WithIsMeVote(this Partial<PollRecord> it)
        => it.AddFieldName("meVote");
    
    public static Partial<PollRecord> WithCountPeople(this Partial<PollRecord> it)
        => it.AddFieldName("countPeople");
    
    public static Partial<PollRecord> WithIsAnonymous(this Partial<PollRecord> it)
        => it.AddFieldName("anonymous");
    
    public static Partial<PollRecord> WithIsClosed(this Partial<PollRecord> it)
        => it.AddFieldName("closed");
    
    public static Partial<PollRecord> WithIsExtendable(this Partial<PollRecord> it)
        => it.AddFieldName("extendable");
    
    public static Partial<PollRecord> WithIsMultiChoice(this Partial<PollRecord> it)
        => it.AddFieldName("multiChoice");
    
    public static Partial<PollRecord> WithIsEnded(this Partial<PollRecord> it)
        => it.AddFieldName("ended");
    
    public static Partial<PollRecord> WithExpirationTime(this Partial<PollRecord> it)
        => it.AddFieldName("expirationTime");
    
    public static Partial<PollRecord> WithVotes(this Partial<PollRecord> it)
        => it.AddFieldName("votes");
    
    public static Partial<PollRecord> WithVotes(this Partial<PollRecord> it, Func<Partial<VoteGroup>, Partial<VoteGroup>> partialBuilder)
        => it.AddFieldName("votes", partialBuilder(new Partial<VoteGroup>(it)));
    
}


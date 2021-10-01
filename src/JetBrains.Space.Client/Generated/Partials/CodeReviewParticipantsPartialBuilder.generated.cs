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

namespace JetBrains.Space.Client.CodeReviewParticipantsPartialBuilder;

public static class CodeReviewParticipantsPartialExtensions
{
    public static Partial<CodeReviewParticipants> WithId(this Partial<CodeReviewParticipants> it)
        => it.AddFieldName("id");
    
    public static Partial<CodeReviewParticipants> WithParticipants(this Partial<CodeReviewParticipants> it)
        => it.AddFieldName("participants");
    
    public static Partial<CodeReviewParticipants> WithParticipants(this Partial<CodeReviewParticipants> it, Func<Partial<CodeReviewParticipant>, Partial<CodeReviewParticipant>> partialBuilder)
        => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipant>(it)));
    
    public static Partial<CodeReviewParticipants> WithReviewers(this Partial<CodeReviewParticipants> it)
        => it.AddFieldName("reviewers");
    
    public static Partial<CodeReviewParticipants> WithReviewers(this Partial<CodeReviewParticipants> it, Func<Partial<CodeReviewParticipantRecord>, Partial<CodeReviewParticipantRecord>> partialBuilder)
        => it.AddFieldName("reviewers", partialBuilder(new Partial<CodeReviewParticipantRecord>(it)));
    
    public static Partial<CodeReviewParticipants> WithAuthors(this Partial<CodeReviewParticipants> it)
        => it.AddFieldName("authors");
    
    public static Partial<CodeReviewParticipants> WithAuthors(this Partial<CodeReviewParticipants> it, Func<Partial<CodeReviewParticipantRecord>, Partial<CodeReviewParticipantRecord>> partialBuilder)
        => it.AddFieldName("authors", partialBuilder(new Partial<CodeReviewParticipantRecord>(it)));
    
    public static Partial<CodeReviewParticipants> WithWatchers(this Partial<CodeReviewParticipants> it)
        => it.AddFieldName("watchers");
    
    public static Partial<CodeReviewParticipants> WithWatchers(this Partial<CodeReviewParticipants> it, Func<Partial<CodeReviewParticipantRecord>, Partial<CodeReviewParticipantRecord>> partialBuilder)
        => it.AddFieldName("watchers", partialBuilder(new Partial<CodeReviewParticipantRecord>(it)));
    
}


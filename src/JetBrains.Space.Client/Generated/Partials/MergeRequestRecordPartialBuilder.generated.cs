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

namespace JetBrains.Space.Client.MergeRequestRecordPartialBuilder;

public static class MergeRequestRecordPartialExtensions
{
    public static Partial<MergeRequestRecord> WithId(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("id");
    
    public static Partial<MergeRequestRecord> WithProject(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("project");
    
    public static Partial<MergeRequestRecord> WithProject(this Partial<MergeRequestRecord> it, Func<Partial<ProjectKey>, Partial<ProjectKey>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<ProjectKey>(it)));
    
    public static Partial<MergeRequestRecord> WithProjectId(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("projectId");
    
    public static Partial<MergeRequestRecord> WithNumber(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("number");
    
    public static Partial<MergeRequestRecord> WithTitle(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("title");
    
    public static Partial<MergeRequestRecord> WithState(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("state");
    
    public static Partial<MergeRequestRecord> WithState(this Partial<MergeRequestRecord> it, Func<Partial<CodeReviewState>, Partial<CodeReviewState>> partialBuilder)
        => it.AddFieldName("state", partialBuilder(new Partial<CodeReviewState>(it)));
    
    public static Partial<MergeRequestRecord> WithCanBeReopened(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("canBeReopened");
    
    public static Partial<MergeRequestRecord> WithCreatedAt(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("createdAt");
    
    public static Partial<MergeRequestRecord> WithCreatedBy(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("createdBy");
    
    public static Partial<MergeRequestRecord> WithCreatedBy(this Partial<MergeRequestRecord> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("createdBy", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<MergeRequestRecord> WithIsTurnBased(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("turnBased");
    
    public static Partial<MergeRequestRecord> WithFeedChannel(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("feedChannel");
    
    public static Partial<MergeRequestRecord> WithFeedChannel(this Partial<MergeRequestRecord> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
        => it.AddFieldName("feedChannel", partialBuilder(new Partial<M2ChannelRecord>(it)));
    
    public static Partial<MergeRequestRecord> WithBranchPairs(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("branchPairs");
    
    public static Partial<MergeRequestRecord> WithBranchPairs(this Partial<MergeRequestRecord> it, Func<Partial<MergeRequestBranchPair>, Partial<MergeRequestBranchPair>> partialBuilder)
        => it.AddFieldName("branchPairs", partialBuilder(new Partial<MergeRequestBranchPair>(it)));
    
    public static Partial<MergeRequestRecord> WithAuthors(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("authors");
    
    public static Partial<MergeRequestRecord> WithAuthors(this Partial<MergeRequestRecord> it, Func<Partial<CodeReviewParticipantRecord>, Partial<CodeReviewParticipantRecord>> partialBuilder)
        => it.AddFieldName("authors", partialBuilder(new Partial<CodeReviewParticipantRecord>(it)));
    
    public static Partial<MergeRequestRecord> WithDiscussionCounter(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("discussionCounter");
    
    public static Partial<MergeRequestRecord> WithDiscussionCounter(this Partial<MergeRequestRecord> it, Func<Partial<Counter>, Partial<Counter>> partialBuilder)
        => it.AddFieldName("discussionCounter", partialBuilder(new Partial<Counter>(it)));
    
    public static Partial<MergeRequestRecord> WithIssueIds(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("issueIds");
    
    public static Partial<MergeRequestRecord> WithParticipants(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("participants");
    
    public static Partial<MergeRequestRecord> WithParticipants(this Partial<MergeRequestRecord> it, Func<Partial<CodeReviewParticipant>, Partial<CodeReviewParticipant>> partialBuilder)
        => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipant>(it)));
    
    public static Partial<MergeRequestRecord> WithReviewers(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("reviewers");
    
    public static Partial<MergeRequestRecord> WithReviewers(this Partial<MergeRequestRecord> it, Func<Partial<CodeReviewParticipantRecord>, Partial<CodeReviewParticipantRecord>> partialBuilder)
        => it.AddFieldName("reviewers", partialBuilder(new Partial<CodeReviewParticipantRecord>(it)));
    
    public static Partial<MergeRequestRecord> WithWatchers(this Partial<MergeRequestRecord> it)
        => it.AddFieldName("watchers");
    
    public static Partial<MergeRequestRecord> WithWatchers(this Partial<MergeRequestRecord> it, Func<Partial<CodeReviewParticipantRecord>, Partial<CodeReviewParticipantRecord>> partialBuilder)
        => it.AddFieldName("watchers", partialBuilder(new Partial<CodeReviewParticipantRecord>(it)));
    
}


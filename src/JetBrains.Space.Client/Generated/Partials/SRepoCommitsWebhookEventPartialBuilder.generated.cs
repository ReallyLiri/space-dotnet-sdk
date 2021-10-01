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

namespace JetBrains.Space.Client.SRepoCommitsWebhookEventPartialBuilder;

public static class SRepoCommitsWebhookEventPartialExtensions
{
    public static Partial<SRepoCommitsWebhookEvent> WithProjectKey(this Partial<SRepoCommitsWebhookEvent> it)
        => it.AddFieldName("projectKey");
    
    public static Partial<SRepoCommitsWebhookEvent> WithProjectKey(this Partial<SRepoCommitsWebhookEvent> it, Func<Partial<ProjectKey>, Partial<ProjectKey>> partialBuilder)
        => it.AddFieldName("projectKey", partialBuilder(new Partial<ProjectKey>(it)));
    
    public static Partial<SRepoCommitsWebhookEvent> WithRepository(this Partial<SRepoCommitsWebhookEvent> it)
        => it.AddFieldName("repository");
    
    public static Partial<SRepoCommitsWebhookEvent> WithCommit(this Partial<SRepoCommitsWebhookEvent> it)
        => it.AddFieldName("commit");
    
    public static Partial<SRepoCommitsWebhookEvent> WithCommit(this Partial<SRepoCommitsWebhookEvent> it, Func<Partial<GitCommitInfoWithChanges>, Partial<GitCommitInfoWithChanges>> partialBuilder)
        => it.AddFieldName("commit", partialBuilder(new Partial<GitCommitInfoWithChanges>(it)));
    
}


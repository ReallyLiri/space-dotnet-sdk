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

namespace JetBrains.Space.Client.UnfurlDetailsCommitPartialBuilder;

public static class UnfurlDetailsCommitPartialExtensions
{
    public static Partial<UnfurlDetailsCommit> WithProject(this Partial<UnfurlDetailsCommit> it)
        => it.AddFieldName("project");
    
    public static Partial<UnfurlDetailsCommit> WithProject(this Partial<UnfurlDetailsCommit> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
    
    public static Partial<UnfurlDetailsCommit> WithRepository(this Partial<UnfurlDetailsCommit> it)
        => it.AddFieldName("repository");
    
    public static Partial<UnfurlDetailsCommit> WithCommitId(this Partial<UnfurlDetailsCommit> it)
        => it.AddFieldName("commitId");
    
    public static Partial<UnfurlDetailsCommit> WithMessage(this Partial<UnfurlDetailsCommit> it)
        => it.AddFieldName("message");
    
    public static Partial<UnfurlDetailsCommit> WithCommitDate(this Partial<UnfurlDetailsCommit> it)
        => it.AddFieldName("commitDate");
    
    public static Partial<UnfurlDetailsCommit> WithAuthor(this Partial<UnfurlDetailsCommit> it)
        => it.AddFieldName("author");
    
    public static Partial<UnfurlDetailsCommit> WithAuthor(this Partial<UnfurlDetailsCommit> it, Func<Partial<GitAuthorInfo>, Partial<GitAuthorInfo>> partialBuilder)
        => it.AddFieldName("author", partialBuilder(new Partial<GitAuthorInfo>(it)));
    
    public static Partial<UnfurlDetailsCommit> WithAuthorProfile(this Partial<UnfurlDetailsCommit> it)
        => it.AddFieldName("authorProfile");
    
    public static Partial<UnfurlDetailsCommit> WithAuthorProfile(this Partial<UnfurlDetailsCommit> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("authorProfile", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<UnfurlDetailsCommit> WithIsHideAuthorAndDate(this Partial<UnfurlDetailsCommit> it)
        => it.AddFieldName("hideAuthorAndDate");
    
    public static Partial<UnfurlDetailsCommit> WithIsWithBranchTags(this Partial<UnfurlDetailsCommit> it)
        => it.AddFieldName("withBranchTags");
    
}


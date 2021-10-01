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

namespace JetBrains.Space.Client.RepoCommitsSubscriptionFilterSpecPartialBuilder;

public static class RepoCommitsSubscriptionFilterSpecPartialExtensions
{
    public static Partial<RepoCommitsSubscriptionFilterSpec> WithAuthors(this Partial<RepoCommitsSubscriptionFilterSpec> it)
        => it.AddFieldName("authors");
    
    public static Partial<RepoCommitsSubscriptionFilterSpec> WithCommitters(this Partial<RepoCommitsSubscriptionFilterSpec> it)
        => it.AddFieldName("committers");
    
    public static Partial<RepoCommitsSubscriptionFilterSpec> WithBranchSpec(this Partial<RepoCommitsSubscriptionFilterSpec> it)
        => it.AddFieldName("branchSpec");
    
    public static Partial<RepoCommitsSubscriptionFilterSpec> WithPathSpec(this Partial<RepoCommitsSubscriptionFilterSpec> it)
        => it.AddFieldName("pathSpec");
    
    public static Partial<RepoCommitsSubscriptionFilterSpec> WithMessageRegex(this Partial<RepoCommitsSubscriptionFilterSpec> it)
        => it.AddFieldName("messageRegex");
    
}


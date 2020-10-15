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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.GitCommitWithGraphPartialBuilder
{
    public static class GitCommitWithGraphPartialExtensions
    {
        public static Partial<GitCommitWithGraph> WithRepositoryName(this Partial<GitCommitWithGraph> it)
            => it.AddFieldName("repositoryName");
        
        public static Partial<GitCommitWithGraph> WithCommit(this Partial<GitCommitWithGraph> it)
            => it.AddFieldName("commit");
        
        public static Partial<GitCommitWithGraph> WithCommit(this Partial<GitCommitWithGraph> it, Func<Partial<GitCommitInfo>, Partial<GitCommitInfo>> partialBuilder)
            => it.AddFieldName("commit", partialBuilder(new Partial<GitCommitInfo>(it)));
        
        public static Partial<GitCommitWithGraph> WithReviews(this Partial<GitCommitWithGraph> it)
            => it.AddFieldName("reviews");
        
        public static Partial<GitCommitWithGraph> WithReviews(this Partial<GitCommitWithGraph> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
            => it.AddFieldName("reviews", partialBuilder(new Partial<CodeReviewRecord>(it)));
        
        public static Partial<GitCommitWithGraph> WithLayout(this Partial<GitCommitWithGraph> it)
            => it.AddFieldName("layout");
        
        public static Partial<GitCommitWithGraph> WithLayout(this Partial<GitCommitWithGraph> it, Func<Partial<GitGraphLayoutLine>, Partial<GitGraphLayoutLine>> partialBuilder)
            => it.AddFieldName("layout", partialBuilder(new Partial<GitGraphLayoutLine>(it)));
        
        public static Partial<GitCommitWithGraph> WithIsUnreachable(this Partial<GitCommitWithGraph> it)
            => it.AddFieldName("unreachable");
        
    }
    
}

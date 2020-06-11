// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.GitCommitWithGraphDtoExtensions
{
    public static class GitCommitWithGraphDtoPartialExtensions
    {
        public static Partial<GitCommitWithGraphDto> WithRepositoryName(this Partial<GitCommitWithGraphDto> it)
            => it.AddFieldName("repositoryName");
        
        public static Partial<GitCommitWithGraphDto> WithCommit(this Partial<GitCommitWithGraphDto> it)
            => it.AddFieldName("commit");
        
        public static Partial<GitCommitWithGraphDto> WithCommit(this Partial<GitCommitWithGraphDto> it, Func<Partial<GitCommitInfoDto>, Partial<GitCommitInfoDto>> partialBuilder)
            => it.AddFieldName("commit", partialBuilder(new Partial<GitCommitInfoDto>(it)));
        
        public static Partial<GitCommitWithGraphDto> WithReviews(this Partial<GitCommitWithGraphDto> it)
            => it.AddFieldName("reviews");
        
        public static Partial<GitCommitWithGraphDto> WithReviews(this Partial<GitCommitWithGraphDto> it, Func<Partial<CodeReviewRecordDto>, Partial<CodeReviewRecordDto>> partialBuilder)
            => it.AddFieldName("reviews", partialBuilder(new Partial<CodeReviewRecordDto>(it)));
        
        public static Partial<GitCommitWithGraphDto> WithLayout(this Partial<GitCommitWithGraphDto> it)
            => it.AddFieldName("layout");
        
        public static Partial<GitCommitWithGraphDto> WithLayout(this Partial<GitCommitWithGraphDto> it, Func<Partial<GitGraphLayoutLineDto>, Partial<GitGraphLayoutLineDto>> partialBuilder)
            => it.AddFieldName("layout", partialBuilder(new Partial<GitGraphLayoutLineDto>(it)));
        
        public static Partial<GitCommitWithGraphDto> WithUnreachable(this Partial<GitCommitWithGraphDto> it)
            => it.AddFieldName("unreachable");
        
    }
    
}

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

namespace SpaceDotNet.Client.GitCommitInfoDtoExtensions
{
    public static class GitCommitInfoDtoPartialExtensions
    {
        public static Partial<GitCommitInfoDto> WithId(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("id");
        
        public static Partial<GitCommitInfoDto> WithMessage(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("message");
        
        public static Partial<GitCommitInfoDto> WithAuthorDate(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("authorDate");
        
        public static Partial<GitCommitInfoDto> WithCommitDate(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("commitDate");
        
        public static Partial<GitCommitInfoDto> WithAuthor(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("author");
        
        public static Partial<GitCommitInfoDto> WithAuthor(this Partial<GitCommitInfoDto> it, Func<Partial<GitAuthorInfoDto>, Partial<GitAuthorInfoDto>> partialBuilder)    => it.AddFieldName("author", partialBuilder(new Partial<GitAuthorInfoDto>()));
        
        public static Partial<GitCommitInfoDto> WithCommitter(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("committer");
        
        public static Partial<GitCommitInfoDto> WithCommitter(this Partial<GitCommitInfoDto> it, Func<Partial<GitAuthorInfoDto>, Partial<GitAuthorInfoDto>> partialBuilder)    => it.AddFieldName("committer", partialBuilder(new Partial<GitAuthorInfoDto>()));
        
        public static Partial<GitCommitInfoDto> WithAuthorProfile(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("authorProfile");
        
        public static Partial<GitCommitInfoDto> WithAuthorProfile(this Partial<GitCommitInfoDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)    => it.AddFieldName("authorProfile", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<GitCommitInfoDto> WithParents(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("parents");
        
        public static Partial<GitCommitInfoDto> WithTags(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("tags");
        
        public static Partial<GitCommitInfoDto> WithBranches(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("branches");
        
        public static Partial<GitCommitInfoDto> WithBranches(this Partial<GitCommitInfoDto> it, Func<Partial<BranchInfoDto>, Partial<BranchInfoDto>> partialBuilder)    => it.AddFieldName("branches", partialBuilder(new Partial<BranchInfoDto>()));
        
        public static Partial<GitCommitInfoDto> WithHeads(this Partial<GitCommitInfoDto> it)    => it.AddFieldName("heads");
        
    }
    
}

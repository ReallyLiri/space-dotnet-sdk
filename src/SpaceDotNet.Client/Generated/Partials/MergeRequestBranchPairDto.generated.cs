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

namespace SpaceDotNet.Client.MergeRequestBranchPairDtoExtensions
{
    public static class MergeRequestBranchPairDtoPartialExtensions
    {
        public static Partial<MergeRequestBranchPairDto> WithRepository(this Partial<MergeRequestBranchPairDto> it)
            => it.AddFieldName("repository");
        
        public static Partial<MergeRequestBranchPairDto> WithSourceBranch(this Partial<MergeRequestBranchPairDto> it)
            => it.AddFieldName("sourceBranch");
        
        public static Partial<MergeRequestBranchPairDto> WithTargetBranch(this Partial<MergeRequestBranchPairDto> it)
            => it.AddFieldName("targetBranch");
        
        public static Partial<MergeRequestBranchPairDto> WithSourceBranchRef(this Partial<MergeRequestBranchPairDto> it)
            => it.AddFieldName("sourceBranchRef");
        
        public static Partial<MergeRequestBranchPairDto> WithSourceBranchInfo(this Partial<MergeRequestBranchPairDto> it)
            => it.AddFieldName("sourceBranchInfo");
        
        public static Partial<MergeRequestBranchPairDto> WithSourceBranchInfo(this Partial<MergeRequestBranchPairDto> it, Func<Partial<MergeRequestBranchDto>, Partial<MergeRequestBranchDto>> partialBuilder)
            => it.AddFieldName("sourceBranchInfo", partialBuilder(new Partial<MergeRequestBranchDto>(it)));
        
        public static Partial<MergeRequestBranchPairDto> WithTargetBranchInfo(this Partial<MergeRequestBranchPairDto> it)
            => it.AddFieldName("targetBranchInfo");
        
        public static Partial<MergeRequestBranchPairDto> WithTargetBranchInfo(this Partial<MergeRequestBranchPairDto> it, Func<Partial<MergeRequestBranchDto>, Partial<MergeRequestBranchDto>> partialBuilder)
            => it.AddFieldName("targetBranchInfo", partialBuilder(new Partial<MergeRequestBranchDto>(it)));
        
    }
    
}

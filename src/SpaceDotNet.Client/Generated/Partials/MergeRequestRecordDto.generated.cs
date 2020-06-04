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

namespace SpaceDotNet.Client.MergeRequestRecordDtoExtensions
{
    public static class MergeRequestRecordDtoPartialExtensions
    {
        public static Partial<MergeRequestRecordDto> WithId(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("id");
        
        public static Partial<MergeRequestRecordDto> WithProject(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("project");
        
        public static Partial<MergeRequestRecordDto> WithProject(this Partial<MergeRequestRecordDto> it, Func<Partial<ProjectKeyDto>, Partial<ProjectKeyDto>> partialBuilder)    => it.AddFieldName("project", partialBuilder(new Partial<ProjectKeyDto>()));
        
        public static Partial<MergeRequestRecordDto> WithProjectId(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("projectId");
        
        public static Partial<MergeRequestRecordDto> WithNumber(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("number");
        
        public static Partial<MergeRequestRecordDto> WithTitle(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("title");
        
        public static Partial<MergeRequestRecordDto> WithState(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("state");
        
        public static Partial<MergeRequestRecordDto> WithState(this Partial<MergeRequestRecordDto> it, Func<Partial<CodeReviewState>, Partial<CodeReviewState>> partialBuilder)    => it.AddFieldName("state", partialBuilder(new Partial<CodeReviewState>()));
        
        public static Partial<MergeRequestRecordDto> WithCanBeReopened(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("canBeReopened");
        
        public static Partial<MergeRequestRecordDto> WithCreatedAt(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("createdAt");
        
        public static Partial<MergeRequestRecordDto> WithCreatedBy(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("createdBy");
        
        public static Partial<MergeRequestRecordDto> WithCreatedBy(this Partial<MergeRequestRecordDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)    => it.AddFieldName("createdBy", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<MergeRequestRecordDto> WithTurnBased(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("turnBased");
        
        public static Partial<MergeRequestRecordDto> WithParticipants(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("participants");
        
        public static Partial<MergeRequestRecordDto> WithParticipants(this Partial<MergeRequestRecordDto> it, Func<Partial<CodeReviewParticipantDto>, Partial<CodeReviewParticipantDto>> partialBuilder)    => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipantDto>()));
        
        public static Partial<MergeRequestRecordDto> WithFeedChannel(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("feedChannel");
        
        public static Partial<MergeRequestRecordDto> WithFeedChannel(this Partial<MergeRequestRecordDto> it, Func<Partial<M2ChannelRecordDto>, Partial<M2ChannelRecordDto>> partialBuilder)    => it.AddFieldName("feedChannel", partialBuilder(new Partial<M2ChannelRecordDto>()));
        
        public static Partial<MergeRequestRecordDto> WithBranchPairs(this Partial<MergeRequestRecordDto> it)    => it.AddFieldName("branchPairs");
        
        public static Partial<MergeRequestRecordDto> WithBranchPairs(this Partial<MergeRequestRecordDto> it, Func<Partial<MergeRequestBranchPairDto>, Partial<MergeRequestBranchPairDto>> partialBuilder)    => it.AddFieldName("branchPairs", partialBuilder(new Partial<MergeRequestBranchPairDto>()));
        
    }
    
}

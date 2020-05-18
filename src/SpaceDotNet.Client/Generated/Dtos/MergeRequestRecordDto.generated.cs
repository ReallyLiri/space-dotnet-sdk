// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3596616+00:00
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

namespace SpaceDotNet.Client
{
    public class MergeRequestRecordDto
         : CodeReviewRecordDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("project")]
        public ProjectKeyDto Project { get; set; }        
        
        [Required]
        [JsonPropertyName("projectId")]
        public string ProjectId { get; set; }        
        
        [Required]
        [JsonPropertyName("number")]
        public int Number { get; set; }        
        
        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }        
        
        [Required]
        [JsonPropertyName("state")]
        public CodeReviewState State { get; set; }        
        
        [JsonPropertyName("canBeReopened")]
        public bool? CanBeReopened { get; set; }        
        
        [Required]
        [JsonPropertyName("createdAt")]
        public long CreatedAt { get; set; }        
        
        [Required]
        [JsonPropertyName("createdBy")]
        public TDMemberProfileDto CreatedBy { get; set; }        
        
        [JsonPropertyName("turnBased")]
        public bool? TurnBased { get; set; }        
        
        [Required]
        [JsonPropertyName("participants")]
        public List<CodeReviewParticipantDto> Participants { get; set; }        
        
        [JsonPropertyName("feedChannel")]
        public M2ChannelRecordDto? FeedChannel { get; set; }        
        
        [Required]
        [JsonPropertyName("branchPairs")]
        public List<MergeRequestBranchPairDto> BranchPairs { get; set; }        
        
    }
    
}

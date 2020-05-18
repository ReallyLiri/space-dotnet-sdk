// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.2771429+00:00
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
    public class ArticleRecordDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }        
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created { get; set; }        
        
        [Required]
        [JsonPropertyName("author")]
        public TDMemberProfileDto Author { get; set; }        
        
        [Required]
        [JsonPropertyName("aliases")]
        public List<BGArticleAliasDto> Aliases { get; set; }        
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel { get; set; }        
        
        [Required]
        [JsonPropertyName("channelContent")]
        public M2ChannelContentRecordDto ChannelContent { get; set; }        
        
        [Required]
        [JsonPropertyName("reactions")]
        public AllReactionsToItemRecordDto Reactions { get; set; }        
        
        [Required]
        [JsonPropertyName("content")]
        public string Content { get; set; }        
        
        [JsonPropertyName("event")]
        public MeetingRecordDto? Event { get; set; }        
        
        [JsonPropertyName("location")]
        public TDLocationDto? Location { get; set; }        
        
        [JsonPropertyName("locations")]
        public List<TDLocationDto>? Locations { get; set; }        
        
        [JsonPropertyName("project")]
        public PRProjectDto? Project { get; set; }        
        
        [JsonPropertyName("team")]
        public TDTeamDto? Team { get; set; }        
        
        [JsonPropertyName("teams")]
        public List<TDTeamDto>? Teams { get; set; }        
        
        [Required]
        [JsonPropertyName("editable")]
        public bool Editable { get; set; }        
        
        [Required]
        [JsonPropertyName("preview")]
        public string Preview { get; set; }        
        
        [Required]
        [JsonPropertyName("previewImages")]
        public List<ArticleMarkdownImageDto> PreviewImages { get; set; }        
        
        [JsonPropertyName("wordsNumber")]
        public int? WordsNumber { get; set; }        
        
    }
    
}

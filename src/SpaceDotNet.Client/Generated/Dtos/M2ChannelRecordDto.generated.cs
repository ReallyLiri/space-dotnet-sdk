// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3451160+00:00
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
    public class M2ChannelRecordDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("contact")]
        public M2ChannelContactDto Contact { get; set; }        
        
        [Required]
        [JsonPropertyName("totalMessages")]
        public int TotalMessages { get; set; }        
        
        [JsonPropertyName("lastMessage")]
        public MessageInfoDto? LastMessage { get; set; }        
        
        [JsonPropertyName("authors")]
        public List<TDMemberProfileDto>? Authors { get; set; }        
        
        [JsonPropertyName("commentAuthors")]
        public List<CPrincipalDto>? CommentAuthors { get; set; }        
        
        [JsonPropertyName("participants")]
        public List<ChannelParticipantDto>? Participants { get; set; }        
        
        [JsonPropertyName("channelArchived")]
        public bool? ChannelArchived { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel { get; set; }        
        
        [JsonPropertyName("messages")]
        public List<ChannelItemRecordDto>? Messages { get; set; }        
        
        [JsonPropertyName("content")]
        public M2ChannelContentInfoDto? Content { get; set; }        
        
    }
    
}

// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3083405+00:00
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
    public class FTSBlogDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }        
        
        [Required]
        [JsonPropertyName("author")]
        public TDMemberProfileDto Author { get; set; }        
        
        [Required]
        [JsonPropertyName("date")]
        public SpaceTime Date { get; set; }        
        
        [Required]
        [JsonPropertyName("snippets")]
        public List<FTSSnippetDto> Snippets { get; set; }        
        
        [JsonPropertyName("comments")]
        public List<FTSBlogCommentDto>? Comments { get; set; }        
        
    }
    
}

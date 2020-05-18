// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.6733461+00:00
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
    public class CreateDraftRequestDto
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }        
        
        [JsonPropertyName("text")]
        public string? Text { get; set; }        
        
        [JsonPropertyName("textVersion")]
        public long? TextVersion { get; set; }        
        
        [Required]
        [JsonPropertyName("type")]
        public DraftDocumentType Type { get; set; }        
        
        [JsonPropertyName("publicationDetails")]
        public DraftPublicationDetailsDto? PublicationDetails { get; set; }        
        
    }
    
}

// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.6757575+00:00
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
    public class CreateMemberLocationRequestDto
    {
        [Required]
        [JsonPropertyName("member")]
        public string Member { get; set; }        
        
        [Required]
        [JsonPropertyName("location")]
        public string Location { get; set; }        
        
        [JsonPropertyName("since")]
        public SpaceDate? Since { get; set; }        
        
        [JsonPropertyName("till")]
        public SpaceDate? Till { get; set; }        
        
        [JsonPropertyName("previousLocation")]
        public string? PreviousLocation { get; set; }        
        
    }
    
}

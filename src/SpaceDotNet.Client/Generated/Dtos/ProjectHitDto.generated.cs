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

namespace SpaceDotNet.Client
{
    public class ProjectHitDto
         : EntityHitDto, IClassNameConvertible
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("score")]
        public double Score { get; set; }        
        
        [Required]
        [JsonPropertyName("key")]
        public string Key { get; set; }        
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }        
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }        
        
        [Required]
        [JsonPropertyName("ref")]
        public PRProjectDto Ref { get; set; }        
        
    }
    
}
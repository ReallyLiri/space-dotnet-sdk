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
    public class CreateAbsenceRequest
    {
        [Required]
        [JsonPropertyName("member")]
        public string Member { get; set; }
    
        [Required]
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    
        [Required]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        [JsonPropertyName("location")]
        public string? Location { get; set; }
    
        [Required]
        [JsonPropertyName("since")]
        public SpaceDate Since { get; set; }
    
        [Required]
        [JsonPropertyName("till")]
        public SpaceDate Till { get; set; }
    
        [Required]
        [JsonPropertyName("available")]
        public bool Available { get; set; }
    
        [Required]
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValueDto>? CustomFieldValues { get; set; }
    
    }
    
}
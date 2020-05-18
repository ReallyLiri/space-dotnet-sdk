// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3677600+00:00
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
    public class PackageVersionInfoDto
    {
        [Required]
        [JsonPropertyName("type")]
        public PackageTypeDto Type { get; set; }        
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository { get; set; }        
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }        
        
        [Required]
        [JsonPropertyName("version")]
        public string Version { get; set; }        
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }        
        
    }
    
}

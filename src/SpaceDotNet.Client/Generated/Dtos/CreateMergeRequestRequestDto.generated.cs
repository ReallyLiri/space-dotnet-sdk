// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.6763991+00:00
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
    public class CreateMergeRequestRequestDto
    {
        [Required]
        [JsonPropertyName("sourceBranch")]
        public string SourceBranch { get; set; }        
        
        [Required]
        [JsonPropertyName("targetBranch")]
        public string TargetBranch { get; set; }        
        
        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }        
        
    }
    
}

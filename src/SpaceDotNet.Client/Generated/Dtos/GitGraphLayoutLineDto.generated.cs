// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3234692+00:00
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
    public class GitGraphLayoutLineDto
    {
        [Required]
        [JsonPropertyName("nodes")]
        public List<GitGraphLayoutNodeDto> Nodes { get; set; }        
        
        [Required]
        [JsonPropertyName("edges")]
        public List<GitGraphLayoutEdgeDto> Edges { get; set; }        
        
    }
    
}

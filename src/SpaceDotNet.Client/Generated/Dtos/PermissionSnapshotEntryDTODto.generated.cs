// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3698571+00:00
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
    public class PermissionSnapshotEntryDTODto
    {
        [Required]
        [JsonPropertyName("principalIndex")]
        public int PrincipalIndex { get; set; }        
        
        [Required]
        [JsonPropertyName("rightIndex")]
        public int RightIndex { get; set; }        
        
        [Required]
        [JsonPropertyName("allTargets")]
        public bool AllTargets { get; set; }        
        
        [Required]
        [JsonPropertyName("targetIndices")]
        public List<int> TargetIndices { get; set; }        
        
    }
    
}

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
    public class TDMergedEventDto
    {
        [Required]
        [JsonPropertyName("events")]
        public List<Pair<TDMembershipDto, int>> Events { get; set; }        
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfileDto Profile { get; set; }        
        
    }
    
}
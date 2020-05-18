// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.6760212+00:00
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
    public class CreateMembershipRequestDto
    {
        [Required]
        [JsonPropertyName("memberId")]
        public string MemberId { get; set; }        
        
        [Required]
        [JsonPropertyName("teamId")]
        public string TeamId { get; set; }        
        
        [Required]
        [JsonPropertyName("roleId")]
        public string RoleId { get; set; }        
        
        [Required]
        [JsonPropertyName("lead")]
        public bool Lead { get; set; }        
        
        [JsonPropertyName("managerId")]
        public string? ManagerId { get; set; }        
        
        [JsonPropertyName("since")]
        public SpaceDate? Since { get; set; }        
        
        [JsonPropertyName("till")]
        public SpaceDate? Till { get; set; }        
        
        [JsonPropertyName("activeSince")]
        public SpaceTime? ActiveSince { get; set; }        
        
        [JsonPropertyName("activeTill")]
        public SpaceTime? ActiveTill { get; set; }        
        
        [JsonPropertyName("previousMembershipId")]
        public string? PreviousMembershipId { get; set; }        
        
        [Required]
        [JsonPropertyName("requiresApproval")]
        public bool RequiresApproval { get; set; }        
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValueDto>? CustomFieldValues { get; set; }        
        
    }
    
}

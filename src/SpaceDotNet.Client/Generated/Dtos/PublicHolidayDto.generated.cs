// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3735631+00:00
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
    public class PublicHolidayDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("calendar")]
        public PublicHolidayCalendarRecordDto Calendar { get; set; }        
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }        
        
        [Required]
        [JsonPropertyName("date")]
        public SpaceDate Date { get; set; }        
        
        [Required]
        [JsonPropertyName("workingDay")]
        public bool WorkingDay { get; set; }        
        
    }
    
}

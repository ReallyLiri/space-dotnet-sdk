// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3737426+00:00
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
    public class PublicHolidayCalendarRecordDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }        
        
        [JsonPropertyName("firstDate")]
        public SpaceDate? FirstDate { get; set; }        
        
        [JsonPropertyName("lastDate")]
        public SpaceDate? LastDate { get; set; }        
        
        [Required]
        [JsonPropertyName("eventsCount")]
        public int EventsCount { get; set; }        
        
        [Required]
        [JsonPropertyName("location")]
        public TDLocationDto Location { get; set; }        
        
    }
    
}

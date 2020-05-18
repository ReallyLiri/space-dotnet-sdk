// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.2993914+00:00
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
    public class ESGithubAuthModuleSettingsDto
         : ESOAuth2AuthModuleSettingsDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [Required]
        [JsonPropertyName("githubUrl")]
        public string GithubUrl { get; set; }        
        
        [Required]
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }        
        
        [Required]
        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; set; }        
        
        [Required]
        [JsonPropertyName("registerNewUsers")]
        public bool RegisterNewUsers { get; set; }        
        
        [Required]
        [JsonPropertyName("organizations")]
        public List<string> Organizations { get; set; }        
        
    }
    
}

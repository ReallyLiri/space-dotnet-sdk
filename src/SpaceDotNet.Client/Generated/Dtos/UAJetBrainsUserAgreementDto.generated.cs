// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class UAJetBrainsUserAgreementDto
         : IPropagatePropertyAccessPath
    {
        public UAJetBrainsUserAgreementDto() { }
        
        public UAJetBrainsUserAgreementDto(string content, UAVersionDto version, SpaceTime updated)
        {
            Content = content;
            Version = version;
            Updated = updated;
        }
        
        private PropertyValue<string> _content = new PropertyValue<string>(nameof(UAJetBrainsUserAgreementDto), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public string Content
        {
            get { return _content.GetValue(); }
            set { _content.SetValue(value); }
        }
    
        private PropertyValue<UAVersionDto> _version = new PropertyValue<UAVersionDto>(nameof(UAJetBrainsUserAgreementDto), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public UAVersionDto Version
        {
            get { return _version.GetValue(); }
            set { _version.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _updated = new PropertyValue<SpaceTime>(nameof(UAJetBrainsUserAgreementDto), nameof(Updated));
        
        [Required]
        [JsonPropertyName("updated")]
        public SpaceTime Updated
        {
            get { return _updated.GetValue(); }
            set { _updated.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _content.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
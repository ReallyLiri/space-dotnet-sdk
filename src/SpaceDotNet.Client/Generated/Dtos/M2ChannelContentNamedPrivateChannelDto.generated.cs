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
    public sealed class M2ChannelContentNamedPrivateChannelDto
         : M2ChannelContactInfoDto, M2ChannelContentInfoDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentNamedPrivateChannel";
        
        public M2ChannelContentNamedPrivateChannelDto() { }
        
        public M2ChannelContentNamedPrivateChannelDto(string name, ChannelSpecificDefaultsDto? notificationDefaults = null)
        {
            Name = name;
            NotificationDefaults = notificationDefaults;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(M2ChannelContentNamedPrivateChannelDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<ChannelSpecificDefaultsDto?> _notificationDefaults = new PropertyValue<ChannelSpecificDefaultsDto?>(nameof(M2ChannelContentNamedPrivateChannelDto), nameof(NotificationDefaults));
        
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaultsDto? NotificationDefaults
        {
            get { return _notificationDefaults.GetValue(); }
            set { _notificationDefaults.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

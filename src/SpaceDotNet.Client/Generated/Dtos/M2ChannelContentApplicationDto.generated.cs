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
    public sealed class M2ChannelContentApplicationDto
         : M2ChannelContactInfoDto, M2ChannelContentInfoDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentApplication";
        
        public M2ChannelContentApplicationDto() { }
        
        public M2ChannelContentApplicationDto(ESServiceDto service, ChannelSpecificDefaultsDto notificationDefaults)
        {
            Service = service;
            NotificationDefaults = notificationDefaults;
        }
        
        private PropertyValue<ESServiceDto> _service = new PropertyValue<ESServiceDto>(nameof(M2ChannelContentApplicationDto), nameof(Service));
        
        [Required]
        [JsonPropertyName("service")]
        public ESServiceDto Service
        {
            get { return _service.GetValue(); }
            set { _service.SetValue(value); }
        }
    
        private PropertyValue<ChannelSpecificDefaultsDto> _notificationDefaults = new PropertyValue<ChannelSpecificDefaultsDto>(nameof(M2ChannelContentApplicationDto), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaultsDto NotificationDefaults
        {
            get { return _notificationDefaults.GetValue(); }
            set { _notificationDefaults.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _service.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

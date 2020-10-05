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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class M2ChannelContentNamedPrivateChannel
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentNamedPrivateChannel";
        
        public M2ChannelContentNamedPrivateChannel() { }
        
        public M2ChannelContentNamedPrivateChannel(string name, bool canHaveThreads, ChannelSpecificDefaults? notificationDefaults = null)
        {
            Name = name;
            NotificationDefaults = notificationDefaults;
            CanHaveThreads = canHaveThreads;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(M2ChannelContentNamedPrivateChannel), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<ChannelSpecificDefaults?> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults?>(nameof(M2ChannelContentNamedPrivateChannel), nameof(NotificationDefaults));
        
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults? NotificationDefaults
        {
            get { return _notificationDefaults.GetValue(); }
            set { _notificationDefaults.SetValue(value); }
        }
    
        private PropertyValue<bool> _canHaveThreads = new PropertyValue<bool>(nameof(M2ChannelContentNamedPrivateChannel), nameof(CanHaveThreads));
        
        [Required]
        [JsonPropertyName("canHaveThreads")]
        public bool CanHaveThreads
        {
            get { return _canHaveThreads.GetValue(); }
            set { _canHaveThreads.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
            _canHaveThreads.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

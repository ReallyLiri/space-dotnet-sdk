// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
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
    public sealed class AllChannelsListEntry
         : IPropagatePropertyAccessPath
    {
        public AllChannelsListEntry() { }
        
        public AllChannelsListEntry(string channelId, string name, string description, M2Access access, DateTime created, int subscribers, bool subscribed, string? icon = null)
        {
            ChannelId = channelId;
            Name = name;
            Description = description;
            Access = access;
            Icon = icon;
            Created = created;
            Subscribers = subscribers;
            IsSubscribed = subscribed;
        }
        
        private PropertyValue<string> _channelId = new PropertyValue<string>(nameof(AllChannelsListEntry), nameof(ChannelId));
        
        [Required]
        [JsonPropertyName("channelId")]
        public string ChannelId
        {
            get { return _channelId.GetValue(); }
            set { _channelId.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(AllChannelsListEntry), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(AllChannelsListEntry), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<M2Access> _access = new PropertyValue<M2Access>(nameof(AllChannelsListEntry), nameof(Access));
        
        [Required]
        [JsonPropertyName("access")]
        public M2Access Access
        {
            get { return _access.GetValue(); }
            set { _access.SetValue(value); }
        }
    
        private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(AllChannelsListEntry), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public string? Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(AllChannelsListEntry), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<int> _subscribers = new PropertyValue<int>(nameof(AllChannelsListEntry), nameof(Subscribers));
        
        [Required]
        [JsonPropertyName("subscribers")]
        public int Subscribers
        {
            get { return _subscribers.GetValue(); }
            set { _subscribers.SetValue(value); }
        }
    
        private PropertyValue<bool> _subscribed = new PropertyValue<bool>(nameof(AllChannelsListEntry), nameof(IsSubscribed));
        
        [Required]
        [JsonPropertyName("subscribed")]
        public bool IsSubscribed
        {
            get { return _subscribed.GetValue(); }
            set { _subscribed.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _channelId.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _access.SetAccessPath(path, validateHasBeenSet);
            _icon.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _subscribers.SetAccessPath(path, validateHasBeenSet);
            _subscribed.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

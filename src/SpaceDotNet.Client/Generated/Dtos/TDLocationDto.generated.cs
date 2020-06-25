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
    public sealed class TDLocationDto
         : IPropagatePropertyAccessPath
    {
        public TDLocationDto() { }
        
        public TDLocationDto(string id, string name, List<string> phones, List<string> emails, string type, bool archived, ATimeZoneWithOffsetDto? timezone = null, string? tz = null, List<int>? workdays = null, List<string>? equipment = null, string? description = null, string? address = null, TDLocationDto? parent = null, string? mapId = null, string? channelId = null)
        {
            Id = id;
            Name = name;
            Timezone = timezone;
            Tz = tz;
            Workdays = workdays;
            Phones = phones;
            Emails = emails;
            Equipment = equipment;
            Description = description;
            Address = address;
            Parent = parent;
            Type = type;
            MapId = mapId;
            ChannelId = channelId;
            Archived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDLocationDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TDLocationDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<ATimeZoneWithOffsetDto?> _timezone = new PropertyValue<ATimeZoneWithOffsetDto?>(nameof(TDLocationDto), nameof(Timezone));
        
        [JsonPropertyName("timezone")]
        public ATimeZoneWithOffsetDto? Timezone
        {
            get { return _timezone.GetValue(); }
            set { _timezone.SetValue(value); }
        }
    
        private PropertyValue<string?> _tz = new PropertyValue<string?>(nameof(TDLocationDto), nameof(Tz));
        
        [JsonPropertyName("tz")]
        public string? Tz
        {
            get { return _tz.GetValue(); }
            set { _tz.SetValue(value); }
        }
    
        private PropertyValue<List<int>?> _workdays = new PropertyValue<List<int>?>(nameof(TDLocationDto), nameof(Workdays));
        
        [JsonPropertyName("workdays")]
        public List<int>? Workdays
        {
            get { return _workdays.GetValue(); }
            set { _workdays.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _phones = new PropertyValue<List<string>>(nameof(TDLocationDto), nameof(Phones));
        
        [Required]
        [JsonPropertyName("phones")]
        public List<string> Phones
        {
            get { return _phones.GetValue(); }
            set { _phones.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _emails = new PropertyValue<List<string>>(nameof(TDLocationDto), nameof(Emails));
        
        [Required]
        [JsonPropertyName("emails")]
        public List<string> Emails
        {
            get { return _emails.GetValue(); }
            set { _emails.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _equipment = new PropertyValue<List<string>?>(nameof(TDLocationDto), nameof(Equipment));
        
        [JsonPropertyName("equipment")]
        public List<string>? Equipment
        {
            get { return _equipment.GetValue(); }
            set { _equipment.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(TDLocationDto), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string?> _address = new PropertyValue<string?>(nameof(TDLocationDto), nameof(Address));
        
        [JsonPropertyName("address")]
        public string? Address
        {
            get { return _address.GetValue(); }
            set { _address.SetValue(value); }
        }
    
        private PropertyValue<TDLocationDto?> _parent = new PropertyValue<TDLocationDto?>(nameof(TDLocationDto), nameof(Parent));
        
        [JsonPropertyName("parent")]
        public TDLocationDto? Parent
        {
            get { return _parent.GetValue(); }
            set { _parent.SetValue(value); }
        }
    
        private PropertyValue<string> _type = new PropertyValue<string>(nameof(TDLocationDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public string Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<string?> _mapId = new PropertyValue<string?>(nameof(TDLocationDto), nameof(MapId));
        
        [JsonPropertyName("mapId")]
        public string? MapId
        {
            get { return _mapId.GetValue(); }
            set { _mapId.SetValue(value); }
        }
    
        private PropertyValue<string?> _channelId = new PropertyValue<string?>(nameof(TDLocationDto), nameof(ChannelId));
        
        [JsonPropertyName("channelId")]
        public string? ChannelId
        {
            get { return _channelId.GetValue(); }
            set { _channelId.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TDLocationDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _timezone.SetAccessPath(path, validateHasBeenSet);
            _tz.SetAccessPath(path, validateHasBeenSet);
            _workdays.SetAccessPath(path, validateHasBeenSet);
            _phones.SetAccessPath(path, validateHasBeenSet);
            _emails.SetAccessPath(path, validateHasBeenSet);
            _equipment.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _address.SetAccessPath(path, validateHasBeenSet);
            _parent.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
            _mapId.SetAccessPath(path, validateHasBeenSet);
            _channelId.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

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
    public sealed class TDTeamDto
         : IPropagatePropertyAccessPath
    {
        public TDTeamDto() { }
        
        public TDTeamDto(string id, string name, string description, bool archived, List<TDMembershipDto> memberships, TDTeamDto? parent = null, List<string>? emails = null, string? channelId = null, bool? disbanded = null, SpaceDate? disbandedAt = null)
        {
            Id = id;
            Name = name;
            Description = description;
            Parent = parent;
            Emails = emails;
            ChannelId = channelId;
            Archived = archived;
            Disbanded = disbanded;
            DisbandedAt = disbandedAt;
            Memberships = memberships;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDTeamDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TDTeamDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(TDTeamDto), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<TDTeamDto?> _parent = new PropertyValue<TDTeamDto?>(nameof(TDTeamDto), nameof(Parent));
        
        [JsonPropertyName("parent")]
        public TDTeamDto? Parent
        {
            get { return _parent.GetValue(); }
            set { _parent.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _emails = new PropertyValue<List<string>?>(nameof(TDTeamDto), nameof(Emails));
        
        [JsonPropertyName("emails")]
        public List<string>? Emails
        {
            get { return _emails.GetValue(); }
            set { _emails.SetValue(value); }
        }
    
        private PropertyValue<string?> _channelId = new PropertyValue<string?>(nameof(TDTeamDto), nameof(ChannelId));
        
        [JsonPropertyName("channelId")]
        public string? ChannelId
        {
            get { return _channelId.GetValue(); }
            set { _channelId.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TDTeamDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<bool?> _disbanded = new PropertyValue<bool?>(nameof(TDTeamDto), nameof(Disbanded));
        
        [JsonPropertyName("disbanded")]
        public bool? Disbanded
        {
            get { return _disbanded.GetValue(); }
            set { _disbanded.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _disbandedAt = new PropertyValue<SpaceDate?>(nameof(TDTeamDto), nameof(DisbandedAt));
        
        [JsonPropertyName("disbandedAt")]
        public SpaceDate? DisbandedAt
        {
            get { return _disbandedAt.GetValue(); }
            set { _disbandedAt.SetValue(value); }
        }
    
        private PropertyValue<List<TDMembershipDto>> _memberships = new PropertyValue<List<TDMembershipDto>>(nameof(TDTeamDto), nameof(Memberships));
        
        [Required]
        [JsonPropertyName("memberships")]
        public List<TDMembershipDto> Memberships
        {
            get { return _memberships.GetValue(); }
            set { _memberships.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _parent.SetAccessPath(path, validateHasBeenSet);
            _emails.SetAccessPath(path, validateHasBeenSet);
            _channelId.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _disbanded.SetAccessPath(path, validateHasBeenSet);
            _disbandedAt.SetAccessPath(path, validateHasBeenSet);
            _memberships.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

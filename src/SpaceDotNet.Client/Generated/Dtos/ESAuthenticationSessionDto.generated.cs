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
    public sealed class ESAuthenticationSessionDto
         : IPropagatePropertyAccessPath
    {
        public ESAuthenticationSessionDto() { }
        
        public ESAuthenticationSessionDto(string id, TDMemberProfileDto profile, SpaceTime created, SpaceTime expires, bool current, AccessRecordDto? lastAccess = null)
        {
            Id = id;
            Profile = profile;
            Created = created;
            Expires = expires;
            LastAccess = lastAccess;
            Current = current;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESAuthenticationSessionDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _profile = new PropertyValue<TDMemberProfileDto>(nameof(ESAuthenticationSessionDto), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfileDto Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _created = new PropertyValue<SpaceTime>(nameof(ESAuthenticationSessionDto), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _expires = new PropertyValue<SpaceTime>(nameof(ESAuthenticationSessionDto), nameof(Expires));
        
        [Required]
        [JsonPropertyName("expires")]
        public SpaceTime Expires
        {
            get { return _expires.GetValue(); }
            set { _expires.SetValue(value); }
        }
    
        private PropertyValue<AccessRecordDto?> _lastAccess = new PropertyValue<AccessRecordDto?>(nameof(ESAuthenticationSessionDto), nameof(LastAccess));
        
        [JsonPropertyName("lastAccess")]
        public AccessRecordDto? LastAccess
        {
            get { return _lastAccess.GetValue(); }
            set { _lastAccess.SetValue(value); }
        }
    
        private PropertyValue<bool> _current = new PropertyValue<bool>(nameof(ESAuthenticationSessionDto), nameof(Current));
        
        [Required]
        [JsonPropertyName("current")]
        public bool Current
        {
            get { return _current.GetValue(); }
            set { _current.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _profile.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _expires.SetAccessPath(path, validateHasBeenSet);
            _lastAccess.SetAccessPath(path, validateHasBeenSet);
            _current.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

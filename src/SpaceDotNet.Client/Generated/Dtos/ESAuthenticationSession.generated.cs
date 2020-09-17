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
    public sealed class ESAuthenticationSession
         : IPropagatePropertyAccessPath
    {
        public ESAuthenticationSession() { }
        
        public ESAuthenticationSession(string id, TDMemberProfile profile, SpaceTime created, SpaceTime expires, bool current, AccessRecord? lastAccess = null)
        {
            Id = id;
            Profile = profile;
            Created = created;
            Expires = expires;
            LastAccess = lastAccess;
            IsCurrent = current;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESAuthenticationSession), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(ESAuthenticationSession), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfile Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _created = new PropertyValue<SpaceTime>(nameof(ESAuthenticationSession), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _expires = new PropertyValue<SpaceTime>(nameof(ESAuthenticationSession), nameof(Expires));
        
        [Required]
        [JsonPropertyName("expires")]
        public SpaceTime Expires
        {
            get { return _expires.GetValue(); }
            set { _expires.SetValue(value); }
        }
    
        private PropertyValue<AccessRecord?> _lastAccess = new PropertyValue<AccessRecord?>(nameof(ESAuthenticationSession), nameof(LastAccess));
        
        [JsonPropertyName("lastAccess")]
        public AccessRecord? LastAccess
        {
            get { return _lastAccess.GetValue(); }
            set { _lastAccess.SetValue(value); }
        }
    
        private PropertyValue<bool> _current = new PropertyValue<bool>(nameof(ESAuthenticationSession), nameof(IsCurrent));
        
        [Required]
        [JsonPropertyName("current")]
        public bool IsCurrent
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
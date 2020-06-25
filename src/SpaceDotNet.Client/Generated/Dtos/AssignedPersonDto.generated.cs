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
    public sealed class AssignedPersonDto
         : IPropagatePropertyAccessPath
    {
        public AssignedPersonDto() { }
        
        public AssignedPersonDto(TDMemberProfileDto? profile = null, string? role = null)
        {
            Profile = profile;
            Role = role;
        }
        
        private PropertyValue<TDMemberProfileDto?> _profile = new PropertyValue<TDMemberProfileDto?>(nameof(AssignedPersonDto), nameof(Profile));
        
        [JsonPropertyName("profile")]
        public TDMemberProfileDto? Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<string?> _role = new PropertyValue<string?>(nameof(AssignedPersonDto), nameof(Role));
        
        [JsonPropertyName("role")]
        public string? Role
        {
            get { return _role.GetValue(); }
            set { _role.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _role.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

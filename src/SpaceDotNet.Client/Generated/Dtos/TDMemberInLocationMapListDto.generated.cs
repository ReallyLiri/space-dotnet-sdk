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
    public sealed class TDMemberInLocationMapListDto
         : IPropagatePropertyAccessPath
    {
        public TDMemberInLocationMapListDto() { }
        
        public TDMemberInLocationMapListDto(TDMemberProfileDto profile, TDMemberLocationDto memberLocation, TDLocationMapPointDto? locationMapPoint = null)
        {
            Profile = profile;
            MemberLocation = memberLocation;
            LocationMapPoint = locationMapPoint;
        }
        
        private PropertyValue<TDMemberProfileDto> _profile = new PropertyValue<TDMemberProfileDto>(nameof(TDMemberInLocationMapListDto), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfileDto Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<TDMemberLocationDto> _memberLocation = new PropertyValue<TDMemberLocationDto>(nameof(TDMemberInLocationMapListDto), nameof(MemberLocation));
        
        [Required]
        [JsonPropertyName("memberLocation")]
        public TDMemberLocationDto MemberLocation
        {
            get { return _memberLocation.GetValue(); }
            set { _memberLocation.SetValue(value); }
        }
    
        private PropertyValue<TDLocationMapPointDto?> _locationMapPoint = new PropertyValue<TDLocationMapPointDto?>(nameof(TDMemberInLocationMapListDto), nameof(LocationMapPoint));
        
        [JsonPropertyName("locationMapPoint")]
        public TDLocationMapPointDto? LocationMapPoint
        {
            get { return _locationMapPoint.GetValue(); }
            set { _locationMapPoint.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _memberLocation.SetAccessPath(path, validateHasBeenSet);
            _locationMapPoint.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

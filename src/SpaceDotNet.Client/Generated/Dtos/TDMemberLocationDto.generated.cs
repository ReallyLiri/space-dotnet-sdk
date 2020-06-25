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
    public sealed class TDMemberLocationDto
         : IPropagatePropertyAccessPath
    {
        public TDMemberLocationDto() { }
        
        public TDMemberLocationDto(string id, TDLocationDto location, TDMemberProfileDto member, bool archived, List<TDLocationMapPointDto>? locationMapPoints = null, SpaceDate? since = null, SpaceDate? till = null)
        {
            Id = id;
            Location = location;
            LocationMapPoints = locationMapPoints;
            Since = since;
            Till = till;
            Member = member;
            Archived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDMemberLocationDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<TDLocationDto> _location = new PropertyValue<TDLocationDto>(nameof(TDMemberLocationDto), nameof(Location));
        
        [Required]
        [JsonPropertyName("location")]
        public TDLocationDto Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        private PropertyValue<List<TDLocationMapPointDto>?> _locationMapPoints = new PropertyValue<List<TDLocationMapPointDto>?>(nameof(TDMemberLocationDto), nameof(LocationMapPoints));
        
        [JsonPropertyName("locationMapPoints")]
        public List<TDLocationMapPointDto>? LocationMapPoints
        {
            get { return _locationMapPoints.GetValue(); }
            set { _locationMapPoints.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _since = new PropertyValue<SpaceDate?>(nameof(TDMemberLocationDto), nameof(Since));
        
        [JsonPropertyName("since")]
        public SpaceDate? Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _till = new PropertyValue<SpaceDate?>(nameof(TDMemberLocationDto), nameof(Till));
        
        [JsonPropertyName("till")]
        public SpaceDate? Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _member = new PropertyValue<TDMemberProfileDto>(nameof(TDMemberLocationDto), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public TDMemberProfileDto Member
        {
            get { return _member.GetValue(); }
            set { _member.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TDMemberLocationDto), nameof(Archived));
        
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
            _location.SetAccessPath(path, validateHasBeenSet);
            _locationMapPoints.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _member.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

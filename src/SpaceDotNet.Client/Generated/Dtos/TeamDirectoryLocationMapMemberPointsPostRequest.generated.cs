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
    public class TeamDirectoryLocationMapMemberPointsPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryLocationMapMemberPointsPostRequest() { }
        
        public TeamDirectoryLocationMapMemberPointsPostRequest(string memberLocationId, int x, int y, string mapId)
        {
            MemberLocationId = memberLocationId;
            X = x;
            Y = y;
            MapId = mapId;
        }
        
        private PropertyValue<string> _memberLocationId = new PropertyValue<string>(nameof(TeamDirectoryLocationMapMemberPointsPostRequest), nameof(MemberLocationId));
        
        [Required]
        [JsonPropertyName("memberLocationId")]
        public string MemberLocationId
        {
            get { return _memberLocationId.GetValue(); }
            set { _memberLocationId.SetValue(value); }
        }
    
        private PropertyValue<int> _x = new PropertyValue<int>(nameof(TeamDirectoryLocationMapMemberPointsPostRequest), nameof(X));
        
        [Required]
        [JsonPropertyName("x")]
        public int X
        {
            get { return _x.GetValue(); }
            set { _x.SetValue(value); }
        }
    
        private PropertyValue<int> _y = new PropertyValue<int>(nameof(TeamDirectoryLocationMapMemberPointsPostRequest), nameof(Y));
        
        [Required]
        [JsonPropertyName("y")]
        public int Y
        {
            get { return _y.GetValue(); }
            set { _y.SetValue(value); }
        }
    
        private PropertyValue<string> _mapId = new PropertyValue<string>(nameof(TeamDirectoryLocationMapMemberPointsPostRequest), nameof(MapId));
        
        [Required]
        [JsonPropertyName("mapId")]
        public string MapId
        {
            get { return _mapId.GetValue(); }
            set { _mapId.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _memberLocationId.SetAccessPath(path, validateHasBeenSet);
            _x.SetAccessPath(path, validateHasBeenSet);
            _y.SetAccessPath(path, validateHasBeenSet);
            _mapId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

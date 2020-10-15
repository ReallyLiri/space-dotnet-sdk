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
    public sealed class TDLocationMapPoint
         : IPropagatePropertyAccessPath
    {
        public TDLocationMapPoint() { }
        
        public TDLocationMapPoint(string id, int x, int y, DateTime created, string? mapId = null, string? memberLocation = null, bool? deleted = null)
        {
            Id = id;
            MapId = mapId;
            X = x;
            Y = y;
            Created = created;
            MemberLocation = memberLocation;
            IsDeleted = deleted;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDLocationMapPoint), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string?> _mapId = new PropertyValue<string?>(nameof(TDLocationMapPoint), nameof(MapId));
        
        [JsonPropertyName("mapId")]
        public string? MapId
        {
            get { return _mapId.GetValue(); }
            set { _mapId.SetValue(value); }
        }
    
        private PropertyValue<int> _x = new PropertyValue<int>(nameof(TDLocationMapPoint), nameof(X));
        
        [Required]
        [JsonPropertyName("x")]
        public int X
        {
            get { return _x.GetValue(); }
            set { _x.SetValue(value); }
        }
    
        private PropertyValue<int> _y = new PropertyValue<int>(nameof(TDLocationMapPoint), nameof(Y));
        
        [Required]
        [JsonPropertyName("y")]
        public int Y
        {
            get { return _y.GetValue(); }
            set { _y.SetValue(value); }
        }
    
        private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(TDLocationMapPoint), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<string?> _memberLocation = new PropertyValue<string?>(nameof(TDLocationMapPoint), nameof(MemberLocation));
        
        [JsonPropertyName("memberLocation")]
        public string? MemberLocation
        {
            get { return _memberLocation.GetValue(); }
            set { _memberLocation.SetValue(value); }
        }
    
        private PropertyValue<bool?> _deleted = new PropertyValue<bool?>(nameof(TDLocationMapPoint), nameof(IsDeleted));
        
        [JsonPropertyName("deleted")]
        public bool? IsDeleted
        {
            get { return _deleted.GetValue(); }
            set { _deleted.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _mapId.SetAccessPath(path, validateHasBeenSet);
            _x.SetAccessPath(path, validateHasBeenSet);
            _y.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _memberLocation.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

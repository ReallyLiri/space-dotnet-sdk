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
    public class TeamDirectoryLocationMapMemberPointsForLocationPointIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryLocationMapMemberPointsForLocationPointIdPatchRequest() { }
        
        public TeamDirectoryLocationMapMemberPointsForLocationPointIdPatchRequest(int? x = null, int? y = null)
        {
            X = x;
            Y = y;
        }
        
        private PropertyValue<int?> _x = new PropertyValue<int?>(nameof(TeamDirectoryLocationMapMemberPointsForLocationPointIdPatchRequest), nameof(X));
        
        [JsonPropertyName("x")]
        public int? X
        {
            get { return _x.GetValue(); }
            set { _x.SetValue(value); }
        }
    
        private PropertyValue<int?> _y = new PropertyValue<int?>(nameof(TeamDirectoryLocationMapMemberPointsForLocationPointIdPatchRequest), nameof(Y));
        
        [JsonPropertyName("y")]
        public int? Y
        {
            get { return _y.GetValue(); }
            set { _y.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _x.SetAccessPath(path, validateHasBeenSet);
            _y.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

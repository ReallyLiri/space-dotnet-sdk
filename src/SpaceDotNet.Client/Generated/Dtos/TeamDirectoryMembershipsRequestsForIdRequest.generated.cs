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
    public class TeamDirectoryMembershipsRequestsForIdRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryMembershipsRequestsForIdRequest() { }
        
        public TeamDirectoryMembershipsRequestsForIdRequest(bool approved)
        {
            Approved = approved;
        }
        
        private PropertyValue<bool> _approved = new PropertyValue<bool>(nameof(TeamDirectoryMembershipsRequestsForIdRequest), nameof(Approved));
        
        [Required]
        [JsonPropertyName("approved")]
        public bool Approved
        {
            get { return _approved.GetValue(); }
            set { _approved.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _approved.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

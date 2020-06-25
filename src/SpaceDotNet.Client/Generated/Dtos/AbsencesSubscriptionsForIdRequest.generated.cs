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
    public class AbsencesSubscriptionsForIdRequest
         : IPropagatePropertyAccessPath
    {
        public AbsencesSubscriptionsForIdRequest() { }
        
        public AbsencesSubscriptionsForIdRequest(string? locationId = null, string? teamId = null, string? reasonId = null)
        {
            LocationId = locationId;
            TeamId = teamId;
            ReasonId = reasonId;
        }
        
        private PropertyValue<string?> _locationId = new PropertyValue<string?>(nameof(AbsencesSubscriptionsForIdRequest), nameof(LocationId));
        
        [JsonPropertyName("locationId")]
        public string? LocationId
        {
            get { return _locationId.GetValue(); }
            set { _locationId.SetValue(value); }
        }
    
        private PropertyValue<string?> _teamId = new PropertyValue<string?>(nameof(AbsencesSubscriptionsForIdRequest), nameof(TeamId));
        
        [JsonPropertyName("teamId")]
        public string? TeamId
        {
            get { return _teamId.GetValue(); }
            set { _teamId.SetValue(value); }
        }
    
        private PropertyValue<string?> _reasonId = new PropertyValue<string?>(nameof(AbsencesSubscriptionsForIdRequest), nameof(ReasonId));
        
        [JsonPropertyName("reasonId")]
        public string? ReasonId
        {
            get { return _reasonId.GetValue(); }
            set { _reasonId.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _locationId.SetAccessPath(path, validateHasBeenSet);
            _teamId.SetAccessPath(path, validateHasBeenSet);
            _reasonId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

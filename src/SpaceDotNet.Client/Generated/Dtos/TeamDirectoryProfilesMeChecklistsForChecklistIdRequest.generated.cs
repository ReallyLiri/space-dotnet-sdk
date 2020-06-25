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
    public class TeamDirectoryProfilesMeChecklistsForChecklistIdRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryProfilesMeChecklistsForChecklistIdRequest() { }
        
        public TeamDirectoryProfilesMeChecklistsForChecklistIdRequest(string name, string? description = null)
        {
            Name = name;
            Description = description;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TeamDirectoryProfilesMeChecklistsForChecklistIdRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(TeamDirectoryProfilesMeChecklistsForChecklistIdRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

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
    public class ProjectsForProjectPlanningChecklistsForChecklistIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPlanningChecklistsForChecklistIdPatchRequest() { }
        
        public ProjectsForProjectPlanningChecklistsForChecklistIdPatchRequest(string name, string? description = null, string? owner = null, string? tag = null)
        {
            Name = name;
            Description = description;
            Owner = owner;
            Tag = tag;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsForProjectPlanningChecklistsForChecklistIdPatchRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectPlanningChecklistsForChecklistIdPatchRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string?> _owner = new PropertyValue<string?>(nameof(ProjectsForProjectPlanningChecklistsForChecklistIdPatchRequest), nameof(Owner));
        
        [JsonPropertyName("owner")]
        public string? Owner
        {
            get { return _owner.GetValue(); }
            set { _owner.SetValue(value); }
        }
    
        private PropertyValue<string?> _tag = new PropertyValue<string?>(nameof(ProjectsForProjectPlanningChecklistsForChecklistIdPatchRequest), nameof(Tag));
        
        [JsonPropertyName("tag")]
        public string? Tag
        {
            get { return _tag.GetValue(); }
            set { _tag.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _owner.SetAccessPath(path, validateHasBeenSet);
            _tag.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

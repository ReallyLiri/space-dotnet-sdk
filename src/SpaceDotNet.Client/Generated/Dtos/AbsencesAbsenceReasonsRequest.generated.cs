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
    public class AbsencesAbsenceReasonsRequest
         : IPropagatePropertyAccessPath
    {
        public AbsencesAbsenceReasonsRequest() { }
        
        public AbsencesAbsenceReasonsRequest(string name, string description, bool defaultAvailability, bool approvalRequired, string? icon = null)
        {
            Name = name;
            Description = description;
            DefaultAvailability = defaultAvailability;
            ApprovalRequired = approvalRequired;
            Icon = icon;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(AbsencesAbsenceReasonsRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(AbsencesAbsenceReasonsRequest), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<bool> _defaultAvailability = new PropertyValue<bool>(nameof(AbsencesAbsenceReasonsRequest), nameof(DefaultAvailability));
        
        [Required]
        [JsonPropertyName("defaultAvailability")]
        public bool DefaultAvailability
        {
            get { return _defaultAvailability.GetValue(); }
            set { _defaultAvailability.SetValue(value); }
        }
    
        private PropertyValue<bool> _approvalRequired = new PropertyValue<bool>(nameof(AbsencesAbsenceReasonsRequest), nameof(ApprovalRequired));
        
        [Required]
        [JsonPropertyName("approvalRequired")]
        public bool ApprovalRequired
        {
            get { return _approvalRequired.GetValue(); }
            set { _approvalRequired.SetValue(value); }
        }
    
        private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(AbsencesAbsenceReasonsRequest), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public string? Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _defaultAvailability.SetAccessPath(path, validateHasBeenSet);
            _approvalRequired.SetAccessPath(path, validateHasBeenSet);
            _icon.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

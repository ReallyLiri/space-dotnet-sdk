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
    public sealed class ResponsibilityRecordDto
         : IPropagatePropertyAccessPath
    {
        public ResponsibilityRecordDto() { }
        
        public ResponsibilityRecordDto(string responsibilityId, string summary, List<AssignedPersonDto> assignedPeople, string? notes = null)
        {
            ResponsibilityId = responsibilityId;
            Summary = summary;
            Notes = notes;
            AssignedPeople = assignedPeople;
        }
        
        private PropertyValue<string> _responsibilityId = new PropertyValue<string>(nameof(ResponsibilityRecordDto), nameof(ResponsibilityId));
        
        [Required]
        [JsonPropertyName("responsibilityId")]
        public string ResponsibilityId
        {
            get { return _responsibilityId.GetValue(); }
            set { _responsibilityId.SetValue(value); }
        }
    
        private PropertyValue<string> _summary = new PropertyValue<string>(nameof(ResponsibilityRecordDto), nameof(Summary));
        
        [Required]
        [JsonPropertyName("summary")]
        public string Summary
        {
            get { return _summary.GetValue(); }
            set { _summary.SetValue(value); }
        }
    
        private PropertyValue<string?> _notes = new PropertyValue<string?>(nameof(ResponsibilityRecordDto), nameof(Notes));
        
        [JsonPropertyName("notes")]
        public string? Notes
        {
            get { return _notes.GetValue(); }
            set { _notes.SetValue(value); }
        }
    
        private PropertyValue<List<AssignedPersonDto>> _assignedPeople = new PropertyValue<List<AssignedPersonDto>>(nameof(ResponsibilityRecordDto), nameof(AssignedPeople));
        
        [Required]
        [JsonPropertyName("assignedPeople")]
        public List<AssignedPersonDto> AssignedPeople
        {
            get { return _assignedPeople.GetValue(); }
            set { _assignedPeople.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _responsibilityId.SetAccessPath(path, validateHasBeenSet);
            _summary.SetAccessPath(path, validateHasBeenSet);
            _notes.SetAccessPath(path, validateHasBeenSet);
            _assignedPeople.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

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
    public sealed class AbsenceRecordDto
         : IPropagatePropertyAccessPath
    {
        public AbsenceRecordDto() { }
        
        public AbsenceRecordDto(string id, bool archived, TDMemberProfileDto member, string icon, SpaceDate since, SpaceDate till, bool available, AbsenceReasonRecordDto? reason = null, string? description = null, TDLocationDto? location = null, AbsenceApprovalDto? approval = null, List<CustomColumnValuesWithSchemaDataDto>? customFields = null)
        {
            Id = id;
            Archived = archived;
            Member = member;
            Icon = icon;
            Reason = reason;
            Description = description;
            Since = since;
            Till = till;
            Location = location;
            Available = available;
            Approval = approval;
            CustomFields = customFields;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(AbsenceRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(AbsenceRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _member = new PropertyValue<TDMemberProfileDto>(nameof(AbsenceRecordDto), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public TDMemberProfileDto Member
        {
            get { return _member.GetValue(); }
            set { _member.SetValue(value); }
        }
    
        private PropertyValue<string> _icon = new PropertyValue<string>(nameof(AbsenceRecordDto), nameof(Icon));
        
        [Required]
        [JsonPropertyName("icon")]
        public string Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        private PropertyValue<AbsenceReasonRecordDto?> _reason = new PropertyValue<AbsenceReasonRecordDto?>(nameof(AbsenceRecordDto), nameof(Reason));
        
        [JsonPropertyName("reason")]
        public AbsenceReasonRecordDto? Reason
        {
            get { return _reason.GetValue(); }
            set { _reason.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(AbsenceRecordDto), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _since = new PropertyValue<SpaceDate>(nameof(AbsenceRecordDto), nameof(Since));
        
        [Required]
        [JsonPropertyName("since")]
        public SpaceDate Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _till = new PropertyValue<SpaceDate>(nameof(AbsenceRecordDto), nameof(Till));
        
        [Required]
        [JsonPropertyName("till")]
        public SpaceDate Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<TDLocationDto?> _location = new PropertyValue<TDLocationDto?>(nameof(AbsenceRecordDto), nameof(Location));
        
        [JsonPropertyName("location")]
        public TDLocationDto? Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        private PropertyValue<bool> _available = new PropertyValue<bool>(nameof(AbsenceRecordDto), nameof(Available));
        
        [Required]
        [JsonPropertyName("available")]
        public bool Available
        {
            get { return _available.GetValue(); }
            set { _available.SetValue(value); }
        }
    
        private PropertyValue<AbsenceApprovalDto?> _approval = new PropertyValue<AbsenceApprovalDto?>(nameof(AbsenceRecordDto), nameof(Approval));
        
        [JsonPropertyName("approval")]
        public AbsenceApprovalDto? Approval
        {
            get { return _approval.GetValue(); }
            set { _approval.SetValue(value); }
        }
    
        private PropertyValue<List<CustomColumnValuesWithSchemaDataDto>?> _customFields = new PropertyValue<List<CustomColumnValuesWithSchemaDataDto>?>(nameof(AbsenceRecordDto), nameof(CustomFields));
        
        [JsonPropertyName("customFields")]
        public List<CustomColumnValuesWithSchemaDataDto>? CustomFields
        {
            get { return _customFields.GetValue(); }
            set { _customFields.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _member.SetAccessPath(path, validateHasBeenSet);
            _icon.SetAccessPath(path, validateHasBeenSet);
            _reason.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
            _available.SetAccessPath(path, validateHasBeenSet);
            _approval.SetAccessPath(path, validateHasBeenSet);
            _customFields.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

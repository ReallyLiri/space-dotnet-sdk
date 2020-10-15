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
    public sealed class AbsenceRecord
         : IPropagatePropertyAccessPath
    {
        public AbsenceRecord() { }
        
        public AbsenceRecord(string id, bool archived, TDMemberProfile member, string icon, DateTime since, DateTime till, bool available, Dictionary<string, CFValue> customFields, AbsenceReasonRecord? reason = null, string? description = null, TDLocation? location = null, AbsenceApproval? approval = null)
        {
            Id = id;
            IsArchived = archived;
            Member = member;
            Icon = icon;
            Reason = reason;
            Description = description;
            Since = since;
            Till = till;
            Location = location;
            IsAvailable = available;
            Approval = approval;
            CustomFields = customFields;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(AbsenceRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(AbsenceRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile> _member = new PropertyValue<TDMemberProfile>(nameof(AbsenceRecord), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public TDMemberProfile Member
        {
            get { return _member.GetValue(); }
            set { _member.SetValue(value); }
        }
    
        private PropertyValue<string> _icon = new PropertyValue<string>(nameof(AbsenceRecord), nameof(Icon));
        
        [Required]
        [JsonPropertyName("icon")]
        public string Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        private PropertyValue<AbsenceReasonRecord?> _reason = new PropertyValue<AbsenceReasonRecord?>(nameof(AbsenceRecord), nameof(Reason));
        
        [JsonPropertyName("reason")]
        public AbsenceReasonRecord? Reason
        {
            get { return _reason.GetValue(); }
            set { _reason.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(AbsenceRecord), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<DateTime> _since = new PropertyValue<DateTime>(nameof(AbsenceRecord), nameof(Since));
        
        [Required]
        [JsonPropertyName("since")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<DateTime> _till = new PropertyValue<DateTime>(nameof(AbsenceRecord), nameof(Till));
        
        [Required]
        [JsonPropertyName("till")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<TDLocation?> _location = new PropertyValue<TDLocation?>(nameof(AbsenceRecord), nameof(Location));
        
        [JsonPropertyName("location")]
        public TDLocation? Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        private PropertyValue<bool> _available = new PropertyValue<bool>(nameof(AbsenceRecord), nameof(IsAvailable));
        
        [Required]
        [JsonPropertyName("available")]
        public bool IsAvailable
        {
            get { return _available.GetValue(); }
            set { _available.SetValue(value); }
        }
    
        private PropertyValue<AbsenceApproval?> _approval = new PropertyValue<AbsenceApproval?>(nameof(AbsenceRecord), nameof(Approval));
        
        [JsonPropertyName("approval")]
        public AbsenceApproval? Approval
        {
            get { return _approval.GetValue(); }
            set { _approval.SetValue(value); }
        }
    
        private PropertyValue<Dictionary<string, CFValue>> _customFields = new PropertyValue<Dictionary<string, CFValue>>(nameof(AbsenceRecord), nameof(CustomFields));
        
        [Required]
        [JsonPropertyName("customFields")]
        public Dictionary<string, CFValue> CustomFields
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

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
    public sealed class CalendarEventSpecDto
         : IPropagatePropertyAccessPath
    {
        public CalendarEventSpecDto() { }
        
        public CalendarEventSpecDto(SpaceTime start, SpaceTime end, bool allDay, ATimeZoneDto timezone, RecurrenceRuleDto? recurrenceRule = null, string? parentId = null)
        {
            Start = start;
            End = end;
            RecurrenceRule = recurrenceRule;
            AllDay = allDay;
            Timezone = timezone;
            ParentId = parentId;
        }
        
        private PropertyValue<SpaceTime> _start = new PropertyValue<SpaceTime>(nameof(CalendarEventSpecDto), nameof(Start));
        
        [Required]
        [JsonPropertyName("start")]
        public SpaceTime Start
        {
            get { return _start.GetValue(); }
            set { _start.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _end = new PropertyValue<SpaceTime>(nameof(CalendarEventSpecDto), nameof(End));
        
        [Required]
        [JsonPropertyName("end")]
        public SpaceTime End
        {
            get { return _end.GetValue(); }
            set { _end.SetValue(value); }
        }
    
        private PropertyValue<RecurrenceRuleDto?> _recurrenceRule = new PropertyValue<RecurrenceRuleDto?>(nameof(CalendarEventSpecDto), nameof(RecurrenceRule));
        
        [JsonPropertyName("recurrenceRule")]
        public RecurrenceRuleDto? RecurrenceRule
        {
            get { return _recurrenceRule.GetValue(); }
            set { _recurrenceRule.SetValue(value); }
        }
    
        private PropertyValue<bool> _allDay = new PropertyValue<bool>(nameof(CalendarEventSpecDto), nameof(AllDay));
        
        [Required]
        [JsonPropertyName("allDay")]
        public bool AllDay
        {
            get { return _allDay.GetValue(); }
            set { _allDay.SetValue(value); }
        }
    
        private PropertyValue<ATimeZoneDto> _timezone = new PropertyValue<ATimeZoneDto>(nameof(CalendarEventSpecDto), nameof(Timezone));
        
        [Required]
        [JsonPropertyName("timezone")]
        public ATimeZoneDto Timezone
        {
            get { return _timezone.GetValue(); }
            set { _timezone.SetValue(value); }
        }
    
        private PropertyValue<string?> _parentId = new PropertyValue<string?>(nameof(CalendarEventSpecDto), nameof(ParentId));
        
        [JsonPropertyName("parentId")]
        public string? ParentId
        {
            get { return _parentId.GetValue(); }
            set { _parentId.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _start.SetAccessPath(path, validateHasBeenSet);
            _end.SetAccessPath(path, validateHasBeenSet);
            _recurrenceRule.SetAccessPath(path, validateHasBeenSet);
            _allDay.SetAccessPath(path, validateHasBeenSet);
            _timezone.SetAccessPath(path, validateHasBeenSet);
            _parentId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

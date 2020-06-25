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
    public sealed class RecurrenceRuleFreqWeeklyDto
         : RecurrenceRuleFreqDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "RecurrenceRuleFreq.Weekly";
        
        public RecurrenceRuleFreqWeeklyDto() { }
        
        public RecurrenceRuleFreqWeeklyDto(List<Weekday> weekdays, int interval)
        {
            Weekdays = weekdays;
            Interval = interval;
        }
        
        private PropertyValue<List<Weekday>> _weekdays = new PropertyValue<List<Weekday>>(nameof(RecurrenceRuleFreqWeeklyDto), nameof(Weekdays));
        
        [Required]
        [JsonPropertyName("weekdays")]
        public List<Weekday> Weekdays
        {
            get { return _weekdays.GetValue(); }
            set { _weekdays.SetValue(value); }
        }
    
        private PropertyValue<int> _interval = new PropertyValue<int>(nameof(RecurrenceRuleFreqWeeklyDto), nameof(Interval));
        
        [Required]
        [JsonPropertyName("interval")]
        public int Interval
        {
            get { return _interval.GetValue(); }
            set { _interval.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _weekdays.SetAccessPath(path, validateHasBeenSet);
            _interval.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

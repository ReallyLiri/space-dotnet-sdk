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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class RecurrenceRuleFreqWeekly
     : RecurrenceRuleFreq, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "RecurrenceRuleFreq.Weekly";
    
    public RecurrenceRuleFreqWeekly() { }
    
    public RecurrenceRuleFreqWeekly(List<Weekday> weekdays, int interval)
    {
        Weekdays = weekdays;
        Interval = interval;
    }
    
    private PropertyValue<List<Weekday>> _weekdays = new PropertyValue<List<Weekday>>(nameof(RecurrenceRuleFreqWeekly), nameof(Weekdays), new List<Weekday>());
    
    [Required]
    [JsonPropertyName("weekdays")]
    public List<Weekday> Weekdays
    {
        get => _weekdays.GetValue();
        set => _weekdays.SetValue(value);
    }

    private PropertyValue<int> _interval = new PropertyValue<int>(nameof(RecurrenceRuleFreqWeekly), nameof(Interval));
    
    [Required]
    [JsonPropertyName("interval")]
    public int Interval
    {
        get => _interval.GetValue();
        set => _interval.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _weekdays.SetAccessPath(path, validateHasBeenSet);
        _interval.SetAccessPath(path, validateHasBeenSet);
    }

}


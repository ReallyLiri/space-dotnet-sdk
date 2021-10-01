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

public class TeamDirectoryProfilesForProfileWorkingDaysPostRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryProfilesForProfileWorkingDaysPostRequest() { }
    
    public TeamDirectoryProfilesForProfileWorkingDaysPostRequest(WorkingDaysSpec workingDaysSpec, DateTime? dateStart = null, DateTime? dateEnd = null)
    {
        DateStart = dateStart;
        DateEnd = dateEnd;
        WorkingDaysSpec = workingDaysSpec;
    }
    
    private PropertyValue<DateTime?> _dateStart = new PropertyValue<DateTime?>(nameof(TeamDirectoryProfilesForProfileWorkingDaysPostRequest), nameof(DateStart));
    
    [JsonPropertyName("dateStart")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? DateStart
    {
        get => _dateStart.GetValue();
        set => _dateStart.SetValue(value);
    }

    private PropertyValue<DateTime?> _dateEnd = new PropertyValue<DateTime?>(nameof(TeamDirectoryProfilesForProfileWorkingDaysPostRequest), nameof(DateEnd));
    
    [JsonPropertyName("dateEnd")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? DateEnd
    {
        get => _dateEnd.GetValue();
        set => _dateEnd.SetValue(value);
    }

    private PropertyValue<WorkingDaysSpec> _workingDaysSpec = new PropertyValue<WorkingDaysSpec>(nameof(TeamDirectoryProfilesForProfileWorkingDaysPostRequest), nameof(WorkingDaysSpec));
    
    [Required]
    [JsonPropertyName("workingDaysSpec")]
    public WorkingDaysSpec WorkingDaysSpec
    {
        get => _workingDaysSpec.GetValue();
        set => _workingDaysSpec.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _dateStart.SetAccessPath(path, validateHasBeenSet);
        _dateEnd.SetAccessPath(path, validateHasBeenSet);
        _workingDaysSpec.SetAccessPath(path, validateHasBeenSet);
    }

}


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

public sealed class TDMergedEvent
     : IPropagatePropertyAccessPath
{
    public TDMergedEvent() { }
    
    public TDMergedEvent(List<Pair<TDMembership, int>> events, TDMemberProfile profile)
    {
        Events = events;
        Profile = profile;
    }
    
    private PropertyValue<List<Pair<TDMembership, int>>> _events = new PropertyValue<List<Pair<TDMembership, int>>>(nameof(TDMergedEvent), nameof(Events), new List<Pair<TDMembership, int>>());
    
    [Required]
    [JsonPropertyName("events")]
    public List<Pair<TDMembership, int>> Events
    {
        get => _events.GetValue();
        set => _events.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(TDMergedEvent), nameof(Profile));
    
    [Required]
    [JsonPropertyName("profile")]
    public TDMemberProfile Profile
    {
        get => _profile.GetValue();
        set => _profile.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _events.SetAccessPath(path, validateHasBeenSet);
        _profile.SetAccessPath(path, validateHasBeenSet);
    }

}


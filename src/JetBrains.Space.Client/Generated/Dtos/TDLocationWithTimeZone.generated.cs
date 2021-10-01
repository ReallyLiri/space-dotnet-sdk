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

public sealed class TDLocationWithTimeZone
     : IPropagatePropertyAccessPath
{
    public TDLocationWithTimeZone() { }
    
    public TDLocationWithTimeZone(string id, string name, ATimeZoneWithOffset timezone)
    {
        Id = id;
        Name = name;
        Timezone = timezone;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDLocationWithTimeZone), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(TDLocationWithTimeZone), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<ATimeZoneWithOffset> _timezone = new PropertyValue<ATimeZoneWithOffset>(nameof(TDLocationWithTimeZone), nameof(Timezone));
    
    [Required]
    [JsonPropertyName("timezone")]
    public ATimeZoneWithOffset Timezone
    {
        get => _timezone.GetValue();
        set => _timezone.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _timezone.SetAccessPath(path, validateHasBeenSet);
    }

}


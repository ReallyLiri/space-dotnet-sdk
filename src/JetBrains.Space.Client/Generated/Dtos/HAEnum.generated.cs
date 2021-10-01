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

public sealed class HAEnum
     : IPropagatePropertyAccessPath
{
    public HAEnum() { }
    
    public HAEnum(string id, string name, List<string> values, HADeprecation? deprecation = null)
    {
        Id = id;
        Name = name;
        Values = values;
        Deprecation = deprecation;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(HAEnum), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(HAEnum), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<List<string>> _values = new PropertyValue<List<string>>(nameof(HAEnum), nameof(Values), new List<string>());
    
    [Required]
    [JsonPropertyName("values")]
    public List<string> Values
    {
        get => _values.GetValue();
        set => _values.SetValue(value);
    }

    private PropertyValue<HADeprecation?> _deprecation = new PropertyValue<HADeprecation?>(nameof(HAEnum), nameof(Deprecation));
    
    [JsonPropertyName("deprecation")]
    public HADeprecation? Deprecation
    {
        get => _deprecation.GetValue();
        set => _deprecation.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _values.SetAccessPath(path, validateHasBeenSet);
        _deprecation.SetAccessPath(path, validateHasBeenSet);
    }

}


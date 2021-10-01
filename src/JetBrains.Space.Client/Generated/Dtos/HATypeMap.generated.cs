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

public sealed class HATypeMap
     : HAType, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "HA_Type.Map";
    
    public HATypeMap() { }
    
    public HATypeMap(HAType valueType, bool nullable, List<string> tags)
    {
        ValueType = valueType;
        IsNullable = nullable;
        Tags = tags;
    }
    
    private PropertyValue<HAType> _valueType = new PropertyValue<HAType>(nameof(HATypeMap), nameof(ValueType));
    
    [Required]
    [JsonPropertyName("valueType")]
    public HAType ValueType
    {
        get => _valueType.GetValue();
        set => _valueType.SetValue(value);
    }

    private PropertyValue<bool> _nullable = new PropertyValue<bool>(nameof(HATypeMap), nameof(IsNullable));
    
    [Required]
    [JsonPropertyName("nullable")]
    public bool IsNullable
    {
        get => _nullable.GetValue();
        set => _nullable.SetValue(value);
    }

    private PropertyValue<List<string>> _tags = new PropertyValue<List<string>>(nameof(HATypeMap), nameof(Tags), new List<string>());
    
    [Required]
    [JsonPropertyName("tags")]
    public List<string> Tags
    {
        get => _tags.GetValue();
        set => _tags.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _valueType.SetAccessPath(path, validateHasBeenSet);
        _nullable.SetAccessPath(path, validateHasBeenSet);
        _tags.SetAccessPath(path, validateHasBeenSet);
    }

}


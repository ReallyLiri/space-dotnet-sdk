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

public sealed class HATypeArray
     : HAType, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "HA_Type.Array";
    
    public HATypeArray() { }
    
    public HATypeArray(HAType elementType, bool nullable, List<string> tags)
    {
        ElementType = elementType;
        IsNullable = nullable;
        Tags = tags;
    }
    
    private PropertyValue<HAType> _elementType = new PropertyValue<HAType>(nameof(HATypeArray), nameof(ElementType));
    
    [Required]
    [JsonPropertyName("elementType")]
    public HAType ElementType
    {
        get => _elementType.GetValue();
        set => _elementType.SetValue(value);
    }

    private PropertyValue<bool> _nullable = new PropertyValue<bool>(nameof(HATypeArray), nameof(IsNullable));
    
    [Required]
    [JsonPropertyName("nullable")]
    public bool IsNullable
    {
        get => _nullable.GetValue();
        set => _nullable.SetValue(value);
    }

    private PropertyValue<List<string>> _tags = new PropertyValue<List<string>>(nameof(HATypeArray), nameof(Tags), new List<string>());
    
    [Required]
    [JsonPropertyName("tags")]
    public List<string> Tags
    {
        get => _tags.GetValue();
        set => _tags.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _elementType.SetAccessPath(path, validateHasBeenSet);
        _nullable.SetAccessPath(path, validateHasBeenSet);
        _tags.SetAccessPath(path, validateHasBeenSet);
    }

}


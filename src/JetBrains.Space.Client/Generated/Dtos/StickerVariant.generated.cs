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

public sealed class StickerVariant
     : IPropagatePropertyAccessPath
{
    public StickerVariant() { }
    
    public StickerVariant(string id, int width, int height, string? name = null)
    {
        Id = id;
        Name = name;
        Width = width;
        Height = height;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(StickerVariant), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(StickerVariant), nameof(Name));
    
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<int> _width = new PropertyValue<int>(nameof(StickerVariant), nameof(Width));
    
    [Required]
    [JsonPropertyName("width")]
    public int Width
    {
        get => _width.GetValue();
        set => _width.SetValue(value);
    }

    private PropertyValue<int> _height = new PropertyValue<int>(nameof(StickerVariant), nameof(Height));
    
    [Required]
    [JsonPropertyName("height")]
    public int Height
    {
        get => _height.GetValue();
        set => _height.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _width.SetAccessPath(path, validateHasBeenSet);
        _height.SetAccessPath(path, validateHasBeenSet);
    }

}


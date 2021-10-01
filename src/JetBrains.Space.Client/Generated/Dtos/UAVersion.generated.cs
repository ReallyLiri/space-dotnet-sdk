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

public sealed class UAVersion
     : IPropagatePropertyAccessPath
{
    public UAVersion() { }
    
    public UAVersion(int major, int minor)
    {
        Major = major;
        Minor = minor;
    }
    
    private PropertyValue<int> _major = new PropertyValue<int>(nameof(UAVersion), nameof(Major));
    
    [Required]
    [JsonPropertyName("major")]
    public int Major
    {
        get => _major.GetValue();
        set => _major.SetValue(value);
    }

    private PropertyValue<int> _minor = new PropertyValue<int>(nameof(UAVersion), nameof(Minor));
    
    [Required]
    [JsonPropertyName("minor")]
    public int Minor
    {
        get => _minor.GetValue();
        set => _minor.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _major.SetAccessPath(path, validateHasBeenSet);
        _minor.SetAccessPath(path, validateHasBeenSet);
    }

}


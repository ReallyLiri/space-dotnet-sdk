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

public sealed class EventConferenceData
     : IPropagatePropertyAccessPath
{
    public EventConferenceData() { }
    
    public EventConferenceData(EventConferenceKind kind, string? url = null)
    {
        Kind = kind;
        Url = url;
    }
    
    private PropertyValue<EventConferenceKind> _kind = new PropertyValue<EventConferenceKind>(nameof(EventConferenceData), nameof(Kind));
    
    [Required]
    [JsonPropertyName("kind")]
    public EventConferenceKind Kind
    {
        get => _kind.GetValue();
        set => _kind.SetValue(value);
    }

    private PropertyValue<string?> _url = new PropertyValue<string?>(nameof(EventConferenceData), nameof(Url));
    
    [JsonPropertyName("url")]
    public string? Url
    {
        get => _url.GetValue();
        set => _url.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _kind.SetAccessPath(path, validateHasBeenSet);
        _url.SetAccessPath(path, validateHasBeenSet);
    }

}


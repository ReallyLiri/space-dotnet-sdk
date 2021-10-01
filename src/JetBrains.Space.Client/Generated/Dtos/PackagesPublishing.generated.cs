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

public sealed class PackagesPublishing
     : IPropagatePropertyAccessPath
{
    public PackagesPublishing() { }
    
    public PackagesPublishing(string publishingId, long created, bool successful, long? started = null, long? completed = null, string? error = null, CPrincipal? principal = null)
    {
        PublishingId = publishingId;
        Created = created;
        Started = started;
        Completed = completed;
        IsSuccessful = successful;
        Error = error;
        Principal = principal;
    }
    
    private PropertyValue<string> _publishingId = new PropertyValue<string>(nameof(PackagesPublishing), nameof(PublishingId));
    
    [Required]
    [JsonPropertyName("publishingId")]
    public string PublishingId
    {
        get => _publishingId.GetValue();
        set => _publishingId.SetValue(value);
    }

    private PropertyValue<long> _created = new PropertyValue<long>(nameof(PackagesPublishing), nameof(Created));
    
    [Required]
    [JsonPropertyName("created")]
    public long Created
    {
        get => _created.GetValue();
        set => _created.SetValue(value);
    }

    private PropertyValue<long?> _started = new PropertyValue<long?>(nameof(PackagesPublishing), nameof(Started));
    
    [JsonPropertyName("started")]
    public long? Started
    {
        get => _started.GetValue();
        set => _started.SetValue(value);
    }

    private PropertyValue<long?> _completed = new PropertyValue<long?>(nameof(PackagesPublishing), nameof(Completed));
    
    [JsonPropertyName("completed")]
    public long? Completed
    {
        get => _completed.GetValue();
        set => _completed.SetValue(value);
    }

    private PropertyValue<bool> _successful = new PropertyValue<bool>(nameof(PackagesPublishing), nameof(IsSuccessful));
    
    [Required]
    [JsonPropertyName("successful")]
    public bool IsSuccessful
    {
        get => _successful.GetValue();
        set => _successful.SetValue(value);
    }

    private PropertyValue<string?> _error = new PropertyValue<string?>(nameof(PackagesPublishing), nameof(Error));
    
    [JsonPropertyName("error")]
    public string? Error
    {
        get => _error.GetValue();
        set => _error.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _principal = new PropertyValue<CPrincipal?>(nameof(PackagesPublishing), nameof(Principal));
    
    [JsonPropertyName("principal")]
    public CPrincipal? Principal
    {
        get => _principal.GetValue();
        set => _principal.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _publishingId.SetAccessPath(path, validateHasBeenSet);
        _created.SetAccessPath(path, validateHasBeenSet);
        _started.SetAccessPath(path, validateHasBeenSet);
        _completed.SetAccessPath(path, validateHasBeenSet);
        _successful.SetAccessPath(path, validateHasBeenSet);
        _error.SetAccessPath(path, validateHasBeenSet);
        _principal.SetAccessPath(path, validateHasBeenSet);
    }

}


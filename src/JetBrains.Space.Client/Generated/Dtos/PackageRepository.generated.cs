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

public sealed class PackageRepository
     : IPropagatePropertyAccessPath
{
    public PackageRepository() { }
    
    public PackageRepository(string id, PackageType type, bool @public, PackageRepositoryMode mode, bool archived, string? name = null, string? description = null, ESPackageRepositorySettings? settings = null)
    {
        Id = id;
        Type = type;
        Name = name;
        Description = description;
        IsPublic = @public;
        Settings = settings;
        Mode = mode;
        IsArchived = archived;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(PackageRepository), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(PackageRepository), nameof(Type));
    
    [Required]
    [JsonPropertyName("type")]
    public PackageType Type
    {
        get => _type.GetValue();
        set => _type.SetValue(value);
    }

    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(PackageRepository), nameof(Name));
    
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(PackageRepository), nameof(Description));
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    private PropertyValue<bool> _public = new PropertyValue<bool>(nameof(PackageRepository), nameof(IsPublic));
    
    [Required]
    [JsonPropertyName("public")]
    public bool IsPublic
    {
        get => _public.GetValue();
        set => _public.SetValue(value);
    }

    private PropertyValue<ESPackageRepositorySettings?> _settings = new PropertyValue<ESPackageRepositorySettings?>(nameof(PackageRepository), nameof(Settings));
    
    [JsonPropertyName("settings")]
    public ESPackageRepositorySettings? Settings
    {
        get => _settings.GetValue();
        set => _settings.SetValue(value);
    }

    private PropertyValue<PackageRepositoryMode> _mode = new PropertyValue<PackageRepositoryMode>(nameof(PackageRepository), nameof(Mode));
    
    [Required]
    [JsonPropertyName("mode")]
    public PackageRepositoryMode Mode
    {
        get => _mode.GetValue();
        set => _mode.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(PackageRepository), nameof(IsArchived));
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue();
        set => _archived.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _type.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
        _public.SetAccessPath(path, validateHasBeenSet);
        _settings.SetAccessPath(path, validateHasBeenSet);
        _mode.SetAccessPath(path, validateHasBeenSet);
        _archived.SetAccessPath(path, validateHasBeenSet);
    }

}


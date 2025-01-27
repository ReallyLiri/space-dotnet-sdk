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

public sealed class DashboardPreferencesRecord
     : IPropagatePropertyAccessPath
{
    public DashboardPreferencesRecord() { }
    
    public DashboardPreferencesRecord(string id, bool archived, List<List<DashboardItemData>>? data = null, DashboardContainerType? type = null)
    {
        Id = id;
        IsArchived = archived;
        Data = data;
        Type = type;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(DashboardPreferencesRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(DashboardPreferencesRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<List<List<DashboardItemData>>?> _data = new PropertyValue<List<List<DashboardItemData>>?>(nameof(DashboardPreferencesRecord), nameof(Data), "data");
    
    [JsonPropertyName("data")]
    public List<List<DashboardItemData>>? Data
    {
        get => _data.GetValue(InlineErrors);
        set => _data.SetValue(value);
    }

    private PropertyValue<DashboardContainerType?> _type = new PropertyValue<DashboardContainerType?>(nameof(DashboardPreferencesRecord), nameof(Type), "type");
    
    [JsonPropertyName("type")]
    public DashboardContainerType? Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _data.SetAccessPath(parentChainPath, validateHasBeenSet);
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


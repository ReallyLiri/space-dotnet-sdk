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

public sealed class EventSubjectInfoDTO
     : IPropagatePropertyAccessPath
{
    public EventSubjectInfoDTO() { }
    
    public EventSubjectInfoDTO(string code, string name, string description, List<EventTypeInfoDTO> events, List<SubscriptionFilter> defaultFilters, string? parentCode = null, string? featureFlag = null)
    {
        Code = code;
        ParentCode = parentCode;
        Name = name;
        Description = description;
        Events = events;
        DefaultFilters = defaultFilters;
        FeatureFlag = featureFlag;
    }
    
    private PropertyValue<string> _code = new PropertyValue<string>(nameof(EventSubjectInfoDTO), nameof(Code), "code");
    
    [Required]
    [JsonPropertyName("code")]
    public string Code
    {
        get => _code.GetValue(InlineErrors);
        set => _code.SetValue(value);
    }

    private PropertyValue<string?> _parentCode = new PropertyValue<string?>(nameof(EventSubjectInfoDTO), nameof(ParentCode), "parentCode");
    
    [JsonPropertyName("parentCode")]
    public string? ParentCode
    {
        get => _parentCode.GetValue(InlineErrors);
        set => _parentCode.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(EventSubjectInfoDTO), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _description = new PropertyValue<string>(nameof(EventSubjectInfoDTO), nameof(Description), "description");
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<List<EventTypeInfoDTO>> _events = new PropertyValue<List<EventTypeInfoDTO>>(nameof(EventSubjectInfoDTO), nameof(Events), "events", new List<EventTypeInfoDTO>());
    
    [Required]
    [JsonPropertyName("events")]
    public List<EventTypeInfoDTO> Events
    {
        get => _events.GetValue(InlineErrors);
        set => _events.SetValue(value);
    }

    private PropertyValue<List<SubscriptionFilter>> _defaultFilters = new PropertyValue<List<SubscriptionFilter>>(nameof(EventSubjectInfoDTO), nameof(DefaultFilters), "defaultFilters", new List<SubscriptionFilter>());
    
    [Required]
    [JsonPropertyName("defaultFilters")]
    public List<SubscriptionFilter> DefaultFilters
    {
        get => _defaultFilters.GetValue(InlineErrors);
        set => _defaultFilters.SetValue(value);
    }

    private PropertyValue<string?> _featureFlag = new PropertyValue<string?>(nameof(EventSubjectInfoDTO), nameof(FeatureFlag), "featureFlag");
    
    [JsonPropertyName("featureFlag")]
    public string? FeatureFlag
    {
        get => _featureFlag.GetValue(InlineErrors);
        set => _featureFlag.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _code.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parentCode.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _events.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultFilters.SetAccessPath(parentChainPath, validateHasBeenSet);
        _featureFlag.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


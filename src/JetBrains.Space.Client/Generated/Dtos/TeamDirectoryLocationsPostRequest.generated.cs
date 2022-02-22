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

public class TeamDirectoryLocationsPostRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryLocationsPostRequest() { }
    
    public TeamDirectoryLocationsPostRequest(string name, string? timezone = null, List<int>? workdays = null, List<string>? phones = null, List<string>? emails = null, List<string>? equipment = null, string? description = null, string? address = null, string? type = null, string? parentId = null, int? capacity = null)
    {
        Name = name;
        Timezone = timezone;
        Workdays = workdays;
        Phones = phones;
        Emails = emails;
        Equipment = equipment;
        Description = description;
        Address = address;
        Type = type;
        ParentId = parentId;
        Capacity = capacity;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(TeamDirectoryLocationsPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _timezone = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Timezone), "timezone");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("timezone")]
    public string? Timezone
    {
        get => _timezone.GetValue(InlineErrors);
        set => _timezone.SetValue(value);
    }

    private PropertyValue<List<int>?> _workdays = new PropertyValue<List<int>?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Workdays), "workdays");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("workdays")]
    public List<int>? Workdays
    {
        get => _workdays.GetValue(InlineErrors);
        set => _workdays.SetValue(value);
    }

    private PropertyValue<List<string>?> _phones = new PropertyValue<List<string>?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Phones), "phones");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("phones")]
    public List<string>? Phones
    {
        get => _phones.GetValue(InlineErrors);
        set => _phones.SetValue(value);
    }

    private PropertyValue<List<string>?> _emails = new PropertyValue<List<string>?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Emails), "emails");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("emails")]
    public List<string>? Emails
    {
        get => _emails.GetValue(InlineErrors);
        set => _emails.SetValue(value);
    }

    private PropertyValue<List<string>?> _equipment = new PropertyValue<List<string>?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Equipment), "equipment");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("equipment")]
    public List<string>? Equipment
    {
        get => _equipment.GetValue(InlineErrors);
        set => _equipment.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _address = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Address), "address");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("address")]
    public string? Address
    {
        get => _address.GetValue(InlineErrors);
        set => _address.SetValue(value);
    }

    private PropertyValue<string?> _type = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Type), "type");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("type")]
    public string? Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string?> _parentId = new PropertyValue<string?>(nameof(TeamDirectoryLocationsPostRequest), nameof(ParentId), "parentId");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("parentId")]
    public string? ParentId
    {
        get => _parentId.GetValue(InlineErrors);
        set => _parentId.SetValue(value);
    }

    private PropertyValue<int?> _capacity = new PropertyValue<int?>(nameof(TeamDirectoryLocationsPostRequest), nameof(Capacity), "capacity");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("capacity")]
    public int? Capacity
    {
        get => _capacity.GetValue(InlineErrors);
        set => _capacity.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _timezone.SetAccessPath(parentChainPath, validateHasBeenSet);
        _workdays.SetAccessPath(parentChainPath, validateHasBeenSet);
        _phones.SetAccessPath(parentChainPath, validateHasBeenSet);
        _emails.SetAccessPath(parentChainPath, validateHasBeenSet);
        _equipment.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _address.SetAccessPath(parentChainPath, validateHasBeenSet);
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parentId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _capacity.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


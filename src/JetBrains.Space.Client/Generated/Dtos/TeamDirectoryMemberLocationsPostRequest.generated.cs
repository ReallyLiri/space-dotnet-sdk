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

public class TeamDirectoryMemberLocationsPostRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryMemberLocationsPostRequest() { }
    
    public TeamDirectoryMemberLocationsPostRequest(ProfileIdentifier member, string location, DateTime? since = null, DateTime? till = null, string? previousLocation = null)
    {
        Member = member;
        Location = location;
        Since = since;
        Till = till;
        PreviousLocation = previousLocation;
    }
    
    private PropertyValue<ProfileIdentifier> _member = new PropertyValue<ProfileIdentifier>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(Member), "member");
    
    [Required]
    [JsonPropertyName("member")]
    public ProfileIdentifier Member
    {
        get => _member.GetValue(InlineErrors);
        set => _member.SetValue(value);
    }

    private PropertyValue<string> _location = new PropertyValue<string>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(Location), "location");
    
    [Required]
    [JsonPropertyName("location")]
    public string Location
    {
        get => _location.GetValue(InlineErrors);
        set => _location.SetValue(value);
    }

    private PropertyValue<DateTime?> _since = new PropertyValue<DateTime?>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(Since), "since");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("since")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? Since
    {
        get => _since.GetValue(InlineErrors);
        set => _since.SetValue(value);
    }

    private PropertyValue<DateTime?> _till = new PropertyValue<DateTime?>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(Till), "till");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("till")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? Till
    {
        get => _till.GetValue(InlineErrors);
        set => _till.SetValue(value);
    }

    private PropertyValue<string?> _previousLocation = new PropertyValue<string?>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(PreviousLocation), "previousLocation");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("previousLocation")]
    public string? PreviousLocation
    {
        get => _previousLocation.GetValue(InlineErrors);
        set => _previousLocation.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _member.SetAccessPath(parentChainPath, validateHasBeenSet);
        _location.SetAccessPath(parentChainPath, validateHasBeenSet);
        _since.SetAccessPath(parentChainPath, validateHasBeenSet);
        _till.SetAccessPath(parentChainPath, validateHasBeenSet);
        _previousLocation.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


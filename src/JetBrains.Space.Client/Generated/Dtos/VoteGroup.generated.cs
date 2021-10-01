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

public sealed class VoteGroup
     : IPropagatePropertyAccessPath
{
    public VoteGroup() { }
    
    public VoteGroup(string variantName, int count, bool meVote, List<TDMemberProfile> lastUsers, TDMemberProfile? owner = null)
    {
        VariantName = variantName;
        Count = count;
        IsMeVote = meVote;
        LastUsers = lastUsers;
        Owner = owner;
    }
    
    private PropertyValue<string> _variantName = new PropertyValue<string>(nameof(VoteGroup), nameof(VariantName));
    
    [Required]
    [JsonPropertyName("variantName")]
    public string VariantName
    {
        get => _variantName.GetValue();
        set => _variantName.SetValue(value);
    }

    private PropertyValue<int> _count = new PropertyValue<int>(nameof(VoteGroup), nameof(Count));
    
    [Required]
    [JsonPropertyName("count")]
    public int Count
    {
        get => _count.GetValue();
        set => _count.SetValue(value);
    }

    private PropertyValue<bool> _meVote = new PropertyValue<bool>(nameof(VoteGroup), nameof(IsMeVote));
    
    [Required]
    [JsonPropertyName("meVote")]
    public bool IsMeVote
    {
        get => _meVote.GetValue();
        set => _meVote.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _lastUsers = new PropertyValue<List<TDMemberProfile>>(nameof(VoteGroup), nameof(LastUsers), new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("lastUsers")]
    public List<TDMemberProfile> LastUsers
    {
        get => _lastUsers.GetValue();
        set => _lastUsers.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _owner = new PropertyValue<TDMemberProfile?>(nameof(VoteGroup), nameof(Owner));
    
    [JsonPropertyName("owner")]
    public TDMemberProfile? Owner
    {
        get => _owner.GetValue();
        set => _owner.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _variantName.SetAccessPath(path, validateHasBeenSet);
        _count.SetAccessPath(path, validateHasBeenSet);
        _meVote.SetAccessPath(path, validateHasBeenSet);
        _lastUsers.SetAccessPath(path, validateHasBeenSet);
        _owner.SetAccessPath(path, validateHasBeenSet);
    }

}


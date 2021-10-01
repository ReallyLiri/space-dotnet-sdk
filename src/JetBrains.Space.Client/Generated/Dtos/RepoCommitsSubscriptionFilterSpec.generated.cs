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

public sealed class RepoCommitsSubscriptionFilterSpec
     : IPropagatePropertyAccessPath
{
    public RepoCommitsSubscriptionFilterSpec() { }
    
    public RepoCommitsSubscriptionFilterSpec(List<string> authors, List<string> committers, List<string> branchSpec, string pathSpec, string messageRegex)
    {
        Authors = authors;
        Committers = committers;
        BranchSpec = branchSpec;
        PathSpec = pathSpec;
        MessageRegex = messageRegex;
    }
    
    private PropertyValue<List<string>> _authors = new PropertyValue<List<string>>(nameof(RepoCommitsSubscriptionFilterSpec), nameof(Authors), new List<string>());
    
    [Required]
    [JsonPropertyName("authors")]
    public List<string> Authors
    {
        get => _authors.GetValue();
        set => _authors.SetValue(value);
    }

    private PropertyValue<List<string>> _committers = new PropertyValue<List<string>>(nameof(RepoCommitsSubscriptionFilterSpec), nameof(Committers), new List<string>());
    
    [Required]
    [JsonPropertyName("committers")]
    public List<string> Committers
    {
        get => _committers.GetValue();
        set => _committers.SetValue(value);
    }

    private PropertyValue<List<string>> _branchSpec = new PropertyValue<List<string>>(nameof(RepoCommitsSubscriptionFilterSpec), nameof(BranchSpec), new List<string>());
    
    [Required]
    [JsonPropertyName("branchSpec")]
    public List<string> BranchSpec
    {
        get => _branchSpec.GetValue();
        set => _branchSpec.SetValue(value);
    }

    private PropertyValue<string> _pathSpec = new PropertyValue<string>(nameof(RepoCommitsSubscriptionFilterSpec), nameof(PathSpec));
    
    [Required]
    [JsonPropertyName("pathSpec")]
    public string PathSpec
    {
        get => _pathSpec.GetValue();
        set => _pathSpec.SetValue(value);
    }

    private PropertyValue<string> _messageRegex = new PropertyValue<string>(nameof(RepoCommitsSubscriptionFilterSpec), nameof(MessageRegex));
    
    [Required]
    [JsonPropertyName("messageRegex")]
    public string MessageRegex
    {
        get => _messageRegex.GetValue();
        set => _messageRegex.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _authors.SetAccessPath(path, validateHasBeenSet);
        _committers.SetAccessPath(path, validateHasBeenSet);
        _branchSpec.SetAccessPath(path, validateHasBeenSet);
        _pathSpec.SetAccessPath(path, validateHasBeenSet);
        _messageRegex.SetAccessPath(path, validateHasBeenSet);
    }

}


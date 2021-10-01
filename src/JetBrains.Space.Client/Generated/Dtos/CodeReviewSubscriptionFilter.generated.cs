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

public sealed class CodeReviewSubscriptionFilter
     : SubscriptionFilter, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "CodeReviewSubscriptionFilter";
    
    public CodeReviewSubscriptionFilter() { }
    
    public CodeReviewSubscriptionFilter(List<TDMemberProfile> authors, List<TDMemberProfile> participants, List<string> branchSpec, List<string> pathSpec, string titleRegex, PRProject? project = null, string? repository = null)
    {
        Project = project;
        Repository = repository;
        Authors = authors;
        Participants = participants;
        BranchSpec = branchSpec;
        PathSpec = pathSpec;
        TitleRegex = titleRegex;
    }
    
    private PropertyValue<PRProject?> _project = new PropertyValue<PRProject?>(nameof(CodeReviewSubscriptionFilter), nameof(Project));
    
    [JsonPropertyName("project")]
    public PRProject? Project
    {
        get => _project.GetValue();
        set => _project.SetValue(value);
    }

    private PropertyValue<string?> _repository = new PropertyValue<string?>(nameof(CodeReviewSubscriptionFilter), nameof(Repository));
    
    [JsonPropertyName("repository")]
    public string? Repository
    {
        get => _repository.GetValue();
        set => _repository.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _authors = new PropertyValue<List<TDMemberProfile>>(nameof(CodeReviewSubscriptionFilter), nameof(Authors), new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("authors")]
    public List<TDMemberProfile> Authors
    {
        get => _authors.GetValue();
        set => _authors.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _participants = new PropertyValue<List<TDMemberProfile>>(nameof(CodeReviewSubscriptionFilter), nameof(Participants), new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("participants")]
    public List<TDMemberProfile> Participants
    {
        get => _participants.GetValue();
        set => _participants.SetValue(value);
    }

    private PropertyValue<List<string>> _branchSpec = new PropertyValue<List<string>>(nameof(CodeReviewSubscriptionFilter), nameof(BranchSpec), new List<string>());
    
    [Required]
    [JsonPropertyName("branchSpec")]
    public List<string> BranchSpec
    {
        get => _branchSpec.GetValue();
        set => _branchSpec.SetValue(value);
    }

    private PropertyValue<List<string>> _pathSpec = new PropertyValue<List<string>>(nameof(CodeReviewSubscriptionFilter), nameof(PathSpec), new List<string>());
    
    [Required]
    [JsonPropertyName("pathSpec")]
    public List<string> PathSpec
    {
        get => _pathSpec.GetValue();
        set => _pathSpec.SetValue(value);
    }

    private PropertyValue<string> _titleRegex = new PropertyValue<string>(nameof(CodeReviewSubscriptionFilter), nameof(TitleRegex));
    
    [Required]
    [JsonPropertyName("titleRegex")]
    public string TitleRegex
    {
        get => _titleRegex.GetValue();
        set => _titleRegex.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _project.SetAccessPath(path, validateHasBeenSet);
        _repository.SetAccessPath(path, validateHasBeenSet);
        _authors.SetAccessPath(path, validateHasBeenSet);
        _participants.SetAccessPath(path, validateHasBeenSet);
        _branchSpec.SetAccessPath(path, validateHasBeenSet);
        _pathSpec.SetAccessPath(path, validateHasBeenSet);
        _titleRegex.SetAccessPath(path, validateHasBeenSet);
    }

}


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

public sealed class DeploymentsSubscriptionFilter
     : SubscriptionFilter, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "DeploymentsSubscriptionFilter";
    
    public DeploymentsSubscriptionFilter() { }
    
    public DeploymentsSubscriptionFilter(PRProject? project = null, List<string>? repositories = null, List<string>? targetIdentifiers = null)
    {
        Project = project;
        Repositories = repositories;
        TargetIdentifiers = targetIdentifiers;
    }
    
    private PropertyValue<PRProject?> _project = new PropertyValue<PRProject?>(nameof(DeploymentsSubscriptionFilter), nameof(Project), "project");
    
    [JsonPropertyName("project")]
    public PRProject? Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<List<string>?> _repositories = new PropertyValue<List<string>?>(nameof(DeploymentsSubscriptionFilter), nameof(Repositories), "repositories");
    
    [JsonPropertyName("repositories")]
    public List<string>? Repositories
    {
        get => _repositories.GetValue(InlineErrors);
        set => _repositories.SetValue(value);
    }

    private PropertyValue<List<string>?> _targetIdentifiers = new PropertyValue<List<string>?>(nameof(DeploymentsSubscriptionFilter), nameof(TargetIdentifiers), "targetIdentifiers");
    
    [JsonPropertyName("targetIdentifiers")]
    public List<string>? TargetIdentifiers
    {
        get => _targetIdentifiers.GetValue(InlineErrors);
        set => _targetIdentifiers.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositories.SetAccessPath(parentChainPath, validateHasBeenSet);
        _targetIdentifiers.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

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

public sealed class VcsCommitListCFInputValue
     : CFInputValue, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "VcsCommitListCFInputValue";
    
    public VcsCommitListCFInputValue() { }
    
    public VcsCommitListCFInputValue(List<CFCommitIdentifier> commits)
    {
        Commits = commits;
    }
    
    private PropertyValue<List<CFCommitIdentifier>> _commits = new PropertyValue<List<CFCommitIdentifier>>(nameof(VcsCommitListCFInputValue), nameof(Commits), new List<CFCommitIdentifier>());
    
    [Required]
    [JsonPropertyName("commits")]
    public List<CFCommitIdentifier> Commits
    {
        get => _commits.GetValue();
        set => _commits.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _commits.SetAccessPath(path, validateHasBeenSet);
    }

}


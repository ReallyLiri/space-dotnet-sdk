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

public sealed class VcsCommitCFInputValue
     : CFInputValue, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "VcsCommitCFInputValue";
    
    public VcsCommitCFInputValue() { }
    
    public VcsCommitCFInputValue(CFCommitIdentifier? commit = null)
    {
        Commit = commit;
    }
    
    private PropertyValue<CFCommitIdentifier?> _commit = new PropertyValue<CFCommitIdentifier?>(nameof(VcsCommitCFInputValue), nameof(Commit));
    
    [JsonPropertyName("commit")]
    public CFCommitIdentifier? Commit
    {
        get => _commit.GetValue();
        set => _commit.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _commit.SetAccessPath(path, validateHasBeenSet);
    }

}


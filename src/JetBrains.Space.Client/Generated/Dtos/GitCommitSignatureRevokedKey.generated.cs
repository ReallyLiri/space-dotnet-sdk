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

public sealed class GitCommitSignatureRevokedKey
     : GitCommitSignature, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "GitCommitSignature.RevokedKey";
    
    public GitCommitSignatureRevokedKey() { }
    
    public GitCommitSignatureRevokedKey(string description, string? revokeComment = null)
    {
        Description = description;
        RevokeComment = revokeComment;
    }
    
    private PropertyValue<string> _description = new PropertyValue<string>(nameof(GitCommitSignatureRevokedKey), nameof(Description));
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _revokeComment = new PropertyValue<string?>(nameof(GitCommitSignatureRevokedKey), nameof(RevokeComment));
    
    [JsonPropertyName("revokeComment")]
    public string? RevokeComment
    {
        get => _revokeComment.GetValue();
        set => _revokeComment.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _description.SetAccessPath(path, validateHasBeenSet);
        _revokeComment.SetAccessPath(path, validateHasBeenSet);
    }

}


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

public sealed class SshKeyData
     : IPropagatePropertyAccessPath
{
    public SshKeyData() { }
    
    public SshKeyData(string fingerprint, string publicKey, string comment, string? sha256fingerprint = null, DateTime? createdAt = null, DateTime? lastUsed = null, string? lastResource = null)
    {
        Fingerprint = fingerprint;
        Sha256fingerprint = sha256fingerprint;
        PublicKey = publicKey;
        Comment = comment;
        CreatedAt = createdAt;
        LastUsed = lastUsed;
        LastResource = lastResource;
    }
    
    private PropertyValue<string> _fingerprint = new PropertyValue<string>(nameof(SshKeyData), nameof(Fingerprint), "fingerprint");
    
    [Required]
    [JsonPropertyName("fingerprint")]
    public string Fingerprint
    {
        get => _fingerprint.GetValue(InlineErrors);
        set => _fingerprint.SetValue(value);
    }

    private PropertyValue<string?> _sha256fingerprint = new PropertyValue<string?>(nameof(SshKeyData), nameof(Sha256fingerprint), "sha256fingerprint");
    
    [JsonPropertyName("sha256fingerprint")]
    public string? Sha256fingerprint
    {
        get => _sha256fingerprint.GetValue(InlineErrors);
        set => _sha256fingerprint.SetValue(value);
    }

    private PropertyValue<string> _publicKey = new PropertyValue<string>(nameof(SshKeyData), nameof(PublicKey), "publicKey");
    
    [Required]
    [JsonPropertyName("publicKey")]
    public string PublicKey
    {
        get => _publicKey.GetValue(InlineErrors);
        set => _publicKey.SetValue(value);
    }

    private PropertyValue<string> _comment = new PropertyValue<string>(nameof(SshKeyData), nameof(Comment), "comment");
    
    [Required]
    [JsonPropertyName("comment")]
    public string Comment
    {
        get => _comment.GetValue(InlineErrors);
        set => _comment.SetValue(value);
    }

    private PropertyValue<DateTime?> _createdAt = new PropertyValue<DateTime?>(nameof(SshKeyData), nameof(CreatedAt), "createdAt");
    
    [JsonPropertyName("createdAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? CreatedAt
    {
        get => _createdAt.GetValue(InlineErrors);
        set => _createdAt.SetValue(value);
    }

    private PropertyValue<DateTime?> _lastUsed = new PropertyValue<DateTime?>(nameof(SshKeyData), nameof(LastUsed), "lastUsed");
    
    [JsonPropertyName("lastUsed")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? LastUsed
    {
        get => _lastUsed.GetValue(InlineErrors);
        set => _lastUsed.SetValue(value);
    }

    private PropertyValue<string?> _lastResource = new PropertyValue<string?>(nameof(SshKeyData), nameof(LastResource), "lastResource");
    
    [JsonPropertyName("lastResource")]
    public string? LastResource
    {
        get => _lastResource.GetValue(InlineErrors);
        set => _lastResource.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _fingerprint.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sha256fingerprint.SetAccessPath(parentChainPath, validateHasBeenSet);
        _publicKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _comment.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lastUsed.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lastResource.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


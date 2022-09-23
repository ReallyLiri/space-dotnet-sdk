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

public sealed class UnfurlDetailsSnapshotDiff
     : InlineUnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsSnapshotDiff";
    
    public UnfurlDetailsSnapshotDiff() { }
    
    public UnfurlDetailsSnapshotDiff(string snapshotId, string baseSnapshotId)
    {
        SnapshotId = snapshotId;
        BaseSnapshotId = baseSnapshotId;
    }
    
    private PropertyValue<string> _snapshotId = new PropertyValue<string>(nameof(UnfurlDetailsSnapshotDiff), nameof(SnapshotId), "snapshotId");
    
    [Required]
    [JsonPropertyName("snapshotId")]
    public string SnapshotId
    {
        get => _snapshotId.GetValue(InlineErrors);
        set => _snapshotId.SetValue(value);
    }

    private PropertyValue<string> _baseSnapshotId = new PropertyValue<string>(nameof(UnfurlDetailsSnapshotDiff), nameof(BaseSnapshotId), "baseSnapshotId");
    
    [Required]
    [JsonPropertyName("baseSnapshotId")]
    public string BaseSnapshotId
    {
        get => _baseSnapshotId.GetValue(InlineErrors);
        set => _baseSnapshotId.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _snapshotId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _baseSnapshotId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


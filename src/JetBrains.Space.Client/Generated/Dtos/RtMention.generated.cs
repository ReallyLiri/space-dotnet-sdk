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

public sealed class RtMention
     : InlineNodeWithMarks, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RtMention";
    
    public RtMention() { }
    
    public RtMention(RtMentionAttrs attrs, List<DocumentMark> marks)
    {
        Attrs = attrs;
        Marks = marks;
    }
    
    private PropertyValue<RtMentionAttrs> _attrs = new PropertyValue<RtMentionAttrs>(nameof(RtMention), nameof(Attrs), "attrs");
    
    [Required]
    [JsonPropertyName("attrs")]
    public RtMentionAttrs Attrs
    {
        get => _attrs.GetValue(InlineErrors);
        set => _attrs.SetValue(value);
    }

    private PropertyValue<List<DocumentMark>> _marks = new PropertyValue<List<DocumentMark>>(nameof(RtMention), nameof(Marks), "marks", new List<DocumentMark>());
    
    [Required]
    [JsonPropertyName("marks")]
    public List<DocumentMark> Marks
    {
        get => _marks.GetValue(InlineErrors);
        set => _marks.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _attrs.SetAccessPath(parentChainPath, validateHasBeenSet);
        _marks.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


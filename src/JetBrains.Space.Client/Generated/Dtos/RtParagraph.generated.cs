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

public sealed class RtParagraph
     : BlockNodeWithMarks, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RtParagraph";
    
    public RtParagraph() { }
    
    public RtParagraph(List<InlineNode> children, List<DocumentMark> marks, PmNodeTextAlign textAlign)
    {
        Children = children;
        Marks = marks;
        TextAlign = textAlign;
    }
    
    private PropertyValue<List<InlineNode>> _children = new PropertyValue<List<InlineNode>>(nameof(RtParagraph), nameof(Children), "children", new List<InlineNode>());
    
    [Required]
    [JsonPropertyName("children")]
    public List<InlineNode> Children
    {
        get => _children.GetValue(InlineErrors);
        set => _children.SetValue(value);
    }

    private PropertyValue<List<DocumentMark>> _marks = new PropertyValue<List<DocumentMark>>(nameof(RtParagraph), nameof(Marks), "marks", new List<DocumentMark>());
    
    [Required]
    [JsonPropertyName("marks")]
    public List<DocumentMark> Marks
    {
        get => _marks.GetValue(InlineErrors);
        set => _marks.SetValue(value);
    }

    private PropertyValue<PmNodeTextAlign> _textAlign = new PropertyValue<PmNodeTextAlign>(nameof(RtParagraph), nameof(TextAlign), "textAlign");
    
    [Required]
    [JsonPropertyName("textAlign")]
    public PmNodeTextAlign TextAlign
    {
        get => _textAlign.GetValue(InlineErrors);
        set => _textAlign.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _children.SetAccessPath(parentChainPath, validateHasBeenSet);
        _marks.SetAccessPath(parentChainPath, validateHasBeenSet);
        _textAlign.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


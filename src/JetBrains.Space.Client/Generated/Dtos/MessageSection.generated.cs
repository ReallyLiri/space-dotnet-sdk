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

public sealed class MessageSection
     : MessageSectionElement, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MessageSection";
    
    public MessageSection() { }
    
    public MessageSection(List<MessageBlockElement> elements, string? header = null, string? footer = null, MessageStyle? style = null, MessageTextSize? textSize = null)
    {
        Elements = elements;
        Header = header;
        Footer = footer;
        Style = style;
        TextSize = textSize;
    }
    
    private PropertyValue<List<MessageBlockElement>> _elements = new PropertyValue<List<MessageBlockElement>>(nameof(MessageSection), nameof(Elements), "elements", new List<MessageBlockElement>());
    
    /// <summary>
    /// Block elements that constitute the section
    /// </summary>
    [Required]
    [JsonPropertyName("elements")]
    public List<MessageBlockElement> Elements
    {
        get => _elements.GetValue(InlineErrors);
        set => _elements.SetValue(value);
    }

    private PropertyValue<string?> _header = new PropertyValue<string?>(nameof(MessageSection), nameof(Header), "header");
    
    /// <summary>
    /// Header text is displayed with a large font size at the top of the section
    /// </summary>
    [JsonPropertyName("header")]
    public string? Header
    {
        get => _header.GetValue(InlineErrors);
        set => _header.SetValue(value);
    }

    private PropertyValue<string?> _footer = new PropertyValue<string?>(nameof(MessageSection), nameof(Footer), "footer");
    
    /// <summary>
    /// Footer text is displayed with a small font size and in a dimmed color at the bottom of the section
    /// </summary>
    [JsonPropertyName("footer")]
    public string? Footer
    {
        get => _footer.GetValue(InlineErrors);
        set => _footer.SetValue(value);
    }

    private PropertyValue<MessageStyle?> _style = new PropertyValue<MessageStyle?>(nameof(MessageSection), nameof(Style), "style");
    
    /// <summary>
    /// Section style determines the color of the left-hand side bar
    /// </summary>
    /// <remarks>
    /// This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.
    /// </remarks>
#if NET6_0_OR_GREATER
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.", DiagnosticId = "SPC001")]
#else
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.")]
#endif
    
    [JsonPropertyName("style")]
    public MessageStyle? Style
    {
        get => _style.GetValue(InlineErrors);
        set => _style.SetValue(value);
    }

    private PropertyValue<MessageTextSize?> _textSize = new PropertyValue<MessageTextSize?>(nameof(MessageSection), nameof(TextSize), "textSize");
    
    /// <summary>
    /// Default text size for all the elements within the section (excluding header and footer)
    /// </summary>
    /// <remarks>
    /// This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.
    /// </remarks>
#if NET6_0_OR_GREATER
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.", DiagnosticId = "SPC001")]
#else
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.")]
#endif
    
    [JsonPropertyName("textSize")]
    public MessageTextSize? TextSize
    {
        get => _textSize.GetValue(InlineErrors);
        set => _textSize.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _elements.SetAccessPath(parentChainPath, validateHasBeenSet);
        _header.SetAccessPath(parentChainPath, validateHasBeenSet);
        _footer.SetAccessPath(parentChainPath, validateHasBeenSet);
        _style.SetAccessPath(parentChainPath, validateHasBeenSet);
        _textSize.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


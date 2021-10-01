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

public sealed class UnfurlDetailsBlockMarkdown
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsBlockMarkdown";
    
    public UnfurlDetailsBlockMarkdown() { }
    
    public UnfurlDetailsBlockMarkdown(string title, string markdown, string? icon = null)
    {
        Icon = icon;
        Title = title;
        Markdown = markdown;
    }
    
    private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(UnfurlDetailsBlockMarkdown), nameof(Icon));
    
    [JsonPropertyName("icon")]
    public string? Icon
    {
        get => _icon.GetValue();
        set => _icon.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(UnfurlDetailsBlockMarkdown), nameof(Title));
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue();
        set => _title.SetValue(value);
    }

    private PropertyValue<string> _markdown = new PropertyValue<string>(nameof(UnfurlDetailsBlockMarkdown), nameof(Markdown));
    
    [Required]
    [JsonPropertyName("markdown")]
    public string Markdown
    {
        get => _markdown.GetValue();
        set => _markdown.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _icon.SetAccessPath(path, validateHasBeenSet);
        _title.SetAccessPath(path, validateHasBeenSet);
        _markdown.SetAccessPath(path, validateHasBeenSet);
    }

}


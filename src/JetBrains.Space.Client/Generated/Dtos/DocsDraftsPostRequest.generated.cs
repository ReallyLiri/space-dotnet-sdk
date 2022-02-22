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

public class DocsDraftsPostRequest
     : IPropagatePropertyAccessPath
{
    public DocsDraftsPostRequest() { }
    
    public DocsDraftsPostRequest(DraftDocumentType type = DraftDocumentType.RICHTEXT, string? title = null, string? text = null, long? textVersion = null, string? folder = null, PublicationDetails? publicationDetails2 = null)
    {
        Title = title;
        Text = text;
        TextVersion = textVersion;
        Type = type;
        Folder = folder;
        PublicationDetails2 = publicationDetails2;
    }
    
    private PropertyValue<string?> _title = new PropertyValue<string?>(nameof(DocsDraftsPostRequest), nameof(Title), "title");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("title")]
    public string? Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<string?> _text = new PropertyValue<string?>(nameof(DocsDraftsPostRequest), nameof(Text), "text");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("text")]
    public string? Text
    {
        get => _text.GetValue(InlineErrors);
        set => _text.SetValue(value);
    }

    private PropertyValue<long?> _textVersion = new PropertyValue<long?>(nameof(DocsDraftsPostRequest), nameof(TextVersion), "textVersion");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("textVersion")]
    public long? TextVersion
    {
        get => _textVersion.GetValue(InlineErrors);
        set => _textVersion.SetValue(value);
    }

    private PropertyValue<DraftDocumentType> _type = new PropertyValue<DraftDocumentType>(nameof(DocsDraftsPostRequest), nameof(Type), "type", DraftDocumentType.RICHTEXT);
    
    [JsonPropertyName("type")]
    public DraftDocumentType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string?> _folder = new PropertyValue<string?>(nameof(DocsDraftsPostRequest), nameof(Folder), "folder");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("folder")]
    public string? Folder
    {
        get => _folder.GetValue(InlineErrors);
        set => _folder.SetValue(value);
    }

    private PropertyValue<PublicationDetails?> _publicationDetails2 = new PropertyValue<PublicationDetails?>(nameof(DocsDraftsPostRequest), nameof(PublicationDetails2), "publicationDetails2");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("publicationDetails2")]
    public PublicationDetails? PublicationDetails2
    {
        get => _publicationDetails2.GetValue(InlineErrors);
        set => _publicationDetails2.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _text.SetAccessPath(parentChainPath, validateHasBeenSet);
        _textVersion.SetAccessPath(parentChainPath, validateHasBeenSet);
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _folder.SetAccessPath(parentChainPath, validateHasBeenSet);
        _publicationDetails2.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


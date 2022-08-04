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

public sealed class MessageControlGroup
     : MessageBlockElement, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MessageControlGroup";
    
    public MessageControlGroup() { }
    
    public MessageControlGroup(List<MessageControlElement> elements)
    {
        Elements = elements;
    }
    
    private PropertyValue<List<MessageControlElement>> _elements = new PropertyValue<List<MessageControlElement>>(nameof(MessageControlGroup), nameof(Elements), "elements", new List<MessageControlElement>());
    
    [Required]
    [JsonPropertyName("elements")]
    public List<MessageControlElement> Elements
    {
        get => _elements.GetValue(InlineErrors);
        set => _elements.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _elements.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


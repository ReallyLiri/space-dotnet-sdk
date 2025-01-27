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

#if NET6_0_OR_GREATER
[Obsolete("This part of API is not supported yet on mobile clients. Messages using it will be replaced with stubs on iOS and Android.", DiagnosticId = "SPC001")]
#else
[Obsolete("This part of API is not supported yet on mobile clients. Messages using it will be replaced with stubs on iOS and Android.")]
#endif

public sealed class MessageOutlineElements
     : MessageOutlineBase, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MessageOutlineElements";
    
    public MessageOutlineElements() { }
    
    public MessageOutlineElements(List<MessageInlineElement> elements)
    {
        Elements = elements;
    }
    
    private PropertyValue<List<MessageInlineElement>> _elements = new PropertyValue<List<MessageInlineElement>>(nameof(MessageOutlineElements), nameof(Elements), "elements", new List<MessageInlineElement>());
    
    [Required]
    [JsonPropertyName("elements")]
    public List<MessageInlineElement> Elements
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


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

public class ExternalLinkPatternsPostRequest
     : IPropagatePropertyAccessPath
{
    public ExternalLinkPatternsPostRequest() { }
    
    public ExternalLinkPatternsPostRequest(string pattern, string linkReplacement)
    {
        Pattern = pattern;
        LinkReplacement = linkReplacement;
    }
    
    private PropertyValue<string> _pattern = new PropertyValue<string>(nameof(ExternalLinkPatternsPostRequest), nameof(Pattern), "pattern");
    
    /// <summary>
    /// Prefix that is used in the external IDs and that will be recognised by Space to generate links
    /// </summary>
    [Required]
    [JsonPropertyName("pattern")]
    public string Pattern
    {
        get => _pattern.GetValue(InlineErrors);
        set => _pattern.SetValue(value);
    }

    private PropertyValue<string> _linkReplacement = new PropertyValue<string>(nameof(ExternalLinkPatternsPostRequest), nameof(LinkReplacement), "linkReplacement");
    
    /// <summary>
    /// URL of the external resource ending with *<?>* which is a variable for a number that follows the prefix
    /// </summary>
    [Required]
    [JsonPropertyName("linkReplacement")]
    public string LinkReplacement
    {
        get => _linkReplacement.GetValue(InlineErrors);
        set => _linkReplacement.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _pattern.SetAccessPath(parentChainPath, validateHasBeenSet);
        _linkReplacement.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


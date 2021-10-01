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

public sealed class ApplicationUnfurlPattern
     : IPropagatePropertyAccessPath
{
    public ApplicationUnfurlPattern() { }
    
    public ApplicationUnfurlPattern(string pattern, string linkReplacement, RightStatus status, CPrincipal? modificationAuthor = null, DateTime? modificationTimestamp = null)
    {
        Pattern = pattern;
        LinkReplacement = linkReplacement;
        Status = status;
        ModificationAuthor = modificationAuthor;
        ModificationTimestamp = modificationTimestamp;
    }
    
    private PropertyValue<string> _pattern = new PropertyValue<string>(nameof(ApplicationUnfurlPattern), nameof(Pattern));
    
    [Required]
    [JsonPropertyName("pattern")]
    public string Pattern
    {
        get => _pattern.GetValue();
        set => _pattern.SetValue(value);
    }

    private PropertyValue<string> _linkReplacement = new PropertyValue<string>(nameof(ApplicationUnfurlPattern), nameof(LinkReplacement));
    
    [Required]
    [JsonPropertyName("linkReplacement")]
    public string LinkReplacement
    {
        get => _linkReplacement.GetValue();
        set => _linkReplacement.SetValue(value);
    }

    private PropertyValue<RightStatus> _status = new PropertyValue<RightStatus>(nameof(ApplicationUnfurlPattern), nameof(Status));
    
    [Required]
    [JsonPropertyName("status")]
    public RightStatus Status
    {
        get => _status.GetValue();
        set => _status.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _modificationAuthor = new PropertyValue<CPrincipal?>(nameof(ApplicationUnfurlPattern), nameof(ModificationAuthor));
    
    [JsonPropertyName("modificationAuthor")]
    public CPrincipal? ModificationAuthor
    {
        get => _modificationAuthor.GetValue();
        set => _modificationAuthor.SetValue(value);
    }

    private PropertyValue<DateTime?> _modificationTimestamp = new PropertyValue<DateTime?>(nameof(ApplicationUnfurlPattern), nameof(ModificationTimestamp));
    
    [JsonPropertyName("modificationTimestamp")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? ModificationTimestamp
    {
        get => _modificationTimestamp.GetValue();
        set => _modificationTimestamp.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _pattern.SetAccessPath(path, validateHasBeenSet);
        _linkReplacement.SetAccessPath(path, validateHasBeenSet);
        _status.SetAccessPath(path, validateHasBeenSet);
        _modificationAuthor.SetAccessPath(path, validateHasBeenSet);
        _modificationTimestamp.SetAccessPath(path, validateHasBeenSet);
    }

}


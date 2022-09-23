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

public sealed class TopLevelPageUiExtensionApi
     : AppUiExtensionApi, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "TopLevelPageUiExtensionApi";
    
    public TopLevelPageUiExtensionApi() { }
    
    public TopLevelPageUiExtensionApi(string displayName, string uniqueCode, string? description = null, string? iframeUrl = null)
    {
        DisplayName = displayName;
        Description = description;
        UniqueCode = uniqueCode;
        IframeUrl = iframeUrl;
    }
    
    private PropertyValue<string> _displayName = new PropertyValue<string>(nameof(TopLevelPageUiExtensionApi), nameof(DisplayName), "displayName");
    
    [Required]
    [JsonPropertyName("displayName")]
    public string DisplayName
    {
        get => _displayName.GetValue(InlineErrors);
        set => _displayName.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(TopLevelPageUiExtensionApi), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string> _uniqueCode = new PropertyValue<string>(nameof(TopLevelPageUiExtensionApi), nameof(UniqueCode), "uniqueCode");
    
    [Required]
    [JsonPropertyName("uniqueCode")]
    public string UniqueCode
    {
        get => _uniqueCode.GetValue(InlineErrors);
        set => _uniqueCode.SetValue(value);
    }

    private PropertyValue<string?> _iframeUrl = new PropertyValue<string?>(nameof(TopLevelPageUiExtensionApi), nameof(IframeUrl), "iframeUrl");
    
    [JsonPropertyName("iframeUrl")]
    public string? IframeUrl
    {
        get => _iframeUrl.GetValue(InlineErrors);
        set => _iframeUrl.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _displayName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _uniqueCode.SetAccessPath(parentChainPath, validateHasBeenSet);
        _iframeUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


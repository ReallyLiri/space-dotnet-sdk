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

public sealed class ChatContactDetailsDefault
     : ChatContactDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "ChatContactDetails.Default";
    
    public ChatContactDetailsDefault() { }
    
    public ChatContactDetailsDefault(string type, string name, string? legacyName = null, string? icon = null, string? fontIcon = null, PrivateFeedColor? fontIconColor = null, M2Access? access = null, bool? resolvedImpl = null, ContactExtraTag? extra = null)
    {
        Type = type;
        Name = name;
        LegacyName = legacyName;
        Icon = icon;
        FontIcon = fontIcon;
        FontIconColor = fontIconColor;
        Access = access;
        IsResolvedImpl = resolvedImpl;
        Extra = extra;
    }
    
    private PropertyValue<string> _type = new PropertyValue<string>(nameof(ChatContactDetailsDefault), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public string Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ChatContactDetailsDefault), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _legacyName = new PropertyValue<string?>(nameof(ChatContactDetailsDefault), nameof(LegacyName), "legacyName");
    
    [JsonPropertyName("legacyName")]
    public string? LegacyName
    {
        get => _legacyName.GetValue(InlineErrors);
        set => _legacyName.SetValue(value);
    }

    private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(ChatContactDetailsDefault), nameof(Icon), "icon");
    
    [JsonPropertyName("icon")]
    public string? Icon
    {
        get => _icon.GetValue(InlineErrors);
        set => _icon.SetValue(value);
    }

    private PropertyValue<string?> _fontIcon = new PropertyValue<string?>(nameof(ChatContactDetailsDefault), nameof(FontIcon), "fontIcon");
    
    [JsonPropertyName("fontIcon")]
    public string? FontIcon
    {
        get => _fontIcon.GetValue(InlineErrors);
        set => _fontIcon.SetValue(value);
    }

    private PropertyValue<PrivateFeedColor?> _fontIconColor = new PropertyValue<PrivateFeedColor?>(nameof(ChatContactDetailsDefault), nameof(FontIconColor), "fontIconColor");
    
    [JsonPropertyName("fontIconColor")]
    public PrivateFeedColor? FontIconColor
    {
        get => _fontIconColor.GetValue(InlineErrors);
        set => _fontIconColor.SetValue(value);
    }

    private PropertyValue<M2Access?> _access = new PropertyValue<M2Access?>(nameof(ChatContactDetailsDefault), nameof(Access), "access");
    
    [JsonPropertyName("access")]
    public M2Access? Access
    {
        get => _access.GetValue(InlineErrors);
        set => _access.SetValue(value);
    }

    private PropertyValue<bool?> _resolvedImpl = new PropertyValue<bool?>(nameof(ChatContactDetailsDefault), nameof(IsResolvedImpl), "resolvedImpl");
    
    [JsonPropertyName("resolvedImpl")]
    public bool? IsResolvedImpl
    {
        get => _resolvedImpl.GetValue(InlineErrors);
        set => _resolvedImpl.SetValue(value);
    }

    private PropertyValue<ContactExtraTag?> _extra = new PropertyValue<ContactExtraTag?>(nameof(ChatContactDetailsDefault), nameof(Extra), "extra");
    
    [JsonPropertyName("extra")]
    public ContactExtraTag? Extra
    {
        get => _extra.GetValue(InlineErrors);
        set => _extra.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _legacyName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _icon.SetAccessPath(parentChainPath, validateHasBeenSet);
        _fontIcon.SetAccessPath(parentChainPath, validateHasBeenSet);
        _fontIconColor.SetAccessPath(parentChainPath, validateHasBeenSet);
        _access.SetAccessPath(parentChainPath, validateHasBeenSet);
        _resolvedImpl.SetAccessPath(parentChainPath, validateHasBeenSet);
        _extra.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


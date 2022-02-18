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

public sealed class OrganizationForUpdateDTO
     : IPropagatePropertyAccessPath
{
    public OrganizationForUpdateDTO() { }
    
    public OrganizationForUpdateDTO(string name, string? slogan = null, string? logoSmall = null, string? logo = null, string? logoId = null, string? slackWorkspace = null, bool? onboardingRequired = null, bool? userAgreementAccepted = null, ATimeZone? timezone = null, string? license = null)
    {
        Name = name;
        Slogan = slogan;
        LogoSmall = logoSmall;
        Logo = logo;
        LogoId = logoId;
        SlackWorkspace = slackWorkspace;
        IsOnboardingRequired = onboardingRequired;
        IsUserAgreementAccepted = userAgreementAccepted;
        Timezone = timezone;
        License = license;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(OrganizationForUpdateDTO), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _slogan = new PropertyValue<string?>(nameof(OrganizationForUpdateDTO), nameof(Slogan), "slogan");
    
    [JsonPropertyName("slogan")]
    public string? Slogan
    {
        get => _slogan.GetValue(InlineErrors);
        set => _slogan.SetValue(value);
    }

    private PropertyValue<string?> _logoSmall = new PropertyValue<string?>(nameof(OrganizationForUpdateDTO), nameof(LogoSmall), "logoSmall");
    
    [JsonPropertyName("logoSmall")]
    public string? LogoSmall
    {
        get => _logoSmall.GetValue(InlineErrors);
        set => _logoSmall.SetValue(value);
    }

    private PropertyValue<string?> _logo = new PropertyValue<string?>(nameof(OrganizationForUpdateDTO), nameof(Logo), "logo");
    
    [JsonPropertyName("logo")]
    public string? Logo
    {
        get => _logo.GetValue(InlineErrors);
        set => _logo.SetValue(value);
    }

    private PropertyValue<string?> _logoId = new PropertyValue<string?>(nameof(OrganizationForUpdateDTO), nameof(LogoId), "logoId");
    
    [JsonPropertyName("logoId")]
    public string? LogoId
    {
        get => _logoId.GetValue(InlineErrors);
        set => _logoId.SetValue(value);
    }

    private PropertyValue<string?> _slackWorkspace = new PropertyValue<string?>(nameof(OrganizationForUpdateDTO), nameof(SlackWorkspace), "slackWorkspace");
    
    [Obsolete("Is no longer supported (since 2021-10-13) (will be removed in a future version)")]
    [JsonPropertyName("slackWorkspace")]
    public string? SlackWorkspace
    {
        get => _slackWorkspace.GetValue(InlineErrors);
        set => _slackWorkspace.SetValue(value);
    }

    private PropertyValue<bool?> _onboardingRequired = new PropertyValue<bool?>(nameof(OrganizationForUpdateDTO), nameof(IsOnboardingRequired), "onboardingRequired");
    
    [JsonPropertyName("onboardingRequired")]
    public bool? IsOnboardingRequired
    {
        get => _onboardingRequired.GetValue(InlineErrors);
        set => _onboardingRequired.SetValue(value);
    }

    private PropertyValue<bool?> _userAgreementAccepted = new PropertyValue<bool?>(nameof(OrganizationForUpdateDTO), nameof(IsUserAgreementAccepted), "userAgreementAccepted");
    
    [JsonPropertyName("userAgreementAccepted")]
    public bool? IsUserAgreementAccepted
    {
        get => _userAgreementAccepted.GetValue(InlineErrors);
        set => _userAgreementAccepted.SetValue(value);
    }

    private PropertyValue<ATimeZone?> _timezone = new PropertyValue<ATimeZone?>(nameof(OrganizationForUpdateDTO), nameof(Timezone), "timezone");
    
    [JsonPropertyName("timezone")]
    public ATimeZone? Timezone
    {
        get => _timezone.GetValue(InlineErrors);
        set => _timezone.SetValue(value);
    }

    private PropertyValue<string?> _license = new PropertyValue<string?>(nameof(OrganizationForUpdateDTO), nameof(License), "license");
    
    [JsonPropertyName("license")]
    public string? License
    {
        get => _license.GetValue(InlineErrors);
        set => _license.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _slogan.SetAccessPath(parentChainPath, validateHasBeenSet);
        _logoSmall.SetAccessPath(parentChainPath, validateHasBeenSet);
        _logo.SetAccessPath(parentChainPath, validateHasBeenSet);
        _logoId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _slackWorkspace.SetAccessPath(parentChainPath, validateHasBeenSet);
        _onboardingRequired.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userAgreementAccepted.SetAccessPath(parentChainPath, validateHasBeenSet);
        _timezone.SetAccessPath(parentChainPath, validateHasBeenSet);
        _license.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

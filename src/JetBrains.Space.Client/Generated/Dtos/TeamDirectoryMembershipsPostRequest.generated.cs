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

public class TeamDirectoryMembershipsPostRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryMembershipsPostRequest() { }
    
    public TeamDirectoryMembershipsPostRequest(ProfileIdentifier member, string teamId, string roleId, bool lead = false, bool requiresApproval = false, ProfileIdentifier? manager = null, DateTime? activeSince = null, DateTime? activeTill = null, string? previousMembershipId = null, List<CustomFieldInputValue>? customFieldValues = null)
    {
        Member = member;
        TeamId = teamId;
        RoleId = roleId;
        IsLead = lead;
        Manager = manager;
        ActiveSince = activeSince;
        ActiveTill = activeTill;
        PreviousMembershipId = previousMembershipId;
        IsRequiresApproval = requiresApproval;
        CustomFieldValues = customFieldValues;
    }
    
    private PropertyValue<ProfileIdentifier> _member = new PropertyValue<ProfileIdentifier>(nameof(TeamDirectoryMembershipsPostRequest), nameof(Member), "member");
    
    [Required]
    [JsonPropertyName("member")]
    public ProfileIdentifier Member
    {
        get => _member.GetValue(InlineErrors);
        set => _member.SetValue(value);
    }

    private PropertyValue<string> _teamId = new PropertyValue<string>(nameof(TeamDirectoryMembershipsPostRequest), nameof(TeamId), "teamId");
    
    [Required]
    [JsonPropertyName("teamId")]
    public string TeamId
    {
        get => _teamId.GetValue(InlineErrors);
        set => _teamId.SetValue(value);
    }

    private PropertyValue<string> _roleId = new PropertyValue<string>(nameof(TeamDirectoryMembershipsPostRequest), nameof(RoleId), "roleId");
    
    [Required]
    [JsonPropertyName("roleId")]
    public string RoleId
    {
        get => _roleId.GetValue(InlineErrors);
        set => _roleId.SetValue(value);
    }

    private PropertyValue<bool> _lead = new PropertyValue<bool>(nameof(TeamDirectoryMembershipsPostRequest), nameof(IsLead), "lead");
    
    [Obsolete("The property is deprecated (since 2020-12-01) (will be removed in a future version)")]
    [JsonPropertyName("lead")]
    public bool IsLead
    {
        get => _lead.GetValue(InlineErrors);
        set => _lead.SetValue(value);
    }

    private PropertyValue<ProfileIdentifier?> _manager = new PropertyValue<ProfileIdentifier?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(Manager), "manager");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("manager")]
    public ProfileIdentifier? Manager
    {
        get => _manager.GetValue(InlineErrors);
        set => _manager.SetValue(value);
    }

    private PropertyValue<DateTime?> _activeSince = new PropertyValue<DateTime?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(ActiveSince), "activeSince");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("activeSince")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? ActiveSince
    {
        get => _activeSince.GetValue(InlineErrors);
        set => _activeSince.SetValue(value);
    }

    private PropertyValue<DateTime?> _activeTill = new PropertyValue<DateTime?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(ActiveTill), "activeTill");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("activeTill")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? ActiveTill
    {
        get => _activeTill.GetValue(InlineErrors);
        set => _activeTill.SetValue(value);
    }

    private PropertyValue<string?> _previousMembershipId = new PropertyValue<string?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(PreviousMembershipId), "previousMembershipId");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("previousMembershipId")]
    public string? PreviousMembershipId
    {
        get => _previousMembershipId.GetValue(InlineErrors);
        set => _previousMembershipId.SetValue(value);
    }

    private PropertyValue<bool> _requiresApproval = new PropertyValue<bool>(nameof(TeamDirectoryMembershipsPostRequest), nameof(IsRequiresApproval), "requiresApproval");
    
    [JsonPropertyName("requiresApproval")]
    public bool IsRequiresApproval
    {
        get => _requiresApproval.GetValue(InlineErrors);
        set => _requiresApproval.SetValue(value);
    }

    private PropertyValue<List<CustomFieldInputValue>?> _customFieldValues = new PropertyValue<List<CustomFieldInputValue>?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(CustomFieldValues), "customFieldValues");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("customFieldValues")]
    public List<CustomFieldInputValue>? CustomFieldValues
    {
        get => _customFieldValues.GetValue(InlineErrors);
        set => _customFieldValues.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _member.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teamId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _roleId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lead.SetAccessPath(parentChainPath, validateHasBeenSet);
        _manager.SetAccessPath(parentChainPath, validateHasBeenSet);
        _activeSince.SetAccessPath(parentChainPath, validateHasBeenSet);
        _activeTill.SetAccessPath(parentChainPath, validateHasBeenSet);
        _previousMembershipId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _requiresApproval.SetAccessPath(parentChainPath, validateHasBeenSet);
        _customFieldValues.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


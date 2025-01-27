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

public class CallsPostRequest
     : IPropagatePropertyAccessPath
{
    public CallsPostRequest() { }
    
    public CallsPostRequest(List<ProfileIdentifier> participants, bool @private, string? channelId = null, string? description = null)
    {
        Participants = participants;
        IsPrivate = @private;
        ChannelId = channelId;
        Description = description;
    }
    
    private PropertyValue<List<ProfileIdentifier>> _participants = new PropertyValue<List<ProfileIdentifier>>(nameof(CallsPostRequest), nameof(Participants), "participants", new List<ProfileIdentifier>());
    
    [Required]
    [JsonPropertyName("participants")]
    public List<ProfileIdentifier> Participants
    {
        get => _participants.GetValue(InlineErrors);
        set => _participants.SetValue(value);
    }

    private PropertyValue<bool> _private = new PropertyValue<bool>(nameof(CallsPostRequest), nameof(IsPrivate), "private");
    
    [Required]
    [JsonPropertyName("private")]
    public bool IsPrivate
    {
        get => _private.GetValue(InlineErrors);
        set => _private.SetValue(value);
    }

    private PropertyValue<string?> _channelId = new PropertyValue<string?>(nameof(CallsPostRequest), nameof(ChannelId), "channelId");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("channelId")]
    public string? ChannelId
    {
        get => _channelId.GetValue(InlineErrors);
        set => _channelId.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CallsPostRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _participants.SetAccessPath(parentChainPath, validateHasBeenSet);
        _private.SetAccessPath(parentChainPath, validateHasBeenSet);
        _channelId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


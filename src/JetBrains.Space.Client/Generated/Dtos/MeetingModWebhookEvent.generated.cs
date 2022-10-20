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

public sealed class MeetingModWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MeetingModWebhookEvent";
    
    public MeetingModWebhookEvent() { }
    
    public MeetingModWebhookEvent(KMetaMod meta, Meeting meeting)
    {
        Meta = meta;
        Meeting = meeting;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(MeetingModWebhookEvent), nameof(Meta), "meta");
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue(InlineErrors);
        set => _meta.SetValue(value);
    }

    private PropertyValue<Meeting> _meeting = new PropertyValue<Meeting>(nameof(MeetingModWebhookEvent), nameof(Meeting), "meeting");
    
    [Required]
    [JsonPropertyName("meeting")]
    public Meeting Meeting
    {
        get => _meeting.GetValue(InlineErrors);
        set => _meeting.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _meeting.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


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

public sealed class SessionParticipationRecord
     : IPropagatePropertyAccessPath
{
    public SessionParticipationRecord() { }
    
    public SessionParticipationRecord(string id, long connectionId, string sessionId, TDMemberProfile member, List<DataProducerOptions> dataProducers, List<ProducerOptions> producers)
    {
        Id = id;
        ConnectionId = connectionId;
        SessionId = sessionId;
        Member = member;
        DataProducers = dataProducers;
        Producers = producers;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(SessionParticipationRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<long> _connectionId = new PropertyValue<long>(nameof(SessionParticipationRecord), nameof(ConnectionId), "connectionId");
    
    [Required]
    [JsonPropertyName("connectionId")]
    public long ConnectionId
    {
        get => _connectionId.GetValue(InlineErrors);
        set => _connectionId.SetValue(value);
    }

    private PropertyValue<string> _sessionId = new PropertyValue<string>(nameof(SessionParticipationRecord), nameof(SessionId), "sessionId");
    
    [Required]
    [JsonPropertyName("sessionId")]
    public string SessionId
    {
        get => _sessionId.GetValue(InlineErrors);
        set => _sessionId.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _member = new PropertyValue<TDMemberProfile>(nameof(SessionParticipationRecord), nameof(Member), "member");
    
    [Required]
    [JsonPropertyName("member")]
    public TDMemberProfile Member
    {
        get => _member.GetValue(InlineErrors);
        set => _member.SetValue(value);
    }

    private PropertyValue<List<DataProducerOptions>> _dataProducers = new PropertyValue<List<DataProducerOptions>>(nameof(SessionParticipationRecord), nameof(DataProducers), "dataProducers", new List<DataProducerOptions>());
    
    [Required]
    [JsonPropertyName("dataProducers")]
    public List<DataProducerOptions> DataProducers
    {
        get => _dataProducers.GetValue(InlineErrors);
        set => _dataProducers.SetValue(value);
    }

    private PropertyValue<List<ProducerOptions>> _producers = new PropertyValue<List<ProducerOptions>>(nameof(SessionParticipationRecord), nameof(Producers), "producers", new List<ProducerOptions>());
    
    [Required]
    [JsonPropertyName("producers")]
    public List<ProducerOptions> Producers
    {
        get => _producers.GetValue(InlineErrors);
        set => _producers.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _connectionId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sessionId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _member.SetAccessPath(parentChainPath, validateHasBeenSet);
        _dataProducers.SetAccessPath(parentChainPath, validateHasBeenSet);
        _producers.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

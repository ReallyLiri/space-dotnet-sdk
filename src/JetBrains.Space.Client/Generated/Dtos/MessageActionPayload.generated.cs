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

public sealed class MessageActionPayload
     : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MessageActionPayload";
    
    public MessageActionPayload() { }
    
    public MessageActionPayload(string actionId, string actionValue, MessageContext message, string clientId, string userId, string? verificationToken = null)
    {
        ActionId = actionId;
        ActionValue = actionValue;
        Message = message;
        ClientId = clientId;
        UserId = userId;
        VerificationToken = verificationToken;
    }
    
    private PropertyValue<string> _actionId = new PropertyValue<string>(nameof(MessageActionPayload), nameof(ActionId), "actionId");
    
    [Required]
    [JsonPropertyName("actionId")]
    public string ActionId
    {
        get => _actionId.GetValue(InlineErrors);
        set => _actionId.SetValue(value);
    }

    private PropertyValue<string> _actionValue = new PropertyValue<string>(nameof(MessageActionPayload), nameof(ActionValue), "actionValue");
    
    [Required]
    [JsonPropertyName("actionValue")]
    public string ActionValue
    {
        get => _actionValue.GetValue(InlineErrors);
        set => _actionValue.SetValue(value);
    }

    private PropertyValue<MessageContext> _message = new PropertyValue<MessageContext>(nameof(MessageActionPayload), nameof(Message), "message");
    
    [Required]
    [JsonPropertyName("message")]
    public MessageContext Message
    {
        get => _message.GetValue(InlineErrors);
        set => _message.SetValue(value);
    }

    private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(MessageActionPayload), nameof(ClientId), "clientId");
    
    [Required]
    [JsonPropertyName("clientId")]
    public string ClientId
    {
        get => _clientId.GetValue(InlineErrors);
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string> _userId = new PropertyValue<string>(nameof(MessageActionPayload), nameof(UserId), "userId");
    
    [Required]
    [JsonPropertyName("userId")]
    public string UserId
    {
        get => _userId.GetValue(InlineErrors);
        set => _userId.SetValue(value);
    }

    private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(MessageActionPayload), nameof(VerificationToken), "verificationToken");
    
    [JsonPropertyName("verificationToken")]
    public string? VerificationToken
    {
        get => _verificationToken.GetValue(InlineErrors);
        set => _verificationToken.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _actionId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _actionValue.SetAccessPath(parentChainPath, validateHasBeenSet);
        _message.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _verificationToken.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}


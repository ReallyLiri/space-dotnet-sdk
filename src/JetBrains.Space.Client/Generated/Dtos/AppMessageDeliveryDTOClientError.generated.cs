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

public sealed class AppMessageDeliveryDTOClientError
     : IPropagatePropertyAccessPath
{
    public AppMessageDeliveryDTOClientError() { }
    
    public AppMessageDeliveryDTOClientError(string className, string? message = null, string? causeClassName = null, string? causeMessage = null)
    {
        ClassName = className;
        Message = message;
        CauseClassName = causeClassName;
        CauseMessage = causeMessage;
    }
    
    private PropertyValue<string> _className = new PropertyValue<string>(nameof(AppMessageDeliveryDTOClientError), nameof(ClassName));
    
    [Required]
    [JsonPropertyName("className")]
    public string ClassName
    {
        get => _className.GetValue();
        set => _className.SetValue(value);
    }

    private PropertyValue<string?> _message = new PropertyValue<string?>(nameof(AppMessageDeliveryDTOClientError), nameof(Message));
    
    [JsonPropertyName("message")]
    public string? Message
    {
        get => _message.GetValue();
        set => _message.SetValue(value);
    }

    private PropertyValue<string?> _causeClassName = new PropertyValue<string?>(nameof(AppMessageDeliveryDTOClientError), nameof(CauseClassName));
    
    [JsonPropertyName("causeClassName")]
    public string? CauseClassName
    {
        get => _causeClassName.GetValue();
        set => _causeClassName.SetValue(value);
    }

    private PropertyValue<string?> _causeMessage = new PropertyValue<string?>(nameof(AppMessageDeliveryDTOClientError), nameof(CauseMessage));
    
    [JsonPropertyName("causeMessage")]
    public string? CauseMessage
    {
        get => _causeMessage.GetValue();
        set => _causeMessage.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _className.SetAccessPath(path, validateHasBeenSet);
        _message.SetAccessPath(path, validateHasBeenSet);
        _causeClassName.SetAccessPath(path, validateHasBeenSet);
        _causeMessage.SetAccessPath(path, validateHasBeenSet);
    }

}

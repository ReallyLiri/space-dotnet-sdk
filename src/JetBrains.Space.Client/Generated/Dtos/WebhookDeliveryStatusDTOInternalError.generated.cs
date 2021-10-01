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

public sealed class WebhookDeliveryStatusDTOInternalError
     : WebhookDeliveryStatus, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "WebhookDeliveryStatusDTO.InternalError";
    
    public WebhookDeliveryStatusDTOInternalError() { }
    
    public WebhookDeliveryStatusDTOInternalError(string deliveryId, DateTime sentTime)
    {
        DeliveryId = deliveryId;
        SentTime = sentTime;
    }
    
    private PropertyValue<string> _deliveryId = new PropertyValue<string>(nameof(WebhookDeliveryStatusDTOInternalError), nameof(DeliveryId));
    
    [Required]
    [JsonPropertyName("deliveryId")]
    public string DeliveryId
    {
        get => _deliveryId.GetValue();
        set => _deliveryId.SetValue(value);
    }

    private PropertyValue<DateTime> _sentTime = new PropertyValue<DateTime>(nameof(WebhookDeliveryStatusDTOInternalError), nameof(SentTime));
    
    [Required]
    [JsonPropertyName("sentTime")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime SentTime
    {
        get => _sentTime.GetValue();
        set => _sentTime.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _deliveryId.SetAccessPath(path, validateHasBeenSet);
        _sentTime.SetAccessPath(path, validateHasBeenSet);
    }

}


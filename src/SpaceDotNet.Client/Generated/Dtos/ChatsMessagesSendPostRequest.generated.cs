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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class ChatsMessagesSendPostRequest
         : IPropagatePropertyAccessPath
    {
        public ChatsMessagesSendPostRequest() { }
        
        public ChatsMessagesSendPostRequest(string channel, string text, bool pending = false, string? temporaryId = null)
        {
            Channel = channel;
            Text = text;
            IsPending = pending;
            TemporaryId = temporaryId;
        }
        
        private PropertyValue<string> _channel = new PropertyValue<string>(nameof(ChatsMessagesSendPostRequest), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public string Channel
        {
            get { return _channel.GetValue(); }
            set { _channel.SetValue(value); }
        }
    
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(ChatsMessagesSendPostRequest), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<bool> _pending = new PropertyValue<bool>(nameof(ChatsMessagesSendPostRequest), nameof(IsPending));
        
        [JsonPropertyName("pending")]
        public bool IsPending
        {
            get { return _pending.GetValue(); }
            set { _pending.SetValue(value); }
        }
    
        private PropertyValue<string?> _temporaryId = new PropertyValue<string?>(nameof(ChatsMessagesSendPostRequest), nameof(TemporaryId));
        
        [JsonPropertyName("temporaryId")]
        public string? TemporaryId
        {
            get { return _temporaryId.GetValue(); }
            set { _temporaryId.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _channel.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
            _pending.SetAccessPath(path, validateHasBeenSet);
            _temporaryId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

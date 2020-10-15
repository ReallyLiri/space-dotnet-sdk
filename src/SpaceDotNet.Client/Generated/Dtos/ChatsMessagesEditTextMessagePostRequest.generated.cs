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
    public class ChatsMessagesEditTextMessagePostRequest
         : IPropagatePropertyAccessPath
    {
        public ChatsMessagesEditTextMessagePostRequest() { }
        
        public ChatsMessagesEditTextMessagePostRequest(string channelId, string text, string messageId)
        {
            ChannelId = channelId;
            Text = text;
            MessageId = messageId;
        }
        
        private PropertyValue<string> _channelId = new PropertyValue<string>(nameof(ChatsMessagesEditTextMessagePostRequest), nameof(ChannelId));
        
        [Required]
        [JsonPropertyName("channelId")]
        public string ChannelId
        {
            get { return _channelId.GetValue(); }
            set { _channelId.SetValue(value); }
        }
    
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(ChatsMessagesEditTextMessagePostRequest), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<string> _messageId = new PropertyValue<string>(nameof(ChatsMessagesEditTextMessagePostRequest), nameof(MessageId));
        
        [Required]
        [JsonPropertyName("messageId")]
        public string MessageId
        {
            get { return _messageId.GetValue(); }
            set { _messageId.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _channelId.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
            _messageId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

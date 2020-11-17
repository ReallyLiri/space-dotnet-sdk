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
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public class ChatsChannelsForChannelIdMessagesPostRequest
         : IPropagatePropertyAccessPath
    {
        public ChatsChannelsForChannelIdMessagesPostRequest() { }
        
        public ChatsChannelsForChannelIdMessagesPostRequest(string text, string? temporaryId = null)
        {
            Text = text;
            TemporaryId = temporaryId;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(ChatsChannelsForChannelIdMessagesPostRequest), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<string?> _temporaryId = new PropertyValue<string?>(nameof(ChatsChannelsForChannelIdMessagesPostRequest), nameof(TemporaryId));
        
        [JsonPropertyName("temporaryId")]
        public string? TemporaryId
        {
            get => _temporaryId.GetValue();
            set => _temporaryId.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _temporaryId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
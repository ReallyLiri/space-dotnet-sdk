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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class ArticleChannelRecord
         : IPropagatePropertyAccessPath
    {
        public ArticleChannelRecord() { }
        
        public ArticleChannelRecord(string id, bool archived, M2ChannelRecord channel, AllReactionsToItemRecord reactions, M2ChannelContentRecord? channelContent = null)
        {
            Id = id;
            IsArchived = archived;
            Channel = channel;
            ChannelContent = channelContent;
            Reactions = reactions;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ArticleChannelRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ArticleChannelRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<M2ChannelRecord> _channel = new PropertyValue<M2ChannelRecord>(nameof(ArticleChannelRecord), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecord Channel
        {
            get => _channel.GetValue();
            set => _channel.SetValue(value);
        }
    
        private PropertyValue<M2ChannelContentRecord?> _channelContent = new PropertyValue<M2ChannelContentRecord?>(nameof(ArticleChannelRecord), nameof(ChannelContent));
        
        [JsonPropertyName("channelContent")]
        public M2ChannelContentRecord? ChannelContent
        {
            get => _channelContent.GetValue();
            set => _channelContent.SetValue(value);
        }
    
        private PropertyValue<AllReactionsToItemRecord> _reactions = new PropertyValue<AllReactionsToItemRecord>(nameof(ArticleChannelRecord), nameof(Reactions));
        
        [Required]
        [JsonPropertyName("reactions")]
        public AllReactionsToItemRecord Reactions
        {
            get => _reactions.GetValue();
            set => _reactions.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _channelContent.SetAccessPath(path, validateHasBeenSet);
            _reactions.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}

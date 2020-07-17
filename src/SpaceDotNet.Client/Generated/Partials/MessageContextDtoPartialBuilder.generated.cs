// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.MessageContextDtoPartialBuilder
{
    public static class MessageContextDtoPartialExtensions
    {
        public static Partial<MessageContextDto> WithMessageId(this Partial<MessageContextDto> it)
            => it.AddFieldName("messageId");
        
        public static Partial<MessageContextDto> WithChannelId(this Partial<MessageContextDto> it)
            => it.AddFieldName("channelId");
        
        public static Partial<MessageContextDto> WithMessageData(this Partial<MessageContextDto> it)
            => it.AddFieldName("messageData");
        
        public static Partial<MessageContextDto> WithBody(this Partial<MessageContextDto> it)
            => it.AddFieldName("body");
        
        public static Partial<MessageContextDto> WithBody(this Partial<MessageContextDto> it, Func<Partial<ChatMessageDto>, Partial<ChatMessageDto>> partialBuilder)
            => it.AddFieldName("body", partialBuilder(new Partial<ChatMessageDto>(it)));
        
        public static Partial<MessageContextDto> WithAttachment(this Partial<MessageContextDto> it)
            => it.AddFieldName("attachment");
        
        public static Partial<MessageContextDto> WithAttachment(this Partial<MessageContextDto> it, Func<Partial<AttachmentDto>, Partial<AttachmentDto>> partialBuilder)
            => it.AddFieldName("attachment", partialBuilder(new Partial<AttachmentDto>(it)));
        
        public static Partial<MessageContextDto> WithExternalId(this Partial<MessageContextDto> it)
            => it.AddFieldName("externalId");
        
    }
    
}

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

namespace SpaceDotNet.Client.MessageHitDtoExtensions
{
    public static class MessageHitDtoPartialExtensions
    {
        public static Partial<MessageHitDto> WithId(this Partial<MessageHitDto> it)    => it.AddFieldName("id");
        
        public static Partial<MessageHitDto> WithScore(this Partial<MessageHitDto> it)    => it.AddFieldName("score");
        
        public static Partial<MessageHitDto> WithChannel(this Partial<MessageHitDto> it)    => it.AddFieldName("channel");
        
        public static Partial<MessageHitDto> WithChannel(this Partial<MessageHitDto> it, Func<Partial<M2ChannelRecordDto>, Partial<M2ChannelRecordDto>> partialBuilder)    => it.AddFieldName("channel", partialBuilder(new Partial<M2ChannelRecordDto>()));
        
        public static Partial<MessageHitDto> WithRef(this Partial<MessageHitDto> it)    => it.AddFieldName("ref");
        
        public static Partial<MessageHitDto> WithRef(this Partial<MessageHitDto> it, Func<Partial<ChannelItemRecordDto>, Partial<ChannelItemRecordDto>> partialBuilder)    => it.AddFieldName("ref", partialBuilder(new Partial<ChannelItemRecordDto>()));
        
        public static Partial<MessageHitDto> WithMessage(this Partial<MessageHitDto> it)    => it.AddFieldName("message");
        
    }
    
}

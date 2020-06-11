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

namespace SpaceDotNet.Client.M2ChannelContactThreadDtoExtensions
{
    public static class M2ChannelContactThreadDtoPartialExtensions
    {
        public static Partial<M2ChannelContactThreadDto> WithParent(this Partial<M2ChannelContactThreadDto> it)
            => it.AddFieldName("parent");
        
        public static Partial<M2ChannelContactThreadDto> WithParent(this Partial<M2ChannelContactThreadDto> it, Func<Partial<M2ChannelRecordDto>, Partial<M2ChannelRecordDto>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<M2ChannelRecordDto>(it)));
        
        public static Partial<M2ChannelContactThreadDto> WithText(this Partial<M2ChannelContactThreadDto> it)
            => it.AddFieldName("text");
        
        public static Partial<M2ChannelContactThreadDto> WithMessageId(this Partial<M2ChannelContactThreadDto> it)
            => it.AddFieldName("messageId");
        
        public static Partial<M2ChannelContactThreadDto> WithAuthor(this Partial<M2ChannelContactThreadDto> it)
            => it.AddFieldName("author");
        
        public static Partial<M2ChannelContactThreadDto> WithAuthor(this Partial<M2ChannelContactThreadDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<M2ChannelContactThreadDto> WithMessageAuthor(this Partial<M2ChannelContactThreadDto> it)
            => it.AddFieldName("messageAuthor");
        
        public static Partial<M2ChannelContactThreadDto> WithMessageAuthor(this Partial<M2ChannelContactThreadDto> it, Func<Partial<CPrincipalDto>, Partial<CPrincipalDto>> partialBuilder)
            => it.AddFieldName("messageAuthor", partialBuilder(new Partial<CPrincipalDto>(it)));
        
        public static Partial<M2ChannelContactThreadDto> WithAttachments(this Partial<M2ChannelContactThreadDto> it)
            => it.AddFieldName("attachments");
        
    }
    
}

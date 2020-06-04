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

namespace SpaceDotNet.Client.M2ChannelContentMemberDtoExtensions
{
    public static class M2ChannelContentMemberDtoPartialExtensions
    {
        public static Partial<M2ChannelContentMemberDto> WithMember(this Partial<M2ChannelContentMemberDto> it)    => it.AddFieldName("member");
        
        public static Partial<M2ChannelContentMemberDto> WithMember(this Partial<M2ChannelContentMemberDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)    => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<M2ChannelContentMemberDto> WithNotificationDefaults(this Partial<M2ChannelContentMemberDto> it)    => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelContentMemberDto> WithNotificationDefaults(this Partial<M2ChannelContentMemberDto> it, Func<Partial<ChannelSpecificDefaultsDto>, Partial<ChannelSpecificDefaultsDto>> partialBuilder)    => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaultsDto>()));
        
        public static Partial<M2ChannelContentMemberDto> WithMemberAbsences(this Partial<M2ChannelContentMemberDto> it)    => it.AddFieldName("memberAbsences");
        
        public static Partial<M2ChannelContentMemberDto> WithMemberAbsences(this Partial<M2ChannelContentMemberDto> it, Func<Partial<ProfileAbsencesRecordDto>, Partial<ProfileAbsencesRecordDto>> partialBuilder)    => it.AddFieldName("memberAbsences", partialBuilder(new Partial<ProfileAbsencesRecordDto>()));
        
        public static Partial<M2ChannelContentMemberDto> WithMemberTeams(this Partial<M2ChannelContentMemberDto> it)    => it.AddFieldName("memberTeams");
        
        public static Partial<M2ChannelContentMemberDto> WithMemberTeams(this Partial<M2ChannelContentMemberDto> it, Func<Partial<ProfileMembershipRecordDto>, Partial<ProfileMembershipRecordDto>> partialBuilder)    => it.AddFieldName("memberTeams", partialBuilder(new Partial<ProfileMembershipRecordDto>()));
        
    }
    
}

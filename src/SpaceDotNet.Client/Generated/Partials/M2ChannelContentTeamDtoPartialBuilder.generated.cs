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

namespace SpaceDotNet.Client.M2ChannelContentTeamDtoPartialBuilder
{
    public static class M2ChannelContentTeamDtoPartialExtensions
    {
        public static Partial<M2ChannelContentTeamDto> WithTeam(this Partial<M2ChannelContentTeamDto> it)
            => it.AddFieldName("team");
        
        public static Partial<M2ChannelContentTeamDto> WithTeam(this Partial<M2ChannelContentTeamDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("team", partialBuilder(new Partial<TDTeamDto>(it)));
        
        public static Partial<M2ChannelContentTeamDto> WithNotificationDefaults(this Partial<M2ChannelContentTeamDto> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelContentTeamDto> WithNotificationDefaults(this Partial<M2ChannelContentTeamDto> it, Func<Partial<ChannelSpecificDefaultsDto>, Partial<ChannelSpecificDefaultsDto>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaultsDto>(it)));
        
    }
    
}
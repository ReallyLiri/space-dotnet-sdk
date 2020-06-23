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

namespace SpaceDotNet.Client.M2ChannelContentApplicationDtoExtensions
{
    public static class M2ChannelContentApplicationDtoPartialExtensions
    {
        public static Partial<M2ChannelContentApplicationDto> WithService(this Partial<M2ChannelContentApplicationDto> it)
            => it.AddFieldName("service");
        
        public static Partial<M2ChannelContentApplicationDto> WithService(this Partial<M2ChannelContentApplicationDto> it, Func<Partial<ESServiceDto>, Partial<ESServiceDto>> partialBuilder)
            => it.AddFieldName("service", partialBuilder(new Partial<ESServiceDto>(it)));
        
        public static Partial<M2ChannelContentApplicationDto> WithNotificationDefaults(this Partial<M2ChannelContentApplicationDto> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelContentApplicationDto> WithNotificationDefaults(this Partial<M2ChannelContentApplicationDto> it, Func<Partial<ChannelSpecificDefaultsDto>, Partial<ChannelSpecificDefaultsDto>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaultsDto>(it)));
        
    }
    
}
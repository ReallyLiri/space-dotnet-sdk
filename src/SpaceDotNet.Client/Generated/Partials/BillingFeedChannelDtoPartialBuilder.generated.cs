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

namespace SpaceDotNet.Client.BillingFeedChannelDtoPartialBuilder
{
    public static class BillingFeedChannelDtoPartialExtensions
    {
        public static Partial<BillingFeedChannelDto> WithNotificationDefaults(this Partial<BillingFeedChannelDto> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<BillingFeedChannelDto> WithNotificationDefaults(this Partial<BillingFeedChannelDto> it, Func<Partial<ChannelSpecificDefaultsDto>, Partial<ChannelSpecificDefaultsDto>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaultsDto>(it)));
        
    }
    
}
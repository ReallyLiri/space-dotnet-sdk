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

namespace SpaceDotNet.Client.TDLocationDtoExtensions
{
    public static class TDLocationDtoPartialExtensions
    {
        public static Partial<TDLocationDto> WithId(this Partial<TDLocationDto> it)
            => it.AddFieldName("id");
        
        public static Partial<TDLocationDto> WithName(this Partial<TDLocationDto> it)
            => it.AddFieldName("name");
        
        public static Partial<TDLocationDto> WithTimezone(this Partial<TDLocationDto> it)
            => it.AddFieldName("timezone");
        
        public static Partial<TDLocationDto> WithTimezone(this Partial<TDLocationDto> it, Func<Partial<ATimeZoneWithOffsetDto>, Partial<ATimeZoneWithOffsetDto>> partialBuilder)
            => it.AddFieldName("timezone", partialBuilder(new Partial<ATimeZoneWithOffsetDto>(it)));
        
        public static Partial<TDLocationDto> WithTz(this Partial<TDLocationDto> it)
            => it.AddFieldName("tz");
        
        public static Partial<TDLocationDto> WithWorkdays(this Partial<TDLocationDto> it)
            => it.AddFieldName("workdays");
        
        public static Partial<TDLocationDto> WithPhones(this Partial<TDLocationDto> it)
            => it.AddFieldName("phones");
        
        public static Partial<TDLocationDto> WithEmails(this Partial<TDLocationDto> it)
            => it.AddFieldName("emails");
        
        public static Partial<TDLocationDto> WithEquipment(this Partial<TDLocationDto> it)
            => it.AddFieldName("equipment");
        
        public static Partial<TDLocationDto> WithDescription(this Partial<TDLocationDto> it)
            => it.AddFieldName("description");
        
        public static Partial<TDLocationDto> WithAddress(this Partial<TDLocationDto> it)
            => it.AddFieldName("address");
        
        public static Partial<TDLocationDto> WithParent(this Partial<TDLocationDto> it)
            => it.AddFieldName("parent");
        
        public static Partial<TDLocationDto> WithParentRecursive(this Partial<TDLocationDto> it)
            => it.AddFieldName("parent!");
        
        public static Partial<TDLocationDto> WithParent(this Partial<TDLocationDto> it, Func<Partial<TDLocationDto>, Partial<TDLocationDto>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<TDLocationDto>(it)));
        
        public static Partial<TDLocationDto> WithType(this Partial<TDLocationDto> it)
            => it.AddFieldName("type");
        
        public static Partial<TDLocationDto> WithMapId(this Partial<TDLocationDto> it)
            => it.AddFieldName("mapId");
        
        public static Partial<TDLocationDto> WithChannelId(this Partial<TDLocationDto> it)
            => it.AddFieldName("channelId");
        
        public static Partial<TDLocationDto> WithArchived(this Partial<TDLocationDto> it)
            => it.AddFieldName("archived");
        
    }
    
}

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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.TDLocationPartialBuilder;

public static class TDLocationPartialExtensions
{
    public static Partial<TDLocation> WithId(this Partial<TDLocation> it)
        => it.AddFieldName("id");
    
    public static Partial<TDLocation> WithName(this Partial<TDLocation> it)
        => it.AddFieldName("name");
    
    [Obsolete("Use tz field that contains no specific offset for a timezone. Field timezone is always null (since 2019.0.1) (will be removed in a future version)")]
    public static Partial<TDLocation> WithTimezone(this Partial<TDLocation> it)
        => it.AddFieldName("timezone");
    
    [Obsolete("Use tz field that contains no specific offset for a timezone. Field timezone is always null (since 2019.0.1) (will be removed in a future version)")]
    public static Partial<TDLocation> WithTimezone(this Partial<TDLocation> it, Func<Partial<ATimeZoneWithOffset>, Partial<ATimeZoneWithOffset>> partialBuilder)
        => it.AddFieldName("timezone", partialBuilder(new Partial<ATimeZoneWithOffset>(it)));
    
    public static Partial<TDLocation> WithTz(this Partial<TDLocation> it)
        => it.AddFieldName("tz");
    
    public static Partial<TDLocation> WithWorkdays(this Partial<TDLocation> it)
        => it.AddFieldName("workdays");
    
    public static Partial<TDLocation> WithPhones(this Partial<TDLocation> it)
        => it.AddFieldName("phones");
    
    public static Partial<TDLocation> WithEmails(this Partial<TDLocation> it)
        => it.AddFieldName("emails");
    
    public static Partial<TDLocation> WithEquipment(this Partial<TDLocation> it)
        => it.AddFieldName("equipment");
    
    public static Partial<TDLocation> WithDescription(this Partial<TDLocation> it)
        => it.AddFieldName("description");
    
    public static Partial<TDLocation> WithAddress(this Partial<TDLocation> it)
        => it.AddFieldName("address");
    
    public static Partial<TDLocation> WithParent(this Partial<TDLocation> it)
        => it.AddFieldName("parent");
    
    public static Partial<TDLocation> WithParentRecursive(this Partial<TDLocation> it)
        => it.AddFieldName("parent!");
    
    public static Partial<TDLocation> WithParent(this Partial<TDLocation> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
        => it.AddFieldName("parent", partialBuilder(new Partial<TDLocation>(it)));
    
    public static Partial<TDLocation> WithType(this Partial<TDLocation> it)
        => it.AddFieldName("type");
    
    public static Partial<TDLocation> WithMapId(this Partial<TDLocation> it)
        => it.AddFieldName("mapId");
    
    public static Partial<TDLocation> WithCapacity(this Partial<TDLocation> it)
        => it.AddFieldName("capacity");
    
    public static Partial<TDLocation> WithChannelId(this Partial<TDLocation> it)
        => it.AddFieldName("channelId");
    
    public static Partial<TDLocation> WithIsArchived(this Partial<TDLocation> it)
        => it.AddFieldName("archived");
    
    public static Partial<TDLocation> WithEquipment2(this Partial<TDLocation> it)
        => it.AddFieldName("equipment2");
    
    public static Partial<TDLocation> WithEquipment2(this Partial<TDLocation> it, Func<Partial<TDLocationEquipmentTypeRecord>, Partial<TDLocationEquipmentTypeRecord>> partialBuilder)
        => it.AddFieldName("equipment2", partialBuilder(new Partial<TDLocationEquipmentTypeRecord>(it)));
    
}


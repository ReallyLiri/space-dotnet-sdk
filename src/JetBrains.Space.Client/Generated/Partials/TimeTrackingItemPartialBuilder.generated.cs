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

namespace JetBrains.Space.Client.TimeTrackingItemPartialBuilder;

public static class TimeTrackingItemPartialExtensions
{
    public static Partial<TimeTrackingItem> WithId(this Partial<TimeTrackingItem> it)
        => it.AddFieldName("id");
    
    public static Partial<TimeTrackingItem> WithUser(this Partial<TimeTrackingItem> it)
        => it.AddFieldName("user");
    
    public static Partial<TimeTrackingItem> WithUser(this Partial<TimeTrackingItem> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("user", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<TimeTrackingItem> WithProject(this Partial<TimeTrackingItem> it)
        => it.AddFieldName("project");
    
    public static Partial<TimeTrackingItem> WithProject(this Partial<TimeTrackingItem> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
    
    public static Partial<TimeTrackingItem> WithDate(this Partial<TimeTrackingItem> it)
        => it.AddFieldName("date");
    
    public static Partial<TimeTrackingItem> WithDuration(this Partial<TimeTrackingItem> it)
        => it.AddFieldName("duration");
    
    public static Partial<TimeTrackingItem> WithDescription(this Partial<TimeTrackingItem> it)
        => it.AddFieldName("description");
    
    public static Partial<TimeTrackingItem> WithSubjectType(this Partial<TimeTrackingItem> it)
        => it.AddFieldName("subjectType");
    
    public static Partial<TimeTrackingItem> WithSubjectType(this Partial<TimeTrackingItem> it, Func<Partial<TimeTrackingSubjectType>, Partial<TimeTrackingSubjectType>> partialBuilder)
        => it.AddFieldName("subjectType", partialBuilder(new Partial<TimeTrackingSubjectType>(it)));
    
    public static Partial<TimeTrackingItem> WithSubject(this Partial<TimeTrackingItem> it)
        => it.AddFieldName("subject");
    
}


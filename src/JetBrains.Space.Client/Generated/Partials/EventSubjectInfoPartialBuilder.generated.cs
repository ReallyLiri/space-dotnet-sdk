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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.EventSubjectInfoPartialBuilder
{
    public static class EventSubjectInfoPartialExtensions
    {
        public static Partial<EventSubjectInfo> WithCode(this Partial<EventSubjectInfo> it)
            => it.AddFieldName("code");
        
        public static Partial<EventSubjectInfo> WithParentCode(this Partial<EventSubjectInfo> it)
            => it.AddFieldName("parentCode");
        
        public static Partial<EventSubjectInfo> WithName(this Partial<EventSubjectInfo> it)
            => it.AddFieldName("name");
        
        public static Partial<EventSubjectInfo> WithDescription(this Partial<EventSubjectInfo> it)
            => it.AddFieldName("description");
        
        public static Partial<EventSubjectInfo> WithEvents(this Partial<EventSubjectInfo> it)
            => it.AddFieldName("events");
        
        public static Partial<EventSubjectInfo> WithEvents(this Partial<EventSubjectInfo> it, Func<Partial<EventTypeInfo>, Partial<EventTypeInfo>> partialBuilder)
            => it.AddFieldName("events", partialBuilder(new Partial<EventTypeInfo>(it)));
        
        public static Partial<EventSubjectInfo> WithDefaultFilters(this Partial<EventSubjectInfo> it)
            => it.AddFieldName("defaultFilters");
        
        public static Partial<EventSubjectInfo> WithDefaultFilters(this Partial<EventSubjectInfo> it, Func<Partial<SubscriptionFilter>, Partial<SubscriptionFilter>> partialBuilder)
            => it.AddFieldName("defaultFilters", partialBuilder(new Partial<SubscriptionFilter>(it)));
        
        public static Partial<EventSubjectInfo> WithFeatureFlag(this Partial<EventSubjectInfo> it)
            => it.AddFieldName("featureFlag");
        
    }
    
}

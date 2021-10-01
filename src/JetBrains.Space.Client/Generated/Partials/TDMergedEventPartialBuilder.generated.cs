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

namespace JetBrains.Space.Client.TDMergedEventPartialBuilder;

public static class TDMergedEventPartialExtensions
{
    public static Partial<TDMergedEvent> WithEvents(this Partial<TDMergedEvent> it)
        => it.AddFieldName("events");
    
    public static Partial<TDMergedEvent> WithEvents(this Partial<TDMergedEvent> it, Func<Partial<Pair<TDMembership, int>>, Partial<Pair<TDMembership, int>>> partialBuilder)
        => it.AddFieldName("events", partialBuilder(new Partial<Pair<TDMembership, int>>(it)));
    
    public static Partial<TDMergedEvent> WithProfile(this Partial<TDMergedEvent> it)
        => it.AddFieldName("profile");
    
    public static Partial<TDMergedEvent> WithProfile(this Partial<TDMergedEvent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfile>(it)));
    
}


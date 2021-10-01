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

namespace JetBrains.Space.Client.ESApplicationPasswordPartialBuilder;

public static class ESApplicationPasswordPartialExtensions
{
    public static Partial<ESApplicationPassword> WithId(this Partial<ESApplicationPassword> it)
        => it.AddFieldName("id");
    
    public static Partial<ESApplicationPassword> WithProfile(this Partial<ESApplicationPassword> it)
        => it.AddFieldName("profile");
    
    public static Partial<ESApplicationPassword> WithProfile(this Partial<ESApplicationPassword> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<ESApplicationPassword> WithName(this Partial<ESApplicationPassword> it)
        => it.AddFieldName("name");
    
    public static Partial<ESApplicationPassword> WithScope(this Partial<ESApplicationPassword> it)
        => it.AddFieldName("scope");
    
    public static Partial<ESApplicationPassword> WithCreated(this Partial<ESApplicationPassword> it)
        => it.AddFieldName("created");
    
    public static Partial<ESApplicationPassword> WithLastAccess(this Partial<ESApplicationPassword> it)
        => it.AddFieldName("lastAccess");
    
    public static Partial<ESApplicationPassword> WithLastAccess(this Partial<ESApplicationPassword> it, Func<Partial<AccessRecord>, Partial<AccessRecord>> partialBuilder)
        => it.AddFieldName("lastAccess", partialBuilder(new Partial<AccessRecord>(it)));
    
}


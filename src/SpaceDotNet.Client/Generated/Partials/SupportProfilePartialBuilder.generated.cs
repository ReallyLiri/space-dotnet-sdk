// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.SupportProfilePartialBuilder
{
    public static class SupportProfilePartialExtensions
    {
        public static Partial<SupportProfile> WithProfile(this Partial<SupportProfile> it)
            => it.AddFieldName("profile");
        
        public static Partial<SupportProfile> WithProfile(this Partial<SupportProfile> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<SupportProfile> WithIsAdminPermissionsGranted(this Partial<SupportProfile> it)
            => it.AddFieldName("adminPermissionsGranted");
        
    }
    
}
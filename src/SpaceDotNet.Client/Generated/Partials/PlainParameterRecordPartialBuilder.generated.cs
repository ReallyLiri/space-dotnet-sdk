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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.PlainParameterRecordPartialBuilder
{
    public static class PlainParameterRecordPartialExtensions
    {
        public static Partial<PlainParameterRecord> WithId(this Partial<PlainParameterRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<PlainParameterRecord> WithIsArchived(this Partial<PlainParameterRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<PlainParameterRecord> WithBundleId(this Partial<PlainParameterRecord> it)
            => it.AddFieldName("bundleId");
        
        public static Partial<PlainParameterRecord> WithKey(this Partial<PlainParameterRecord> it)
            => it.AddFieldName("key");
        
        public static Partial<PlainParameterRecord> WithValue(this Partial<PlainParameterRecord> it)
            => it.AddFieldName("value");
        
    }
    
}

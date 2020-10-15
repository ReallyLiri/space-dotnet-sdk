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

namespace SpaceDotNet.Client.DiffContextPartialBuilder
{
    public static class DiffContextPartialExtensions
    {
        public static Partial<DiffContext> WithLeft(this Partial<DiffContext> it)
            => it.AddFieldName("left");
        
        public static Partial<DiffContext> WithLeft(this Partial<DiffContext> it, Func<Partial<DiffSide>, Partial<DiffSide>> partialBuilder)
            => it.AddFieldName("left", partialBuilder(new Partial<DiffSide>(it)));
        
        public static Partial<DiffContext> WithRight(this Partial<DiffContext> it)
            => it.AddFieldName("right");
        
        public static Partial<DiffContext> WithRight(this Partial<DiffContext> it, Func<Partial<DiffSide>, Partial<DiffSide>> partialBuilder)
            => it.AddFieldName("right", partialBuilder(new Partial<DiffSide>(it)));
        
    }
    
}

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

namespace SpaceDotNet.Client.MCSectionPartialBuilder
{
    public static class MCSectionPartialExtensions
    {
        public static Partial<MCSection> WithHeader(this Partial<MCSection> it)
            => it.AddFieldName("header");
        
        public static Partial<MCSection> WithHeader(this Partial<MCSection> it, Func<Partial<MCText>, Partial<MCText>> partialBuilder)
            => it.AddFieldName("header", partialBuilder(new Partial<MCText>(it)));
        
        public static Partial<MCSection> WithElements(this Partial<MCSection> it)
            => it.AddFieldName("elements");
        
        public static Partial<MCSection> WithElements(this Partial<MCSection> it, Func<Partial<MCElement>, Partial<MCElement>> partialBuilder)
            => it.AddFieldName("elements", partialBuilder(new Partial<MCElement>(it)));
        
        public static Partial<MCSection> WithFooter(this Partial<MCSection> it)
            => it.AddFieldName("footer");
        
        public static Partial<MCSection> WithFooter(this Partial<MCSection> it, Func<Partial<MCText>, Partial<MCText>> partialBuilder)
            => it.AddFieldName("footer", partialBuilder(new Partial<MCText>(it)));
        
    }
    
}

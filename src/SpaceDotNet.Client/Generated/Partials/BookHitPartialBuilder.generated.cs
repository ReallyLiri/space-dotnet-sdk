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

namespace SpaceDotNet.Client.BookHitPartialBuilder
{
    public static class BookHitPartialExtensions
    {
        public static Partial<BookHit> WithId(this Partial<BookHit> it)
            => it.AddFieldName("id");
        
        public static Partial<BookHit> WithScore(this Partial<BookHit> it)
            => it.AddFieldName("score");
        
        public static Partial<BookHit> WithRef(this Partial<BookHit> it)
            => it.AddFieldName("ref");
        
        public static Partial<BookHit> WithRef(this Partial<BookHit> it, Func<Partial<KBBook>, Partial<KBBook>> partialBuilder)
            => it.AddFieldName("ref", partialBuilder(new Partial<KBBook>(it)));
        
        public static Partial<BookHit> WithTitle(this Partial<BookHit> it)
            => it.AddFieldName("title");
        
        public static Partial<BookHit> WithSummary(this Partial<BookHit> it)
            => it.AddFieldName("summary");
        
    }
    
}

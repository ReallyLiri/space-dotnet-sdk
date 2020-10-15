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

namespace SpaceDotNet.Client.GitGraphLayoutEdgePartialBuilder
{
    public static class GitGraphLayoutEdgePartialExtensions
    {
        public static Partial<GitGraphLayoutEdge> WithFrom(this Partial<GitGraphLayoutEdge> it)
            => it.AddFieldName("from");
        
        public static Partial<GitGraphLayoutEdge> WithTo(this Partial<GitGraphLayoutEdge> it)
            => it.AddFieldName("to");
        
        public static Partial<GitGraphLayoutEdge> WithType(this Partial<GitGraphLayoutEdge> it)
            => it.AddFieldName("type");
        
        public static Partial<GitGraphLayoutEdge> WithType(this Partial<GitGraphLayoutEdge> it, Func<Partial<GitGraphEdgeType>, Partial<GitGraphEdgeType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<GitGraphEdgeType>(it)));
        
        public static Partial<GitGraphLayoutEdge> WithStyle(this Partial<GitGraphLayoutEdge> it)
            => it.AddFieldName("style");
        
        public static Partial<GitGraphLayoutEdge> WithStyle(this Partial<GitGraphLayoutEdge> it, Func<Partial<GitGraphEdgeLineStyle>, Partial<GitGraphEdgeLineStyle>> partialBuilder)
            => it.AddFieldName("style", partialBuilder(new Partial<GitGraphEdgeLineStyle>(it)));
        
        public static Partial<GitGraphLayoutEdge> WithIsHasArrow(this Partial<GitGraphLayoutEdge> it)
            => it.AddFieldName("hasArrow");
        
        public static Partial<GitGraphLayoutEdge> WithColor(this Partial<GitGraphLayoutEdge> it)
            => it.AddFieldName("color");
        
    }
    
}
